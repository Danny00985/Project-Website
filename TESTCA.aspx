<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TESTCA.aspx.cs" Inherits="TESTCA" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
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
                    <asp:LinkButton ID="LinkButton15" runat="server" OnClick="LinkButton15_Click"  >TESTCA(1-3-2017)</asp:LinkButton></td>
        </tr>
        <tr style="height:25px"> 
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton14" runat="server" OnClick="LinkButton14_Click" >TESTCA(30-1-2017)</asp:LinkButton></td>
        </tr>
        <tr style="height:25px"> 
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton13" runat="server" OnClick="LinkButton13_Click">TESTCA(28-12-2016)</asp:LinkButton></td>
        </tr>
         <tr style="height:25px"> 
                <td style="width: 222px; height: 20px;">
                    <asp:LinkButton ID="LinkButton12" runat="server" OnClick="LinkButton12_Click">TESTCA(25-11-2016)</asp:LinkButton></td>
        </tr>
        <tr style="height:25px"> 
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton11" runat="server" OnClick="LinkButton11_Click">TESTCA(25-10-2016)</asp:LinkButton></td>
        </tr>
        
        <tr style="height:25px"> 
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton10" runat="server" OnClick="LinkButton10_Click">TESTCA(26-9-2016)</asp:LinkButton></td>
        </tr>
        
        <tr style="height:25px"> 
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton9" runat="server" OnClick="LinkButton9_Click" >TESTCA(22-8-2016)</asp:LinkButton></td>
        </tr>
        
        <tr style="height:25px"> 
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton8" runat="server" OnClick="LinkButton8_Click" >TESTCA(20-7-2016)</asp:LinkButton></td>
        </tr>
        
        <tr style="height:25px"> 
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton7" runat="server" OnClick="LinkButton7_Click">TESTCA(16-6-2016)</asp:LinkButton></td>
        </tr>
        
        <tr style="height:25px"> 
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton6" runat="server" OnClick="LinkButton6_Click">TESTCA(16-5-2016)</asp:LinkButton></td>
        </tr>
        
        <tr style="height:25px"> 
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click">TESTCA(16-4-2016)</asp:LinkButton></td>
        </tr>
        
        <tr style="height:25px"> 
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">TESTCA(16-3-2016)</asp:LinkButton></td>
             </tr>
        
        <tr style="height:25px"> 
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">TESTCA(14-1-2016)</asp:LinkButton></td>
             </tr>
        <tr style="height:25px"> 
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" >TESTCA(14-12-2015)</asp:LinkButton></td>
             </tr>
             <tr style="height:25px"> 
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">TESTCA(12-11-2015)</asp:LinkButton></td>
             </tr>
               
        <tr><td style="width: 222px"><br /></td></tr><br />
            
        <tr style="height:25px">     
                <td style="width: 222px; height: 25px;">
                    <asp:LinkButton ID="LinkButton16" runat="server" PostBackUrl="~/TESTCA2017.aspx">1</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton17" runat="server" PostBackUrl="~/TESTCA.aspx">2</asp:LinkButton>
                </td>
            </tr>
        </table>
            
    </div>
        


        
<div id="footer" align="left">&nbsp;
	Copyright © 2012,Myanmar ICT Development Corporation Ltd. All Rights Reserved.	
	<%-- <img src="images/myanmar-info-tech-root-ca.gif" class="logo-img" />--%>
	</div>        
        
    </form>
</body>
</html>
