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

public partial class crlnew : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "National Root CA: Certificate Revocation List";
    }
    protected void Root_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "MyanmarRootCA2010(20-1-2011).crl");

            string file = "MyanmarRootCA2010(20-1-2011).crl";
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
   
    //protected void MOSS_Click(object sender, EventArgs e)
    //{

    //}
    //protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    //{
    //    if (Page.IsPostBack)
    //    {

    //        //Response.ContentType = "application/ms-word";
    //        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
    //        Response.ContentType = "application/CRL";
    //        Response.AddHeader("content-disposition", "attachment; filename=" + "MyanmarRootCA2010.crl");

    //        string file = "MyanmarRootCA2010.crl";
    //        string folderpath = Server.MapPath("~/Download");
    //        string f = (folderpath + "/" + file);

    //        FileStream sourceFile = new FileStream(@f, FileMode.Open);
    //        //"..\Certificate\" + label2.text + ".cer"
    //        //FileStream sourceFile = new FileStream(@"Certificates\" + Label2.Text + ".cer", FileMode.Open);

    //        //String file = Label2.Text;
    //        //String folderpath = Server.MapPath("~/Certificates");
    //        //FileInfo f = new fileinfo(folderpath + "/", file);


    //        long FileSize;
    //        FileSize = sourceFile.Length;
    //        byte[] getContent = new byte[(int)FileSize];
    //        sourceFile.Read(getContent, 0, (int)sourceFile.Length);
    //        sourceFile.Close();

    //        Response.BinaryWrite(getContent);
    //    }
    //}
    

    //protected void YCA_Click(object sender, EventArgs e)
    //{
    //    if (Page.IsPostBack)
    //    {

    //        //Response.ContentType = "application/ms-word";
    //        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
    //        Response.ContentType = "application/CRL";
    //        Response.AddHeader("content-disposition", "attachment; filename=" + "YCA.crl");

    //        string file = "YCA.crl";
    //        string folderpath = Server.MapPath("~/Download");
    //        string f = (folderpath + "/" + file);

    //        FileStream sourceFile = new FileStream(@f, FileMode.Open);
    //        //"..\Certificate\" + label2.text + ".cer"
    //        //FileStream sourceFile = new FileStream(@"Certificates\" + Label2.Text + ".cer", FileMode.Open);

    //        //String file = Label2.Text;
    //        //String folderpath = Server.MapPath("~/Certificates");
    //        //FileInfo f = new fileinfo(folderpath + "/", file);


    //        long FileSize;
    //        FileSize = sourceFile.Length;
    //        byte[] getContent = new byte[(int)FileSize];
    //        sourceFile.Read(getContent, 0, (int)sourceFile.Length);
    //        sourceFile.Close();

    //        Response.BinaryWrite(getContent);
    //    }
    //}
   // protected void LinkButton1_Click(object sender, EventArgs e)
   // {
   //    if (Page.IsPostBack)
   // {

   //     //Response.ContentType = "application/ms-word";
   //       //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
   //        Response.ContentType = "application/CRL";
   //      Response.AddHeader("content-disposition", "attachment; filename=" + "MyanmarRootCA2010.crl");

   //        string file = "MyanmarRootCA2010.crl";
   //        string folderpath = Server.MapPath("~/Download");
   //        string f = (folderpath + "/" + file);

   //        FileStream sourceFile = new FileStream(@f, FileMode.Open);
   //     //"..\Certificate\" + label2.text + ".cer"
   //         //FileStream sourceFile = new FileStream(@"Certificates\" + Label2.Text + ".cer", FileMode.Open);

   //     //String file = Label2.Text;
   //      //String folderpath = Server.MapPath("~/Certificates");
   //       //FileInfo f = new fileinfo(folderpath + "/", file);


   //      long FileSize;
   //        FileSize = sourceFile.Length;
   //       byte[] getContent = new byte[(int)FileSize];
   //      sourceFile.Read(getContent, 0, (int)sourceFile.Length);
   //      sourceFile.Close();

   //       Response.BinaryWrite(getContent);
   //    }
   //}
    //protected void MOSSCA_Click(object sender, EventArgs e)
    //{
    //    if (Page.IsPostBack)
    //    {

    //        //Response.ContentType = "application/ms-word";
    //        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
    //        Response.ContentType = "application/CRL";
    //        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCA.crl");

    //        string file = "MOSSCA.crl";
    //        string folderpath = Server.MapPath("~/Download");
    //        string f = (folderpath + "/" + file);

    //        FileStream sourceFile = new FileStream(@f, FileMode.Open);
    //        //"..\Certificate\" + label2.text + ".cer"
    //        //FileStream sourceFile = new FileStream(@"Certificates\" + Label2.Text + ".cer", FileMode.Open);

    //        //String file = Label2.Text;
    //        //String folderpath = Server.MapPath("~/Certificates");
    //        //FileInfo f = new fileinfo(folderpath + "/", file);


    //        long FileSize;
    //        FileSize = sourceFile.Length;
    //        byte[] getContent = new byte[(int)FileSize];
    //        sourceFile.Read(getContent, 0, (int)sourceFile.Length);
    //        sourceFile.Close();

    //        Response.BinaryWrite(getContent);
    //    }
    //}
    //protected void LinkButton2_Click(object sender, EventArgs e)
    //{
    //    if (Page.IsPostBack)
    //    {

    //        //Response.ContentType = "application/ms-word";
    //        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
    //        Response.ContentType = "application/CRL";
    //        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCA(25-4-2012).crl");

    //        string file = "MOSSCA(25-4-2012).crl";
    //        string folderpath = Server.MapPath("~/Download");
    //        string f = (folderpath + "/" + file);

    //        FileStream sourceFile = new FileStream(@f, FileMode.Open);
    //        //"..\Certificate\" + label2.text + ".cer"
    //        //FileStream sourceFile = new FileStream(@"Certificates\" + Label2.Text + ".cer", FileMode.Open);

    //        //String file = Label2.Text;
    //        //String folderpath = Server.MapPath("~/Certificates");
    //        //FileInfo f = new fileinfo(folderpath + "/", file);


    //        long FileSize;
    //        FileSize = sourceFile.Length;
    //        byte[] getContent = new byte[(int)FileSize];
    //        sourceFile.Read(getContent, 0, (int)sourceFile.Length);
    //        sourceFile.Close();

    //        Response.BinaryWrite(getContent);
    //    }
    //}
    //protected void LinkButton3_Click(object sender, EventArgs e)
    //{
    //    if (Page.IsPostBack)
    //    {

    //        //Response.ContentType = "application/ms-word";
    //        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
    //        Response.ContentType = "application/CRL";
    //        Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(7-5-2012).crl");

    //        string file = "YCA(7-5-2012).crl";
    //        string folderpath = Server.MapPath("~/Download");
    //        string f = (folderpath + "/" + file);

    //        FileStream sourceFile = new FileStream(@f, FileMode.Open);
    //        //"..\Certificate\" + label2.text + ".cer"
    //        //FileStream sourceFile = new FileStream(@"Certificates\" + Label2.Text + ".cer", FileMode.Open);

    //        //String file = Label2.Text;
    //        //String folderpath = Server.MapPath("~/Certificates");
    //        //FileInfo f = new fileinfo(folderpath + "/", file);


    //        long FileSize;
    //        FileSize = sourceFile.Length;
    //        byte[] getContent = new byte[(int)FileSize];
    //        sourceFile.Read(getContent, 0, (int)sourceFile.Length);
    //        sourceFile.Close();

    //        Response.BinaryWrite(getContent);
    //    }
    //}
    //protected void LinkButton4_Click(object sender, EventArgs e)
    //{
    //    if (Page.IsPostBack)
    //    {

    //        //Response.ContentType = "application/ms-word";
    //        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
    //        Response.ContentType = "application/CRL";
    //        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCA(15-5-2012).crl");

    //        string file = "MOSSCA(15-5-2012).crl";
    //        string folderpath = Server.MapPath("~/Download");
    //        string f = (folderpath + "/" + file);

    //        FileStream sourceFile = new FileStream(@f, FileMode.Open);
    //        //"..\Certificate\" + label2.text + ".cer"
    //        //FileStream sourceFile = new FileStream(@"Certificates\" + Label2.Text + ".cer", FileMode.Open);

    //        //String file = Label2.Text;
    //        //String folderpath = Server.MapPath("~/Certificates");
    //        //FileInfo f = new fileinfo(folderpath + "/", file);


    //        long FileSize;
    //        FileSize = sourceFile.Length;
    //        byte[] getContent = new byte[(int)FileSize];
    //        sourceFile.Read(getContent, 0, (int)sourceFile.Length);
    //        sourceFile.Close();

    //        Response.BinaryWrite(getContent);
    //    }
    //}
    ///// <summary>
    ///// For YCA Function
    ///// </summary>
    ///// <param name="sender"></param>
    ///// <param name="e"></param>
    //protected void LinkButton5_Click(object sender, EventArgs e)
    //{
    //    if (Page.IsPostBack)
    //    {

    //        //Response.ContentType = "application/ms-word";
    //        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
    //        Response.ContentType = "application/CRL";
    //        Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(14-5-2012).crl");

    //        string file = "YCA(14-5-2012).crl";
    //        string folderpath = Server.MapPath("~/Download");
    //        string f = (folderpath + "/" + file);

    //        FileStream sourceFile = new FileStream(@f, FileMode.Open);
    //        //"..\Certificate\" + label2.text + ".cer"
    //        //FileStream sourceFile = new FileStream(@"Certificates\" + Label2.Text + ".cer", FileMode.Open);

    //        //String file = Label2.Text;
    //        //String folderpath = Server.MapPath("~/Certificates");
    //        //FileInfo f = new fileinfo(folderpath + "/", file);


    //        long FileSize;
    //        FileSize = sourceFile.Length;
    //        byte[] getContent = new byte[(int)FileSize];
    //        sourceFile.Read(getContent, 0, (int)sourceFile.Length);
    //        sourceFile.Close();

    //        Response.BinaryWrite(getContent);
    //    }
    //}
    //protected void LinkButton6_Click(object sender, EventArgs e)
    //{
    //    ShowCRLFileforMOSS();
    //}

    ///// <summary>
    ///// For MOSSCA Function
    ///// </summary>
    //private void ShowCRLFileforMOSS()
    //{
    //    if (Page.IsPostBack)
    //    {

    //        //Response.ContentType = "application/ms-word";
    //        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
    //        Response.ContentType = "application/CRL";
    //        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCA(28-05-2012).crl");

    //        string file = "MOSSCA(28-05-2012).crl";
    //        string folderpath = Server.MapPath("~/Download");
    //        string f = (folderpath + "/" + file);

    //        FileStream sourceFile = new FileStream(@f, FileMode.Open);
    //        //"..\Certificate\" + label2.text + ".cer"
    //        //FileStream sourceFile = new FileStream(@"Certificates\" + Label2.Text + ".cer", FileMode.Open);

    //        //String file = Label2.Text;
    //        //String folderpath = Server.MapPath("~/Certificates");
    //        //FileInfo f = new fileinfo(folderpath + "/", file);


    //        long FileSize;
    //        FileSize = sourceFile.Length;
    //        byte[] getContent = new byte[(int)FileSize];
    //        sourceFile.Read(getContent, 0, (int)sourceFile.Length);
    //        sourceFile.Close();

    //        Response.BinaryWrite(getContent);
    //    }
    //}


    //protected void LinkButton7_Click(object sender, EventArgs e)
    //{
    //    if (Page.IsPostBack)
    //    {

    //        //Response.ContentType = "application/ms-word";
    //        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
    //        Response.ContentType = "application/CRL";
    //        Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(21-5-2012).crl");

    //        string file = "YCA(21-5-2012).crl";
    //        string folderpath = Server.MapPath("~/Download");
    //        string f = (folderpath + "/" + file);

    //        FileStream sourceFile = new FileStream(@f, FileMode.Open);
    //        //"..\Certificate\" + label2.text + ".cer"
    //        //FileStream sourceFile = new FileStream(@"Certificates\" + Label2.Text + ".cer", FileMode.Open);

    //        //String file = Label2.Text;
    //        //String folderpath = Server.MapPath("~/Certificates");
    //        //FileInfo f = new fileinfo(folderpath + "/", file);


    //        long FileSize;
    //        FileSize = sourceFile.Length;
    //        byte[] getContent = new byte[(int)FileSize];
    //        sourceFile.Read(getContent, 0, (int)sourceFile.Length);
    //        sourceFile.Close();

    //        Response.BinaryWrite(getContent);
    //    }
    //}
    //protected void LinkButton8_Click(object sender, EventArgs e)
    //{
    //    if (Page.IsPostBack)
    //    {

    //        //Response.ContentType = "application/ms-word";
    //        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
    //        Response.ContentType = "application/CRL";
    //        Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(28-5-2012).crl");

    //        string file = "YCA(28-5-2012).crl";
    //        string folderpath = Server.MapPath("~/Download");
    //        string f = (folderpath + "/" + file);

    //        FileStream sourceFile = new FileStream(@f, FileMode.Open);
    //        //"..\Certificate\" + label2.text + ".cer"
    //        //FileStream sourceFile = new FileStream(@"Certificates\" + Label2.Text + ".cer", FileMode.Open);

    //        //String file = Label2.Text;
    //        //String folderpath = Server.MapPath("~/Certificates");
    //        //FileInfo f = new fileinfo(folderpath + "/", file);


    //        long FileSize;
    //        FileSize = sourceFile.Length;
    //        byte[] getContent = new byte[(int)FileSize];
    //        sourceFile.Read(getContent, 0, (int)sourceFile.Length);
    //        sourceFile.Close();

    //        Response.BinaryWrite(getContent);
    //    }
    //}
    //protected void LinkButton9_Click(object sender, EventArgs e)
    //{
    //    if (Page.IsPostBack)
    //    {

    //        //Response.ContentType = "application/ms-word";
    //        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
    //        Response.ContentType = "application/CRL";
    //        Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(4-6-2012).crl");

    //        string file = "YCA(4-6-2012).crl";
    //        string folderpath = Server.MapPath("~/Download");
    //        string f = (folderpath + "/" + file);

    //        FileStream sourceFile = new FileStream(@f, FileMode.Open);
    //        //"..\Certificate\" + label2.text + ".cer"
    //        //FileStream sourceFile = new FileStream(@"Certificates\" + Label2.Text + ".cer", FileMode.Open);

    //        //String file = Label2.Text;
    //        //String folderpath = Server.MapPath("~/Certificates");
    //        //FileInfo f = new fileinfo(folderpath + "/", file);


    //        long FileSize;
    //        FileSize = sourceFile.Length;
    //        byte[] getContent = new byte[(int)FileSize];
    //        sourceFile.Read(getContent, 0, (int)sourceFile.Length);
    //        sourceFile.Close();

    //        Response.BinaryWrite(getContent);
    //    }
    //}
    //protected void LinkButton10_Click(object sender, EventArgs e)
    //{
    //    if (Page.IsPostBack)
    //    {

    //        //Response.ContentType = "application/ms-word";
    //        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
    //        Response.ContentType = "application/CRL";
    //        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCA(6-6-2012).crl");

    //        string file = "MOSSCA(6-6-2012).crl";
    //        string folderpath = Server.MapPath("~/Download");
    //        string f = (folderpath + "/" + file);

    //        FileStream sourceFile = new FileStream(@f, FileMode.Open);
    //        //"..\Certificate\" + label2.text + ".cer"
    //        //FileStream sourceFile = new FileStream(@"Certificates\" + Label2.Text + ".cer", FileMode.Open);

    //        //String file = Label2.Text;
    //        //String folderpath = Server.MapPath("~/Certificates");
    //        //FileInfo f = new fileinfo(folderpath + "/", file);


    //        long FileSize;
    //        FileSize = sourceFile.Length;
    //        byte[] getContent = new byte[(int)FileSize];
    //        sourceFile.Read(getContent, 0, (int)sourceFile.Length);
    //        sourceFile.Close();

    //        Response.BinaryWrite(getContent);
    //    }
    //}
    //protected void LinkButton11_Click(object sender, EventArgs e)
    //{
    //    if (Page.IsPostBack)
    //    {

    //        //Response.ContentType = "application/ms-word";
    //        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
    //        Response.ContentType = "application/CRL";
    //        Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(11-6-2012).crl");

    //        string file = "YCA(11-6-2012).crl";
    //        string folderpath = Server.MapPath("~/Download");
    //        string f = (folderpath + "/" + file);

    //        FileStream sourceFile = new FileStream(@f, FileMode.Open);
    //        //"..\Certificate\" + label2.text + ".cer"
    //        //FileStream sourceFile = new FileStream(@"Certificates\" + Label2.Text + ".cer", FileMode.Open);

    //        //String file = Label2.Text;
    //        //String folderpath = Server.MapPath("~/Certificates");
    //        //FileInfo f = new fileinfo(folderpath + "/", file);


    //        long FileSize;
    //        FileSize = sourceFile.Length;
    //        byte[] getContent = new byte[(int)FileSize];
    //        sourceFile.Read(getContent, 0, (int)sourceFile.Length);
    //        sourceFile.Close();

    //        Response.BinaryWrite(getContent);
    //    }
    //}
    //protected void LinkButton12_Click(object sender, EventArgs e)
    //{
    //    if (Page.IsPostBack)
    //    {

    //        //Response.ContentType = "application/ms-word";
    //        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
    //        Response.ContentType = "application/CRL";
    //        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCA(12-6-2012).crl");

    //        string file = "MOSSCA(12-6-2012).crl";
    //        string folderpath = Server.MapPath("~/Download");
    //        string f = (folderpath + "/" + file);

    //        FileStream sourceFile = new FileStream(@f, FileMode.Open);
    //        //"..\Certificate\" + label2.text + ".cer"
    //        //FileStream sourceFile = new FileStream(@"Certificates\" + Label2.Text + ".cer", FileMode.Open);

    //        //String file = Label2.Text;
    //        //String folderpath = Server.MapPath("~/Certificates");
    //        //FileInfo f = new fileinfo(folderpath + "/", file);


    //        long FileSize;
    //        FileSize = sourceFile.Length;
    //        byte[] getContent = new byte[(int)FileSize];
    //        sourceFile.Read(getContent, 0, (int)sourceFile.Length);
    //        sourceFile.Close();

    //        Response.BinaryWrite(getContent);
    //    }
    //}
    //protected void LinkButton13_Click(object sender, EventArgs e)
    //{
    //    if (Page.IsPostBack)
    //    {

    //        //Response.ContentType = "application/ms-word";
    //        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
    //        Response.ContentType = "application/CRL";
    //        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCA(18-6-2012).crl");

    //        string file = "MOSSCA(18-6-2012).crl";
    //        string folderpath = Server.MapPath("~/Download");
    //        string f = (folderpath + "/" + file);

    //        FileStream sourceFile = new FileStream(@f, FileMode.Open);
    //        //"..\Certificate\" + label2.text + ".cer"
    //        //FileStream sourceFile = new FileStream(@"Certificates\" + Label2.Text + ".cer", FileMode.Open);

    //        //String file = Label2.Text;
    //        //String folderpath = Server.MapPath("~/Certificates");
    //        //FileInfo f = new fileinfo(folderpath + "/", file);


    //        long FileSize;
    //        FileSize = sourceFile.Length;
    //        byte[] getContent = new byte[(int)FileSize];
    //        sourceFile.Read(getContent, 0, (int)sourceFile.Length);
    //        sourceFile.Close();

    //        Response.BinaryWrite(getContent);
    //    }
    //}
    //protected void LinkButton14_Click(object sender, EventArgs e)
    //{
    //    if (Page.IsPostBack)
    //    {

    //        //Response.ContentType = "application/ms-word";
    //        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
    //        Response.ContentType = "application/CRL";
    //        Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(15-6-2012).crl");

    //        string file = "YCA(15-6-2012).crl";
    //        string folderpath = Server.MapPath("~/Download");
    //        string f = (folderpath + "/" + file);

    //        FileStream sourceFile = new FileStream(@f, FileMode.Open);
    //        //"..\Certificate\" + label2.text + ".cer"
    //        //FileStream sourceFile = new FileStream(@"Certificates\" + Label2.Text + ".cer", FileMode.Open);

    //        //String file = Label2.Text;
    //        //String folderpath = Server.MapPath("~/Certificates");
    //        //FileInfo f = new fileinfo(folderpath + "/", file);


    //        long FileSize;
    //        FileSize = sourceFile.Length;
    //        byte[] getContent = new byte[(int)FileSize];
    //        sourceFile.Read(getContent, 0, (int)sourceFile.Length);
    //        sourceFile.Close();

    //        Response.BinaryWrite(getContent);
    //    }

    //}
    //protected void LinkButton15_Click(object sender, EventArgs e)
    //{
    //    if (Page.IsPostBack)
    //    {

    //        //Response.ContentType = "application/ms-word";
    //        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
    //        Response.ContentType = "application/CRL";
    //        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCA(25-6-2012).crl");

    //        string file = "MOSSCA(25-6-2012).crl";
    //        string folderpath = Server.MapPath("~/Download");
    //        string f = (folderpath + "/" + file);

    //        FileStream sourceFile = new FileStream(@f, FileMode.Open);
    //        //"..\Certificate\" + label2.text + ".cer"
    //        //FileStream sourceFile = new FileStream(@"Certificates\" + Label2.Text + ".cer", FileMode.Open);

    //        //String file = Label2.Text;
    //        //String folderpath = Server.MapPath("~/Certificates");
    //        //FileInfo f = new fileinfo(folderpath + "/", file);


    //        long FileSize;
    //        FileSize = sourceFile.Length;
    //        byte[] getContent = new byte[(int)FileSize];
    //        sourceFile.Read(getContent, 0, (int)sourceFile.Length);
    //        sourceFile.Close();

    //        Response.BinaryWrite(getContent);
    //    }
    //}
    //protected void LinkButton16_Click(object sender, EventArgs e)
    //{
    //    if (Page.IsPostBack)
    //    {

    //        //Response.ContentType = "application/ms-word";
    //        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
    //        Response.ContentType = "application/CRL";
    //        Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(25-6-2012).crl");

    //        string file = "YCA(25-6-2012).crl";
    //        string folderpath = Server.MapPath("~/Download");
    //        string f = (folderpath + "/" + file);

    //        FileStream sourceFile = new FileStream(@f, FileMode.Open);
    //        //"..\Certificate\" + label2.text + ".cer"
    //        //FileStream sourceFile = new FileStream(@"Certificates\" + Label2.Text + ".cer", FileMode.Open);

    //        //String file = Label2.Text;
    //        //String folderpath = Server.MapPath("~/Certificates");
    //        //FileInfo f = new fileinfo(folderpath + "/", file);


    //        long FileSize;
    //        FileSize = sourceFile.Length;
    //        byte[] getContent = new byte[(int)FileSize];
    //        sourceFile.Read(getContent, 0, (int)sourceFile.Length);
    //        sourceFile.Close();

    //        Response.BinaryWrite(getContent);
    //    }
    //}
    //protected void LinkButton17_Click(object sender, EventArgs e)
    //{
    //    if (Page.IsPostBack)
    //    {

    //        //Response.ContentType = "application/ms-word";
    //        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
    //        Response.ContentType = "application/CRL";
    //        Response.AddHeader("content-disposition", "attachment; filename=" + "YCA(2-7-2012).crl");

    //        string file = "YCA(2-7-2012).crl";
    //        string folderpath = Server.MapPath("~/Download");
    //        string f = (folderpath + "/" + file);

    //        FileStream sourceFile = new FileStream(@f, FileMode.Open);
    //        //"..\Certificate\" + label2.text + ".cer"
    //        //FileStream sourceFile = new FileStream(@"Certificates\" + Label2.Text + ".cer", FileMode.Open);

    //        //String file = Label2.Text;
    //        //String folderpath = Server.MapPath("~/Certificates");
    //        //FileInfo f = new fileinfo(folderpath + "/", file);


    //        long FileSize;
    //        FileSize = sourceFile.Length;
    //        byte[] getContent = new byte[(int)FileSize];
    //        sourceFile.Read(getContent, 0, (int)sourceFile.Length);
    //        sourceFile.Close();

    //        Response.BinaryWrite(getContent);
    //    }
    //}
    //protected void LinkButton18_Click(object sender, EventArgs e)
    //{
    //    if (Page.IsPostBack)
    //    {

    //        //Response.ContentType = "application/ms-word";
    //        //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
    //        Response.ContentType = "application/CRL";
    //        Response.AddHeader("content-disposition", "attachment; filename=" + "MOSSCA(2-7-2012).crl");

    //        string file = "MOSSCA(2-7-2012).crl";
    //        string folderpath = Server.MapPath("~/Download");
    //        string f = (folderpath + "/" + file);

    //        FileStream sourceFile = new FileStream(@f, FileMode.Open);
    //        //"..\Certificate\" + label2.text + ".cer"
    //        //FileStream sourceFile = new FileStream(@"Certificates\" + Label2.Text + ".cer", FileMode.Open);

    //        //String file = Label2.Text;
    //        //String folderpath = Server.MapPath("~/Certificates");
    //        //FileInfo f = new fileinfo(folderpath + "/", file);


    //        long FileSize;
    //        FileSize = sourceFile.Length;
    //        byte[] getContent = new byte[(int)FileSize];
    //        sourceFile.Read(getContent, 0, (int)sourceFile.Length);
    //        sourceFile.Close();

    //        Response.BinaryWrite(getContent);
    //    }
    //}
    protected void LinkButton19_Click(object sender, EventArgs e)
    {
        Response.Redirect("YCA2018CRL4.aspx");
    }
    protected void LinkButton20_Click(object sender, EventArgs e)
    {
        Response.Redirect("MOSS2019CRL3.aspx");
        
    }
    protected void LinkButton1_Click1(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "MyanmarRootCA2010(15-3-2012).crl");

            string file = "MyanmarRootCA2010(15-3-2012).crl";
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
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "MyanmarRootCA2010.crl");

            string file = "MyanmarRootCA2010.crl";
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
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "MyanmarRootCA2015.crl");

            string file = "MyanmarRootCA2015.crl";
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
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("TESTCA2017.aspx");
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "MyanmarRootCA2017.crl");

            string file = "MyanmarRootCA2017.crl";
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
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "MyanmarNationalRootCASHA-256(2017).crl");

            string file = "MyanmarNationalRootCASHA-256(2017).crl";
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
    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "NationalRootCASHA256(14-3-2018).crl");

            string file = "NationalRootCASHA256(14-3-2018).crl";
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
    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        Response.Redirect("MOSSCASHA22022.aspx");
    }
    protected void LinkButton9_Click(object sender, EventArgs e)
    {
        Response.Redirect("YCASHA22020CRL.aspx");
    }
    protected void LinkButton10_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "MyanmarRootCA2018(17-8-2018).crl");

            string file = "MyanmarRootCA2018(17-8-2018).crl";
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
    protected void LinkButton11_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "Myanmar National RootCA 2017(13-9-2018).crl");

            string file = "Myanmar National RootCA 2017(13-9-2018).crl";
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
    protected void LinkButton12_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "Myanmar National RootCA 2017(14-3-2019).crl");

            string file = "Myanmar National RootCA 2017(14-3-2019).crl";
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
    protected void LinkButton13_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "Myanmar National RootCA 2017(13-9-2019).crl");

            string file = "Myanmar National RootCA 2017(13-9-2019).crl";
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
    protected void LinkButton14_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "Myanmar National RootCA 2017(11-3-2020).crl");

            string file = "Myanmar National RootCA 2017(11-3-2020).crl";
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
    protected void LinkButton15_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "MyanmarNationalRootCA2017(10-9-2020).crl");

            string file = "MyanmarNationalRootCA2017(10-9-2020).crl";
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
    protected void LinkButton16_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "Myanmar National RootCA 2017(10.3.2021).crl");

            string file = "Myanmar National RootCA 2017(10.3.2021).crl";
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
    protected void LinkButton17_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "Myanmar National RootCA 2017(9-3-2022).crl");

            string file = "Myanmar National RootCA 2017(9-3-2022).crl";
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
    protected void LinkButton18_Click(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {

            //Response.ContentType = "application/ms-word";
            //Response.AddHeader("content-disposition", "attachment; filename=download.doc");
            Response.ContentType = "application/CRL";
            Response.AddHeader("content-disposition", "attachment; filename=" + "Myanmar National RootCA 2017.crl");

            string file = "Myanmar National RootCA 2017.crl";
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
            Response.AddHeader("content-disposition", "attachment; filename=" + "Myanmar National RootCA 2017.crl");

            string file = "Root CA CRL 7-3-2024.crl";
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

