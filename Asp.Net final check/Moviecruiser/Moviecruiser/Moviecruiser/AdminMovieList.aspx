<%@ Page Title="" Language="C#" MasterPageFile="~/MovieAdmin.Master" AutoEventWireup="true" CodeBehind="AdminMovieList.aspx.cs" Inherits="Moviecruiser.WebForm2" %>
<%@ Register Src="~/HeaderAdmin.ascx" TagPrefix="adminh" TagName="head" %>
<%@ Register Src="~/FooterAdmin.ascx" TagPrefix="adminf" TagName="foot" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <adminh:head ID="h" runat="server" ></adminh:head>
   <h2> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Movies </h2>
    <asp:GridView ID="GridAdmin" runat="server" Width="984px" Height="247px" BorderStyle="None" CellPadding="3" CellSpacing="1" GridLines="None" HorizontalAlign="Center" AutoGenerateColumns="False">
        <HeaderStyle BorderStyle="None" HorizontalAlign="Left" />
        <RowStyle HorizontalAlign="Left" />
          <Columns>
               <asp:BoundField HeaderText="ID" DataField="Id" />
               <asp:BoundField HeaderText="Title" DataField="Title" />
               <asp:BoundField HeaderText="Box Office" DataField="BoxOffice" />
               <asp:BoundField HeaderText="Active" DataField="Active" />
               <asp:BoundField HeaderText="Date Of Launch" DataField="DateofLaunch" />
               <asp:BoundField HeaderText="Genre" DataField="Genre" />
               <asp:BoundField HeaderText="Has Teaser" DataField="HasTeaser" />
                  <asp:HyperLinkField
            DataNavigateUrlFields="id"
            DataNavigateUrlFormatString="~\EditMovie.aspx?id={0}"
            Text="Edit"
            HeaderText="Action" />
</Columns>
    </asp:GridView>
         <adminf:foot ID="f" runat="server"></adminf:foot> 
</asp:Content>
 
<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
</asp:Content>
