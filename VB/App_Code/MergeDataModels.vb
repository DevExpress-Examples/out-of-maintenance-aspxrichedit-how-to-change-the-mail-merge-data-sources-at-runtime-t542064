Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Public NotInheritable Class MergeDataModels
	Private Sub New()
	End Sub
	Public Shared Function GetTestData1() As List(Of TestMergeModel1)
		Dim ds = New List(Of TestMergeModel1)()
		For i As Integer = 0 To 9
			ds.Add(New TestMergeModel1 With {.FirstName1 = "First Name_1_" & i, .LastName1 = "LastName_1_" & i, .Address1 = "Address_1_" & i})
		Next i
		Return ds
	End Function
	Public Shared Function GetTestData2() As List(Of TestMergeModel2)
		Dim ds = New List(Of TestMergeModel2)()
		For i As Integer = 0 To 9
			ds.Add(New TestMergeModel2 With {.FirstName2 = "First Name_2_" & i, .LastName2 = "LastName_2_" & i, .Address2 = "Address_2_" & i})
		Next i
		Return ds
	End Function
End Class

Public Class TestMergeModel1
	Private privateFirstName1 As String
	Public Property FirstName1() As String
		Get
			Return privateFirstName1
		End Get
		Set(ByVal value As String)
			privateFirstName1 = value
		End Set
	End Property
	Private privateLastName1 As String
	Public Property LastName1() As String
		Get
			Return privateLastName1
		End Get
		Set(ByVal value As String)
			privateLastName1 = value
		End Set
	End Property
	Private privateAddress1 As String
	Public Property Address1() As String
		Get
			Return privateAddress1
		End Get
		Set(ByVal value As String)
			privateAddress1 = value
		End Set
	End Property
End Class

Public Class TestMergeModel2
	Private privateFirstName2 As String
	Public Property FirstName2() As String
		Get
			Return privateFirstName2
		End Get
		Set(ByVal value As String)
			privateFirstName2 = value
		End Set
	End Property
	Private privateLastName2 As String
	Public Property LastName2() As String
		Get
			Return privateLastName2
		End Get
		Set(ByVal value As String)
			privateLastName2 = value
		End Set
	End Property
	Private privateAddress2 As String
	Public Property Address2() As String
		Get
			Return privateAddress2
		End Get
		Set(ByVal value As String)
			privateAddress2 = value
		End Set
	End Property
End Class