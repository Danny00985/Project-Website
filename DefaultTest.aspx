<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DefaultTest.aspx.cs" Inherits="DefaultTest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
     <script type="text/javascript" language="javascript">
    function validate()
    {
        if(document.getElementById("<%=txtCommonName.ClientID%>").value=="")
        {
            alert("Name field cannot be blank");
            document.getElementById("<%=txtCommonName.ClientID%>").focus();
            return false;
        }


//            bool IsValidEmail(string str)
//            {
//                // Return true if strIn is in valid e-mail format.
//                return Regex.IsMatch(str, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"); 
//            }
        
//        var complete=true;
//        var email=document.form1.text.value;
//        if((email.indexOf("@")==-1 || (email.indexOf(".")==-1))
//        {
//            alert("Email format invalid.");
//            complete=false;
//        }

//        if(Regex.IsMatch(document.getElementById("<%=txtCommonName.ClientID%>").value), @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
//        {
//            alert("Email format invalid");
//            document.getElementById("<%=txtCommonName.ClientID%>").focus();
//            return false;
//        }

        return true;
    }


    </script>
    

</head>
<body>
     <form id="form1" runat="server">
    <div>
        
        
  <asp:TextBox ID="txtCommonName" runat="server"  ></asp:TextBox>
   <asp:Button id="ASPNET_Server_Control" runat="server" Text="Button" OnClientClick="return validate()" OnClick="ASPNET_Server_Control_Click2"   /><br />
    
     
        
         <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" AutoGenerateRows="False"  >
            <Fields>
                <asp:BoundField DataField="Serial_Num"  HeaderText="Serial Num" />
                <asp:BoundField DataField="Name"  HeaderText="Name" />
                <asp:BoundField DataField="SEmail"  HeaderText="Email" />
                <asp:BoundField DataField="SOrganization"  HeaderText="Organization" />
                <asp:BoundField DataField="Valid_From"  HeaderText="Valid_From" />
                <asp:BoundField DataField="Valid_To"  HeaderText="Valid_To" />
                <asp:BoundField DataField="Status"  HeaderText="Status" />
            </Fields>
        </asp:DetailsView>
      
        
    </div>
    </form>
</body>
</html>
