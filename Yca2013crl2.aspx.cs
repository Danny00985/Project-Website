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

public partial class Yca2013crl2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "National Root CA: Certificate Revocation List";
    }
    protected void linkButton53_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(13-5-2013).crl");

            string file = "YCA(13-5-2013).crl";
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
    protected void linkButton54_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(20-5-2013).crl");

            string file = "YCA(20-5-2013).crl";
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
    protected void linkButton55_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(27-5-2013).crl");

            string file = "YCA(27-5-2013).crl";
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
    protected void linkButton56_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(3-6-2013).crl");

            string file = "YCA(3-6-2013).crl";
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
    protected void linkButton57_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(10-6-2013).crl");

            string file = "YCA(10-6-2013).crl";
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
    protected void linkButton58_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(17-6-2013).crl");

            string file = "YCA(17-6-2013).crl";
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
    protected void linkButton59_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(24-6-2013).crl");

            string file = "YCA(24-6-2013).crl";
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
    protected void linkButton60_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(1-7-2013).crl");

            string file = "YCA(1-7-2013).crl";
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
    protected void linkButton61_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(8-7-2013).crl");

            string file = "YCA(8-7-2013).crl";
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
    protected void linkButton62_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(15-7-2013).crl");

            string file = "YCA(15-7-2013).crl";
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
    protected void linkButton63_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(23-7-2013).crl");

            string file = "YCA(23-7-2013).crl";
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
    protected void linkButton64_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(29-7-2013).crl");

            string file = "YCA(29-7-2013).crl";
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
    protected void linkButton65_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(5-8-2013).crl");

            string file = "YCA(5-8-2013).crl";
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
    protected void linkButton66_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(12-8-2013).crl");

            string file = "YCA(12-8-2013).crl";
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
    protected void linkButton67_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(19-8-2013).crl");

            string file = "YCA(19-8-2013).crl";
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
    protected void linkButton68_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(26-8-2013).crl");

            string file = "YCA(26-8-2013).crl";
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
    protected void linkButton69_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(2-9-2013).crl");

            string file = "YCA(2-9-2013).crl";
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
