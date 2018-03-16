<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="QLDD_2018.Admin.User.Login" %>

<!DOCTYPE html>
<html class="bg-black">
    <head>
        <meta charset="UTF-8">
        <title>AdminLTE | Log in</title>
        <meta content='width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no' name='viewport'>
        <!-- bootstrap 3.0.2 -->
        <link href="../../Content/admin/bootstrap.min.css" rel="stylesheet" type="text/css" />
        <!-- font Awesome -->
        <link href="../../Content/admin/font-awesome.min.css" rel="stylesheet" type="text/css" />
        <!-- Theme style -->
        <link href="../../Content/admin/AdminLTE.css" rel="stylesheet" type="text/css" />
		
        <style>
            #flashMessage{
                color: red;
                font-size: 14pt;
            }
        </style>

    </head>
    <body class="bg-black">
        <form runat="server">
        <div class="form-box" id="login-box">
            <div class="header">Đăng nhập
            <% if (Session["check"] != null){ %><%=Session["check"] %><%} %>
            </div>
                <input type="hidden" name="_method" value="POST">
                <div class="body bg-gray">
                    <div class="form-group">
                        <label>Email : </label>
                        <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" />
                    </div>
                    <div class="form-group">
                        <label>Email : </label>
                        <asp:TextBox runat="server" TextMode="Password" ID="txtPassword" CssClass="form-control" />
                    </div>
                    <div class="form-group">
                        <input type="checkbox" name="remember_me"/> Remember Me
                    </div>
                </div>
                <div class="footer">
                    <asp:Button runat="server" Text="Login" ID="btnLogin" OnClick="btnLogin_Click" />
                    <p><a href="#">Lost password?</a></p>

                </div>
            <div class="margin text-center">
                <br/>
            </div>
        </div>
            </form>
        <!-- jQuery 2.0.2 -->
        <script src="http://ajax.googleapis.com/ajax/libs/jquery/2.0.2/jquery.min.js"></script>
        <!-- Bootstrap -->
        <script src="http://almsaeedstudio.com/AdminLTE/js/bootstrap.min.js" type="text/javascript"></script>

    </body>
</html>
