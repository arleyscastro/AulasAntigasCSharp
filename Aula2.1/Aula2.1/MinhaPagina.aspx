<%@ Page Language="C#" AutoEventWireup="true" 
CodeBehind="MinhaPagina.aspx.cs" Inherits="Aula2._1.MinhaPagina" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:TextBox ID="txtValor" runat="server" Width="95px"></asp:TextBox>
            <asp:Button ID="btnOk" runat="server" Text="Ok isso é coisa séria" Width="173px" OnClick="btnOk_Click" />
            <br />
            <asp:Label ID="lblResultado" runat="server" Text="Olha isso aqui Vei... Massaaaa !!!!!"></asp:Label>

            <br />
            <asp:Button ID="btnChamada" runat="server" Text="Envia para outra tela" OnClick="btnChamada_Click" />
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtSobeNome" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
