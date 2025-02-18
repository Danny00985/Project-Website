<%@ Page Language="C#"  AutoEventWireup="true" CodeFile="resources.aspx.cs" Inherits="resources" Title="Untitled Page" %>
<%-- Add content controls here --%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Root CA - Myanmar Info-Tech Corporation</title>
<link href="css/default.css" rel="stylesheet" type="text/css" media="screen"/>
 <link rel="shortcut icon" href="~/images/final.png" type="image/x-icon" /> 
</head>

<body>
<form id="form1" runat="server">
<div id="container-header">
	<div id="header" >
		<ul id="nav">
			<li><a href="Default.aspx">Home</a></li>
			<li><a href="aboutus.aspx">About Us</a></li>
			<li><a href="ActivitiesNews.aspx">Activities News</a></li>
			<li id="current-page"><a href="resources.aspx">Resources</a></li>
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

<div id="container-content" style="width: 896px"> 
    <%--<div id="container-homepage-links">--%>
	    <div id="root-ca" style="height: 180px; width: 272px;">
		    <h2>Resources</h2>
		    <p><a href="PKIBasics.aspx">PKI Basics</a></p>
		    <%-- <p><a href="#">License and Approval</a></p> --%>		
		    <%-- <p><a href="#">Guide Lines for Submission of Certificate and CRLs</a></p>--%>
		   <p><a href="Download/Root Certificate Application Form.pdf">Certificate Application Form</a></p>
		   <p><a href="Download/certificateRevokeform.pdf">Certificate Revocation Request Form</a></p>
		   <p><a href="Download/RootCA Applicaion Form (2022).pdf">Certificate Application Form 2022</a></p>
		   <p><a href="Download/Certificate Revocation Request Form(2022).pdf">Certificate Revocation Request Form 2022</a></p>
		   <%--<p><a href="http://ldap.rootca.org.mm/ldap/">Light Weight Directory Service</a></p>--%>	
           <%--<p><a href="Download.aspx">Certificate Download</a></p>--%>	
	    </div>
	    <div id="provide" style="height:200px; width: 200px;">
		    <h2>Publications</h2>
		    <p><a href="Download/CP(14.3.2012).pdf">Certificate Policy</a></p>
		    <p><a href="Download/CPS(14.3.2012).pdf">Certification Practice Statement</a></p>
		    <%--<p><a href="#">Subscriber Agreement</a></p>--%>
		    <p><a href="Download/RelyingPartyAgreement.pdf">Relying Party Agreement</a></p>
	    </div>
	    <div id="info" style="width: 300px"> 
	    <h2>Download</h2>
	    
			 <p><a href="Download.aspx">Root CA Certificates and CRLs Download</a></p>  <%--  <h2>Download</h2>--%> 
		      <p>&nbsp;</p>
		     <%-- <p><strong> e Token PKI Client</strong></p>--%>
		     <h2>e Token PKI Client</h2>
               		<p><a href="Download/e Token PKI Client Manual.pdf">e Token PKI Client Manual</a></p>
               		<ul>
                    	<li><a href="Download/PKIClient-x32-5.1.msi">PKI Client-x32-5.1 Download</a></li>
                    	<li><a href="Download/PKIClient-x32-5.1-SP1.msi">PKI Client-x32-5.1 Service Pack 1 Download</a></li>
                    	<li><a href="Download/PKIClient-x64-5.1-SP1.msi">PKI Client-x64-5.1 Service Pack 1 Download</a></li>
                    </ul>
		      
	    </div>
    	
    	
    </div>
   <div id="download">
       &nbsp;<br />
       &nbsp;
      
 <%--  </div>--%>
  </div>
  
<div id="footer">
	Copyright © 2012,Myanmar ICT Development Corporation Ltd. All Rights Reserved.
	 <%--<img src="images/myanmar-info-tech-root-ca.gif" class="logo-img" />--%>
	</div>
	</form>
</body>
</html>

