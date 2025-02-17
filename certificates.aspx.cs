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
using System.IO;
using System.Text.RegularExpressions;
using RootCA.BusinessLogic;

public partial class certificates : System.Web.UI.Page
{
    public string Issuer
    {
        get { return ddlCA.SelectedValue; }
    }
    public string CommonName
    {
        get { return txtCommonName.Text; }
    }
    public string Email
    {
        get { return txtEmail.Text; }
    }
    public string SerialNo
    {
        get { return txtNumber.Text ; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        SetPageTitle();

        if (!IsPostBack)
        {
            ddlCA_DataBind();
        }
                
       
    }
    protected void Page_Init(object sender, EventArgs e)
    {
        
    }

    private void ddlCA_DataBind()
    {
        RootController controller = new RootController();
        //System.Collections.Generic.List<RootInfo> rootlist = new System.Collections.Generic.List<RootInfo>();
        //rootlist.Add(controller.SelectList());
        //ddlCA.DataSource = rootlist;
        ddlCA.DataSource = controller.SelectAllListinCA();
        ddlCA.DataTextField = "Cert_Name";
        ddlCA.DataValueField = "Cert_Name";
        ddlCA.DataBind();
        ddlCA.Items.Insert(0, "");
    }

       
    void SetPageTitle()
    {
        this.Title = "National Root CA: Search Certificates";
    }

    

    //protected void DetailsView1_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
    //{
    //    RootController controller = new RootController();
    //    DetailsView1.DataSource = controller.SelectListAll();
    //    DetailsView1.DataBind();
    //}
    //protected void DetailsView1_PageIndexChanged(object sender, EventArgs e)
    //{
    //    RootController controller = new RootController();
    //    DetailsView1.DataSource = controller.SelectListAll();
    //    DetailsView1.DataBind();
    //}
    //protected void DetailsView1_DataBound(object sender, EventArgs e)
    //{
    //    RootController controller = new RootController();
    //    DetailsView1.DataSource = controller.SelectListAll();
    //    DetailsView1.DataBind();
    //}
    //protected void DetailsView1_ItemCommand(object sender, DetailsViewCommandEventArgs e)
    //{
    //    RootController controller = new RootController();
    //    DetailsView1.DataSource= controller.SelectList();
    //    DetailsView1.DataBind();
    //}
    
    protected void butEmail_Click(object sender, EventArgs e)
    {
        if (Regex.IsMatch(txtEmail.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
        {

            Server.Transfer("~/CertificateDetail.aspx");
        }
        else
            return;
          
    }
    protected void butNo_Click(object sender, EventArgs e)
    {
        Server.Transfer("~/CertificateDetail.aspx");
    }
    protected void butName_Click1(object sender, EventArgs e)
    {
        
            Server.Transfer("~/CertificateDetail.aspx");
   }


    protected void ddlCA_SelectedIndexChanged(object sender, EventArgs e)
    {
        //ddlCA.SelectedIndex = ddlCA.SelectedIndex;
        //ddlOrganization_DataBind();
    }

    private void ddlOrganization_DataBind()
    {
        //RootController controller = new RootController();
        
        //ddlOrganization.DataSource = controller.SelectAllByCACert_Name(ddlCA.SelectedValue);
        //ddlOrganization.DataTextField = "SOUnit";
        //ddlOrganization.DataValueField = "SOUnit";
        //ddlOrganization.DataBind();
        //ddlOrganization.Items.Insert(0, "");
    }
    protected void txtCommonName_TextChanged(object sender, EventArgs e)
    {

    }
}
