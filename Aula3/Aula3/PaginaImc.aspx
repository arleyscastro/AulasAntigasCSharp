<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaImc.aspx.cs" Inherits="Aula3.PaginaImc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td><asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label></td>
                    <td><asp:Label ID="lblNome" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label2" runat="server" Text="Altura"></asp:Label></td>
                    <td><asp:Label ID="lblAltura" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label3" runat="server" Text="Peso"></asp:Label></td>
                    <td><asp:Label ID="lblPeso" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label4" runat="server" Text="IMC"></asp:Label></td>
                    <td><asp:Label ID="lblImc" runat="server"></asp:Label></td>
                </tr>
            </table>
            <br/>
            <asp:Button ID="btnVoltar" runat="server" Text="Voltar" OnClick="btnVoltar_Click" />
        </div>
    </form>
</body>
</html>
