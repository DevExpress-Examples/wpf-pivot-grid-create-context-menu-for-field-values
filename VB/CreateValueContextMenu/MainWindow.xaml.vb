Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows
Imports DevExpress.Xpf.PivotGrid
Imports HowToBindToMDB.NwindDataSetTableAdapters
Imports DevExpress.Xpf.PivotGrid.Internal

Namespace HowToBindToMDB
    Partial Public Class MainWindow
        Inherits Window
        Private salesPersonDataTable As New NwindDataSet.SalesPersonDataTable()
        Private salesPersonDataAdapter As New SalesPersonTableAdapter()

        Public Sub New()
            InitializeComponent()
            pivotGridControl1.DataSource = salesPersonDataTable
        End Sub

        Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            salesPersonDataAdapter.Fill(salesPersonDataTable)
        End Sub

        Private Sub CopyValueItem_ItemClick(ByVal sender As Object, _
											ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            Dim menuInfo As PivotGridFieldValueMenuInfo = _
				TryCast(pivotGridControl1.GridMenu.MenuInfo, PivotGridFieldValueMenuInfo)
            If menuInfo IsNot Nothing AndAlso menuInfo.ValueItem IsNot Nothing AndAlso _
				menuInfo.ValueItem.Value.ToString() <> String.Empty Then
					Clipboard.SetText(menuInfo.ValueItem.Value.ToString())
            End If
        End Sub

        Private Sub FilterValueItem_ItemClick(ByVal sender As Object, _
											  ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            Dim menuInfo As PivotGridFieldValueMenuInfo = _
				TryCast(pivotGridControl1.GridMenu.MenuInfo, PivotGridFieldValueMenuInfo)
            If menuInfo IsNot Nothing AndAlso menuInfo.ValueItem IsNot Nothing AndAlso _
				menuInfo.ValueItem.Value IsNot Nothing AndAlso _
				menuInfo.ValueItem.Field IsNot Nothing Then
					Dim field As PivotGridField = menuInfo.ValueItem.Field
					Dim value As Object = menuInfo.ValueItem.Value
					field.FilterValues.FilterType = FieldFilterType.Included
					field.FilterValues.Add(value)
            End If
        End Sub
    End Class
End Namespace
