Imports System.Windows
Imports DevExpress.Xpf.PivotGrid
Imports HowToBindToMDB.NwindDataSetTableAdapters

Namespace HowToBindToMDB

    Public Partial Class MainWindow
        Inherits Window

        Private salesPersonDataTable As NwindDataSet.SalesPersonDataTable = New NwindDataSet.SalesPersonDataTable()

        Private salesPersonDataAdapter As SalesPersonTableAdapter = New SalesPersonTableAdapter()

        Public Sub New()
            Me.InitializeComponent()
            Me.pivotGridControl1.DataSource = salesPersonDataTable
        End Sub

        Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            salesPersonDataAdapter.Fill(salesPersonDataTable)
        End Sub

        Private Sub CopyValueItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            Dim menuInfo As PivotGridFieldValueMenuInfo = TryCast(Me.pivotGridControl1.GridMenu.MenuInfo, PivotGridFieldValueMenuInfo)
            If menuInfo IsNot Nothing AndAlso menuInfo.ValueItem IsNot Nothing AndAlso Not Equals(menuInfo.ValueItem.Value.ToString(), String.Empty) Then Call Clipboard.SetText(menuInfo.ValueItem.Value.ToString())
        End Sub

        Private Sub FilterValueItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            Dim menuInfo As PivotGridFieldValueMenuInfo = TryCast(Me.pivotGridControl1.GridMenu.MenuInfo, PivotGridFieldValueMenuInfo)
            If menuInfo IsNot Nothing AndAlso menuInfo.ValueItem IsNot Nothing AndAlso menuInfo.ValueItem.Value IsNot Nothing AndAlso menuInfo.ValueItem.Field IsNot Nothing Then
                Dim field As PivotGridField = menuInfo.ValueItem.Field
                Dim value As Object = menuInfo.ValueItem.Value
                field.FilterValues.FilterType = FieldFilterType.Included
                field.FilterValues.Add(value)
            End If
        End Sub
    End Class
End Namespace
