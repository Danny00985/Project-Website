<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CertificateApplication.aspx.cs" Inherits="CertificateApplication" %>

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
<div id="container-header">
	<div id="header">
		<ul id="nav">
			<li id="current-page"><a href="Default.aspx">Home</a></li>
			<li><a href="aboutus.aspx">About Us</a></li>
			<%--<li><a href="services.aspx">Services</a></li>--%>
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
<div id="container-advert">
	<div id="advert">
		<h1>Myanmar National Root CA</h1>
		<p>Secured, Trusted and Proven PKI Solutions</p>
		</div>
</div>

<div id="container-content" > 
<div id="container-homepage-links">
<div id="application">
<h2>Certification Authority Application</h2>
<p>Any applicant who want to provide service as a Certification Authority in Myanmar shall fill out application form (of three copies) and submit by visiting to the Electronic Transactions Control Board at the following address:-</p>
<div class="secretary">
<p >The Secretary</p>
<p >The Electronic Transaction Control Board,</p>
<p >Office No-2, Special Development Zone,</p>
<p >Ministry of Communications and Information Technology,</p>
<p >Nay Pyi Taw, Myanmar.</p>
</div>
</div>
</div><p> <a href="Default.aspx">Go to Home Page</a></p>
</div>
<%--<div class="clear">&nbsp;</div>
--%>
<div id="footer" >
	Copyright © 2012,Myanmar ICT Development Corporation Ltd. All Rights Reserved.	
	 <%--<img src="images/myanmar-info-tech-root-ca.gif" class="logo-img" />--%>
	</div>
	
</form>
</body>
</html>
