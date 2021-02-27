<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Moviecruiser.WebForm9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #login {
            box-shadow: 0 0 2px rgba(0, 0, 0, 0.2), 0 1px 1px rgba(0, 0, 0, .2), 0 3px 0 #fff, 0 4px 0 rgba(0, 0, 0, .2), 0 6px 0 #fff, 0 7px 0 rgba(0, 0, 0, .2);
            position: absolute;
            z-index: 0;
        }
   

#login:before {
    content: '';
    position: absolute;
    z-index: -1;
    border: 1px dashed #ccc;
    top: 5px;
    bottom: 5px;
    left: 5px;
    right: 5px;
    box-shadow: 0 0 0 1px #fff;
}
h1 {
    text-shadow: 0 1px 0 rgba(255, 255, 255, .7), 0px 2px 0 rgba(0, 0, 0, .5);
    text-transform: uppercase;
    text-align: center;
    color: #666;
    margin: 0 0 30px 0;
    letter-spacing: 4px;
    font: normal 26px/1 Verdana, Helvetica;
    position: relative;
}

h1:after, 
h1:before {
    background-color: #777;
    content: "";
    height: 1px;
    position: absolute;
    top: 15px;
    width: 120px;   
}

h1:after {      
    right: 0;
}

h1:before {
    background-image: linear-gradient(right, #777, #fff);
    left: 0;
}

        .auto-style1 {
            left: 164px;
            top: 46px;
            width: 830px;
            height: 379px;
        }

        .auto-style2 {
            height: 196px;
            margin-top: 0px;
        }
        .auto-style3 {
            margin-top: 0px;
        }

    </style>
</head>
<body>
    <       <form id="login" runat="server" class="auto-style1" style="background-color: #FFFFFF; background-image: url('images/Background.jpg');">
    <h1 style="color: #000000; font-weight: bold; font-size: 30px;">Log In</h1>
    <fieldset id="inputs" style="font-size: 25px" class="auto-style2">
        Enter UserName:
        <br />
        <asp:TextBox ID="Txtname" runat="server" placeholder="Username" Height="35px" Width="400px" ></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldNmae" runat="server" ControlToValidate="Txtname" ErrorMessage=" *UserName should not be empty" ForeColor="Red"></asp:RequiredFieldValidator>
         <br />
         <asp:CustomValidator ID="NameValidator" runat="server" ErrorMessage="Invalid username" ClientValidationFunction="ValidateName" ControlToValidate="Txtname" ForeColor="Red" OnServerValidate="ValidateUsername" Display="Dynamic" Font-Size="25px"></asp:CustomValidator>

        <br />
        Enter Password:
        <br />
        <asp:TextBox ID="Txtpassword" runat="server" placeholder="Password" Height="35px" Width="400px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldpassword" runat="server" ControlToValidate="Txtpassword" ErrorMessage=" *password should not be empty" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:CustomValidator ID="PasswordValidator" runat="server" ErrorMessage="Invalid Password" ControlToValidate="Txtpassword" Display="Dynamic" Font-Size="25px" ForeColor="Red" ClientValidationFunction="ValidatePassword" OnServerValidate="ValidatePassword"></asp:CustomValidator>    
       
       
    </fieldset>
    <fieldset id="actions"><br />
        
        <asp:Button ID="submit" runat="server" Text="Log in" BackColor="#FF9900" OnClick="submit_Click" Height="50px" Width="200px" CssClass="auto-style3" />
        
       
    </fieldset>
</form>
   
</body>
</html>
