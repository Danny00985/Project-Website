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

public partial class TESTCA : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "National Root CA: Contact Us";
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        //Response.ContentType = "application/ms-word";
        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
        Response.ContentType = "application/CRL";
        Response.AddHeader("content-disposition", "attachment; filename=" + "TESTCA(12-11-2015).crl");

        string file = "TESTCA(12-11-2015).crl";
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
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        //Response.ContentType = "application/ms-word";
        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
        Response.ContentType = "application/CRL";
        Response.AddHeader("content-disposition", "attachment; filename=" + "TESTCA(14-12-2015).crl");

        string file = "TESTCA(14-12-2015).crl";
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
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        //Response.ContentType = "application/ms-word";
        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
        Response.ContentType = "application/CRL";
        Response.AddHeader("content-disposition", "attachment; filename=" + "TESTCA (14-1-2016).crl");

        string file = "TESTCA (14-1-2016).crl";
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
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        //Response.ContentType = "application/ms-word";
        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
        Response.ContentType = "application/CRL";
        Response.AddHeader("content-disposition", "attachment; filename=" + "TESTCA(16-3-2016).crl");

        string file = "TESTCA(16-3-2016).crl";
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
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        //Response.ContentType = "application/ms-word";
        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
        Response.ContentType = "application/CRL";
        Response.AddHeader("content-disposition", "attachment; filename=" + "TESTCA(16-4-2016).crl");

        string file = "TESTCA(16-4-2016).crl";
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
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        //Response.ContentType = "application/ms-word";
        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
        Response.ContentType = "application/CRL";
        Response.AddHeader("content-disposition", "attachment; filename=" + "TESTCA(16-5-2016).crl");

        string file = "TESTCA(16-5-2016).crl";
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
    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        //Response.ContentType = "application/ms-word";
        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
        Response.ContentType = "application/CRL";
        Response.AddHeader("content-disposition", "attachment; filename=" + "TESTCA(16-6-2016).crl");

        string file = "TESTCA(16-6-2016).crl";
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
    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        //Response.ContentType = "application/ms-word";
        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
        Response.ContentType = "application/CRL";
        Response.AddHeader("content-disposition", "attachment; filename=" + "TESTCA(20-7-2016).crl");

        string file = "TESTCA(20-7-2016).crl";
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
    protected void LinkButton9_Click(object sender, EventArgs e)
    {
        //Response.ContentType = "application/ms-word";
        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
        Response.ContentType = "application/CRL";
        Response.AddHeader("content-disposition", "attachment; filename=" + "TESTCA(22-8-2016).crl");

        string file = "TESTCA(22-8-2016).crl";
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
    protected void LinkButton10_Click(object sender, EventArgs e)
    {
        //Response.ContentType = "application/ms-word";
        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
        Response.ContentType = "application/CRL";
        Response.AddHeader("content-disposition", "attachment; filename=" + "TESTCA(26-9-2016).crl");

        string file = "TESTCA(26-9-2016).crl";
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
    protected void LinkButton11_Click(object sender, EventArgs e)
    {
        //Response.ContentType = "application/ms-word";
        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
        Response.ContentType = "application/CRL";
        Response.AddHeader("content-disposition", "attachment; filename=" + "TESTCA(25-10-2016).crl");

        string file = "TESTCA(25-10-2016).crl";
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
    protected void LinkButton12_Click(object sender, EventArgs e)
    {
        //Response.ContentType = "application/ms-word";
        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
        Response.ContentType = "application/CRL";
        Response.AddHeader("content-disposition", "attachment; filename=" + "TESTCA(25-11-2016).crl");

        string file = "TESTCA(25-11-2016).crl";
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
    protected void LinkButton13_Click(object sender, EventArgs e)
    {
        //Response.ContentType = "application/ms-word";
        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
        Response.ContentType = "application/CRL";
        Response.AddHeader("content-disposition", "attachment; filename=" + "TESTCA(28-12-2016).crl");

        string file = "TESTCA(28-12-2016).crl";
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
    protected void LinkButton14_Click(object sender, EventArgs e)
    {
        //Response.ContentType = "application/ms-word";
        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
        Response.ContentType = "application/CRL";
        Response.AddHeader("content-disposition", "attachment; filename=" + "TESTCA(30-1-2017).crl");

        string file = "TESTCA(30-1-2017).crl";
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
    protected void LinkButton15_Click(object sender, EventArgs e)
    {
        //Response.ContentType = "application/ms-word";
        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
        Response.ContentType = "application/CRL";
        Response.AddHeader("content-disposition", "attachment; filename=" + "TESTCA(1-3-2017).crl");

        string file = "TESTCA(1-3-2017).crl";
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
