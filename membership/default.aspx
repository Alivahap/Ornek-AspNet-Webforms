<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="membership._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Label"> Baba corona güzel ama biz efez içiyoz </asp:Label>
    
    <asp:Button Text="Cookie Al" runat="server" ID="btnAl" OnClick="btnAl_Click" />
    <asp:Label Text="text" runat="server" ID="lbl" />

</asp:Content>
