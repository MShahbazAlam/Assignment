<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment_1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Collections Of Automobile</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="color:blue"><strong>Collections Of Automobile</strong></h1>
             <h2>Select a car to Check Image and Price</h2>
            <asp:DropDownList ID="ddlItems" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlItems_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Image ID="imgItem" runat="server" />
            <br />
            <br />
            <asp:Label ID="lblCost" runat="server"></asp:Label>
            <br />
            <asp:Button ID="btnShowCost" runat="server" Text="Show Cost" OnClick="btnShowCost_Click" />
        </div>
    </form>
</body>
</html>
