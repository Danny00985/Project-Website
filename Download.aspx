 <%@ Page Language="C#" AutoEventWireup="true" CodeFile="Download.aspx.cs" Inherits="Download" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Root CA - Myanmar Info-Tech Corporation</title>
<link href="css/default.css" rel="stylesheet" type="text/css" media="screen" />
<link rel="shortcut icon" href="~/images/final.png" type="image/x-icon" /> 
<script language="javascript" type="text/javascript">
<!--

// -->
</script>
</head>

<body>
<form id="Form1" runat="server" >
<div id="container-header">
	<div id="header">
		<ul id="nav">
			<li><a href="Default.aspx">Home</a></li>
			<li><a href="aboutus.aspx">About Us</a></li>
			<li><a href="ActivitiesNews.aspx">Activities News</a></li>
			<li><a href="resources.aspx">Resources</a></li>
			<li id="current-page"><a href="Download.aspx">Download</a></li>
			
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
		<h1>Myanmar     National Root CA</h1>
		<p>Secured, Trusted and Proven PKI Solutions</p>
	</div>
</div>
<div id="container-content">
<div id="container-homepage-links" lang="javascript" onclick="return container-homepage-links_onclick()">
	<div id="ca" style="width: 453px">
        <table style="width: 472px">
        <tr style="height:25px" >
                <td style="width: 1028px; height: 40px;">
                   <b> <asp:Label ID="label1" runat="server"  Text="Myanmar RootCA Certificate"></asp:Label></b>
                   </td>
             </tr>
             <tr>
                <td style="width: 1028px; height: 40px;">
                    <span style="font-size: 14px">Myanmar National RootCA SHA-256(2029)</span></td>
                <td style="width: 172px; height: 40px;">
                    <asp:ImageButton ID="ImageButton12" runat="server" ImageUrl="~/images/certificate_icon2.jpg" OnClick="ImageButton12_Click" />
                    <%--<asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/images/certificate_icon2.jpg"
                        OnClick="ImageButton4_Click" />--%><%--<asp:ImageButton ID="ImageButton2" ImageUrl="~/images/crl_icon.gif" runat="server" />--%></td>
                <%--<td style="width: 109px; height: 18px;" align="center" valign="middle">
                    <span style="font-size: 12px"><a href="RootDetail.aspx">View</a></span></td>--%>
                <td style="width: 100px; height: 40px;" align="center"  >
                    <span style="font-size: 14px"><%--<a href="Download/MyanmarRootCA2010.rar">Download</a>--%>
                        <asp:LinkButton ID="LinkButton12" runat="server" OnClick="LinkButton12_Click">Download</asp:LinkButton></span></td>
            </tr>
             <tr>
                <td style="width: 1028px; height: 40px;">
                    <span style="font-size: 14px">Myanmar National RootCA SHA-256(2017)</span></td>
                <td style="width: 172px; height: 40px;">
                    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/images/certificate_icon2.jpg" OnClick="ImageButton2_Click2"/>
                    <%--<asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/images/certificate_icon2.jpg"
                        OnClick="ImageButton4_Click" />--%><%--<asp:ImageButton ID="ImageButton2" ImageUrl="~/images/crl_icon.gif" runat="server" />--%></td>
                <%--<td style="width: 109px; height: 18px;" align="center" valign="middle">
                    <span style="font-size: 12px"><a href="RootDetail.aspx">View</a></span></td>--%>
                <td style="width: 100px; height: 40px;" align="center"  >
                    <span style="font-size: 14px"><%--<a href="Download/MyanmarRootCA2010.rar">Download</a>--%>
                        <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click3" >Download</asp:LinkButton></span></td>
            </tr>
        
           <tr>
                <td style="width: 1028px; height: 40px;">
                    <span style="font-size: 14px">Myanmar National RootCA (2015)</span></td>
                <td style="width: 172px; height: 40px;">
                    <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/images/certificate_icon2.jpg"
                        OnClick="ImageButton4_Click" /><%--<asp:ImageButton ID="ImageButton2" ImageUrl="~/images/crl_icon.gif" runat="server" />--%></td>
                <%--<td style="width: 109px; height: 18px;" align="center" valign="middle">
                    <span style="font-size: 12px"><a href="RootDetail.aspx">View</a></span></td>--%>
                <td style="width: 100px; height: 40px;" align="center"  >
                    <span style="font-size: 14px"><%--<a href="Download/MyanmarRootCA2010.rar">Download</a>--%>
                        <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click">Download</asp:LinkButton></span></td>
            </tr>
             <%--<tr><td style="width: 992px"><br /></td></tr>--%>
            <tr>
                <td style="width: 1028px; height: 40px;">
                    <span style="font-size: 14px">Myanmar National RootCA (2010)</span></td>
                <td style="width: 172px; height: 40px;">
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/certificate_icon2.jpg"  OnClick="ImageButton1_Click" />
                    <%--<asp:ImageButton ID="ImageButton2" ImageUrl="~/images/crl_icon.gif" runat="server" />--%></td>
                <%--<td style="width: 109px; height: 18px;" align="center" valign="middle">
                    <span style="font-size: 12px"><a href="RootDetail.aspx">View</a></span></td>--%>
                <td style="width: 100px; height: 40px;" align="center"  >
                    <span style="font-size: 14px"><%--<a href="Download/MyanmarRootCA2010.rar">Download</a>--%>
                        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Download</asp:LinkButton>
                    </span></td>
            </tr>
            <tr><td style="width: 1028px"></td></tr>
            <tr><td style="width: 1028px; height: 40px;">
                   <b><asp:Label ID="label2" runat="server"  Text="Yatanarpon CA Certificate"></asp:Label></b>
                   </td>
             </tr>
             
             <tr>
                <td style="width: 1028px; height: 40px;">
                    <span style="font-size: 14px">Yatanarpon CA SHA-256(2024)</span></td>
                <td style="width: 172px; height: 40px;">
                    <asp:ImageButton ID="ImageButton15" runat="server" ImageUrl="~/images/certificate_icon2.jpg" OnClick="ImageButton15_Click"/>
                   
                <td style="width: 100px; height: 40px;" align="center">
                    <span style="font-size: 14px"><%--<a href="Download/YatanarponCA.rar">Download</a>--%>
                        <asp:LinkButton ID="LinkButton15" runat="server" OnClick="LinkButton15_Click">Download</asp:LinkButton>
                    </span></td>
            </tr>
             
             
              <tr>
                <td style="width: 1028px; height: 40px;">
                    <span style="font-size: 14px">Yatanarpon CA SHA-256(2022)</span></td>
                <td style="width: 172px; height: 40px;">
                    <asp:ImageButton ID="ImageButton13" runat="server" ImageUrl="~/images/certificate_icon2.jpg" OnClick="ImageButton13_Click"/>
                   
                <td style="width: 100px; height: 40px;" align="center">
                    <span style="font-size: 14px"><%--<a href="Download/YatanarponCA.rar">Download</a>--%>
                        <asp:LinkButton ID="LinkButton13" runat="server" OnClick="LinkButton13_Click"  >Download</asp:LinkButton>
                    </span></td>
            </tr>
             
             <tr>
                <td style="width: 1028px; height: 40px;">
                    <span style="font-size: 14px">Yatanarpon CA SHA-256(2020)</span></td>
                <td style="width: 172px; height: 40px;">
                    <asp:ImageButton ID="ImageButton10" runat="server" ImageUrl="~/images/certificate_icon2.jpg" OnClick="ImageButton10_Click" />
                    <%--<asp:ImageButton ID="ImageButton7" ImageUrl="~/images/certificate_icon2.jpg" runat="server" OnClick="ImageButton3_Click" />--%></td>
                    <%--<asp:ImageButton ID="ImageButton4" ImageUrl="~/images/crl_icon.gif" runat="server" /></td>--%>
                <%--<td style="width: 109px" align="center" valign="middle">
                    <span style="font-size: 12px"><a href="YatanarponDetail.aspx">View</a></span></td>--%>
                <td style="width: 100px; height: 40px;" align="center">
                    <span style="font-size: 14px"><%--<a href="Download/YatanarponCA.rar">Download</a>--%>
                        <asp:LinkButton ID="LinkButton10" runat="server" OnClick="LinkButton10_Click"  >Download</asp:LinkButton>
                    </span></td>
            </tr>
            
             <tr>
                <td style="width: 1028px; height: 40px;">
                    <span style="font-size: 14px">Yatanarpon CA SHA-256(2017)</span></td>
                <td style="width: 172px; height: 40px;">
                    <asp:ImageButton ID="ImageButton7" runat="server" ImageUrl="~/images/certificate_icon2.jpg" OnClick="ImageButton7_Click"/>
                    <%--<asp:ImageButton ID="ImageButton7" ImageUrl="~/images/certificate_icon2.jpg" runat="server" OnClick="ImageButton3_Click" />--%></td>
                    <%--<asp:ImageButton ID="ImageButton4" ImageUrl="~/images/crl_icon.gif" runat="server" /></td>--%>
                <%--<td style="width: 109px" align="center" valign="middle">
                    <span style="font-size: 12px"><a href="YatanarponDetail.aspx">View</a></span></td>--%>
                <td style="width: 100px; height: 40px;" align="center">
                    <span style="font-size: 14px"><%--<a href="Download/YatanarponCA.rar">Download</a>--%>
                        <asp:LinkButton ID="LinkButton7" runat="server" OnClick="LinkButton7_Click" >Download</asp:LinkButton>
                    </span></td>
            </tr>
             
            <tr>
                <td style="width: 1028px; height: 40px;">
                    <span style="font-size: 14px">Yatanarpon CA</span></td>
                <td style="width: 172px; height: 40px;">
                    <asp:ImageButton ID="ImageButton3" ImageUrl="~/images/certificate_icon2.jpg" runat="server" OnClick="ImageButton3_Click" /></td>
                    <%--<asp:ImageButton ID="ImageButton4" ImageUrl="~/images/crl_icon.gif" runat="server" /></td>--%>
                <%--<td style="width: 109px" align="center" valign="middle">
                    <span style="font-size: 12px"><a href="YatanarponDetail.aspx">View</a></span></td>--%>
                <td style="width: 100px; height: 40px;" align="center">
                    <span style="font-size: 14px"><%--<a href="Download/YatanarponCA.rar">Download</a>--%>
                        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Download</asp:LinkButton>
                    </span></td>
            </tr>
            <tr><td style="width: 1028px"></td></tr>
            <tr><td style="width: 1028px; height: 40px;">
                   <b><asp:Label ID="label3" runat="server"  Text="MOSSCA Certificate" Width="272px"></asp:Label></b>
                   </td>
             </tr>
             
              <tr>
                <td style="width: 1028px; height: 40px;">
                    <span style="font-size: 14px">Myanmar Online Security Service CA SHA256(2024)</span></td>
                <td style="width: 172px; height: 40px;">
                    <asp:ImageButton ID="ImageButton16" runat="server" ImageUrl="~/images/certificate_icon2.jpg" OnClick="ImageButton16_Click"/><%--<asp:ImageButton ID="ImageButton9" runat="server" ImageUrl="~/images/certificate_icon2.jpg" OnClick="ImageButton8_Click"/>--%><%--<asp:ImageButton ID="ImageButton8" ImageUrl="~/images/certificate_icon2.jpg" runat="server" OnClick="ImageButton5_Click" />--%></td>
                    <%--<asp:ImageButton ID="ImageButton6" ImageUrl="~/images/crl_icon.gif" runat="server" /></td>--%>
                <%--<td style="width: 109px; height: 18px;" align="center" valign="middle">
                    <span style="font-size: 12px"><a href="MossDetail.aspx">View</a></span></td>--%>
                <td style="width: 100px; height: 40px;" align="center">
                    <span style="font-size: 14px"><%--<a href="Download/MOSSCA.rar">Download</a>--%>
                        &nbsp;<asp:LinkButton ID="LinkButton16" runat="server" OnClick="LinkButton16_Click">Download</asp:LinkButton></span></td>
            </tr>
             
             
              <tr>
                <td style="width: 1028px; height: 40px;">
                    <span style="font-size: 14px">Myanmar Online Security Service CA SHA256(2022)</span></td>
                <td style="width: 172px; height: 40px;">
                    <asp:ImageButton ID="ImageButton14" runat="server" ImageUrl="~/images/certificate_icon2.jpg" OnClick="ImageButton14_Click" /><%--<asp:ImageButton ID="ImageButton9" runat="server" ImageUrl="~/images/certificate_icon2.jpg" OnClick="ImageButton8_Click"/>--%><%--<asp:ImageButton ID="ImageButton8" ImageUrl="~/images/certificate_icon2.jpg" runat="server" OnClick="ImageButton5_Click" />--%></td>
                    <%--<asp:ImageButton ID="ImageButton6" ImageUrl="~/images/crl_icon.gif" runat="server" /></td>--%>
                <%--<td style="width: 109px; height: 18px;" align="center" valign="middle">
                    <span style="font-size: 12px"><a href="MossDetail.aspx">View</a></span></td>--%>
                <td style="width: 100px; height: 40px;" align="center">
                    <span style="font-size: 14px"><%--<a href="Download/MOSSCA.rar">Download</a>--%>
                        &nbsp;<asp:LinkButton ID="LinkButton14" runat="server" OnClick="LinkButton14_Click">Download</asp:LinkButton></span></td>
            </tr>
            
             <tr>
                <td style="width: 1028px; height: 40px;">
                    <span style="font-size: 14px">Myanmar Online Security Service CA SHA256(2020)</span></td>
                <td style="width: 172px; height: 40px;">
                    <asp:ImageButton ID="ImageButton11" runat="server" ImageUrl="~/images/certificate_icon2.jpg" OnClick="ImageButton11_Click" /><%--<asp:ImageButton ID="ImageButton9" runat="server" ImageUrl="~/images/certificate_icon2.jpg" OnClick="ImageButton8_Click"/>--%><%--<asp:ImageButton ID="ImageButton8" ImageUrl="~/images/certificate_icon2.jpg" runat="server" OnClick="ImageButton5_Click" />--%></td>
                    <%--<asp:ImageButton ID="ImageButton6" ImageUrl="~/images/crl_icon.gif" runat="server" /></td>--%>
                <%--<td style="width: 109px; height: 18px;" align="center" valign="middle">
                    <span style="font-size: 12px"><a href="MossDetail.aspx">View</a></span></td>--%>
                <td style="width: 100px; height: 40px;" align="center">
                    <span style="font-size: 14px"><%--<a href="Download/MOSSCA.rar">Download</a>--%>
                        &nbsp;<asp:LinkButton ID="LinkButton11" runat="server" OnClick="LinkButton11_Click">Download</asp:LinkButton></span></td>
            </tr>
             <tr>
                <td style="width: 1028px; height: 40px;">
                    <span style="font-size: 14px">Myanmar Online Security Service CA SHA256(2018)</span></td>
                <td style="width: 172px; height: 40px;">
                    <asp:ImageButton ID="ImageButton9" runat="server" ImageUrl="~/images/certificate_icon2.jpg" OnClick="ImageButton9_Click" /><%--<asp:ImageButton ID="ImageButton9" runat="server" ImageUrl="~/images/certificate_icon2.jpg" OnClick="ImageButton8_Click"/>--%><%--<asp:ImageButton ID="ImageButton8" ImageUrl="~/images/certificate_icon2.jpg" runat="server" OnClick="ImageButton5_Click" />--%></td>
                    <%--<asp:ImageButton ID="ImageButton6" ImageUrl="~/images/crl_icon.gif" runat="server" /></td>--%>
                <%--<td style="width: 109px; height: 18px;" align="center" valign="middle">
                    <span style="font-size: 12px"><a href="MossDetail.aspx">View</a></span></td>--%>
                <td style="width: 100px; height: 40px;" align="center">
                    <span style="font-size: 14px"><%--<a href="Download/MOSSCA.rar">Download</a>--%>
                        &nbsp;<asp:LinkButton ID="LinkButton9" runat="server" OnClick="LinkButton9_Click">Download</asp:LinkButton></span></td>
            </tr>
             <tr>
                <td style="width: 1028px; height: 40px;">
                    <span style="font-size: 14px">Myanmar Online Security Service CA 2017</span></td>
                <td style="width: 172px; height: 40px;">
                    <asp:ImageButton ID="ImageButton8" runat="server" ImageUrl="~/images/certificate_icon2.jpg" OnClick="ImageButton8_Click"/>
                    <%--<asp:ImageButton ID="ImageButton8" ImageUrl="~/images/certificate_icon2.jpg" runat="server" OnClick="ImageButton5_Click" />--%></td>
                    <%--<asp:ImageButton ID="ImageButton6" ImageUrl="~/images/crl_icon.gif" runat="server" /></td>--%>
                <%--<td style="width: 109px; height: 18px;" align="center" valign="middle">
                    <span style="font-size: 12px"><a href="MossDetail.aspx">View</a></span></td>--%>
                <td style="width: 100px; height: 40px;" align="center">
                    <span style="font-size: 14px"><%--<a href="Download/MOSSCA.rar">Download</a>--%>
                        <asp:LinkButton ID="LinkButton8" runat="server" OnClick="LinkButton8_Click" >Download</asp:LinkButton>
                    </span></td>
            </tr>
            <tr>
                <td style="width: 1028px; height: 40px;">
                    <span style="font-size: 14px">Myanmar Online Security Service CA</span></td>
                <td style="width: 172px; height: 40px;">
                    <asp:ImageButton ID="ImageButton5" ImageUrl="~/images/certificate_icon2.jpg" runat="server" OnClick="ImageButton5_Click" /></td>
                    <%--<asp:ImageButton ID="ImageButton6" ImageUrl="~/images/crl_icon.gif" runat="server" /></td>--%>
                <%--<td style="width: 109px; height: 18px;" align="center" valign="middle">
                    <span style="font-size: 12px"><a href="MossDetail.aspx">View</a></span></td>--%>
                <td style="width: 100px; height: 40px;" align="center">
                    <span style="font-size: 14px"><%--<a href="Download/MOSSCA.rar">Download</a>--%>
                        <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">Download</asp:LinkButton>
                    </span></td>
            </tr>
            <tr><td style="width: 1028px"></td></tr>
             <tr><td style="width: 1028px; height: 40px;">
                   <b><asp:Label ID="label4" runat="server"  Text="TEST CA Certificate" Width="272px"></asp:Label></b>
                   </td>
             </tr>
            <tr>
                <td style="width: 1028px; height: 41px;">
                    <span style="font-size: 14px">TEST CA (2015)</span></td>
                <td style="width: 172px; height: 41px;">
                    <asp:ImageButton ID="ImageButton6" runat="server" ImageUrl="~/images/certificate_icon2.jpg" OnClick="ImageButton6_Click" /></td>
                    <%--<asp:ImageButton ID="ImageButton6" ImageUrl="~/images/crl_icon.gif" runat="server" /></td>--%>
                <%--<td style="width: 109px; height: 18px;" align="center" valign="middle">
                    <span style="font-size: 12px"><a href="MossDetail.aspx">View</a></span></td>--%>
                <td style="width: 100px; height: 41px;" align="center">
                    <span style="font-size: 14px"><%--<a href="Download/MOSSCA.rar">Download</a>--%>
                        &nbsp;<asp:LinkButton ID="LinkButton6" runat="server" OnClick="LinkButton6_Click">Download</asp:LinkButton></span></td>
            </tr>
            <%--<tr><td style="width: 691px"><br /></td></tr>
            <tr>
                <td style="width: 691px; height: 16px;">
                    <span style="font-size: 14px">Sub Certificate</span></td>
                <td style="width: 250px; height: 16px;">
                    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/images/certificate_icon2.jpg" OnClick="ImageButton2_Click1"/></td>
                    <%--<asp:ImageButton ID="ImageButton6" ImageUrl="~/images/crl_icon.gif" runat="server" /></td>--%>
                <%--<td style="width: 109px; height: 18px;" align="center" valign="middle">
                    <span style="font-size: 12px"><a href="MossDetail.aspx">View</a></span></td>--%>
                <%--<td style="width: 100px; height: 16px;" align="center">
                    <span style="font-size: 14px"><%--<a href="Download/MOSSCA.rar">Download</a>--%>
                       <%-- &nbsp;<asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click2">Download</asp:LinkButton></span></td>
            </tr>--%>
           
            
        </table>
        
	</div>
	
	
	
</div>
</div>
<div class="clear">&nbsp; <br /><br /><br /><br /><br /><br /></div>

<div   id="footer" >


	Copyright © 2012,Myanmar ICT Development Corporation Ltd. All Rights Reserved.
	 <%--<img src="images/myanmar-info-tech-root-ca.gif" class="logo-img" />--%>
			
		</div>

		</form>
		
</body>
</html>

