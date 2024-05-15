<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="PROJECT_ASP.NET.admin" Theme="Theme2"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin</title>
    <link href="App_Themes/Theme2/css/style.css" rel="stylesheet" >
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <header>
            <h2 class="logo">CarBay</h2>
            <asp:Button ID="User" runat="server" Text="User" OnClick="User_Click"/>
        </header>
                <div class="wrapper">
                    <div class="form-box Login">
                <h2>Login</h2>
                <form2>
                     <div class="input-box">
                         <span class="icon"><ion-icon name="mail-outline"></ion-icon></span>
                         <asp:TextBox ID="txtUsername" CssClass="form-control" runat="server"></asp:TextBox>
                         <label for="">Username</label>
                     </div>
                     <div class="input-box">
                         <span class="icon"><ion-icon name="lock-closed-outline"></ion-icon></span>
                         <input type="password" id="txtPassword" name="txtPassword" runat="server"/>
                         <label for="">Password</label>
                     </div>
                     <asp:Button ID="Button" runat="server" Text="Login" Class="button" OnClick="Button_Click"/>
                </form2>
           </div>
      </div>
    </div>
    </form>
</body>
</html>
