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

public partial class Yca2014clr3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "National Root CA: Certificate Revocation List";
    }
    protected void linkButton87_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(6-1-2014).crl");

            string file = "YCA(6-1-2014).crl";
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
    protected void linkButton88_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(13-1-2014).crl");

            string file = "YCA(13-1-2014).crl";
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
    protected void linkButton89_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(20-1-2014).crl");

            string file = "YCA(20-1-2014).crl";
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
    protected void linkButton90_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(27-1-2014).crl");

            string file = "YCA(27-1-2014).crl";
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
    protected void linkButton91_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(3-2-2014).crl");

            string file = "YCA(3-2-2014).crl";
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
    protected void linkButton92_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(10-2-2014).crl");

            string file = "YCA(10-2-2014).crl";
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
    protected void linkButton93_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(17-2-2014).crl");

            string file = "YCA(17-2-2014).crl";
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
    protected void linkButton94_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(24-2-2014).crl");

            string file = "YCA(24-2-2014).crl";
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
    protected void linkButton95_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(3-3-2014).crl");

            string file = "YCA(3-3-2014).crl";
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
    protected void linkButton96_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(10-3-2014).crl");

            string file = "YCA(10-3-2014).crl";
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
    protected void linkButton97_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(17-3-2014).crl");

            string file = "YCA(17-3-2014).crl";
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
    protected void linkButton98_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(24-3-2014).crl");

            string file = "YCA(24-3-2014).crl";
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
    protected void linkButton99_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(31-3-2014).crl");

            string file = "YCA(31-3-2014).crl";
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
    protected void linkButton100_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(7-4-2014).crl");

            string file = "YCA(7-4-2014).crl";
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
    protected void linkButton101_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(22-4-2014).crl");

            string file = "YCA(22-4-2014).crl";
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
    protected void linkButton102_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(28-4-2014).crl");

            string file = "YCA(28-4-2014).crl";
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
    protected void linkButton104_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(5-5-2014).crl");

            string file = "YCA(5-5-2014).crl";
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
