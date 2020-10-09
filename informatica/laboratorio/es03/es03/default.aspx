<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="es03._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblRegioni" runat="server" Text="Regioni"></asp:Label>
            <asp:DropDownList ID="cmbRegioni" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cmbRegioni_SelectedIndexChanged"></asp:DropDownList>
            <asp:Label ID="lblProvince" runat="server" Text="Province"></asp:Label>
            <asp:DropDownList ID="cmbProvince" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cmbProvince_SelectedIndexChanged"></asp:DropDownList>
            <asp:Label ID="lblComuni" runat="server" Text="Comuni"></asp:Label>
            <asp:DropDownList ID="cmbComuni" runat="server" AutoPostBack="True"></asp:DropDownList>
        </div>
    </form>
</body>
</html>
