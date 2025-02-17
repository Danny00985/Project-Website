<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="Default"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Root CA - Myanmar Info-Tech Corporation</title>
    <link href="css/default.css" rel="stylesheet" type="text/css" media="screen" />
     <link rel="shortcut icon" href="~/images/final.png" type="image/x-icon" /> 
</head>
<body>
<form id="Form1" name="form1" runat="server">
<%--<object width="600" height="400">
            <param name="Music1" value="MusicFileName">
            <embed src="AVSEQ06.wav" width="600" height="400" loop="true">
            </embed>
        </object>--%>
<div id="container-header" >
	<div id="header" >
		<ul id="nav">
			<li id="current-page"><a href="Default.aspx">Home</a></li>
			<li><a href="aboutus.aspx">About Us</a></li>
			<li><a href="ActivitiesNews.aspx">Activities News</a></li>
			<li><a href="resources.aspx">Resources</a></li>			
			<li><a href="Download.aspx">Download</a></li>		
			<li ><a href="crlnew.aspx">Certificate Revocation List</a></li>	
			<li><a href="certificates.aspx">Certificate Repository</a></li>
		    <li><a href="contactus.aspx">Contact Us</a></li>
			
		</ul>
		
	</div>
	<div id="header-img">
	<img  src="images/14root-ca-MICTD long.jpg" alt="Myanmar Info-Tech Root CA" />
	</div>
</div>
<div id="container-advert" style="width: 110%; height: 130px">
	<div id="advert">
		<h1>Myanmar National Root CA</h1>
		<p>Secured, Trusted and Proven PKI Solutions</p>
		</div>
</div>
<div id="container-content" style="height:400px; width: 779px;"> 

	<div id="root-ca">
		<h2 >National Root CA </h2>
		<p>Root Certification Authority (Root CA) was established in 2008 to establish the Public Key Infrastructure in Myanmar and to certify the Certification Authorities (CA) to do the CA business in Myanmar. Root CA is the technical solution provider for Certification Authorities in Myanmar and provides the technical solutions as well as policies and guidelines that they must follow when performing CA operations.</p>
		<p>The premier Public Key Infrastructure (PKI) security and only leading PKI solution provider in Myanmar to enable new PKI enable business solutions.</p>
		<p> <a href="aboutus.aspx">more about us</a></p>
	</div>	
	
	<div id="provide" style="width: 146px; height: 485px">
		<h2>What do we provide?</h2>
		<p style="text-align: left">We provide security services for digital signature creation and encryption and decryption of  messages to provide reliable communication between sender and receiver of information.</p>
	</div>
	
	<div id="info" style="width: 255px" >
		<img src="images/rootca.jpg" alt="Certification Authority" />
		<%--<h2>Services</h2>
		<p>Digital Certificates for Certification Authorities operated by Myanmar Info-Tech Root CA</p>--%>
		<%-- <h2 style="color:Red">Informations</h2> --%>
		<h2 style="color:Purple">Informations</h2>
	
		<p><a href="CertificateApplication.aspx">CA Applicaiton Form</a></p>
		<%--<p><a href="#">National Repository Submission Guide Line</a></p>--%>
		<p><a href="OID.aspx">OID Assignment</a></p>
		
		<p><a href="http://www.yatanarponca.com.mm"> Yatanarpon CA</a></p>
		
		<p><a href="http://www.moss.com.mm"> MOSS CA</a></p>
	</div>
	<%--<p><a href="http://www.counter.plus/details/pZd"><img src="http://www.counter.plus/pZd/" alt="Flag Counter" width="270px" height="100px"></a></p>--%>
    <br />
    <br />
    <br />
    <br />
</div>
<div class="clear" ><div class="clear"></div>	</div>



<div id="footer" >
	Copyright © 2012,Myanmar ICT Development Corporation Ltd. All Rights Reserved.	
	 <%--<img src="images/myanmar-info-tech-root-ca.gif" class="logo-img" />--%>
	</div>


</form>
</body>
</html>
