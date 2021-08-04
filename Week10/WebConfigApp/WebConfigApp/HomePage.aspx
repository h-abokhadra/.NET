<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="WebConfigApp.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p style="text-align: center">
        <br />
    </p>
    <form id="form1" runat="server">
        <p>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Show Data" />
        </p>
        <div>
        </div>
    </form>
</body>
</html>
