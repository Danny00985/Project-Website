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

public partial class Yca2012crl : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "National Root CA: Certificate Revocation List";
    }
    protected void LinkButton19_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(10-9-2012).crl");

            string file = "YCA(10-9-2012).crl";
            string folderpath = Server.MapPath("~/Download");
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

    protected void LinkButton20_Click1(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(17-9-2012).crl");

            string file = "YCA(17-9-2012).crl";
            string folderpath = Server.MapPath("~/Download");
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
    protected void LinkButton21_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(24-9-2012).crl");

            string file = "YCA(24-9-2012).crl";
            string folderpath = Server.MapPath("~/Download");
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
    protected void LinkButton22_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(1-10-2012).crl");

            string file = "YCA(1-10-2012).crl";
            string folderpath = Server.MapPath("~/Download");
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
    protected void LinkButton23_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(8-10-2012).crl");

            string file = "YCA(8-10-2012).crl";
            string folderpath = Server.MapPath("~/Download");
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
    protected void LinkButton24_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(15-10-2012).crl");

            string file = "YCA(15-10-2012).crl";
            string folderpath = Server.MapPath("~/Download");
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
    protected void LinkButton25_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(22-10-2012).crl");

            string file = "YCA(22-10-2012).crl";
            string folderpath = Server.MapPath("~/Download");
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
    protected void LinkButton26_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(29-10-2012).crl");

            string file = "YCA(29-10-2012).crl";
            string folderpath = Server.MapPath("~/Download");
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
    protected void LinkButton27_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(5-11-2012).crl");

            string file = "YCA(5-11-2012).crl";
            string folderpath = Server.MapPath("~/Download");
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
    protected void LinkButton28_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(12-11-2012).crl");

            string file = "YCA(12-11-2012).crl";
            string folderpath = Server.MapPath("~/Download");
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
    protected void LinkButton29_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(19-11-2012).crl");

            string file = "YCA(19-11-2012).crl";
            string folderpath = Server.MapPath("~/Download");
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
    protected void LinkButton30_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(26-11-2012).crl");

            string file = "YCA(26-11-2012).crl";
            string folderpath = Server.MapPath("~/Download");
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
    protected void linkButton31_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(3-12-2012).crl");

            string file = "YCA(3-12-2012).crl";
            string folderpath = Server.MapPath("~/Download");
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
    protected void linkButton32_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(10-12-2012).crl");

            string file = "YCA(10-12-2012).crl";
            string folderpath = Server.MapPath("~/Download");
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
    protected void linkButton33_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(17-12-2012).crl");

            string file = "YCA(17-12-2012).crl";
            string folderpath = Server.MapPath("~/Download");
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
    protected void linkButton34_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(24-12-2012).crl");

            string file = "YCA(24-12-2012).crl";
            string folderpath = Server.MapPath("~/Download");
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
    protected void linkButton35_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(31-12-2012).crl");

            string file = "YCA(31-12-2012).crl";
            string folderpath = Server.MapPath("~/Download");
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
