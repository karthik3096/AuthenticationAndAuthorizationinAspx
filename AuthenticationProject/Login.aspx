<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AuthenticationProject.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <asp:Label ID="lbl_UserName" runat="server" Text="User Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="tb_UserName" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lbl_Password" runat="server" Text="Password"> </asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="tb_Password" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td colspan="2">
                    <asp:Button ID="btn_Login" runat="server" Text="Login" OnClick="btn_Login_Click" />
                </td>
            </tr>

            <tr>
                <td colspan="2">
                    <asp:Label ID="lbl_Message" runat="server" ForeColor="Red" Visible="false"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
