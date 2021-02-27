<%@ Page Title="" Language="C#" MasterPageFile="~/MovieAdmin.Master" AutoEventWireup="true" CodeBehind="LoginAdmin.aspx.cs" Inherits="Moviecruiser.WebForm8" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Enter Name:<asp:TextBox ID="Txtname" runat="server"></asp:TextBox>
    <br />
    Enter Password:<asp:TextBox ID="Txtpassword" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Btnlogin" runat="server" Text="Login" OnClick="Btnlogin_Click" />
   
</asp:Content>
