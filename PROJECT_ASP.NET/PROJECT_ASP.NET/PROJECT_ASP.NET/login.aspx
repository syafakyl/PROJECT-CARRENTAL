<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="PROJECT_ASP.NET.Login" Theme="Theme1"%>

<!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>CarBay</title>
        <link href="App_Themes/Theme1/css/style.css" rel="stylesheet"/>
    </head>
    <body>
        <form id="form1" runat="server">
        <div>

            <header>
                    <h2 class="logo">CarBay</h2>
            </header>

            <div class="wrapper">
                
                <div class="form-box Login">
            <h2>Login</h2>
            <form2>
                 <div class="input-box">
                     <span class="icon"><ion-icon name="mail-outline"></ion-icon></span>
                     <input type="email" id="txtEmail" name="txtEmail" runat="server"/>
                     <label for="">Email</label>
                 </div>
                 <div class="input-box">
                     <span class="icon"><ion-icon name="lock-closed-outline"></ion-icon></span>
                     <input type="password" ID="txtPassword" name="txtPassword" CssClass="form-control" runat="server"/>
                     <label for="">Password</label>
                 </div>
                <asp:CheckBox ID="CheckBox1" runat="server"/>Remember Me!
                <asp:Button ID="Button" runat="server" Text="Login" Class="button" OnClick="Button_Click"/>
                 <div class="login-register">
                     <p>Don't have an account?<a href="#" class="register-link">Register</a></p>
                 </div>
            </form2>
        </div>

        <div class="form-box Register form-container">
            <h2>Register</h2>
            <form3>
                            <div class="input-box">
                                <asp:TextBox ID="txtNIK" CssClass="form-control" runat="server"></asp:TextBox>
                                <label for="NIK">NIK</label>
                            </div>
                            <div class="input-box">
                                <asp:TextBox ID="txtName" CssClass="form-control" runat="server"></asp:TextBox>
                                <label for="Name">Name</label>
                            </div>
                            <div class="input-box">
                                <asp:TextBox ID="txtEmailR" CssClass="form-control" runat="server"></asp:TextBox>
                                <label for="Email">Email</label>
                            </div>
                            <div class="input-box">
                                <input type="password" ID="txtPasswordR" name="txtPasswordR" CssClass="form-control" runat="server"/>
                                <label for="Password">Password</label>
                            </div>
                            <div class="input-box">
                                <asp:TextBox ID="txtPhone" CssClass="form-control" runat="server"></asp:TextBox>
                                <label for="Phone">Phone</label>
                            </div>
                            <div class="input-box">
                                <asp:TextBox ID="txtAddress" CssClass="form-control" runat="server"></asp:TextBox>
                                <label for="Address">Address</label>
                            </div>
                            <asp:Button ID="Button1" runat="server" Text="Register" Class="button" OnClick="Button1_Click"/>  
                            <div class="login-register">
                                <p>Already have an account?<a href="#" class="login-link">Login</a></p>
                            </div>
            </form3>
        </div>
    </div>


<script src="App_Themes/Theme1/js/script.js"></script>
<script type="module" src="https://unpkg.com/ionicons@7.1.0/dist/ionicons/ionicons.esm.js"></script>
<script src="https://unpkg.com/ionicons@7.1.0/dist/ionicons/ionicons.js"></script>

        </div>
    </form>
</body>
</html>
