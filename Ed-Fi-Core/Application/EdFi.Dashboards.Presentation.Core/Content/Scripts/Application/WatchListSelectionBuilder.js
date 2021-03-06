﻿// contains the functionality used to build the watch list selected items.
var WatchListSelectionBuilder = function (watchListModel) {
    // gets the list of selected watch list items
    this.GetSelectedValuesJson = function () {
        var selectedList = iterateTabs(watchListModel.Tabs);
        return ko.toJSON(selectedList);
    }

    // This function will iterate through all of the tabs to get the list of
    // selected items.
    function iterateTabs(tabs) {
        var list = new NameValueList();

        for (var tabCount = 0; tabCount < tabs.length; tabCount++) {
            list.AddRange(iterateColumns(tabs[tabCount].Columns()));
        }

        return list.ToArray();
    }

    // This function will iterate through all of the columns in a tab to get
    // the list of selected items.
    function iterateColumns(columns) {
        var list = new NameValueList();

        for (var columnCount = 0; columnCount < columns.length; columnCount++) {
            list.AddRange(iterateTemplates(columns[columnCount].Templates()));
        }

        return list.ToArray();
    }

    // This is the work horse function; it loops through all of the templates
    // and sub-templates to build the list of selected items.
    function iterateTemplates(templates) {
        var list = new NameValueList();

        // loop through all of the templates; templates can contain sub-templates
        for (var templateCount = 0; templateCount < templates.length; templateCount++) {
            if (templates[templateCount].IsViewModelArray) {
                // if the ViewModel property is an array then process the
                // ViewModel recursively
                var pairList = iterateTemplates(templates[templateCount].ViewModel);

                if (pairList.length > 0) {
                    list.AddRange(pairList);
                }
            } else if (templates[templateCount].ViewModel.TemplateName != undefined) {
                // if the ViewModel property contains just one other ViewModel
                // then process the ViewModel recursively; this is an edge case
                var pair = iterateTemplates(templates[templateCount].ViewModel);

                if (pair.length > 0) {
                    list.Add(pair);
                }
            } else {
                // if the ViewModel contains the actual data then determine the
                // template type and process the data accordingly
                switch (templates[templateCount].TemplateName) {
                    case 'metricRadioButtonTemplate':
                        // when a radio button is clicked it sets the
                        // SelectedValue property; that will be used to
                        // determine which radio button was clicked
                        if (templates[templateCount].ViewModel.SelectedValue() !== undefined) {
                            var radioPair = new NameValuePair(templates[templateCount].ViewModel.Name);
                            radioPair.AddValue(templates[templateCount].ViewModel.SelectedValue());

                            list.Add(radioPair);
                        }
                        break;
                    case 'metricCheckboxTemplate':
                    case 'metricCheckboxInlineTemplate':
                        // when a checkbox is clicked it sets the IsSelected
                        // property of the selection item model class since
                        // multiple can be selected all of the values must be
                        // inspected
                        for (var valueCount = 0; valueCount < templates[templateCount].ViewModel.Values().length; valueCount++) {
                            if (templates[templateCount].ViewModel.Values()[valueCount].IsSelected() === true) {
                                var checkboxPair = null;
                                var listContains = false;

                                // if a checkbox is selected then determine if
                                // another item in the same checkbox list has
                                // already been selected
                                if (!list.Contains(templates[templateCount].ViewModel.Name)) {
                                    checkboxPair = new NameValuePair(templates[templateCount].ViewModel.Name);
                                    listContains = false;
                                } else {
                                    checkboxPair = list.GetByName(templates[templateCount].ViewModel.Name);
                                    listContains = true;
                                }

                                // if this is a new list item then this will
                                // add the first item to the list but if the
                                // list already contains items then this will
                                // add another item to the same list
                                checkboxPair.AddValue(templates[templateCount].ViewModel.Values()[valueCount].Name);

                                // if this item is not already contained in the
                                // list then add it
                                if (!listContains) {
                                    list.Add(checkboxPair);
                                }
                            }
                        }
                        break;
                    case 'metricDropDownTemplate':
                        // there are two types of drop down controls single and
                        // double drop-downs; if there are no data in the
                        // Values array then this is a single drop-down
                        if (templates[templateCount].ViewModel.Values().length <= 0) {
                            // the selection from the comparison drop-down is
                            // stored in the SelectedComparison property
                            if (templates[templateCount].ViewModel.SelectedComparison() !== undefined) {
                                var dropComparisonPair = new NameValuePair(templates[templateCount].ViewModel.Name);
                                dropComparisonPair.AddValue(templates[templateCount].ViewModel.SelectedComparison());

                                list.Add(dropComparisonPair);
                            }
                        } else {
                            // in the double drop-down case both the
                            // SelectedComparison and SelectedValue properties
                            // will contain data
                            if (templates[templateCount].ViewModel.SelectedComparison() !== undefined && templates[templateCount].ViewModel.SelectedValue() !== undefined) {
                                var dropComparisonValuePair = new NameValuePair(templates[templateCount].ViewModel.Name);
                                dropComparisonValuePair.AddValue(templates[templateCount].ViewModel.SelectedComparison());
                                dropComparisonValuePair.AddValue(templates[templateCount].ViewModel.SelectedValue());

                                list.Add(dropComparisonValuePair);
                            }
                        }
                        break;
                    case 'metricDropDownTextboxTemplate':
                        // for the drop-down/textbox both the
                        // SelectedComparison and TextboxValue properties will
                        // contain data
                        if (templates[templateCount].ViewModel.SelectedComparison() !== undefined && templates[templateCount].ViewModel.TextboxValue() !== undefined &&
                            templates[templateCount].ViewModel.TextboxValue() !== "") {
                            var dropTextboxPair = new NameValuePair(templates[templateCount].ViewModel.Name);
                            dropTextboxPair.AddValue(templates[templateCount].ViewModel.SelectedComparison());
                            dropTextboxPair.AddValue(templates[templateCount].ViewModel.TextboxValue());

                            list.Add(dropTextboxPair);
                        }
                        break;
                }
            }
        }

        return list.ToArray();
    }
};