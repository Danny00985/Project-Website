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

public partial class MOSSSAH22018CRL2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "National Root CA: Certificate Revocation List";
    }
    protected void LinkButton15_Click(object sender, EventArgs e)
    {
        //Response.ContentType = "application/ms-word";
        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
        Response.ContentType = "application/CRL";
        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCASHA256(3-11-2018).crl");

        string file = "MOSSCASHA256(3-11-2018).crl";
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
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        //Response.ContentType = "application/ms-word";
        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
        Response.ContentType = "application/CRL";
        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCASHA256(10-11-2018).crl");

        string file = "MOSSCASHA256(10-11-2018).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCASHA256(16-11-2018).crl");

        string file = "MOSSCASHA256(16-11-2018).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCASHA256(23-11-2018).crl");

        string file = "MOSSCASHA256(23-11-2018).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCASHA256(30-11-2018).crl");

        string file = "MOSSCASHA256(30-11-2018).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCASHA256(7-12-2018).crl");

        string file = "MOSSCASHA256(7-12-2018).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCASHA256(14-12-2018).crl");

        string file = "MOSSCASHA256(14-12-2018).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCASHA256(20-12-2018).crl");

        string file = "MOSSCASHA256(20-12-2018).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCASHA256(1-1-2019).crl");

        string file = "MOSSCASHA256(1-1-2019).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCASHA256(7-1-2019).crl");

        string file = "MOSSCASHA256(7-1-2019).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCASHA256(21-1-2019).crl");

        string file = "MOSSCASHA256(21-1-2019).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCASHA256(28-1-2019).crl");

        string file = "MOSSCASHA256(28-1-2019).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCASHA256(4-2-2019).crl");

        string file = "MOSSCASHA256(4-2-2019).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCASHA256(11-2-2019).crl");

        string file = "MOSSCASHA256(11-2-2019).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCASHA256(18-2-2019).crl");

        string file = "MOSSCASHA256(18-2-2019).crl";
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
