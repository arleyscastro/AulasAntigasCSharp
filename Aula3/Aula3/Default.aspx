<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Aula3.Default" %>

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
                    <td><asp:TextBox ID="txtNome" runat="server" Width="472px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label2" runat="server" Text="Altura"></asp:Label></td>
                    <td><asp:TextBox ID="txtAltura" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label3" runat="server" Text="Peso"></asp:Label></td>
                    <td><asp:TextBox ID="txtPeso" runat="server"></asp:TextBox></td>
                </tr>
            </table>
            <br/>
            <asp:Button ID="btnCalculo" runat="server" Text="Calcular o IMC" OnClick="btnCalculo_Click" />
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="Ok" />
        </div>
    </form>
</body>
</html>
