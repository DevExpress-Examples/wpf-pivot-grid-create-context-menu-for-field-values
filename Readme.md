<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128578475/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2205)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# BI Dashboard for WPF - How to Customize the Pivot Grid Context Menu

This example shows how to modify context menu for the Field, Data and Header areas in the PivotGridControl.

- The [Field Value Context Menu](https://docs.devexpress.com/WPF/7996) contains two new items. One command enables the end-user to exclude all fields but the one which is hovered over. Another command copies the field name to the clipboard.
- The [Data Area](https://docs.devexpress.com/WPF/7987) context menu contains a command that copies cell content to the clipboard.
- The [Field Header Context Menu](https://docs.devexpress.com/WPF/7994) is modified to remove a command which reorders fields.
- The [Header Area Context Menu](https://docs.devexpress.com/WPF/8003) is modified to remove all built-in commands and add a drop-down menu with a single item that shows/hides column [grand totals](https://docs.devexpress.com/WPF/8057).

![screenshot](images/ContextMenu.gif)

## Files to Review

* [MainWindow.xaml](./CS/WpfPivotGrid_CustomMenu/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfPivotGrid_CustomMenu/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfPivotGrid_CustomMenu/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfPivotGrid_CustomMenu/MainWindow.xaml.vb))

## API

* [PivotGridControl.FieldValueMenuCustomizations](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotGridControl.FieldValueMenuCustomizations) property
* [PivotGridControl.CellMenuCustomizations](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotGridControl.CellMenuCustomizations) property
* [PivotGridControl.HeaderMenuCustomizations ](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotGridControl.HeaderMenuCustomizations) property
* [PivotGridControl.HeaderAreaMenuCustomizations ](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotGridControl.HeaderAreaMenuCustomizations) property
* [PivotGridControl.GridMenu](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotGridControl.GridMenu) property
* [PivotGridFieldValueMenuInfo](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotGridFieldValueMenuInfo) class
* [FieldValueElementData](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.FieldValueElementData) class
* [CellElementData](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.CellElementData) class
* [PivotGridField](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotGridField) class
* [PivotGridField.FilterValues](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotGridField.FilterValues) property

## More Examples

* [How to Customize the Data Field Menu to Add a Command to Change the Summary Type](https://github.com/DevExpress-Examples/how-to-customize-the-data-field-menu-to-allow-summarytype-and-summarydisplaytype-selection-e20028)
