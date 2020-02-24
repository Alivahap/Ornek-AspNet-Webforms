<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="QueryStringPage.aspx.cs" Inherits="membership.NewFolder1.ViewStatePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox runat="server"  ID="txt" />
    <br /><br />

    <asp:Button Text="at" runat="server" ID ="btnat" OnClick="btnat_Click" />
    

    <asp:Button Text="anasayfa" runat="server" ID="btnAnasayfa" OnClick="btnAnasayfa_Click" />


</asp:Content>
