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
using RootCA.BusinessLogic;

public partial class revokedcer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SetPageTitle();
        if(!IsPostBack)
        gvcer_DataBind();
    }
    
    protected void gvcer_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvcer.PageIndex = e.NewPageIndex;
        gvcer_DataBind();

    }
    void SetPageTitle()
    {
        this.Title = "Myanmar Root CA Certifying Authorities"; 
    }
    void gvcer_DataBind()
    {
        try
        {
            RootController controller = new RootController();
            gvcer.DataSource = controller.SelectListAll1();
            gvcer.DataBind();
        }
        catch (Exception ex)
        {
            return;
        }
    }
}
