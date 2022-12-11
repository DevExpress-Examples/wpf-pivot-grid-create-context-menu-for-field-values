Imports DevExpress.Xpf.PivotGrid
Imports System.Windows

Namespace WpfPivotGrid_CustomMenu

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.pivotGrid.DataSource = CreatePivotDataSource()
        End Sub

        Private Sub CopyFieldElementData_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            Dim menuInfo As PivotGridFieldValueMenuInfo = TryCast(Me.pivotGrid.GridMenu.MenuInfo, PivotGridFieldValueMenuInfo)
            If menuInfo IsNot Nothing AndAlso menuInfo.FieldValueElementData IsNot Nothing AndAlso menuInfo.FieldValueElementData.Value IsNot Nothing Then
                Clipboard.SetDataObject(menuInfo.FieldValueElementData.Value)
            End If
        End Sub

        Private Sub FilterFieldElementData_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            Dim menuInfo As PivotGridFieldValueMenuInfo = TryCast(Me.pivotGrid.GridMenu.MenuInfo, PivotGridFieldValueMenuInfo)
            If menuInfo IsNot Nothing AndAlso menuInfo.FieldValueElementData IsNot Nothing AndAlso menuInfo.FieldValueElementData.Value IsNot Nothing AndAlso menuInfo.FieldValueElementData.Field IsNot Nothing Then
                Dim field As PivotGridField = menuInfo.FieldValueElementData.Field
                Dim value As Object = menuInfo.FieldValueElementData.Value
                field.FilterValues.FilterType = FieldFilterType.Included
                field.FilterValues.Add(value)
            End If
        End Sub

        Private Sub CopyCellElementData_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            Dim menuInfo As PivotGridCellMenuInfo = TryCast(Me.pivotGrid.GridMenu.MenuInfo, PivotGridCellMenuInfo)
            If menuInfo IsNot Nothing AndAlso menuInfo.CellElementData IsNot Nothing AndAlso Not Equals(menuInfo.CellElementData.Value.ToString(), String.Empty) Then
                Clipboard.SetDataObject(menuInfo.CellElementData.DisplayText)
            End If
        End Sub
    End Class
End Namespace
