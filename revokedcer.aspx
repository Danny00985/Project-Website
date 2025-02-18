<%@ Page Language="C#" AutoEventWireup="true" CodeFile="revokedcer.aspx.cs" Inherits="revokedcer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Root CA - Myanmar Info-Tech Corporation</title>
    <link href="css/default.css" rel="stylesheet" type="text/css" media="screen" />
     <link rel="shortcut icon" href="~/images/final.png" type="image/x-icon" /> 
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
			<li><a href="revocation.aspx">Certificate Revocation List</a></li>			
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
<div id="container-homepage-links">


    <asp:GridView ID="gvcer" runat="server" AllowPaging="True" AutoGenerateColumns="False"
        CellPadding="4" ForeColor="#333333" GridLines="None" Height="300px" OnPageIndexChanging="gvcer_PageIndexChanging"
        Style="position: relative"
        Width="920px">
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" Font-Names="Tahoma" ForeColor="White" />
        <Columns>
            <asp:BoundField DataField="Cert_Name" HeaderText="Certificate Name" SortExpression="Cert_Name">
                <HeaderStyle BackColor="Gainsboro" Font-Bold="True" ForeColor="Black" HorizontalAlign="Center" />
                <FooterStyle BackColor="Gainsboro" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="Serial_Num" HeaderText="Serial Number" SortExpression="Serial_Num">
                <HeaderStyle BackColor="Gainsboro" Font-Bold="True" ForeColor="Black" HorizontalAlign="Center" />
                <FooterStyle BackColor="Gainsboro" />
                <ItemStyle Width="150px" HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="SOrganization" HeaderText="SOrganization" SortExpression="SOrganization">
                <HeaderStyle BackColor="Gainsboro" Font-Bold="True" ForeColor="Black" HorizontalAlign="Center" />
                <FooterStyle BackColor="Gainsboro" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="SOUnit" HeaderText="SO Unit" SortExpression="SOUnit">
                <HeaderStyle BackColor="Gainsboro" Font-Bold="True" ForeColor="Black" HorizontalAlign="Center" />
                <FooterStyle BackColor="Gainsboro" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:HyperLinkField DataNavigateUrlFields="Cert_Name" DataNavigateUrlFormatString="./validcertificatesdetail.aspx?ID={0}"
                SortExpression="Cert_Name" Text="Detail">
                <HeaderStyle BackColor="Gainsboro" Font-Bold="True" ForeColor="DarkGreen" />
                <FooterStyle BackColor="Gainsboro" />
            </asp:HyperLinkField>
        </Columns>
        <RowStyle BackColor="#F7F6F3" Font-Names="Tahoma" Font-Size="Smaller" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <PagerStyle BackColor="Gainsboro" Font-Bold="True" Font-Names="Tahoma" Font-Size="Small"
            ForeColor="Black" HorizontalAlign="Center" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" Font-Names="Tahoma" Font-Size="Small"
            ForeColor="White" />
        <EditRowStyle BackColor="#999999" VerticalAlign="Middle" />
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    </asp:GridView>
</div>
</div>
<div class="clear">&nbsp;</div>
<div id="footer">
	Copyright © 2012,Myanmar ICT Development Corporation Ltd. All Rights Reserved.	
	<%-- <img src="images/myanmar-info-tech-root-ca.gif" class="logo-img" />--%>
	</div>
    </form>
</body>
</html>
