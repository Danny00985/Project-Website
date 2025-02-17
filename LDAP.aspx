<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LDAP.aspx.cs" Inherits="LDAP" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
   <title>Root CA - Myanmar Info-Tech Corporation</title>
    <link href="css/default.css" rel="stylesheet" type="text/css" />
    <link rel="shortcut icon" href="~/images/final.png" type="image/x-icon" /> 

    <script type="text/javascript" language="javascript">
    function validateByName()
    {
        if(document.getElementById("<%=ddlCA.ClientID%>").value=="")
        {
            alert("Please Select Organization Unit");
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
            alert("Please Select Organization Unit");
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
   
    </script>

</head>
<body>
    <form id="form1" runat="server">
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
 <div id="Search"  >
       <table  cellpadding="0" cellspacing="0" >
       
        <tr style="height:25px;">
            <td style="width: 301px"><strong>Search For LDAP Data</strong>            
            </td>
        </tr>
       
        
        <tr style="height: 25px">
            <td style="width: 301px">Please Choose an Organization Unit:</td>
        </tr>
        <tr style="height: 25px">
            <td style="width: 301px">
                <asp:DropDownList ID="ddlCA" runat="server" Width="301px" >
                </asp:DropDownList>
            </td>
        </tr>
        <tr style="height: 25px">
            <td style="width: 301px">Search by Common Name:</td>
        </tr>
        <tr style="height: 25px">
            <td style="width: 301px">
                <asp:TextBox ID="txtCommonName" runat="server" Width="227px"></asp:TextBox>&nbsp;
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
        
       
        </table>  
           <br />
           
       
        <p>
            <span style="font-size: small; font-family: Verdana">
                
                <asp:DetailsView ID="dvCertificate"  runat="server" AutoGenerateRows="False" BackColor="White"
                    BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical"
                    Height="50px" Width="100%">
                    <Fields>
                      <asp:BoundField DataField="DisplayName" HeaderText="Name" SortExpression="DisplayName" />
                           <asp:BoundField DataField="Mail" HeaderText="Mail" SortExpression="Mail" />
                    </Fields>
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <AlternatingRowStyle BackColor="Gainsboro" />
                </asp:DetailsView>
            </span></p>
       </div>



<div id="footer" >
	Copyright © 2012,Myanmar ICT Development Corporation Ltd. All Rights Reserved.	
	<%-- <img src="images/myanmar-info-tech-root-ca.gif" class="logo-img" />--%>
	</div>

    </form>
</body>
</html>
