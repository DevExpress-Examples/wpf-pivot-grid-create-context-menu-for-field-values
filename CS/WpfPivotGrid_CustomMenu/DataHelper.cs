using System.Data;

namespace WpfPivotGrid_CustomMenu
{
    static class DataHelper
    {
        public static  DataTable CreatePivotDataSource()
        {
            DataTable myTable = new DataTable();
            myTable.Columns.Add("Name", typeof(string));
            myTable.Columns.Add("Type", typeof(string));
            myTable.Columns.Add("Value", typeof(decimal));
            myTable.Columns.Add("Target", typeof(decimal));

            myTable.Rows.Add(new object[] { "Aaa", "Type 1", 7, 7 });
            myTable.Rows.Add(new object[] { "Aaa", "Type 1", 4, 12 });
            myTable.Rows.Add(new object[] { "Bbb", "Type 1", 12, 13 });
            myTable.Rows.Add(new object[] { "Bbb", "Type 1", 14, 12 });
            myTable.Rows.Add(new object[] { "Ccc", "Type 1", 11, 12 });
            myTable.Rows.Add(new object[] { "Ccc", "Type 1", 10, 12 });

            myTable.Rows.Add(new object[] { "Aaa", "Type 2", 4, 6 });
            myTable.Rows.Add(new object[] { "Aaa", "Type 2", 2, 5 });
            myTable.Rows.Add(new object[] { "Bbb", "Type 2", 3, 4 });
            myTable.Rows.Add(new object[] { "Bbb", "Type 2", 1, 4 });
            myTable.Rows.Add(new object[] { "Ccc", "Type 2", 8, 5 });
            myTable.Rows.Add(new object[] { "Ccc", "Type 2", 22, 13 });

            return myTable;
        }
    }
}
