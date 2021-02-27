<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HeaderAdmin.ascx.cs" Inherits="Moviecruiser.HeaderAdmin" %>
<style type="text/css">
    .auto-style2 {
        float: right;
        height: 42px;
    }
</style>
<header style="background-color: #000080; padding: 15px">
    <nav class="auto-style2">
        <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="White" Font-Underline="True" NavigateUrl="~/AdminMovieList.aspx">Movies</asp:HyperLink>
        </nav>
    <span style="color: #FFFFFF; font-size: 35px;">Movie Cruiser</span>
    <asp:Image ID="Image1" runat="server" Height="57px" ImageUrl="~/images/movie.png" Width="52px" />
           
</header>