<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Disclaimer.aspx.cs" Inherits="Disclaimer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Root CA - Myanmar Info-Tech Corporation</title>
<link href="css/default.css" rel="stylesheet" type="text/css" media="screen" />
<link rel="shortcut icon" href="~/images/final.png" type="image/x-icon" /> 
</head>

<body>
    <div id="container-header">
	<div id="header">
		<ul id="nav">
			<li><a href="Default.aspx">Home</a></li>
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
<div id="container-advert">
	<div id="advert">
		<h1>Myanmar National Root CA</h1>
		<p>Secured, Trusted and Proven PKI Solutions</p>
	</div>
</div>
<div id="container-content">
		<div id="aboutus">
       <div id="disclaimer">
			<h2>Disclaimer</h2>
			<p><b><i> For latest information, subscribers and relying parties are advised to verify the certificates and CRLs from the issuing CA’s website.</i></b></p>
			
		<h2>National Repository of Digital Certificates (NRDC)</h2>
		<p>The Myanmar Root CA operates the National Repository of Digital Certificates (NRDC) as requirement under the direction of the Electronic Transactions Control Board. Copies of all Digital Certificates and the corresponding Certificate Revocation Lists (CRLs) issued by licensed Certification Authorities in the country are maintained in the NRDC.</p>
		<p>Access to these Digital Certificates is provided with a search facility so that the public keys contained in these certificates are available to any member of the public.</p>
		<p>The NRDC is updated through weekly submission by all the licensed CAs as prescribed in the guidelines for submission to NRDC. Relying parties can verify the CAs' public keys by using the NRDC.</p>
		<p><b><i>For latest Information, subscribers and relying parties are advised to verify the certificates and CRL from the issuing CA’s web site.</i></b></p>
		<p><a href="certificates.aspx">Back</a></p>
		
		</div>
	</div>		
	
</div>
<div class="clear">&nbsp;</div>
<div id="footer">
	Copyright © 2012,Myanmar ICT Development Corporation Ltd. All Rights Reserved.
	 <%--<img src="images/myanmar-info-tech-root-ca.gif" class="logo-img" />--%>
		</div>
</body>
</html>
