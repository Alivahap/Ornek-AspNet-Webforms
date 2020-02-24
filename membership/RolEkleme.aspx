<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RolEkleme.aspx.cs" Inherits="membership.RolEkleme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table>
    <tr>
        
        <asp:TextBox runat="server" ID="txtRol"/>
    </tr>
    <tr>
        <asp:Button Text="Rol Ekle" ID="bttnEkle" OnClick="bttnEkle_Click" runat="server" />
    </tr>
</table>

</asp:Content>
