using DevExpress.Xpf.PivotGrid;
using System.Windows;

namespace WpfPivotGrid_CustomMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            pivotGrid.DataSource = DataHelper.CreatePivotDataSource();
        }

        private void CopyFieldElementData_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            PivotGridFieldValueMenuInfo menuInfo = pivotGrid.GridMenu.MenuInfo as PivotGridFieldValueMenuInfo;
            if (menuInfo != null && menuInfo.FieldValueElementData != null &&
                menuInfo.FieldValueElementData.Value.ToString() != string.Empty)
            {
                Clipboard.SetDataObject(menuInfo.FieldValueElementData.Value);
            }
        }

        private void FilterFieldElementData_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            PivotGridFieldValueMenuInfo menuInfo = pivotGrid.GridMenu.MenuInfo as PivotGridFieldValueMenuInfo;
            if (menuInfo != null && menuInfo.FieldValueElementData != null &&
                menuInfo.FieldValueElementData.Value != null &&
                menuInfo.FieldValueElementData.Field != null)
            {
                PivotGridField field = menuInfo.FieldValueElementData.Field;
                object value = menuInfo.FieldValueElementData.Value;
                field.FilterValues.FilterType = FieldFilterType.Included;
                field.FilterValues.Add(value);
            }
        }

        private void CopyCellElementData_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            PivotGridCellMenuInfo menuInfo = pivotGrid.GridMenu.MenuInfo as PivotGridCellMenuInfo;
            if (menuInfo != null && menuInfo.CellElementData != null &&
                menuInfo.CellElementData.Value.ToString() != string.Empty)
            {
                Clipboard.SetDataObject(menuInfo.CellElementData.DisplayText);
            }
        }
    }
}
