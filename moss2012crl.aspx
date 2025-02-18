<%@ Page Language="C#" AutoEventWireup="true" CodeFile="moss2012crl.aspx.cs" Inherits="moss2012crl" %>

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
                <td style="width: 222px;"><asp:Label ID="Label2" runat="server" Text="MOSS Download(CRL)"></asp:Label><br /><br />
                </td>
        </tr>
        <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton11" runat="server" OnClick="LinkButton8_Click" >MOSSCA CRL 7-8-2012 </asp:LinkButton> 
                    </td>
                                  
             </tr>
        <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton7" runat="server" OnClick="LinkButton7_Click" >MOSSCA CRL 30-7-2012 </asp:LinkButton> 
                    </td>
                                  
             </tr>
             <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click" >MOSSCA CRL 23-7-2012 </asp:LinkButton> 
                    </td>
                                  
             </tr>
             <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click" >MOSSCA CRL 16-7-2012 </asp:LinkButton> 
                    </td>
                                  
                  
            </tr>
            <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" >MOSSCA CRL 9-7-2012 </asp:LinkButton> 
                    </td>
                                  
                  
            </tr>
            <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton18" runat="server" OnClick="LinkButton18_Click"  >MOSSCA CRL 2-7-2012 </asp:LinkButton> 
                    </td>
                                  
                  
            </tr>
             <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton15" runat="server" OnClick="LinkButton15_Click">MOSSCA CRL 25-6-2012 </asp:LinkButton> 
                    </td>
                                  
                  
            </tr>
             <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton13" runat="server" OnClick="LinkButton13_Click"  >MOSSCA CRL 18-6-2012 </asp:LinkButton> 
                    </td>
                                  
                  
            </tr>
            <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton12" runat="server" OnClick="LinkButton12_Click"  >MOSSCA CRL 12-6-2012 </asp:LinkButton> 
                    </td>
                                  
                  
            </tr>
            <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton10" runat="server" OnClick="LinkButton10_Click"  >MOSSCA CRL 6-6-2012 </asp:LinkButton> 
                    </td>
                                  
                  
            </tr>
            <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton6" runat="server" OnClick="LinkButton6_Click" >MOSSCA CRL 28-5-2012 </asp:LinkButton> 
                    </td>
                                  
                  
            </tr>
            <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click" >MOSSCA CRL 15-5-2012 </asp:LinkButton> 
                    </td>
                                  
                  
            </tr>
            <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click"  >MOSSCA CRL 25-4-2012 </asp:LinkButton> 
                    </td>
                                  
                  
            </tr>         
            <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="MOSSCA" runat="server" OnClick="MOSSCA_Click"  >MOSSCA CRL 9-4-2012 </asp:LinkButton> 
                    </td>
                                  
                  
            </tr>
            <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton25" runat="server" OnClick="LinkButton25_Click" >MOSSCA CRL 2-4-2012 </asp:LinkButton> 
                    </td>
                                  
                  
            </tr>
           <tr style="height:25px"><td style="width: 222px;"></td></tr>
        
            <tr style="height:25px">     
                <td style="width: 222px; height: 25px;">
                    <asp:LinkButton ID="LinkButton8" runat="server" PostBackUrl="~/MOSS2019CRL3.aspx">1</asp:LinkButton>&nbsp;
                    <asp:LinkButton ID="LinkButton9" runat="server" PostBackUrl="~/MOSS2019CRL2.aspx">2</asp:LinkButton>&nbsp;
                    <asp:LinkButton ID="LinkButton14" runat="server" PostBackUrl="~/MOSS2019CRL.aspx">3</asp:LinkButton>&nbsp;
                    <asp:LinkButton ID="LinkButton16" runat="server" PostBackUrl="~/MOSS2018CRL3.aspx">4</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton17" runat="server" PostBackUrl="~/MOSS2018CRL2.aspx" >5</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton19" runat="server" PostBackUrl="~/MOSS2018CRL.aspx">6</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton20" runat="server" PostBackUrl="~/MOSS2017CRL3.aspx">7</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton21" runat="server" PostBackUrl="~/MOSS2017CRL2.aspx">8</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton22" runat="server" PostBackUrl="~/MOSS2017CRL.aspx">9</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton23" runat="server" PostBackUrl="~/MOSS2016CRL3.aspx">10</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton24" runat="server" PostBackUrl="~/MOSS2016CRL2.aspx">11</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton26" runat="server" PostBackUrl="~/MOSS2016CRL.aspx">12</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton27" runat="server" PostBackUrl="~/MOSS.aspx">13</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton28" runat="server" PostBackUrl="~/moss2012crl.aspx">14</asp:LinkButton></td>
                                  
                  
            </tr>
            
            </table>
    </div>   
        
</div>

        
<div id="footer" align="left">&nbsp;
	Copyright � 2012,Myanmar ICT Development Corporation Ltd. All Rights Reserved.	
	<%-- <img src="images/myanmar-info-tech-root-ca.gif" class="logo-img" />--%>
	</div>        
        
    </form>
</body>
</html>
