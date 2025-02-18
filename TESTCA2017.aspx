<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TESTCA2017.aspx.cs" Inherits="TESTCA2017" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Root CA - Myanmar Info-Tech Corporation</title>
     <link href="css/default.css" rel="stylesheet" type="text/css" media="screen" />
    <link rel="shortcut icon" href="~/images/final.png" type="image/x-icon" /> 
</head>
<body>
   <form id="form1" runat="server">
  <div id="container-header">
	<div id="header">
	<ul id="nav">
			<li><a href="Default.aspx">Home</a></li>
			<li><a href="aboutus.aspx">About Us</a></li>
			<li><a href="ActivitiesNews.aspx">Activities News</a></li>
			<li><a href="resources.aspx">Resources</a></li>
			<li><a href="Download.aspx">Download</a></li>
			<li id="current-page"><a href="crlnew.aspx">Certificate Revocation List</a></li>			
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
        <br />
  <div id="container-content" style="width: 952px; height: 18%">      
        
        <div id="ca" style="width: 431px">
        
        <table id="CRL" cellpadding="0" cellspacing="0" style="width: 443px">
        <tr style="height:25px">
                <td style="width: 222px;"><asp:Label ID="Label2" runat="server" Text="TESTCA Download(CRL)"></asp:Label><br />
                    <br />
                </td>
        </tr>
        <tr style="height:25px"> 
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton6" runat="server" OnClick="LinkButton6_Click"  >TESTCA(3-8-2017)</asp:LinkButton></td>
        </tr>
        <tr style="height:25px"> 
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click"  >TESTCA(3-7-2017)</asp:LinkButton></td>
        </tr>
         <tr style="height:25px"> 
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click"  >TESTCA(2-6-2017)</asp:LinkButton></td>
        </tr>
        <tr style="height:25px"> 
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click"  >TESTCA(2-5-2017)</asp:LinkButton></td>
        </tr>
        <tr style="height:25px"> 
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton15" runat="server" OnClick="LinkButton15_Click"  >TESTCA(1-4-2017)</asp:LinkButton></td>
        </tr>
        <tr><td style="width: 222px"><br /></td></tr><br />
            
        <tr style="height:25px">     
                <td style="width: 222px; height: 25px;">
                <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/TESTCA2017.aspx">1</asp:LinkButton>
                <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/TESTCA.aspx">2</asp:LinkButton>
            </td>
            </tr>
                
        </table>
        </div>
               
        
</div>

        
<div id="footer" align="left">&nbsp;
	Copyright © 2012,Myanmar ICT Development Corporation Ltd. All Rights Reserved.	
	<%-- <img src="images/myanmar-info-tech-root-ca.gif" class="logo-img" />--%>
	</div>        
        
    </form>
</body>
</html>
