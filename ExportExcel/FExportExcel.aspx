<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FExportExcel.aspx.vb" Inherits="ExportExcel.FExportExcel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <asp:GridView ID="GrExcel" runat="server"></asp:GridView>
       <asp:Button ID="BTN_GeneraExcel" runat="server" Text="Generar Excel" Height="32px" Width="130px"  />
    </div>
    </form>
</body>
</html>
