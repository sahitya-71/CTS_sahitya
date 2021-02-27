<%@ Page Title="" Language="C#" MasterPageFile="~/MovieAdmin.Master" AutoEventWireup="true" CodeBehind="EditMovie.aspx.cs" Inherits="Moviecruiser.WebForm3" %>
<%@ Register Src="~/HeaderAdmin.ascx" TagPrefix="adminh" TagName="head" %>
<%@ Register Src="~/FooterAdmin.ascx" TagPrefix="adminf" TagName="foot" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <adminh:head ID="h" runat="server" ></adminh:head>
    <asp:Label ID="Label1" runat="server" Text="Title"></asp:Label>
    <br />
    <asp:TextBox ID="TxtTitle" runat="server" MaxLength="30" Width="700px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldTitle" runat="server" ErrorMessage="*Title field is required" ControlToValidate="TxtTitle" ForeColor="#FF3300"></asp:RequiredFieldValidator>

    <br />
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Gross"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Active&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Date Of Launch&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Genre<br />
    <asp:TextBox ID="TxtGross" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RadioButton ID="Radioyes" GroupName="active" runat="server" Text="Yes" />
&nbsp;&nbsp;
    <asp:RadioButton ID="Radiono" GroupName="active" runat="server" Text="No" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxtDate" runat="server"></asp:TextBox>
    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownGenre" runat="server">
        <asp:ListItem>Superhero</asp:ListItem>
        <asp:ListItem>Science Fiction</asp:ListItem>
        <asp:ListItem>Superhero</asp:ListItem>
        <asp:ListItem>Romance</asp:ListItem>
        <asp:ListItem>Adventure</asp:ListItem>
        <asp:ListItem>Comedy</asp:ListItem>
        <asp:ListItem>Thriller</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RequiredFieldValidator ID="RequiredFieldGross" runat="server" ErrorMessage="*Gross field must be filled" ControlToValidate="TxtGross" ForeColor="#FF3300"></asp:RequiredFieldValidator>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RequiredFieldValidator ID="RequiredFieldDate" runat="server" ErrorMessage="*Date Of Launch field must be filled" ControlToValidate="TxtDate" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <asp:CheckBox ID="ChkHasTeaser" runat="server" Text="Has Teaser" />
    <br />
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" BackColor="#0033CC" Text="Save" Font-Size="10pt" ForeColor="White" Height="70px" OnClick="Button1_Click" Width="200px" />
    <br />
     <adminf:foot ID="f" runat="server"></adminf:foot>        

</asp:Content>
