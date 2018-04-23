Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web.ASPxGridView
Imports DevExpress.Web.ASPxEditors

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub ASPxProgressBar1_DataBound(ByVal sender As Object, ByVal e As EventArgs)
		Dim progressBar As ASPxProgressBar = CType(sender, ASPxProgressBar)

		Dim templateContainer As GridViewDataItemTemplateContainer = CType(progressBar.NamingContainer, GridViewDataItemTemplateContainer)
		Dim rowKeyValue As Object = templateContainer.KeyValue

		If progressBar.Value Is Nothing OrElse rowKeyValue Is Nothing Then
			progressBar.Visible = False
		Else
			progressBar.Attributes.Add("onclick", String.Format("OnProgressBarClickEventHandler('{0}', '{1}');", progressBar.Value, rowKeyValue))
			progressBar.Style.Add("cursor", "pointer")
		End If
	End Sub
End Class