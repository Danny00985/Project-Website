<%@ Page Language="C#" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
 <link rel="shortcut icon" href="~/images/final.png" type="image/x-icon" /> 
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Root CA - Myanmar Info-Tech Corporation</title>
<link href="css/default.css" rel="stylesheet" type="text/css" media="screen" />

</head>

<body>
<form id="Form1" name="form1" runat="server">
<div id="container-header">
	<div id="header">
		<ul id="nav">
			<li><a href="Default.aspx">Home</a></li>
			<li id="current-page"><a href="aboutus.aspx">About Us</a></li>
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
        <%--<asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/1036843793_0625cd2933.jpg"
             Style="left: -7px; position: relative; top: 9px" /><a href="Download/Myanmar_RootCA_2010.rar">Root CA Certificate</a>--%>
       
	 
		<div id="about" >
			<h2>About Us</h2><br />
			<p>Myanmar National Root CA is the highest level Certification Authority and also a leading PKI solution provider in Myanmar to enable new PKI based businesses.</p>
			<p>The Electronic Transactions Law was promulgated in 2004 with the aim as follows: –</p>
            <p>•&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;to support with electronic transactions technology in building a modern, developed countries;</p>
            <p>•&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;to obtain more opportunities for all-round development of sectors including human resources, economic, social and educational sector by electronic transactions technologies;</p>
            <p>•&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;to recognize the authenticity and integrity of electronic record and electronic data message and give legal protection thereof in matters of internal and external transactions, making use of computer network.</p>
            <p>The Law provides the required legal sanctity to the digital signatures based on asymmetric cryptosystems. The digital signatures are now accepted at par with handwritten signatures and the electronic documents that have been digitally signed are treated at par with paper documents.</p>
            <p>As per Chapter IV and V of The Electronic Transactions Law(2004) the Central Body of Electronic Transactions(Central Body) and Electronic Transaction Control Board(Control Board) was formed to  lay down the plans for application, to implement programmes for enriching experience and knowledge on electronic transactions technologies and readiness in globalization process and to carry out activities to be in conformity with the policies relating to electronic transactions technology, legal affairs and specializations to enable communication, with regional and international organizations.</p>
	        <p>The Electronic Transactions Law(2004) provides for the Electronic Transaction Control Board(Control Board) to establish the Root CA and to license and regulate the working of Certification Authorities. The Certification Authorities (CAs) issue digital signature certificates for electronic authentication of users.</p>
	        <p>Myanmar ICT Development Corp. Ltd.(MICTDC)(www.mictdc.com.mm) has been appointed by the Control Board to do as Root Certification Authority of Myanmar in 2008. The key generation ceremony of Root CA was conducted in 3 May, 2010. Root CA was established to provide the technical assistance to Control Board and to promote the growth of e-Commerce and e- Governance through the wide use of digital signatures.</p>
	        <p>Root CA will digitally sign the public keys of CAs in the country. The Root CA is operated as per the standards and guidelines laid down by the Control Board. The Root CA also maintains the Repository of Digital Certificates, which contains all the certificates issued to the CAs in the country.</p>
	        <p>As a growing age of e-Government and e-Commerce business and Information Technology, Myanmar National Root CA provides security solutions for digital signature signing and to encrypt and decrypt messages to provide reliable communication between sender and receiver of information. Myanmar ICT Development Corporation Limited is founded in 2003, and has been working on a number of IT projects since the inception of the company in Myanmar.
            </p>
            <p><a href="aboutus.aspx"> Back </a></p><br />
            <p> <a href="http://www.mictdc.com.mm">More about MICTDC</a></p>
	        
	        <br />
	        <%--<p><a href="https://www.yatanarponca.com.mm">More about Yatanarpon CA</a></p>
	        <br />
	        <p><a href="https://www.moss.com.mm"> More about MOSSCA</a></p>
	        <br />--%>
	        <p> <a href="Default.aspx">Go to Home Page</a></p>
           
	        
		</div>
		
		<h2>Mission</h2><br />
		<p>To enable new PKI solution for our clients based on best practices through secured, trusted and proven PKI Solutions.</p>
		
		
		<br />
		<h2>Competitive Edge</h2><br />
		<p>Myanmar National Root CA is committed to promote Public Key Infrastructure and for the development of PKI enabled applications in Myanmar with a high degree of product reliability, quality and a host of competitive advantages:</p>
		<div id="edge" >
		<p>Recognized certification services throughout Myanmar.</p>
		<p>Leader in Digital Certificate enable services in Myanmar.</p>
		<p>Intensive product development program.</p>
		<p>Effectively introduce new PKI technologies through best practices.</p>
		</div>
	</div>
	<%--<div class="clear">&nbsp;</div>--%>
</div>
<%--<div class="clear">&nbsp;</div>--%>
<div id="footer" >
	
	Copyright © 2012,Myanmar ICT Development Corporation Ltd. All Rights Reserved.	
   
    
   <%-- <img src="images/myanmar-info-tech-root-ca.gif" class="logo-img" />--%>
 
	</div>
	
</form>
</body>
</html>
