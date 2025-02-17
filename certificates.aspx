<%@ Page Language="C#"  AutoEventWireup="true" CodeFile="certificates.aspx.cs" Inherits="certificates" Title="Untitled Page" %>
<%-- Add content controls here --%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Root CA - Myanmar Info-Tech Corporation</title>
    <link href="css/default.css" rel="stylesheet" type="text/css" media="screen" />
    <link rel="shortcut icon" href="~/images/final.png" type="image/x-icon" /> 

    
    <script type="text/javascript" language="javascript">
    function validateByName()
    {
        if(document.getElementById("<%=ddlCA.ClientID%>").value=="")
        {
            alert("Please Select Certifying Authority");
            document.getElementById("<%=ddlCA.ClientID%>").focus();
            return false;
        }
        if(document.getElementById("<%=txtCommonName.ClientID%>").value=="")
        {
            alert("Please enter Common Name to search");
            document.getElementById("<%=txtCommonName.ClientID%>").focus();
            return false;
        }
        
        return true;
    }
    function validateByEmail()
    {
        if(document.getElementById("<%=ddlCA.ClientID%>").value=="")
        {
            alert("Please Select Certifying Authority");
            document.getElementById("<%=ddlCA.ClientID%>").focus();
            return false;
        }
        if(document.getElementById("<%=txtEmail.ClientID%>").value=="")
        {
            alert("Please enter email to search");
            document.getElementById("<%=txtEmail.ClientID%>").focus();
            return false;
        }
        
        var pattern =/^[a-zA-Z0-9_\-.]+@([a-zA-Z0-9\-]+\.)+[a-zA-Z]{2,3}$/;
        if(document.getElementById("<%=txtEmail.ClientID%>").value.search(pattern)>-1)
        {
             return true;
        }
        else
       {
            alert("Invalid Email Format");
            document.getElementById("<%=txtEmail.ClientID%>").focus();
            return false;
       } 


        return true;
    }
    function validateByNo()
    {
        if(document.getElementById("<%=ddlCA.ClientID%>").value=="")
        {
            alert("Please Select Certifying Authority");
            document.getElementById("<%=ddlCA.ClientID%>").focus();
            return false;
        }
        if(document.getElementById("<%=txtNumber.ClientID%>").value=="")
        {
            alert("Please enter serial number to search");
            document.getElementById("<%=txtNumber.ClientID%>").focus();
            return false;
        }
        return true;
    }
    
    </script>
</head>
<body>
<form id="Form1" name="form1" runat="server">
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
<br />
<div id="container-content">
<p >
   <span style="font-size:medium; text-align:justify; font-family: Verdana">
   By clicking the Search button, you accept the terms of our Relying Party Agreement.
   </span> 

</p>
<br />
    <div id="slogan">
    <font size="+1">
    <span class="slogan">
                <p style="text-align: center">
                <span style="color: rgb(0,0,102)"><span style="font-size: 12pt; font-family: Verdana">
                    <%--<strong>Disclaimer</strong>--%>
                <strong><a href="Disclaimer.aspx">Disclaimer</a></strong>  
                    
                    </span></span></p>
        </span></font>
        <tr>
        <td></td>
        </tr>
        <td background="images/cca/hline.gif">
        <img height="1" alt="" src="http://cca.gov.in/images/cca/empty_dot.gif" style="font-size: 12pt;
            font-family: Verdana" width="1" />
        </td>
        
        <tr>
         <td></td>
        </tr>
        <td class="htxt1">
        </td>
        <%--<p style="text-align:justify">
            <span style="font-size: small; text-align:justify; font-family: Verdana">
                For latest information users and relying parties are advised to verify the certificates
                and CRLs from the website of the issuing CA.</span></p>--%>
    
       </div>
    <br />
    
    <div id="Search"  >
       <table width="100%"  cellpadding="0" cellspacing="0" >
       
        <tr style="height:25px;">
            <td style="width: 301px"><strong>Search For Digital Signature Certificate</strong>            
            </td>
        </tr>
       <tr><td>&nbsp;</td></tr>
       
        <tr style="height:25px">
            <td style="width: 301px">Please Choose the Certifying Authority:</td>
        </tr>
        <tr style="height: 25px">
        <td style="width: 301px; height: 25px;" >
            <asp:DropDownList ID="ddlCA" runat="server" Width="300px" AutoPostBack="True" OnSelectedIndexChanged="ddlCA_SelectedIndexChanged">
            </asp:DropDownList>
            </td>
        </tr>
        <%--<tr style="height: 25px">
            <td style="width: 301px">Please Choose an Organization Unit:</td>
        </tr>
        <tr style="height: 25px">
            <td style="width: 301px">
                <asp:DropDownList ID="ddlOrganization" runat="server" Width="301px">
                </asp:DropDownList>
            </td>
        </tr>--%>
        <tr style="height: 25px">
            <td style="width: 301px">Search by Common Name:</td>
        </tr>
        <tr style="height: 25px">
            <td style="width: 301px">
                <asp:TextBox ID="txtCommonName" runat="server" Width="227px" OnTextChanged="txtCommonName_TextChanged"></asp:TextBox>&nbsp;
                <asp:Button ID="butName" runat="server" Text="Search"  OnClientClick="return validateByName()" OnClick="butName_Click1"  />
            </td>
        </tr>
        <tr style="height: 25px">
            <td style="width: 301px">Search by Email:            
            </td>
        </tr>
        <tr style="height: 25px">
            <td style="width: 301px">
                <asp:TextBox ID="txtEmail" runat="server" Width="227px"></asp:TextBox>&nbsp;
                <asp:Button ID="butEmail" runat="server" Text="Search" OnClientClick="return validateByEmail()"  OnClick="butEmail_Click" />
               <%--<small> <asp:RegularExpressionValidator id="RegularExpressionValidator1"  runat="server" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ErrorMessage="Invalid Email Format" ControlToValidate="txtEmail"></asp:RegularExpressionValidator>
               </small>--%>
            </td>
        </tr>
         <tr style="height: 25px">
            <td style="width: 301px">Search by Serial Number:            
            </td>
        </tr>
        <tr style="height: 25px">
            <td style="width: 301px; height: 25px;">
                <asp:TextBox ID="txtNumber"  Width="227px" runat="server"></asp:TextBox>&nbsp;
               <asp:Button ID="Button1" runat="server" Text="Search" OnClientClick="return validateByNo()"  OnClick="butNo_Click" />
            </td>
        </tr>
       
        </table>  
       
        <p>
            <span style="font-size: small; font-family: Verdana"></span>&nbsp;</p>
       </div>
          
   
         
      </div>

<div id="footer" >
	Copyright © 2012,Myanmar ICT Development Corporation Ltd. All Rights Reserved.	
	<%-- <img src="images/myanmar-info-tech-root-ca.gif" class="logo-img" />--%>
	</div>
	</form>
	</body>
	</html>