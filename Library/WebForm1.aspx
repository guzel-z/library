<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Library.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center> <asp:Label ID="Label1" runat="server" Text="Вход" Font-Size="XX-Large"></asp:Label></center>
        </div>
        <p><center><asp:TextBox ID="Login" runat="server" Height="25px" Width="400px" Font-Size="X-Large"></asp:TextBox></center></p>
        <center> <asp:TextBox ID="Password" runat="server" Height="25px" style="margin-top: 0px" Width="400px" Font-Italic="False" Font-Size="X-Large" TextMode="Password"></asp:TextBox></center>
        
        <p><center><asp:Button ID="Enter" runat="server" Text="Войти" Width="100px" Font-Size="Large" Height="25px" OnClick="Enter_Click" /></center></p>
    </form>
</body>
</html>
