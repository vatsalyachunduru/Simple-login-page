<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication10.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                
                <h1 style="background-color:pink">Login</h1>
                <img src="Images/Lock.PNG" />
                
                <table cellspacing="0" border="5" style="border-color:blue"><tr><td>
                    <table  cellPadding="20" cellspacing="0">
                        
                        <tr><td>user id</td><td><asp:TextBox ID="txtUID" runat="server"></asp:TextBox></td></tr>
                        <tr><td>Password</td><td><asp:Textbox ID="txtPWD" runat="server"></asp:Textbox></td></tr>
                        <tr><td colspan="2" align="center"><asp:Button ID="btnLogin" text="Login" runat="server" OnClick="btnLogin_Click" /></td></tr>
                        <tr><td colspan="2"><asp:Label ID="lblMessage" runat="server"></asp:Label></td></tr>
                        
                    </table>
                </td></tr></table>
                <br />
                <hr />
                &copy; www.LearnTopics.com,2017
            </center>
        </div>
    </form>
</body>
</html>
