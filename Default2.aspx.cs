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

public partial class Default2 : System.Web.UI.Page
{
    String UMID
    {
        get
        {
            if (Request.QueryString["ID"] != null)
                return Request.QueryString["ID"];
            return String.Empty;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (UMID != String.Empty)
                fillData();

            SetPageTitle();
        }

    }
    void fillData()
    {
        RootController Controller = new RootController();
        RootInfo info = Controller.SelectList();

        Label1.Text = info.SEmail;
        Label2.Text = info.Cert_Name;
        Label3.Text = info.SOrganization;
        Label4.Text = info.SOUnit;
        Label5.Text = info.SCity;
        Label6.Text = info.SState;
        Label7.Text = info.SCountry;
        Label8.Text = info.Serial_Num;
        Label9.Text = info.Valid_From.ToString();
        Label10.Text = info.Valid_To.ToString();
        Label11.Text = info.ThumbPrint;
        Label12.Text = info.Name;

    }
    //void fillData()
    //{
    //    DetailController Controller = new DetailController();
    //    DetailInfo info = Controller.DetailbyCert_Name(UMID);
    //    Label1.Text = info.SEmail;
    //    Label2.Text = info.Cert_Name;
    //    Label3.Text = info.SOrganization;
    //    Label4.Text = info.SOUnit;
    //    Label5.Text = info.SCity;
    //    Label6.Text = info.SState;
    //    Label7.Text = info.SCountry;
    //    Label8.Text= info.Serial_Num;
    //    Label9.Text = info.Valid_From.ToString();
    //    Label10.Text = info.Valid_To.ToString();
    //    Label11.Text = info.ThumbPrint;
    //}
    void SetPageTitle()
    {
        this.Title = "Myanmar Root CA Certifying Authorities"; 
    }

    //protected void HyperLink1_Load(object sender, EventArgs e)
    //{
    //    if (Page.IsPostBack)
    //    {

    //        Response.ContentType = "application/ms-word";
    //        Response.AddHeader("content-disposition", "attachment; filename=download.doc");

    //        FileStream sourceFile = new FileStream(@"C:\Documents and Settings\Administrator\Desktop\New Folder0\main3.gif", FileMode.Open);
    //        long FileSize;
    //        FileSize = sourceFile.Length;
    //        byte[] getContent = new byte[(int)FileSize];
    //        sourceFile.Read(getContent, 0, (int)sourceFile.Length);
    //        sourceFile.Close();

    //        Response.BinaryWrite(getContent);
    //    }
    //}
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/certificate";
            Response.AddHeader("content-disposition", "attachment; filename=" + Label12.Text );

            string file = Label12.Text;
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
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/certificate";
            Response.AddHeader("content-disposition", "attachment; filename=" + Label12.Text );

            string file = Label12.Text;
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
}
