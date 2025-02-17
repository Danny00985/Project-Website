<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Root CA - Myanmar Info-Tech Corporation</title>
    <link href="css/default.css" rel="stylesheet" type="text/css" media="screen" />
     <link rel="shortcut icon" href="~/images/final.png" type="image/x-icon" /> 
<script language="javascript" type="text/javascript">
<!--



// -->
</script>
</head>
<body>
<form id="Form1" runat="server">
<div id="container-header">
	<div id="header">
		<ul id="nav">
			<li ><a href="Default.aspx">Home</a></li>
			<li><a href="aboutus.aspx">About Us</a></li>
			<li><a href="services.aspx">Services</a></li>
			<li><a href="resources.aspx">Resources</a></li>
			<li><a href="Download.aspx">Download</a></li>		
			<li ><a href="crlnew.aspx">Certificate Revocation List</a></li>	
			<li id="current-page"><a href="certificates.aspx">Certificate Repository</a></li>
			<li><a href="ActivitiesNews.aspx">Activities News</a></li>
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
&nbsp;&nbsp;

    <asp:Label ID="Label12" runat="server" Text="Label" Visible="False"></asp:Label>
 <table  align="center" style="border-top: black thin solid; border-bottom: black thin solid"   >
        <tr>
            <td style="width: 124px; height: 21px;">
                <strong><span style="color: black; font-size: 10pt; font-family: Tahoma;">
                Email</span></strong></td>
            <td style="width: 124px; height: 21px">
            </td>
            <td style="width: 257px; font-weight: bold; color: silver; height: 21px;">
                <asp:Label ID="Label1" runat="server" Style="position: relative" Text="Label" Font-Names="Tahoma" Font-Size="10pt"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 124px; height: 21px;">
                <span style="color: #339900; font-size: 10pt; font-family: Tahoma;"><strong style="color: black">
                Certificate Name</strong></span></td>
            <td style="width: 124px; height: 21px;">
            </td>
            <td style="width: 257px; font-weight: bold; color: silver; height: 21px;">
                <asp:Label ID="Label2" runat="server" Style="position: relative" Text="Label" Font-Names="Tahoma" Font-Size="10pt"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 124px; height: 18px;">
                <strong><span style="color: black; font-size: 10pt; font-family: Tahoma;">
                Organization Unit</span></strong></td>
            <td style="width: 124px; height: 18px">
            </td>
            <td style="width: 257px; font-weight: bold; color: silver; height: 18px;">
                <asp:Label ID="Label3" runat="server" Style="position: relative" Text="Label" Font-Names="Tahoma" Font-Size="10pt" Width="233px"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 124px">
                <span style="color: #339900; font-size: 10pt; font-family: Tahoma;"><strong style="font-size: 10pt; color: black; font-family: Tahoma">Organization</strong></span></td>
            <td style="width: 124px">
            </td>
            <td style="width: 257px; font-weight: bold; color: silver; height: 21px;">
                <asp:Label ID="Label4" runat="server" Style="position: relative" Text="Label" Font-Names="Tahoma" Font-Size="10pt" Width="233px"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 124px">
                <span style="color: #339900; font-size: 10pt; font-family: Tahoma;"><strong style="font-size: 10pt; color: black; font-family: Tahoma">
                Location</strong></span></td>
            <td style="width: 124px">
            </td>
            <td style="width: 257px; font-weight: bold; color: silver; height: 21px;">
                <asp:Label ID="Label5" runat="server" Style="position: relative" Text="Label" Font-Names="Tahoma" Font-Size="10pt"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 124px; height: 21px;">
                <strong><span style="color: black; font-size: 10pt; font-family: Tahoma;">
                State</span></strong></td>
            <td style="width: 124px; height: 21px">
            </td>
            <td style="width: 257px; font-weight: bold; color: silver; height: 21px;">
                <asp:Label ID="Label6" runat="server" Style="position: relative" Text="Label" Font-Names="Tahoma" Font-Size="10pt"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 124px">
                <strong><span style="color: black; font-size: 10pt; font-family: Tahoma;">
                Country</span></strong></td>
            <td style="width: 124px">
            </td>
            <td style="width: 257px; font-weight: bold; color: silver; height: 21px;">
                <asp:Label ID="Label7" runat="server" Style="position: relative" Text="Label" Font-Names="Tahoma" Font-Size="10pt"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 124px">
            </td>
            <td style="width: 124px">
            </td>
            <td style="width: 257px">
            </td>
        </tr>
        <tr>
            <td style="width: 124px">
                <strong><span style="color: black; font-size: 10pt; font-family: Tahoma;">
                Serial Number</span></strong></td>
            <td style="width: 124px">
            </td>
            <td style="width: 257px; font-weight: bold; color: silver; height: 21px;">
                <asp:Label ID="Label8" runat="server" Style="position: relative" Text="Label" Font-Names="Tahoma" Font-Size="10pt"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 124px; height: 21px;">
                <span style="color: #339900; font-size: 10pt; font-family: Tahoma;"><strong style="font-size: 10pt; color: black; font-family: Tahoma">
                Expeired Date</strong></span></td>
            <td style="width: 124px; height: 21px">
            </td>
            <td style="width: 257px; font-weight: bold; color: silver; height: 21px;">
                <asp:Label ID="Label9" runat="server" Style="position: relative" Text="Label" Font-Names="Tahoma" Font-Size="10pt"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 124px">
                <strong><span style="color: black; font-size: 10pt; font-family: Tahoma;">
                Issued Date</span></strong></td>
            <td style="width: 124px">
            </td>
            <td style="width: 257px; font-weight: bold; color: silver; height: 21px;">
                <asp:Label ID="Label10" runat="server" Style="position: relative" Text="Label" Font-Names="Tahoma" Font-Size="10pt"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 124px">
                <span style="color: #339900; font-size: 10pt; font-family: Tahoma;"><strong style="font-size: 10pt; color: black; font-family: Tahoma">Thumbprint</strong></span></td>
            <td style="width: 124px">
            </td>
            <td style="width: 257px; font-weight: bold; color: silver; height: 21px;">
                <asp:Label ID="Label11" runat="server" Style="position: relative" Text="Label" Font-Names="Tahoma" Font-Size="10pt"></asp:Label></td>
        </tr>
    </table>
    
    <asp:ImageButton ID="ImageButton1" runat="server"  Style="position: relative; left: 770px; top: -134px;" ImageUrl="~/images/1036843793_0625cd2933.jpg" OnClick="ImageButton1_Click" />
    &nbsp;
    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" Style="left: 762px;
        position: relative; top: -146px">Download Certificate</asp:LinkButton>&nbsp;


</div>

<div id="footer">
	Copyright © 2012,Myanmar ICT Development Corporation Ltd. All Rights Reserved.	
	<%-- <img src="images/myanmar-info-tech-root-ca.gif" class="logo-img" />--%>
	</div>
	</form>
	</body>
	</html>