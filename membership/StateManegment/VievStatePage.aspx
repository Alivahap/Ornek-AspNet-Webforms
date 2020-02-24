<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="VievStatePage.aspx.cs" Inherits="membership.VievStatePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox runat="server"  ID="txt"/>
    <br /> <br />
    <asp:Button Text="Kaydet" runat="server" ID="btnkaydet" OnClick="btnkaydet_Click" />
    <br /> <br />
    <asp:DropDownList runat="server" ID="drplist">
    </asp:DropDownList>

    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    <asp:Button Text="al" runat="server" ID="btnAl" OnClick="btnAl_Click" />
    <asp:Button Text="at" runat="server" ID="btnAt" OnClick="btnAt_Click" />




</asp:Content>
