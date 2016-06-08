<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Entry.aspx.cs" Inherits="KAZBilling.Entry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="myform" runat="server">
    <div>
    
        Enter Time&nbsp; :&nbsp;
        <asp:TextBox ID="datetimeTextBox" Placeholder="**:**" runat="server"></asp:TextBox>
        <br />
        Duration :&nbsp;
        <asp:TextBox ID="durationTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="showButton" runat="server" OnClick="Buttonshow_Click" Text="Show" />
        <br />
        Total Cost :
        <asp:Label ID="costLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
