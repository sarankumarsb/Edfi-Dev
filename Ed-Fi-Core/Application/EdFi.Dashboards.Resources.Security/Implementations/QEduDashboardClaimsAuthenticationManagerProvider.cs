﻿using EdFi.Dashboards.Infrastructure;
using EdFi.Dashboards.SecurityTokenService.Authentication;
using EdFi.Dashboards.SecurityTokenService.Authentication.Analytics;
using Microsoft.IdentityModel.Claims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;

namespace EdFi.Dashboards.Resources.Security.Implementations
{
    public class QEduDashboardClaimsAuthenticationManagerProvider : IClaimsAuthenticationManagerProvider
    {
        private IStaffInformationFromEmailProvider staffInformationFromUsernameProvider;
        private IAuthenticationProvider authenticationProvider;
        private IHttpContextItemsProvider httpContextItemsProvider;
        private IUserClaimsProvider userClaimsProvider;
        private IClaimsIssuedTrackingEventProvider claimsIssuedTrackingEventProvider;
        private IGetImpersonatedClaimsDataProvider getImpersonatedClaimsDataProvider;

        public QEduDashboardClaimsAuthenticationManagerProvider(IStaffInformationFromEmailProvider staffInformationFromUsernameProvider, IAuthenticationProvider authenticationProvider,
            IUserClaimsProvider userClaimsProvider, IClaimsIssuedTrackingEventProvider claimsIssuedTrackingEventProvider, IHttpContextItemsProvider httpContextItemsProvider,
            IGetImpersonatedClaimsDataProvider getImpersonatedClaimsDataProvider)
        {
            this.staffInformationFromUsernameProvider = staffInformationFromUsernameProvider;
            this.authenticationProvider = authenticationProvider;
            this.userClaimsProvider = userClaimsProvider;
            this.claimsIssuedTrackingEventProvider = claimsIssuedTrackingEventProvider;
            this.httpContextItemsProvider = httpContextItemsProvider;
            this.getImpersonatedClaimsDataProvider = getImpersonatedClaimsDataProvider;
        }

        public Microsoft.IdentityModel.Claims.IClaimsPrincipal Get(string resourceName, Microsoft.IdentityModel.Claims.IClaimsPrincipal incomingPrincipal)
        {
            if (incomingPrincipal == null)
                throw new ArgumentNullException("incomingPrincipal");

            if (!incomingPrincipal.Identity.IsAuthenticated)
                throw new AuthenticationException();

            var identity = incomingPrincipal.Identities.First();

            //Pluck the lea code claim, and set in httpcontext
            var LeaCodeClaim = identity.Claims.FirstOrDefault(x => x.ClaimType == CustomDashboardClaimType.LocalEducationAgencyCode);
            if (LeaCodeClaim == null)
                throw new InvalidOperationException(string.Format("Missing required claim: {0}", CustomDashboardClaimType.LocalEducationAgencyCode));

            httpContextItemsProvider.Add("lea", LeaCodeClaim.Value);

            //Issue Claims
            string username = incomingPrincipal.Identity.Name;

            var emailClaim = identity.Claims.FirstOrDefault(x => x.ClaimType == ClaimTypes.Email);
            if (emailClaim == null)
                throw new InvalidOperationException(string.Format("Missing required claim: {0}", ClaimTypes.Email));
            
            var staffUsi = this.staffInformationFromUsernameProvider.ResolveStaffUSI(username);
            var appSpecificClaims = this.userClaimsProvider.GetApplicationSpecificClaims(username, staffUsi);

            // Determine if we have a "wimp" (WIF-impersonation) parameter
            var isImpersonating = getImpersonatedClaimsDataProvider.IsImpersonating();

            var userClaimsData = isImpersonating
                                    ? getImpersonatedClaimsDataProvider.GetImpersonatedClaimsData(appSpecificClaims) // Create claims data for impersonated user
                                    : new UserClaimsData { Username = username, Claims = appSpecificClaims }; // Create claims data for current user

            //When using dashboard side claims enrichment, we are modifying existing claims, not issuing new ones.
            ReplaceClaimsIfExist(identity, new Claim(ClaimTypes.Name, userClaimsData.Username));

            // VINLOGINTYP
            var serviceTypeClaim = identity.Claims.FirstOrDefault(x => x.ClaimType == EdFiClaimTypes.ServiceType);
            if (serviceTypeClaim == null)
                throw new InvalidOperationException(string.Format("Missing required claim: {0}", EdFiClaimTypes.ServiceType));
            ReplaceClaimsIfExist(identity, new Claim(EdFiClaimTypes.ServiceType, serviceTypeClaim.Value));

            ReplaceClaimsIfExist(identity, userClaimsData.Claims);
            this.claimsIssuedTrackingEventProvider.Track(userClaimsData.Username, staffUsi, false, userClaimsData.Claims);
            return incomingPrincipal;
        }

        public void ReplaceClaimsIfExist(IClaimsIdentity claimsIdentity, Claim claimToReplaceIfExists)
        {
            var existingClaim = claimsIdentity.Claims.FirstOrDefault(x => x.ClaimType == claimToReplaceIfExists.ClaimType);
            if (existingClaim != null)
                claimsIdentity.Claims.Remove(existingClaim);
            claimsIdentity.Claims.Add(claimToReplaceIfExists);
        }

        public void ReplaceClaimsIfExist(IClaimsIdentity claimsIdentity, IEnumerable<Claim> claims)
        {
            foreach (var claim in claims)
            {
                ReplaceClaimsIfExist(claimsIdentity, claim);
            }
        }
    }
}
