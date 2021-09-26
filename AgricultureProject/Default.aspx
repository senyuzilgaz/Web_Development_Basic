<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AgricultureProject.Default" %>

<!DOCTYPE html>
<html lang="zxx">

<head>
    <title>Agriculture</title>
    <!-- Meta tag Keywords -->
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta charset="UTF-8" />
    <script>
        addEventListener("load", function () {
            setTimeout(hideURLbar, 0);
        }, false);

        function hideURLbar() {
            window.scrollTo(0, 1);
        }
    </script>
    <link rel="shortcut icon" href="web/icon.png">
    <!-- Custom-Files -->
    <link rel="stylesheet" href="web/css/bootstrap.css">
    <!-- Bootstrap-Core-CSS -->
    <link rel="stylesheet" href="web/css/style.css" type="text/css" media="all" />
    <!-- Style-CSS -->
    <link rel="stylesheet" href="web/css/font-awesome.css">
    <!-- Font-Awesome-Icons-CSS -->
    <!-- //Custom-Files -->
    <!-- Web-Fonts -->
    <link href="//fonts.googleapis.com/css?family=Roboto:100,100i,300,300i,400,400i,500,500i,700,700i,900,900i&amp;subset=cyrillic,cyrillic-ext,greek,greek-ext,latin-ext,vietnamese"
        rel="stylesheet">
    <!-- //Web-Fonts -->
</head>
<body>
    <div class="main-top py-1">
        <!-- header -->
        <header>
            <div class="container-fluid px-lg-4">
                <nav class="py-4">
                    <div class="logo" id="logo">
                        <a href="index.html">Agriculture</a>

                    </div>
                    <label for="drop" class="toggle">Menu</label>
                    <input type="checkbox" id="drop">
                    <ul class="menu mt-md-3">
                        <li class="mr-lg-2 active"><a href="index.html">Home</a></li>
                        <li class="mr-lg-2"><a href="#about" class="scroll">About</a></li>
                        <li class="mr-lg-2"><a href="#services" class="scroll">Services</a></li>
                        <li class="mr-lg-2"><a href="#features" class="scroll">Features</a></li>
                        <li class="mr-lg-2"><a href="#news" class="scroll">News</a></li>
                        <li><a href="#contact" class="scroll">Contact Us</a></li>
                    </ul>
                </nav>
            </div>
        </header>
        <!-- //header -->


        <!-- //header -->
        <!-- banner -->
        <div class="main-w3pvt">
            <div class="container-fluid">
                <div class="row">
                    <div class="style-banner">
                        <h1 class="text-white">Welcome to Agriculture Project</h1>
                        <p class="mt-5 text-white"> I designed this website using ASP.NET WebForms, and MSSQL. All the data is fetched from Mssql database, and contact form sends it's information to Mssql database. </p>
                        <a href="#about" class="btn button-style mt-sm-5 mt-4 scroll">Learn More</a>
                    </div>
                </div>
            </div>
        </div>
        <!-- //banner -->
    </div>

    <!-- what we do -->
    <section class="wedo py-5" id="about">

        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <div class="container py-lg-5">
                    <div class="text-center">
                        <h2 class="w3_head">Agriculture </h2>
                        <p class="main_p mt-4 mb-4 pt-2 text-center mx-auto"> <%# Eval("Description") %></p>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </section>
    <!-- //what we do -->
    <section class="what_you py-5" id="services">
        <div class="container py-lg-5">
            <div class="row about-info-grids text-center">
                <div class="col-md-4 about-info about-info1">
                    <span class="fa fa-sun-o"></span>
                    <h4>Sun</h4>
                    <div class="h4-underline"></div>
                    <p>Sunlight provides the energy plants need to convert carbon dioxide and water into carbohydrates and oxygen. The carbohydrates produced by photosynthesis are used for vegetative and reproductive growth and to increase crop biomass. Because solar energy is needed for photosynthesis, it only occurs during daylight.</p>
                </div>
                <div class="col-md-4 about-info about-info2">
                    <span class="fa fa-umbrella"></span>
                    <h4>Rainfall</h4>
                    <div class="h4-underline"></div>
                    <p>The primary source of water for agricultural production for most of the world is rainfall. Three main characteristics of rainfall are its amount, frequency and intensity, the values of which vary from place to place, day to day, month to month and also year to year. Precise knowledge of these three main characteristics is essential for planning its full utilization.</p>
                </div>
                <div class="col-md-4 about-info about-info3">
                    <span class="fa fa-cloud"></span>
                    <h4>Fencing</h4>
                    <div class="h4-underline"></div>
                    <p>Fencing plays an important role in creating and demarcating boundaries on farms. This can contain herds and individual animals within a specified area, and excludes wild predators. It also establishes property boundaries.</p>
                </div>
                <div class="whsat_bt text-center mx-auto">
                    <a href="#features" class="btn button-style mt-sm-5 mt-4 scroll">Learn More</a>
                </div>
            </div>
        </div>
    </section>

    <section class="augue py-5" id="features">
        <div class="container py-lg-5">
            <div class="row about-info-augue">
                <div class="col-md-4 about-aug about-aug1">
                    <h4>Importance of Agriculture</h4>
                    <p>Human existence cannot be guaranteed without the intake of food which is the major importance of agriculture and farming. . Now food doesn’t fall from the sky but food are produced by people who are known as farmers. I’m going to list some of the basic importance of agriculture. Although these importance are not limited to these but you can use our comment box to let us know if you need info concerning the post </p>
                    <a href="#news" class="btn button-style mt-sm-5 mt-4 scroll">Learn More</a>
                </div>
                <div class="col-md-4 about-aug about-aug2">
                    <div class="augue_im1">
                        <img src="web/images/g1.jpg" alt="news image" class="img-fluid">
                    </div>
                    <div class="augue_im2 mt-4 mb-4">
                        <img src="web/images/g2.jpg" alt="news image" class="img-fluid">
                    </div>
                    <div class="augue_im3">
                        <img src="web/images/g3.jpg" alt="news image" class="img-fluid">
                    </div>
                </div>
                <div class="col-md-4 about-aug about-aug3">
                    <div class="augue_im4">
                        <img src="web/images/g4.jpg" alt="news image" class="img-fluid">
                    </div>
                    <div class="augue_im5 mt-4 mb-4">
                        <img src="web/images/g5.jpg" alt="news image" class="img-fluid">
                    </div>
                    <div class="augue_im6">
                        <img src="web/images/g6.jpg" alt="news image" class="img-fluid">
                    </div>
                </div>
            </div>
        </div>
    </section>

    <section class="diam  py-5" id="news">

        <div class="container py-lg-5">
            <img src="web/images/1.jpg" alt="news image" class="img-fluid">
        <asp:Repeater ID="Repeater2" runat="server">
            <ItemTemplate>
            <div class="">
                <div style="display: flex;">
                    <h4 style="padding:25px; margin: 25px;"> <%# Eval("Name") %>  </h4>
                    <p style="display: flex;" class="mt-5">  <%# Eval("Description") %> </p>
                </div>
            </div>
            </ItemTemplate>
        </asp:Repeater>
        </div>

    </section>
    <!-- contact -->
    <section class="wedo py-5" id="contact">
        <div class="container py-lg-5">
            <div class="text-center">
                <h3 class="w3_head">Contact us </h3>
                <p class="main_p mt-4 mb-4 pt-2 text-center mx-auto"> You can share your opinions with us, or ask for something you want to know!</p>
            </div>
            <div class="contact_grid_right mt-5 mx-auto text-center">
                <form action="#" method="post">
                    <div class="row contact_top">
                        <div class="col-sm-6">
                            <input type="text" name="Name" placeholder="Name" required="">
                        </div>
                        <div class="col-sm-6">
                            <input type="email" name="Email" placeholder="Email" required="">
                        </div>
                    </div>
                    <textarea name="Message" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Message...';}" required="">Message...</textarea>
                    <button type="button" class="btn btn-success" style="padding: 80px, 80px; font-size: 20px; margin-right: 50px;"> Send Message </button>
                    <button type="reset" class="btn btn-primary" style="padding: 80px, 80px; font-size: 20px;"> Clear Message </button>
                    <div class="clearfix"></div>
                </form>
            </div>
        </div>
    </section>
    <!-- //contact -->
    <!-- footer -->
    <div class="cpy-right text-center py-5">
        <ul class="social_section_1info pt-lg-4 mb-lg-4">
            <li><a href="#"><span class="fa fa-facebook"></span></a></li>
            <li><a href="#"><span class="fa fa-twitter"></span></a></li>
            <li><a href="#"><span class="fa fa-google-plus"></span></a></li>
            <li><a href="#"><span class="fa fa-linkedin"></span></a></li>
        </ul>
        <p>
            © 2021 Combine. All rights reserved | Design by
            Ilgaz Senyuz
        </p>
    </div>
    <!-- //footer -->
</body>
</html>

