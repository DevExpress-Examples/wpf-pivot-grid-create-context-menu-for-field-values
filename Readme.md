<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfPivotGrid_CustomMenu/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfPivotGrid_CustomMenu/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfPivotGrid_CustomMenu/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfPivotGrid_CustomMenu/MainWindow.xaml.vb))
<!-- default file list end -->

# WPF Dashboard Viewer - How to Customize the Pivot Grid Context Menu

This example shows how to modify context menu for the Field, Data and Header areas in the PivotGridControl.

- The [Field Value Context Menu](https://docs.devexpress.com/WPF/7996) contains two new items. One command enables the end-user to exclude all fields but the one which is hovered over. Another command copies the field name to the clipboard.
- The [Data Area](https://docs.devexpress.com/WPF/7987) context menu contains a command that copies cell content to the clipboard.
- The [Field Header Context Menu](https://docs.devexpress.com/WPF/7994) is modified to remove a command which reorders fields.
- The [Header Area Context Menu](https://docs.devexpress.com/WPF/8003) is modified to remove all built-in commands and add a drop-down menu with a single item that shows/hides column [grand totals](https://docs.devexpress.com/WPF/8057).

![screenshot](images/ContextMenu.gif)

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
