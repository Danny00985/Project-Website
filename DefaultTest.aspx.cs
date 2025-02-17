using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class DefaultTest : System.Web.UI.Page
{
    public string CommonName
    {
        get { return txtCommonName.Text; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
         //
        //if (!IsPostBack)
        //{
        //    if (txtCommonName.Text == "")

        //        //ASPNET_Server_Control.Attributes.Add("onClick", "alert('This JS function was added on the fly to this ASP.NET Web Server Control!');");
        //        ASPNET_Server_Control.Attributes.Add("onClick", "alert('This JS function was added on the fly to this ASP.NET Web Server Control!');");
        //    else
        //        ASPNET_Server_Control.Attributes.Add("PostBackUrl", ASPNET_Server_Control.PostBackUrl="~/CrossTest.aspx");

        //    //else
        //    //{
        //    //if (txtCommonName.Text != "")
              
        //   //}
        //}
        

        
//ASPNET_Server_Control.Attributes.Add("style", "background-color:yellow");
//HTML_Server_Control.Attributes.Add("onClick", "alert('This JS function was added on the fly to this HTML Server Control!');");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
       
        ////if (!Page.IsPostBack)
        ////{
        //    if (txtCommonName.Text == "")
        //    {
        //        //ASPNET_Server_Control.Attributes.Add("OnClick", "alert('This JS function was added on the fly to this ASP.NET Web Server Control!');");
        //        ASPNET_Server_Control.Attributes.Add("OnClick","alert('This JS function was added on the fly to this ASP.NET Web Server Control!');");
        //    }
        //    if (txtCommonName.Text != "")
        //       ASPNET_Server_Control.PostBackUrl = "~/CrossTest.aspx";
        ////}
       
        //HTML_Server_Control.Attributes.Add("onClick", "alert('This JS function was added on the fly to this HTML Server Control!');");
    }
    
    protected void HTML_Server_Control_ServerClick(object sender, EventArgs e)
    {
        ////ASPNET_Server_Control.Attributes.Add("onClick", "alert('This JS function was added on the fly to this ASP.NET Web Server Control!');");
        //if (txtCommonName.Text == "")
        //    HTML_Server_Control.Attributes.Add("onClick", "alert('This JS function was added on the fly to this HTML Server Control!');");
        //else
        //    Response.Redirect("~/CrossTest.aspx");
    }
    //protected void ASPNET_Server_Control_Click(object sender, EventArgs e)
    //{
    //    if (Page.IsPostBack)
    //    {
    //        if (txtCommonName.Text != "")
    //            ASPNET_Server_Control.PostBackUrl = "~/CrossTest.aspx";
    //    }
    //}
//    protected void ASPNET_Server_Control_Click(object sender, EventArgs e)
//    {
//        //ASPNET_Server_Control.Attributes.Add("PostBackUrl", ASPNET_Server_Control.PostBackUrl = "~/CrossTest.aspx");
//    }
//    protected void txtCommonName_TextChanged(object sender, EventArgs e)
//    {
//        ASPNET_Server_Control.Attributes.Add("PostBackUrl", ASPNET_Server_Control.PostBackUrl = "~/CrossTest.aspx");
//    }
//    protected void ASPNET_Server_Control_Click1(object sender, EventArgs e)
//    {
//ASPNET_Server_Control.Attributes.Add("PostBackUrl", ASPNET_Server_Control.PostBackUrl = "~/CrossTest.aspx");
    
//    }
    protected void ASPNET_Server_Control_Click2(object sender, EventArgs e)
    {
        Server.Transfer("~/CrossTest.aspx");
    }
}
