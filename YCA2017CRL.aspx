<%@ Page Language="C#" AutoEventWireup="true" CodeFile="YCA2017CRL.aspx.cs" Inherits="YCA2017CRL" %>

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
		<p>Secured, Trusted and Proven Information Technology Solutions</p>
		</div>
</div>
        <br />
  <div id="container-content" style="width: 952px; height: 18%">      
        
        <div id="ca" style="width: 431px">
        
        <table id="CRL" cellpadding="0" cellspacing="0" style="width: 443px">
        
        <tr style="height:25px">
                <td style="width: 222px; height: 25px;"><asp:Label ID="Label2" runat="server" Text="YCA Download(CRL)"></asp:Label><br /><br />
                
                </td>
        </tr>
        <tr style="height:25px">
        <td style="width: 222px;">
            <asp:LinkButton ID="LinkButton18" runat="server" OnClick="LinkButton18_Click" >YCA CRL 15-5-2017</asp:LinkButton>
            
        </td>
        </tr>
        <tr style="height:25px">
        <td style="width: 222px;">
            <asp:LinkButton ID="LinkButton16" runat="server" OnClick="LinkButton16_Click" >YCA CRL 8-5-2017</asp:LinkButton>
            
        </td>
        </tr>
        <tr style="height:25px">
        <td style="width: 222px;">
            <asp:LinkButton ID="LinkButton15" runat="server" OnClick="LinkButton15_Click"  >YCA CRL 24-4-2017</asp:LinkButton>
            
        </td>
        </tr>
        <tr style="height:25px">
        <td style="width: 222px;">
            <asp:LinkButton ID="LinkButton14" runat="server" OnClick="LinkButton14_Click"  >YCA CRL 3-4-2017</asp:LinkButton>
            
        </td>
        </tr>
        <tr style="height:25px">
        <td style="width: 222px;">
            <asp:LinkButton ID="LinkButton13" runat="server" OnClick="LinkButton13_Click"  >YCA CRL 20-3-2017</asp:LinkButton>
            
        </td>
        </tr>
        <tr style="height:25px">
        <td style="width: 222px;">
            <asp:LinkButton ID="LinkButton12" runat="server" OnClick="LinkButton12_Click" >YCA CRL 13-3-2017</asp:LinkButton>
            
        </td>
        </tr>
        <tr style="height:25px">
        <td style="width: 222px;">
            <asp:LinkButton ID="LinkButton11" runat="server" OnClick="LinkButton11_Click" >YCA CRL 6-3-2017</asp:LinkButton>
            
        </td>
        </tr>
        <tr style="height:25px">
        <td style="width: 222px;">
            <asp:LinkButton ID="LinkButton10" runat="server" OnClick="LinkButton10_Click" >YCA CRL 27-2-2017</asp:LinkButton>
            
        </td>
        </tr>
        <tr style="height:25px">
        <td style="width: 222px;">
            <asp:LinkButton ID="LinkButton9" runat="server" OnClick="LinkButton9_Click">YCA CRL 20-2-2017</asp:LinkButton>
            
        </td>
        </tr>
        <tr style="height:25px">
        <td style="width: 222px;">
            <asp:LinkButton ID="LinkButton8" runat="server" OnClick="LinkButton8_Click">YCA CRL 13-2-2017</asp:LinkButton>
            
        </td>
        </tr>
        <tr style="height:25px">
        <td style="width: 222px;">
            <asp:LinkButton ID="LinkButton7" runat="server" OnClick="LinkButton7_Click" >YCA CRL 6-2-2017</asp:LinkButton>
            
        </td>
        </tr>
        <tr style="height:25px">
        <td style="width: 222px;">
            <asp:LinkButton ID="LinkButton6" runat="server" OnClick="LinkButton6_Click"  >YCA CRL 30-1-2017</asp:LinkButton>
            
        </td>
        </tr>
        <tr style="height:25px">
        <td style="width: 222px;">
            <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click"  >YCA CRL 23-1-2017</asp:LinkButton>
            
        </td>
        </tr>
        <tr style="height:25px">
        <td style="width: 222px;">
            <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click"  >YCA CRL 16-1-2017</asp:LinkButton>
            
        </td>
        </tr>
        <tr style="height:25px">
        <td style="width: 222px;">
            <asp:LinkButton ID="LinkButton17" runat="server" OnClick="LinkButton17_Click"  >YCA CRL 9-1-2017</asp:LinkButton>
            
        </td>
        </tr>
        
 <tr><td style="width: 222px"><br /></td></tr>
 
            <tr style="height:25px">     
                <td style="width: 222px; height: 25px;">
                    <asp:LinkButton ID="LinkButton137" runat="server" PostBackUrl="~/YCA2018CRL4.aspx">1</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton138" runat="server" PostBackUrl="~/YCA2018CRL3.aspx">2</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton139" runat="server" PostBackUrl="~/YCA2018CRL2.aspx">3</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton140" runat="server" PostBackUrl="~/YCA2018CRL.aspx">4</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton141" runat="server" PostBackUrl="~/YCA2017CRL3.aspx">5</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton142" runat="server" PostBackUrl="~/YCA2017CRL2.aspx">6</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton143" runat="server" PostBackUrl="~/YCA2017CRL.aspx">7</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton144" runat="server" PostBackUrl="~/YCA2016CRL2.aspx">8</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton145" runat="server" PostBackUrl="~/YCA2016CRL.aspx">9</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton146" runat="server" PostBackUrl="~/YCA.aspx">10</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton147" runat="server" PostBackUrl="~/Yca2015crl.aspx">11</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton148" runat="server" PostBackUrl="~/Yca2015crl2.aspx">12</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Yca2015crl3.aspx">13</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/Yca2014crl.aspx">14</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="~/Yca2014crl2.aspx">15</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton19" runat="server" PostBackUrl="~/Yca2014clr3.aspx">16</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton20" runat="server" PostBackUrl="~/Yca2013crl.aspx">17</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton21" runat="server" PostBackUrl="~/Yca2013crl2.aspx">18</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton22" runat="server" PostBackUrl="~/Yca2013crl3.aspx">19</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton23" runat="server" PostBackUrl="~/Yca2012crl.aspx">20</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton24" runat="server" PostBackUrl="~/Yca2012crl2.aspx">21</asp:LinkButton></td>
             
                  
            </tr>
           
            
            
           <%-- <tr style="height:25px" >
                <td style="width: 222px;">
                    <asp:Label ID="label1" runat="server"  Text="RootCA (Download CRL)"></asp:Label>
                   </td>
             </tr>
              <tr style="height:25px">     
                <td style="width: 222px;">
                    
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click"  >RootCA CRL 15-3-2012 </asp:LinkButton> 
                    
                    </td>
                  
                  
            </tr>
              <tr style="height:25px">     
                <td style="width: 222px;">
                    
                    <asp:LinkButton ID="Root" runat="server" OnClick="Root_Click" >RootCA CRL 20-1-2011 </asp:LinkButton> 
                    
                    </td>
                  
                  
            </tr>
             <tr><td style="width: 222px; height: 17px;"></td></tr>
             --%>
            
          
          
            </table></div></div>
            
        
            
            <div id="footer" align="left">&nbsp;
	Copyright © 2012,Myanmar ICT Development Corporation Ltd. All Rights Reserved.	
	
	</div>        
        
    </form>
</body>
</html>
