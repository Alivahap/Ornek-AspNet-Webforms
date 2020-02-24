<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RolAtama.aspx.cs" Inherits="membership.RolAtama" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>kullanıcı</td>
            <asp:DropDownList runat="server" ID ="drpkullanici">
               
            </asp:DropDownList>
        </tr>
        <tr>
            <td> Roller</td>
            <asp:DropDownList runat="server" ID="drprol">
 
            </asp:DropDownList>
 
            </tr>
        <tr>
            <td>
                <asp:Button Text="Rol ata" runat="server" ID="btnata" OnClick="btnata_Click" /></td>
        </tr>

    </table>
</asp:Content>
