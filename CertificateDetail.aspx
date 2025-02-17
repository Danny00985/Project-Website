     <%@ Page Language="C#" AutoEventWireup="true" CodeFile="CertificateDetail.aspx.cs" Inherits="CertificateDetail" Title="Untitled Page" %>

 <%@ PreviousPageType VirtualPath="~/certificates.aspx"%>
 
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
			<li><a href="ActivitiesNews.aspx">Activities News</a></li>
			<li><a href="resources.aspx">Resources</a></li>
			<li><a href="Download.aspx">Download</a></li>
			<li ><a href="crlnew.aspx">Certificate Revocation List</a></li>	
			<li id="current-page"><a href="certificates.aspx">Certificate Repository</a></li>
			
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
<br />
<p >&nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;
   <span style="font-size: small; text-align:justify; font-family: Verdana">
   If this is the correct Digital ID, you can now choose to download for the Digital ID.
   </span> 

</p>
<br />
 
    <div  id="DetailSearch">
            <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
    <table cellpadding="0" cellspacing="0">
    <tr>
        <td>
            <asp:Label ID="lblName" runat="server"  Text="Label" Visible="False"></asp:Label>&nbsp;
            <asp:Label ID="lblEmail" runat="server" Text="Label" Visible="False"></asp:Label>&nbsp;
            <asp:Label ID="lblNumber" runat="server" Text="Label" Visible="False"></asp:Label>&nbsp;
            <asp:Label ID="lblIssuer" runat="server" Text="Label" Visible="False"></asp:Label>&nbsp;
            <asp:Label ID="lblMessage" runat="server" Text="Message" ForeColor="Red"></asp:Label>          
        </td>
    </tr>
    <tr>
        <td>
         
          <asp:DetailsView ID="dvCertificate" runat="server" Height="50px" Width="100%" AutoGenerateRows="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" OnPageIndexChanging="dvCertificate_PageIndexChanging">
          <Fields>
                  <asp:BoundField DataField="SEmail" HeaderText="Email" SortExpression="SEmail" />
                  <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                  <asp:BoundField DataField="Cert_Name" HeaderText="Cert_Name" SortExpression="Cert_Name" />
                  <asp:BoundField DataField="SOrganization" HeaderText="Organization" SortExpression="SOrganization" />
                  <asp:BoundField DataField="SOUnit" HeaderText="SOUnit" SortExpression="SOUnit" />
                  <asp:BoundField DataField="SCity" HeaderText="City" SortExpression="SCity" />
                  <asp:BoundField DataField="SState" HeaderText="State" SortExpression="SState" />
                  <asp:BoundField DataField="SCountry" HeaderText="Country" SortExpression="SCountry" />
                  <asp:BoundField DataField="Serial_Num" HeaderText="Serial_Num" SortExpression="Serial_Num" />
                  <asp:BoundField DataField="Valid_From" HeaderText="Valid_From" SortExpression="Valid_From" />
                  <asp:BoundField DataField="Valid_To" HeaderText="Valid_To" SortExpression="Valid_To" />
                  <asp:BoundField DataField="ThumbPrint" HeaderText="ThumbPrint" SortExpression="ThumbPrint" />
                  <asp:BoundField DataField="Issuer" HeaderText="Issuer" SortExpression="Issuer" />
                  <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
              </Fields>
              <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
              <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
              <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
              <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
              <EditRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
              <AlternatingRowStyle BackColor="Gainsboro" />
          </asp:DetailsView>
          </td>
         
          </tr> 
                   
</table>
<br />
<div>
<asp:Button ID="butDownload" runat="server" Text="Download" OnClick="butDownload_Click" />
<br /><br />
<p>
    <asp:HyperLink ID="HyperLink1" NavigateUrl="~/certificates.aspx" runat="server">Back</asp:HyperLink></p>
</div>
</div>
</div>
<div id="footer">
	Copyright © 2012,Myanmar ICT Development Corporation Ltd. All Rights Reserved.	
	 <%--<img src="images/myanmar-info-tech-root-ca.gif" class="logo-img" />--%>
	</div>
	</form>
	</body>
	</html>
