Imports Microsoft.VisualBasic
Imports DevExpress.Web
Imports DevExpress.Web.Office
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		If Session("dataMerge") IsNot Nothing Then
			ASPxRichEdit1.DataSource = Session("dataMerge")
			ASPxRichEdit1.DataBind()
		End If
	End Sub
	Protected Sub ASPxCallbackPanel1_Callback(ByVal sender As Object, ByVal e As CallbackEventArgsBase)
        ASPxRichEdit1.[New]()
		If Convert.ToInt32(ASPxComboBox1.Value) = 1 Then
			Session("dataMerge") = MergeDataModels.GetTestData1()
		Else
			Session("dataMerge") = MergeDataModels.GetTestData2()
		End If
		ASPxRichEdit1.DataSource = Session("dataMerge")
		ASPxRichEdit1.DataBind()
	End Sub

End Class