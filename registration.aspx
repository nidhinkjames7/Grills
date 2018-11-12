<%@ Page Language="C#" AutoEventWireup="true" CodeFile="registration.aspx.cs" Inherits="registration" %>


<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>


<!DOCTYPE html>
<html lang="en">
	<head runat="server">
		<meta charset="utf-8">
		<meta http-equiv="X-UA-Compatible" content="IE=edge">
		<meta name="viewport" content="width=device-width, initial-scale=1">
		 <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->

		<title>Grills</title>

		<!-- Google font -->
		<link href="https://fonts.googleapis.com/css?family=Lato:700%7CMontserrat:400,600" rel="stylesheet">

		<!-- Bootstrap -->
		<link type="text/css" rel="stylesheet" href="css/bootstrap.min.css"/>

		<!-- Font Awesome Icon -->
		<link rel="stylesheet" href="css/font-awesome.min.css">

		<!-- Custom stlylesheet -->
		<link type="text/css" rel="stylesheet" href="css/style.css"/>
        <link type="text/css" rel="stylesheet" href="css/grillstyle.css" />

		<!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
		<!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
		<!--[if lt IE 9]>
		  <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
		  <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
		<![endif]-->

    </head>
	<body>

		<!-- Header -->
		<header id="header" class="transparent-nav">
			<div class="container">

				<div class="navbar-header">
					<!-- Logo -->
					<div class="navbar-brand">
						<a class="logo" href="index.html">
							<img src="./img/logo-alt.png" alt="logo">
						</a>
					</div>
					<!-- /Logo -->

					<!-- Mobile toggle -->
					<button class="navbar-toggle">
						<span></span>
					</button>
					<!-- /Mobile toggle -->
				</div>

				<!-- Navigation -->
				<nav id="nav">
					<ul class="main-menu nav navbar-nav navbar-right">
						<li><a href="home.aspx">Home</a></li>
						<li><a href="home.aspx">Login</a></li>
						<li><a href="">Gallery</a></li>
						<li><a href="aboutus.aspx">AboutUs</a></li>
						<li><a href="contactus.aspx">Contact</a></li>
					</ul>
				</nav>
				<!-- /Navigation -->

			</div>
		</header>
		<!-- /Header -->

		<!-- Home -->
		<div id="home" class="hero-area">

			<!-- Backgound Image -->
			<div class="bg-image bg-parallax overlay" style="background-image:url(./img/bk2.jpeg)"></div>
			<!-- /Backgound Image -->

			<div class="home-wrapper">
				<div class="container">
					<div class="row">
						<div class="col-md-8">
                            <br />
                            <center>
							<h1 class="white-text">Grills</h1>
							<p class="lead white-text">keep calm and love food.</p>
                            <h3>REGISTER HERE!!!</h3>
                            <table>
                                <form method="post" runat="server">
                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:grillConnectionString %>' SelectCommand="SELECT * FROM [registration]"></asp:SqlDataSource>
                                    <asp:ScriptManager runat="server"></asp:ScriptManager>
                                    <tr>
                                        <td><asp:Label runat="server" Text="FullName"></asp:Label><asp:TextBox ID="txtfullname" runat="server" placeholder="FullName" required="required"></asp:TextBox></td>
                                        &nbsp &nbsp
                                        <td><asp:Label runat="server" Text="Address"></asp:Label><asp:TextBox ID="txtaddress" runat="server" placeholder="Address" required="required" TextMode="MultiLine"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td><asp:Label runat="server" Text="Date Of Birth"></asp:Label><asp:TextBox ID="txtdob" runat="server" required="required" TextMode="SingleLine"></asp:TextBox>
                                            <cc1:CalendarExtender ID="txtdob_CalendarExtender" runat="server" Enabled="True" TargetControlID="txtdob">
                                            </cc1:CalendarExtender>
                                        </td>
                                        <td><asp:Label runat="server" Text="E-mail"></asp:Label><asp:TextBox ID="txtemail" runat="server" placeholder="E-Mail" required="required" TextMode="Email"></asp:TextBox></td>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid e-mail" ControlToValidate="txtemail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                    </tr>
                                    <tr>
                                        <td><asp:Label runat="server" Text="Phone Number"></asp:Label><asp:TextBox ID="txtphone" runat="server" placeholder="PhoneNumber" required="required"></asp:TextBox></td>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Invalid Phone Number" ValidationExpression="\d{10}" ControlToValidate="txtphone"></asp:RegularExpressionValidator>
                                        <td><asp:Label runat="server" Text="User Name"></asp:Label><asp:TextBox ID="txtusername" runat="server" placeholder="UserName" required="required" TextMode="SingleLine"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td><asp:Label runat="server" Text="Password"></asp:Label><asp:TextBox ID="txtpassword" runat="server" placeholder="Password" required="required" TextMode="Password" CausesValidation="True"></asp:TextBox><cc1:PasswordStrength runat="server" Enabled="True" TargetControlID="txtpassword" ID="txtpassword_PasswordStrength"></cc1:PasswordStrength></td>
                                        <td><asp:Label runat="server" Text="Confirm Password"></asp:Label><asp:TextBox ID="txtcpassword" runat="server" placeholder="Password" required="required" TextMode="Password" ControlToValidate="txtcpassword"></asp:TextBox></td>
                                        <td><asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtpassword" ControlToValidate="txtcpassword" ErrorMessage="Password Does Not Match"></asp:CompareValidator></td>
                                    </tr>
                                    <tr>
                                        <td><asp:Button ID="btnreset" runat="server" Text="Reset" OnClick="btnreset_Click"/></td>
                                        <td><asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" /></td>
                                        
                                    </tr>
                               </form>
                            </table>
                        </center>
						</div>
					</div>
				</div>
			</div>

		</div>
		<!-- /Home -->

 
		<!-- Footer -->
		<footer id="footer" class="section">

			<!-- container -->
			<div class="container">

				<!-- row -->
				<div class="row">

					<!-- footer logo -->
					<div class="col-md-6">
						<div class="footer-logo">
							<a class="logo" href="index.html">
								<img src="./img/logo.png" alt="logo">
							</a>
						</div>
					</div>
					<!-- footer logo -->

					<!-- footer nav -->
					<div class="col-md-6">
						<ul class="footer-nav">
							<li><a href="home.aspx">Home</a></li>
                            <li><a href="home.aspx">Login</a></li>
    						<li><a href="#">Gallery</a></li>
							<li><a href="aboutus.aspx">About</a></li>
							<li><a href="contact.aspx">Contact</a></li>
						</ul>
					</div>
					<!-- /footer nav -->
               
				</div>
				<!-- /row -->

				<!-- row -->
				<div id="bottom-footer" class="row">

					<!-- social -->
					<div class="col-md-4 col-md-push-8">
						<ul class="footer-social">
							<li><a href="#" class="facebook"><i class="fa fa-facebook"></i></a></li>
							<li><a href="#" class="twitter"><i class="fa fa-twitter"></i></a></li>
							<li><a href="#" class="google-plus"><i class="fa fa-google-plus"></i></a></li>
							<li><a href="#" class="instagram"><i class="fa fa-instagram"></i></a></li>
							<li><a href="#" class="youtube"><i class="fa fa-youtube"></i></a></li>
							<li><a href="#" class="linkedin"><i class="fa fa-linkedin"></i></a></li>
						</ul>
					</div>
					<!-- /social -->

					<!-- copyright -->
					<div class="col-md-8 col-md-pull-4">
						<div class="footer-copyright">
							<span>&copy; Copyright 2018. All Rights Reserved. | This template is made with <i class="fa fa-heart-o" aria-hidden="true"></i> by <a href="https://colorlib.com">Colorlib</a></span>
						</div>
					</div>
					<!-- /copyright -->

				</div>
				<!-- row -->

			</div>
			<!-- /container -->

		</footer>
		<!-- /Footer -->

		<!-- preloader -->
		<div id='preloader'><div class='preloader'></div></div>
		<!-- /preloader -->


		<!-- jQuery Plugins -->
		<script type="text/javascript" src="js/jquery.min.js"></script>
		<script type="text/javascript" src="js/bootstrap.min.js"></script>
		<script type="text/javascript" src="js/main.js"></script>

	</body>
</html>
