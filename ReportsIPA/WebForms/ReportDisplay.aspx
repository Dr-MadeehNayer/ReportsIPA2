<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportDisplay.aspx.cs" Inherits="ReportsIPA.WebForms.ReportDisplay" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

            <rsweb:ReportViewer ID="ReportViewer1" runat="server" Height="831px" Width="1512px">
            </rsweb:ReportViewer>
            <br />

        </div>
    </form>
</body>
</html>
