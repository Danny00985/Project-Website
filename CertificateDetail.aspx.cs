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
using RootCA.BusinessLogic;



public partial class CertificateDetail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "National Root CA: Certificate Detail";

        lblMessage.Visible = false;
        if ((PreviousPage != null)) /*|| (PreviousPage.IsCrossPagePostBack)*/
        {
            certificates prevPage = PreviousPage;
            // we can now use the values from textboxes and display them in two Label controls..
            lblName.Text = prevPage.CommonName;

            lblEmail.Text = prevPage.Email;

            lblNumber.Text = prevPage.SerialNo;
            lblIssuer.Text = prevPage.Issuer;
        }
        if (lblName.Text !=string.Empty && lblIssuer.Text !=string.Empty )
        {
            dvCertificate_DataBindByName();
        }
        else if (lblEmail.Text != string.Empty && lblIssuer.Text != string.Empty)
        {
            dvCertificate_DataBindByEmail();
        }
        else
        {
            dvCertificate_DataBindBySerialNo();
        }
        
    }

    private void dvCertificate_DataBindBySerialNo()
    {
        try
        {
            if (lblNumber.Text == "")
            {
                dvCertificate.Visible = false;
            }
            else
            {
                RootController controller = new RootController();
                System.Collections.Generic.List<RootInfo> rootlist = new System.Collections.Generic.List<RootInfo>();
                
                rootlist.Add(controller.SelectBySerialNo(lblNumber.Text,lblIssuer.Text));
                dvCertificate.DataSource = rootlist;
                dvCertificate.Visible = true;
                dvCertificate.DataSource = rootlist;
                dvCertificate.DataBind();

                RootInfo info = controller.SelectBySerialNo(lblNumber.Text,lblIssuer.Text);
                Label1.Text = info.Name;
            }
        }
        catch (Exception ex)
        {
            dvCertificate.Visible = false;
            lblMessage.Visible = true;
            lblMessage.Text = ex.Message;
            butDownload.Visible = false;
            return;
        }
    }

    private void dvCertificate_DataBindByEmail()
    {
        try
        {
            if (lblEmail.Text ==string.Empty && lblIssuer.Text==string.Empty)
            {
                dvCertificate.Visible = false;
            }
            else
            {
                RootController controller = new RootController();
                System.Collections.Generic.List<RootInfo> rootlist = new System.Collections.Generic.List<RootInfo>();
                rootlist.Add(controller.SelectByEmail(lblEmail.Text, lblIssuer.Text));
                dvCertificate.DataSource = rootlist;
                dvCertificate.Visible = true;
                dvCertificate.DataSource = rootlist;
                dvCertificate.DataBind();

                RootInfo info = controller.SelectByEmail(lblEmail.Text, lblIssuer.Text);
                Label1.Text = info.Name;
            }
        }
        catch (Exception ex)
        {
            dvCertificate.Visible = false;
            lblMessage.Visible = true;
            lblMessage.Text = ex.Message;
            butDownload.Visible = false;
            return;
        }
    }

    private void dvCertificate_DataBindByName()
    {
        try
        {
            if (lblName.Text == "")
            {
                dvCertificate.Visible = false;
                
            }
            else
            {
                RootController controller = new RootController();
                System.Collections.Generic.List<RootInfo> rootlist = new System.Collections.Generic.List<RootInfo>();
                rootlist.Add(controller.SelectByCert_Name(lblName.Text, lblIssuer.Text));
                dvCertificate.DataSource = rootlist;
                dvCertificate.Visible = true;
                dvCertificate.DataSource = rootlist;
                dvCertificate.DataBind();

                RootInfo info = controller.SelectByCert_Name(lblName.Text, lblIssuer.Text);
                Label1.Text = info.Name;
               

            }
        }
        catch (Exception ex)
        {
            dvCertificate.Visible = false;
            lblMessage.Visible = true;
            lblMessage.Text = ex.Message;
            butDownload.Visible=false;
            return;
        }
    }

    protected void butDownload_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            //RootInfo info = new RootInfo();
            
            
            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/certificate";
            Response.AddHeader("content-disposition", "attachment; filename=" +Label1.Text);

            string file = Label1.Text;
            string folderpath = Server.MapPath("~/Certificates");            
            string f = (folderpath + "/" + file);

            FileStream sourceFile = new FileStream(@f, FileMode.Open);
            //"..\Certificate\" + label2.text + ".cer"
            //FileStream sourceFile = new FileStream(@"Certificates\" + Label2.Text + ".cer", FileMode.Open);

            //String file = Label2.Text;
            //String folderpath = Server.MapPath("~/Certificates");
            //FileInfo f = new fileinfo(folderpath + "/", file);


            long FileSize;
            FileSize = sourceFile.Length;
            byte[] getContent = new byte[(int)FileSize];
            sourceFile.Read(getContent, 0, (int)sourceFile.Length);
            sourceFile.Close();

            Response.BinaryWrite(getContent);
        }
    }
    protected void dvCertificate_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
    {

    }
}
