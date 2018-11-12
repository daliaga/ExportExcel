Imports System

Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.html
Imports iTextSharp.text.html.simpleparser
Public Class FExportExcel
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Private Sub BTN_GeneraExcel_Click(sender As Object, e As EventArgs) Handles BTN_GeneraExcel.Click
        Dim dt As DataTable
        'creat datasource 
        GrExcel.DataSource = Dt
        GrExcel.DataBind()
        ExportarExcel()

    End Sub
    Public Sub ExportarExcel()

        Response.Clear()
        Response.AddHeader("Content-Disposition", "attachment;filename=Informe Producción - " & Today & ".xls")
        Response.ContentType = "application/vnd.ms-excel"
        Dim sw As StringWriter = New StringWriter()
        Dim htw As HtmlTextWriter = New HtmlTextWriter(sw)
        GrExcel.RenderControl(htw)
        Response.Write(sw.ToString())
        Response.End()

    End Sub
    Public Overloads Overrides Sub VerifyRenderingInServerForm(ByVal control As Control)

    End Sub
End Class