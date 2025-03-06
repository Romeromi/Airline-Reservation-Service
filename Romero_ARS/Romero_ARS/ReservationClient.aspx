<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReservationClient.aspx.cs" Inherits="ReservationClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        


        <asp:Label ID="InstructionLabel" runat="server">Please select the seat type and class to reserve</asp:Label>
        <br />
        <br />


        <asp:DropDownList ID="seatList" runat="server" AutoPostBack="True">
            <asp:ListItem>Window</asp:ListItem>
            <asp:ListItem>Aisle</asp:ListItem>
            <asp:ListItem>Middle</asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="classList" runat="server" AutoPostBack="True">
            <asp:ListItem>Economy</asp:ListItem>
            <asp:ListItem>First</asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp;
        <asp:Button ID="reserveButton" runat="server" OnClick="reserveButton_Click" Text="Reserve" />
        <br />
        <br />
        <asp:Label ID="errorlabel" runat="server"></asp:Label>
        </form>
</body>
</html>
