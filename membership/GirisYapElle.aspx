<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="GirisYapElle.aspx.cs" Inherits="membership.GirisYapElle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 48%;
        }
        .auto-style2 {
            width: 200px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">




    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Kullanıcı Adı</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="133px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Parola</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Width="136px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Kaydol" Width="67px" />
            </td>
        </tr>
    </table>




</asp:Content>
