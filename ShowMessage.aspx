<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowMessage.aspx.cs" Inherits="ShowMessage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Btn" runat="server" OnClick="Btn_Click" Style="position: static"
            Width="42px" /></div>
    </form>
</body>
</html>
<script language="javascript">
    alert("<%=Message%>");
    document.getElementsByName("Btn")[0].click();
</script>