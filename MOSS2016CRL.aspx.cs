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

public partial class MOSS2016CRL : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "National Root CA: Certificate Revocation List";
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        //Response.ContentType = "application/ms-word";
        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
        Response.ContentType = "application/CRL";
        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCA(29-4-2016).crl");

        string file = "MOSSCA(29-4-2016).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCA(9-5-2016).crl");

        string file = "MOSSCA(9-5-2016).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCA(16-5-2016).crl");

        string file = "MOSSCA(16-5-2016).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCA(30-5-2016).crl");

        string file = "MOSSCA(30-5-2016).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCA(6-6-2016).crl");

        string file = "MOSSCA(6-6-2016).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCA(13-6-2016).crl");

        string file = "MOSSCA(13-6-2016).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCA(20-6-2016).crl");

        string file = "MOSSCA(20-6-2016).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCA(27-6-2016).crl");

        string file = "MOSSCA(27-6-2016).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCA(4-7-2016).crl");

        string file = "MOSSCA(4-7-2016).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCA(10-7-2016).crl");

        string file = "MOSSCA(10-7-2016).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCA(18-7-2016).crl");

        string file = "MOSSCA(18-7-2016).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCA(25-7-2016).crl");

        string file = "MOSSCA(25-7-2016).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCA(31-7-2016).crl");

        string file = "MOSSCA(31-7-2016).crl";
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
    protected void LinkButton17_Click(object sender, EventArgs e)
    {
        //Response.ContentType = "application/ms-word";
        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
        Response.ContentType = "application/CRL";
        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCA(8-8-2016).crl");

        string file = "MOSSCA(8-8-2016).crl";
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
        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCA(15-8-2016).crl");

        string file = "MOSSCA(15-8-2016).crl";
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
