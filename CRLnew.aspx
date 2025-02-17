<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CRLnew.aspx.cs" Inherits="crlnew" %>

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
			<li id="current-page"><a href="CRLnew.aspx">Certificate Revocation List</a></li>			
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
        
  <div id="container-content" style="width: 952px; height: 18%">      
        
        <div id="ca" style="width: 431px">
            
        <table id="CRL" cellpadding="0" cellspacing="0" style="width: 443px">
        <tr style="height:25px" >
                <td style="width: 222px; height: 30px;">
                    <b><asp:Label ID="label3" runat="server"  Text="RootCA SHA-256(Download CRL)" Width="264px"></asp:Label></b>
                   </td>
                   </tr>
             
               &nbsp;<tr style="height:25px">     
                <td style="width: 222px; height: 25px;">
                    <asp:LinkButton ID="LinkButton21" runat="server" Width="253px" OnClick="LinkButton21_Click">Root CA CRL 7-3-2024</asp:LinkButton></td>
             </tr>
             
                    
              &nbsp;<tr style="height:25px">     
                <td style="width: 222px; height: 25px;">
                    <asp:LinkButton ID="LinkButton18" runat="server" Width="253px" OnClick="LinkButton18_Click" >RootCA CRL 8-3-2023</asp:LinkButton></td>
             </tr>
              &nbsp;<tr style="height:25px">     
                <td style="width: 222px; height: 25px;">
                    <asp:LinkButton ID="LinkButton17" runat="server" Width="253px" OnClick="LinkButton17_Click" >RootCA CRL 9-3-2022</asp:LinkButton></td>
             </tr>
             &nbsp;<tr style="height:25px">     
                <td style="width: 222px; height: 25px;">
                    <asp:LinkButton ID="LinkButton16" runat="server" Width="253px" OnClick="LinkButton16_Click" >RootCA CRL 10-3-2021</asp:LinkButton></td>
             </tr>
             &nbsp;<tr style="height:25px">     
                <td style="width: 222px; height: 25px;">
                    <asp:LinkButton ID="LinkButton15" runat="server" Width="253px" OnClick="LinkButton15_Click"  >RootCA CRL 10-9-2020</asp:LinkButton></td>
             </tr>
              &nbsp;<tr style="height:25px">     
                <td style="width: 222px; height: 25px;">
                    <asp:LinkButton ID="LinkButton14" runat="server" Width="253px" OnClick="LinkButton14_Click"  >RootCA CRL 11-3-2020</asp:LinkButton></td>
             </tr>
             &nbsp;<tr style="height:25px">     
                <td style="width: 222px; height: 25px;">
                    <asp:LinkButton ID="LinkButton13" runat="server" Width="253px" OnClick="LinkButton13_Click"   >RootCA CRL 13-9-2019</asp:LinkButton></td>
             </tr>
             &nbsp;<tr style="height:25px">     
                <td style="width: 222px; height: 25px;">
                    <asp:LinkButton ID="LinkButton12" runat="server" Width="253px" OnClick="LinkButton12_Click"    >RootCA CRL 14-3-2019</asp:LinkButton></td>
             </tr>
              &nbsp;<tr style="height:25px">     
                <td style="width: 222px; height: 25px;">
                    <asp:LinkButton ID="LinkButton11" runat="server" Width="253px" OnClick="LinkButton11_Click"   >RootCA CRL 13-9-2018</asp:LinkButton></td>
             </tr>
              &nbsp;<tr style="height:25px">     
                <td style="width: 222px; height: 25px;">
                    <asp:LinkButton ID="LinkButton7" runat="server" Width="253px" OnClick="LinkButton7_Click"  >RootCA CRL 14-3-2018</asp:LinkButton></td>
             </tr>
             &nbsp;<tr style="height:25px">     
                <td style="width: 222px; height: 25px;">
                    <asp:LinkButton ID="LinkButton6" runat="server" Width="253px" OnClick="LinkButton6_Click"  >RootCA CRL 14-9-2017</asp:LinkButton></td>
             </tr>
             
             <tr><td style="width: 222px"><br /></td></tr>
             
            <tr style="height:25px" >
                <td style="width: 222px; height: 30px;">
                    <b><asp:Label ID="label1" runat="server"  Text="RootCA SHA-1(Download CRL)" Width="254px"></asp:Label></b>
                   </td>
             </tr>
             &nbsp;<tr style="height:25px">     
                <td style="width: 222px; height: 25px;">
                    <asp:LinkButton ID="LinkButton10" runat="server" OnClick="LinkButton10_Click"  >RootCA CRL 17-8-2018</asp:LinkButton></td>
             </tr>
             &nbsp;<tr style="height:25px">     
                <td style="width: 222px; height: 25px;">
                    <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click" >RootCA CRL 19-8-2017</asp:LinkButton></td>
             </tr>
             &nbsp;<tr style="height:25px">     
                <td style="width: 222px; height: 25px;">
                    <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">RootCA CRL 28-8-2015</asp:LinkButton></td>
             </tr>
             &nbsp;<tr style="height:25px">     
                <td style="width: 222px;">
                    
                    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">RootCA CRL 5-3-2014 </asp:LinkButton> 
                    
                    </td>
             </tr>
            &nbsp;<tr style="height:25px">     
                <td style="width: 222px; height: 25px;">
                    
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click1"  >RootCA CRL 15-3-2012 </asp:LinkButton> 
                    
                    </td>
             </tr>
              <tr style="height:25px">     
                <td style="width: 222px; height: 25px;">
                    
                    <asp:LinkButton ID="Root" runat="server" OnClick="Root_Click" >RootCA CRL 20-1-2011 </asp:LinkButton> 
                    
                    </td>
                  
                  
            </tr>
            
            <tr><td style="width: 222px"><br /></td></tr>
            
            <tr style="height:25px" >
                <td style="width: 222px; height: 30px;">
                    <b><asp:Label ID="label2" runat="server"  Text="CA (Download CRL)" Width="205px"></asp:Label></b>
                   </td>
             </tr>
            <tr style="height:25px" >
                <td style="width: 222px;">
                
                   <%-- <asp:Label ID="label2" runat="server"  Text="YCA (Download CRL)" Width="167px"></asp:Label>--%>
                   
                    <asp:LinkButton ID="LinkButton19" runat="server" OnClick="LinkButton19_Click">YCA SHA-1(Download CRL)</asp:LinkButton>
                </td>
             </tr>
             <tr style="height:25px" >
                <td style="width: 222px;">
                
                   <%-- <asp:Label ID="label2" runat="server"  Text="YCA (Download CRL)" Width="167px"></asp:Label>--%>
                   
                    <asp:LinkButton ID="LinkButton9" runat="server" OnClick="LinkButton9_Click">YCA SHA-256(Download CRL)</asp:LinkButton>
                </td>
             </tr>
             <%--<tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click" >YCA CRL 7-5-2012 </asp:LinkButton> 
                    </td>
                                  
                  
            </tr>
             <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="YCA" runat="server" OnClick="YCA_Click" >YCA CRL 12-3-2012 </asp:LinkButton> 
                    </td>
                                  
                  
            </tr>
             <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click" >YCA CRL 14-5-2012 </asp:LinkButton> 
                    </td>
                                  
                  
            </tr>
            <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton7" runat="server" OnClick="LinkButton7_Click"  >YCA CRL 21-5-2012 </asp:LinkButton> 
                    </td>
                                  
                  
            </tr>
            <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton8" runat="server" OnClick="LinkButton8_Click"   >YCA CRL 28-5-2012 </asp:LinkButton> 
                    </td>
                                  
                  
            </tr>
            <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton9" runat="server" OnClick="LinkButton9_Click"    >YCA CRL 4-6-2012 </asp:LinkButton> 
                    </td>
                                  
                  
            </tr>
            <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton11" runat="server" OnClick="LinkButton11_Click"  >YCA CRL 11-6-2012 </asp:LinkButton> 
                    </td>
                                  
                  
            </tr>
            <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton14" runat="server" OnClick="LinkButton14_Click"   >YCA CRL 15-6-2012 </asp:LinkButton> 
                    </td>
                                  
                  
            </tr>
            <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton16" runat="server" OnClick="LinkButton16_Click"  >YCA CRL 25-6-2012 </asp:LinkButton> 
                    </td>
                           
            </tr>
            <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton17" runat="server" OnClick="LinkButton17_Click"  >YCA CRL 2-7-2012 </asp:LinkButton> 
                    </td>
                                  
                  
            </tr>
            <tr><td style="width: 222px"><br /></td></tr>--%>
            <tr style="height: 25px">
                <td style="width: 222px">
                </td>
            </tr>
            <tr style="height:25px" >
                <td style="width: 222px; height: 25px;">
                   <%-- <asp:Label ID="label3" runat="server" Text="MOSSCA (Download CRL)"></asp:Label><br />--%>
                    <asp:LinkButton ID="LinkButton20" runat="server" OnClick="LinkButton20_Click" Width="243px">MOSSCA SHA-1(Download CRL)</asp:LinkButton></td>
                
            </tr>
            <tr style="height:25px" >
                <td style="width: 222px; height: 25px;">
                   <%-- <asp:Label ID="label3" runat="server" Text="MOSSCA (Download CRL)"></asp:Label><br />--%>
                    <asp:LinkButton ID="LinkButton8" runat="server"  Width="276px" OnClick="LinkButton8_Click">MOSSCA SHA-256 (Download CRL)</asp:LinkButton></td>
                
            </tr>
            <tr style="height: 25px">
                <td style="width: 222px; height: 25px">
                </td>
            </tr>
            <tr style="height:25px" >
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">TESTCA(Download CRL)</asp:LinkButton><%-- <asp:Label ID="label3" runat="server" Text="MOSSCA (Download CRL)"></asp:Label><br />--%></td>
                
            </tr>
           <%-- <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="MOSSCA" runat="server" OnClick="MOSSCA_Click"  >MOSSCA CRL 9-4-2012 </asp:LinkButton> 
                    </td>
                                  
                  
            </tr>
            <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click"   >MOSSCA CRL 25-4-2012 </asp:LinkButton> 
                    </td>
                                  
                  
            </tr>
            <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click"    >MOSSCA CRL 15-5-2012 </asp:LinkButton> 
                    </td>
                                  
                  
            </tr>
            <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton6" runat="server" OnClick="LinkButton6_Click"     >MOSSCA CRL 28-5-2012 </asp:LinkButton> 
                    </td>
                                  
                  
            </tr>
            <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton10" runat="server" OnClick="LinkButton10_Click"      >MOSSCA CRL 6-6-2012 </asp:LinkButton> 
                    </td>
                                  
                  
            </tr>
            <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton12" runat="server" OnClick="LinkButton12_Click"  >MOSSCA CRL 12-6-2012 </asp:LinkButton> 
                    </td>
                                  
                  
            </tr>
              <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton13" runat="server" OnClick="LinkButton13_Click"   >MOSSCA CRL 18-6-2012 </asp:LinkButton> 
                    </td>
                                  
                  
            </tr>
            <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton15" runat="server" OnClick="LinkButton15_Click" >MOSSCA CRL 25-6-2012 </asp:LinkButton> 
                    </td>
                                  
                  
            </tr>
             <tr style="height:25px">     
                <td style="width: 222px;">
                    <asp:LinkButton ID="LinkButton18" runat="server" OnClick="LinkButton18_Click"  >MOSSCA CRL 2-7-2012 </asp:LinkButton> 
                    </td>
                                  
                  
            </tr>--%>
        </table>
    </div>   
        
</div>
<div class="clear">&nbsp;</div>


        
<div id="footer" align="left">&nbsp;
	Copyright © 2012,Myanmar ICT Development Corporation Ltd. All Rights Reserved.	
	 
	</div>        
        
    </form>
</body>
</html>
