﻿Imports System.Data

Namespace WpfPivotGrid_CustomMenu
	Friend Module DataHelper
		Public Function CreatePivotDataSource() As DataTable
			Dim myTable As New DataTable()
			myTable.Columns.Add("Name", GetType(String))
			myTable.Columns.Add("Owner", GetType(String))
			myTable.Columns.Add("Type", GetType(String))
			myTable.Columns.Add("Value", GetType(Decimal))
			myTable.Columns.Add("Target", GetType(Decimal))

			myTable.Rows.Add(New Object() { "Aaa", "Andrew Fuller", "Type 1", 7, 7 })
			myTable.Rows.Add(New Object() {"Aaa", "Anne Dodsworth", "Type 1", 4, 12})
			myTable.Rows.Add(New Object() {"Bbb", "Janet Leverling", "Type 1", 12, 13})
			myTable.Rows.Add(New Object() { "Bbb", "Andrew Fuller", "Type 1", 14, 12 })
			myTable.Rows.Add(New Object() { "Ccc", "Anne Dodsworth", "Type 1", 11, 12 })
			myTable.Rows.Add(New Object() { "Ccc", "Janet Leverling", "Type 1", 10, 12 })

			myTable.Rows.Add(New Object() { "Aaa", "Andrew Fuller", "Type 2", 4, 6 })
			myTable.Rows.Add(New Object() { "Aaa", "Anne Dodsworth", "Type 2", 2, 5 })
			myTable.Rows.Add(New Object() { "Bbb", "Janet Leverling", "Type 2", 3, 4 })
			myTable.Rows.Add(New Object() { "Bbb", "Andrew Fuller", "Type 2", 1, 4 })
			myTable.Rows.Add(New Object() { "Ccc", "Anne Dodsworth", "Type 2", 8, 5 })
			myTable.Rows.Add(New Object() { "Ccc", "Janet Leverling", "Type 2", 22, 13 })

			Return myTable
		End Function
	End Module
End Namespace
