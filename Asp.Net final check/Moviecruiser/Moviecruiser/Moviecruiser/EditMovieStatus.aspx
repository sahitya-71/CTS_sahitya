<%@ Page Title="" Language="C#" MasterPageFile="~/MovieAdmin.Master" AutoEventWireup="true" CodeBehind="EditMovieStatus.aspx.cs" Inherits="Moviecruiser.WebForm4" %>
<%@ Register Src="~/HeaderAdmin.ascx" TagPrefix="adminh" TagName="head" %>
<%@ Register Src="~/FooterAdmin.ascx" TagPrefix="adminf" TagName="foot" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <adminh:head ID="h" runat="server" ></adminh:head>
    
       <p style="font-size: 30px"> Edit Movie Status</p>
      
        <p style="color: #00CC00; font-size: 23px;">
    Movie details saved successfully</p>
        
 
    <adminf:foot ID="f" runat="server"></adminf:foot>   
</asp:Content>
