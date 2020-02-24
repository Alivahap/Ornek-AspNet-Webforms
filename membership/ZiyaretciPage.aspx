<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ZiyaretciPage.aspx.cs" Inherits="membership.ZiyaretciPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:literal runat="server" Text="aktif ziyaretci sayısı"></asp:literal>
  &nbsp;&nbsp;&nbsp;
    <asp:literal runat="server" id="ltrZiyaretci"></asp:literal>
</asp:Content>
