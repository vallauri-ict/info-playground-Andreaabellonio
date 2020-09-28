<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblNome" runat="server" Text="Nome"></asp:Label>
        </div>
        <asp:TextBox ID="txtNome" runat="server" placeholder="Inserire Nome"></asp:TextBox>
        
        <br />
        <br />
        <asp:Button ID="btnInvia" runat="server" Text="Invia" OnClick="btnInvia_Click" />
        <br />
        <br />
        <asp:Label ID="lblMessaggio" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
