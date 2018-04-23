using System.Data;
using System.Data.OleDb;
using System.Windows;
using DevExpress.Xpf.PivotGrid;
using HowToBindToMDB.NwindDataSetTableAdapters;
using DevExpress.Xpf.PivotGrid.Internal;

namespace HowToBindToMDB {
    public partial class MainWindow : Window {
        NwindDataSet.SalesPersonDataTable salesPersonDataTable = new NwindDataSet.SalesPersonDataTable();
        SalesPersonTableAdapter salesPersonDataAdapter = new SalesPersonTableAdapter();

        public MainWindow() {
            InitializeComponent();
            pivotGridControl1.DataSource = salesPersonDataTable;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            salesPersonDataAdapter.Fill(salesPersonDataTable);
        }

        private void CopyValueItem_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            PivotGridFieldValueMenuInfo menuInfo = 
				pivotGridControl1.GridMenu.MenuInfo as PivotGridFieldValueMenuInfo;
            if(menuInfo != null && menuInfo.ValueItem != null && 
				menuInfo.ValueItem.Value.ToString() != string.Empty)
					Clipboard.SetText(menuInfo.ValueItem.Value.ToString());
        }

        private void FilterValueItem_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            PivotGridFieldValueMenuInfo menuInfo = 
				pivotGridControl1.GridMenu.MenuInfo as PivotGridFieldValueMenuInfo;
            if(menuInfo != null && menuInfo.ValueItem != null && 
				menuInfo.ValueItem.Value != null && 
				menuInfo.ValueItem.Field != null) {
				PivotGridField field = menuInfo.ValueItem.Field;
				object value = menuInfo.ValueItem.Value;
				field.FilterValues.FilterType = FieldFilterType.Included;
				field.FilterValues.Add(value);
            }
        }
    }
}
