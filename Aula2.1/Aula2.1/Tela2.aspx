<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tela2.aspx.cs" Inherits="Aula2._1.Tela2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTexto" runat="server" Text="Você está na Tela 2"></asp:Label>
            <br />
            <asp:Button ID="btnVoltar" runat="server" Text="Voltar" OnClick="btnVoltar_Click" />
        </div>
    </form>
</body>
</html>
