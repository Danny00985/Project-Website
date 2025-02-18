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

public partial class ShowMessage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public string RedirectURL
    {
        get
        {
            if (string.IsNullOrEmpty(Request.QueryString["RedirectUrl"]))
                return "~/Search.aspx";
            return Request.QueryString["RedirectUrl"];
        }
    }

    public string Message
    {
        get
        {
            if (string.IsNullOrEmpty(Request.QueryString["Message"]))
                return string.Empty;
            return Request.QueryString["Message"];
        }
    }


    protected void Btn_Click(object sender, EventArgs e)
    {
        Response.Redirect(RedirectURL);
    }
}
