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

public partial class YCA2017CRL : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "National Root CA: Certificate Revocation List";
    }
    protected void LinkButton17_Click(object sender, EventArgs e)
    {
        //Response.ContentType = "application/ms-word";
        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
        Response.ContentType = "application/CRL";
        Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(9-1-2017).crl");

        string file = "YCA(9-1-2017).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(16-1-2017).crl");

        string file = "YCA(16-1-2017).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(23-1-2017).crl");

        string file = "YCA(23-1-2017).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(30-1-2017).crl");

        string file = "YCA(30-1-2017).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(6-2-2017).crl");

        string file = "YCA(6-2-2017).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(13-2-2017).crl");

        string file = "YCA(13-2-2017).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(20-2-2017).crl");

        string file = "YCA(20-2-2017).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(27-2-2017).crl");

        string file = "YCA(27-2-2017).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(6-3-2017).crl");

        string file = "YCA(6-3-2017).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(13-3-2017).crl");

        string file = "YCA(13-3-2017).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(20-3-2017_3-4-2017).crl");

        string file = "YCA(20-3-2017_3-4-2017).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(3-4-2017_24-4-2017).crl");

        string file = "YCA(3-4-2017_24-4-2017).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(24-4-2017_8-5-2017).crl");

        string file = "YCA(24-4-2017_8-5-2017).crl";
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
    protected void LinkButton16_Click(object sender, EventArgs e)
    {
        //Response.ContentType = "application/ms-word";
        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
        Response.ContentType = "application/CRL";
        Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(8-5-2017).crl");

        string file = "YCA(8-5-2017).crl";
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
    protected void LinkButton18_Click(object sender, EventArgs e)
    {
        //Response.ContentType = "application/ms-word";
        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
        Response.ContentType = "application/CRL";
        Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(15-5-2017).crl");

        string file = "YCA(15-5-2017).crl";
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
