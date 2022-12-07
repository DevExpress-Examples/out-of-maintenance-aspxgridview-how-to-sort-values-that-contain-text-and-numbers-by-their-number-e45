Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Text.RegularExpressions
Imports DevExpress.Web

Partial Public Class _Default
	Inherits System.Web.UI.Page

	Protected Sub grid_CustomColumnSort(ByVal sender As Object, ByVal e As CustomColumnSortEventArgs)
		If cb_CustomSort.Checked = False Then
			Return
		End If
		If e.Column.FieldName <> "value" Then
			Return
		End If

		Dim Value1_NumberPart As Integer
		Dim Value1_TextPart As String

		Dim Value1_NumberString As String = Regex.Match(e.Value1.ToString(), "\d+").Value
		If Value1_NumberString <> "" Then
			Value1_NumberPart = Convert.ToInt32(Value1_NumberString)
			Value1_TextPart = e.Value1.ToString().Replace(Value1_NumberString, "").ToLower()
		Else
			Value1_NumberPart = 0
			Value1_TextPart = e.Value1.ToString().ToLower()
		End If


		Dim Value2_NumberPart As Integer
		Dim Value2_TextPart As String
		Dim Value2_NumberString As String = Regex.Match(e.Value2.ToString(), "\d+").Value
		If Value2_NumberString <> "" Then
			Value2_NumberPart = Convert.ToInt32(Value2_NumberString)
			Value2_TextPart = e.Value2.ToString().Replace(Value2_NumberString, "").ToLower()
		Else
			Value2_NumberPart = 0
			Value2_TextPart = e.Value2.ToString().ToLower()
		End If


		If Value1_TextPart <> Value2_TextPart Then
			e.Handled = False
		Else
			e.Handled = True
			If Value1_NumberPart > Value2_NumberPart Then
				e.Result = 1
			Else
				e.Result = -1
			End If
		End If
	End Sub
End Class
