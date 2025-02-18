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

public partial class Yca2014crl2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "National Root CA: Certificate Revocation List";
    }
    protected void linkButton105_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(12-5-2014).crl");

            string file = "YCA(12-5-2014).crl";
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
    protected void linkButton103_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(19-5-2014).crl");

            string file = "YCA(19-5-2014).crl";
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
    protected void linkButton106_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(26-5-2014).crl");

            string file = "YCA(26-5-2014).crl";
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
    protected void linkButton107_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(2-6-2014).crl");

            string file = "YCA(2-6-2014).crl";
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
    protected void linkButton108_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(9-6-2014).crl");

            string file = "YCA(9-6-2014).crl";
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
    protected void linkButton109_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(16-6-2014).crl");

            string file = "YCA(16-6-2014).crl";
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
    protected void linkButton110_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(23-6-2014).crl");

            string file = "YCA(23-6-2014).crl";
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
    protected void linkButton111_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(30-6-2014).crl");

            string file = "YCA(30-6-2014).crl";
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
    protected void linkButton112_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(7-7-2014).crl");

            string file = "YCA(7-7-2014).crl";
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
    protected void linkButton113_Click(object sender, EventArgs e)
    {

        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(14-7-2014).crl");

            string file = "YCA(14-7-2014).crl";
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
    protected void linkButton114_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(21-7-2014).crl");

            string file = "YCA(21-7-2014).crl";
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
    protected void linkButton115_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(28-7-2014).crl");

            string file = "YCA(28-7-2014).crl";
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
    protected void linkButton116_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(4-8-2014).crl");

            string file = "YCA(4-8-2014).crl";
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
    protected void linkButton117_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(11-8-2014).crl");

            string file = "YCA(11-8-2014).crl";
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
    protected void linkButton118_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(18-8-2014).crl");

            string file = "YCA(18-8-2014).crl";
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
    protected void linkButton119_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(25-8-2014).crl");

            string file = "YCA(25-8-2014).crl";
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
    protected void linkButton120_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(1-9-2014).crl");

            string file = "YCA(1-9-2014).crl";
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
