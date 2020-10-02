<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="es02._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Esempio di AutoPostback</h3>
            <asp:CheckBox ID="chkAutoPost" runat="server" Text="Abilita AutoPostBack" OnCheckedChanged="chkAutoPostBack_CheckedChanged"/>
            <br/>
            <asp:DropDownList ID="cmbColore" runat="server" OnSelectedIndexChanged="cmbColore_SelectedIndexChanged"></asp:DropDownList>
            <br/><br/>
            <asp:Panel ID="pnlColore" Width="100px" Height="100px" runat="server"></asp:Panel>
            <br/><br/>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </div>
    </form>
</body>
</html>
