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

public partial class YCASHA22018CRL : System.Web.UI.Page
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "Yca256(6-8-2018).crl");

        string file = "Yca256(6-8-2018).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "Yca256(3-9-2018).crl");

        string file = "Yca256(3-9-2018).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "Yca256(1-10-2018).crl");

        string file = "Yca256(1-10-2018).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "Yca256(5-11-2018).crl");

        string file = "Yca256(5-11-2018).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "Yca256(3-12-2018).crl");

        string file = "Yca256(3-12-2018).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "Yca256(7-1-2019).crl");

        string file = "Yca256(7-1-2019).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "Yca256(4-2-2019).crl");

        string file = "Yca256(4-2-2019).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "Yca256(4-3-2019).crl");

        string file = "Yca256(4-3-2019).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "Yca256(2-4-2019).crl");

        string file = "Yca256(2-4-2019).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "Yca256(6-5-2019).crl");

        string file = "Yca256(6-5-2019).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "Yca256(4-6-2019).crl");

        string file = "Yca256(4-6-2019).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "Yca256(3-7-2019).crl");

        string file = "Yca256(3-7-2019).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "yca256(3-9-2019).crl");

        string file = "yca256(3-9-2019).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "yca256 (6-11-2019).crl");

        string file = "yca256 (6-11-2019).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "yca256 (2-12-2019).crl");

        string file = "yca256 (2-12-2019).crl";
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
