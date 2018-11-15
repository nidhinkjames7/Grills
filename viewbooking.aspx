﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="viewbooking.aspx.cs" Inherits="viewbooking" %>

       <!DOCTYPE html>
        <html lang="en">
	    <head>
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
						<li><a href="adminpage.aspx">Admin Home</a></li>
                        <li><a href="viewfood.aspx">View Food</a></li>
                        <li><a href="addfood.aspx">Add Food</a></li>
						<li><a href="removefood.aspx">Remove Food</a></li>
                        <li><a href="updatefood.aspx">Update Food</a></li>
                        <li><a href="add_gallery_pics.aspx">Add Gallery</a></li>
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
                            <h3>BOOKINGS...!!!</h3>
                             <form method="post" runat="server">

                                 <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="book_id" DataSourceID="SqlDataSource1">
                                     <Columns>
                                         <asp:BoundField DataField="book_id" HeaderText="book_id" ReadOnly="True" InsertVisible="False" SortExpression="book_id"></asp:BoundField>
                                         <asp:BoundField DataField="username" HeaderText="username" SortExpression="username"></asp:BoundField>
                                         <asp:BoundField DataField="food_id" HeaderText="food_id" SortExpression="food_id"></asp:BoundField>
                                         <asp:BoundField DataField="foodquantity" HeaderText="foodquantity" SortExpression="foodquantity"></asp:BoundField>
                                         <asp:BoundField DataField="status" HeaderText="status" SortExpression="status"></asp:BoundField>
                                         <asp:BoundField DataField="delivery" HeaderText="delivery" SortExpression="delivery"></asp:BoundField>
                                     <asp:CommandField ShowEditButton="True" ButtonType="Button" ShowHeader="True" HeaderText="Edit Status"></asp:CommandField>
                                     </Columns>
                                 </asp:GridView>

                                 <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:grillConnectionString %>' SelectCommand="SELECT * FROM [booking]" UpdateCommand="UPDATE [booking] set delivery=@delivery where book_id=@book_id"></asp:SqlDataSource>
                             </form>
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
							<span>&copy; Copyright 2018. All Rights Reserved. | This template is made with <i class="fa fa-heart-o" aria-hidden="true"></i> by <a href="https://colorlib.com">Grills</a></span>
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
