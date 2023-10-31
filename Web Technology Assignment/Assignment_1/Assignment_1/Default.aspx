<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment_1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Collections Of Automobile</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="color: blue"><strong>Collections Of Automobile</strong></h1>
            <h2>Select a car to Check Image and Price</h2>
            <asp:DropDownList ID="Items" runat="server" AutoPostBack="true" OnSelectedIndexChanged="Items_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Cost" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Image ID="imgItem" runat="server" />
            <br />
        </div>
    </form>
</body>
</html>
