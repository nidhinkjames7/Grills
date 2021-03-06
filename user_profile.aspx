﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="user_profile.aspx.cs" Inherits="user_profile" %>

<!DOCTYPE html>

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
        <form runat="server">
		<!-- Header -->
		<header id="header" class="transparent-nav">
			<div class="container">

				<div class="navbar-header">
					<!-- Logo -->
					<div class="navbar-brand">
						<a class="logo" href="home.aspx">
							<h1>Grills</h1>
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
						<li><a href="foodpreview.aspx">My Home</a></li>
						<li><a href="mycart.aspx">My Cart</a></li>
						<li><a href="contactus.aspx">My Bookings</a></li>
                        <li><a href="logout.aspx">Logout</a></li>
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
							<h1 class="white-text">Grills</h1>
							<p class="lead white-text">keep calm and love food.</p>

						</div>
                            <h3>LET'S ORDER!!!</h3>
                            
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                            <Columns>
                                <asp:BoundField DataField="fullname" HeaderText="fullname" SortExpression="fullname"></asp:BoundField>
                                <asp:BoundField DataField="address" HeaderText="address" SortExpression="address"></asp:BoundField>
                                <asp:BoundField DataField="dob" HeaderText="dob" SortExpression="dob"></asp:BoundField>
                                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email"></asp:BoundField>
                                <asp:BoundField DataField="phoneno" HeaderText="phoneno" SortExpression="phoneno"></asp:BoundField>
                                <asp:CommandField ShowEditButton="True" ButtonType="Button" ShowHeader="True" HeaderText="update food"></asp:CommandField>
                                     
                            </Columns>
                        </asp:GridView>

                        <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:grillConnectionString %>' SelectCommand="SELECT [fullname], [address], [dob], [email], [phoneno] FROM [registration] WHERE ([username] = @username)" UpdateCommand="update registration set fullname=@fullname,address=@address,dob=@dob,email=@email,phoneno=@phoneno where reg_id=@reg_id">
                            <SelectParameters>
                                <asp:SessionParameter SessionField="username" Name="username" Type="String"></asp:SessionParameter>
                            </SelectParameters>
                        </asp:SqlDataSource>
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
							<a class="logo" href="home.aspx">
								<h1>Grills</h1>
							</a>
						</div>
					</div>
					<!-- footer logo -->

					<!-- footer nav -->
					<div class="col-md-6">
						<ul class="footer-nav">
							<li><a href="home.aspx">Home</a></li>
							<li><a href="aboutus.aspx">AboutUs</a></li>
							<li><a href="gallery.aspx">Gallery</a></li>
						    <li><a href="contactus.aspx">ContactUs</a></li>
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
		<div id='preloader'><div class='preloader'></div>
            
        </div>
		<!-- /preloader -->


		<!-- jQuery Plugins -->
		<script type="text/javascript" src="js/jquery.min.js"></script>
		<script type="text/javascript" src="js/bootstrap.min.js"></script>
		<script type="text/javascript" src="js/main.js"></script>
            </form>
	</body>
</html>