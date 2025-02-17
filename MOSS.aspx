<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MOSS.aspx.cs" Inherits="MOSS" %>

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
                <td style="width: 222px;"><asp:Label ID="Label2" runat="server" Text="MOSS Download(CRL)"></asp:Label><br />
                </td>
        </tr>
        <tr style="height:25px">     
                <td style="width: 222px;">
                    &nbsp;</td>
                                  
             </tr>
             <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click" >MOSSCA CRL 21-4-2016 </asp:LinkButton> 
                    </td>
                                  
             </tr>
             <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton28" runat="server" OnClick="LinkButton28_Click" >MOSSCA CRL 15-2-2016 </asp:LinkButton> 
                    </td>
                                  
             </tr>
        <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton27" runat="server" OnClick="LinkButton27_Click">MOSSCA CRL 8-10-2015 </asp:LinkButton> 
                    </td>
                                  
             </tr>
        <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton26" runat="server" OnClick="LinkButton26_Click" >MOSSCA CRL 28-9-2015 </asp:LinkButton> 
                    </td>
                                  
             </tr>
        <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton24" runat="server" OnClick="LinkButton24_Click"  >MOSSCA CRL 22-10-2012 </asp:LinkButton> 
                    </td>
                                  
             </tr>
          <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton23" runat="server" OnClick="LinkButton23_Click"  >MOSSCA CRL 15-10-2012 </asp:LinkButton> 
                    </td>
                                  
             </tr>
           <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton22" runat="server" OnClick="LinkButton22_Click"  >MOSSCA CRL 8-10-2012 </asp:LinkButton> 
                    </td>
                                  
             </tr>
           <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton21" runat="server" OnClick="LinkButton21_Click" >MOSSCA CRL 1-10-2012 </asp:LinkButton> 
                    </td>
                                  
             </tr>
            <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton20" runat="server" OnClick="LinkButton20_Click">MOSSCA CRL 24-9-2012 </asp:LinkButton> 
                    </td>
                                  
             </tr>
             <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton19" runat="server" OnClick="LinkButton19_Click"  >MOSSCA CRL 17-9-2012 </asp:LinkButton> 
                    </td>
                                  
             </tr>
             <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton17" runat="server" OnClick="LinkButton17_Click"  >MOSSCA CRL 10-9-2012 </asp:LinkButton> 
                    </td>
                                  
             </tr>
             <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton16" runat="server" OnClick="LinkButton16_Click"  >MOSSCA CRL 3-9-2012 </asp:LinkButton> 
                    </td>
                                  
             </tr>
            <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton14" runat="server" OnClick="LinkButton14_Click"  >MOSSCA CRL 27-8-2012 </asp:LinkButton> 
                    </td>
                                  
             </tr>
            <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton11" runat="server" OnClick="LinkButton11_Click" >MOSSCA CRL 20-8-2012 </asp:LinkButton> 
                    </td>
                                  
             </tr>
             <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton9" runat="server" OnClick="LinkButton9_Click">MOSSCA CRL 13-8-2012 </asp:LinkButton> 
                    </td>
                                  
             </tr>
            <%--<tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton8" runat="server" OnClick="LinkButton8_Click" >MOSSCA CRL 7-8-2012 </asp:LinkButton> 
                    </td>
                                  
             </tr>--%>
             
           <tr style="height:25px"><td style="width: 222px;"></td></tr>
        
             <tr style="height:25px">     
                <td style="width: 222px; height: 25px;">
                    <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/MOSS2019CRL3.aspx">1</asp:LinkButton>&nbsp;
                    <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/MOSS2019CRL2.aspx">2</asp:LinkButton>&nbsp;
                    <asp:LinkButton ID="LinkButton4" runat="server" PostBackUrl="~/MOSS2019CRL.aspx">3</asp:LinkButton>&nbsp;
                    <asp:LinkButton ID="LinkButton5" runat="server" PostBackUrl="~/MOSS2018CRL3.aspx">4</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton6" runat="server" PostBackUrl="~/MOSS2018CRL2.aspx" >5</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton7" runat="server" PostBackUrl="~/MOSS2018CRL.aspx">6</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton8" runat="server" PostBackUrl="~/MOSS2017CRL3.aspx">7</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton10" runat="server" PostBackUrl="~/MOSS2017CRL2.aspx">8</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton12" runat="server" PostBackUrl="~/MOSS2017CRL.aspx">9</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton13" runat="server" PostBackUrl="~/MOSS2016CRL3.aspx">10</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton15" runat="server" PostBackUrl="~/MOSS2016CRL2.aspx">11</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton18" runat="server" PostBackUrl="~/MOSS2016CRL.aspx">12</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton25" runat="server" PostBackUrl="~/MOSS.aspx">13</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton29" runat="server" PostBackUrl="~/moss2012crl.aspx">14</asp:LinkButton></td>
                                  
                  
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
