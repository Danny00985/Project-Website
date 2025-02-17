using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using RootCA.BusinessLogic;
using System.Media;

public partial class Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "National Root CA: Home";

        //string sSelectedAudio = @"D:\ECUSTOMS\AVSEQ06.wav";
        //SoundPlayer myPlayer = new SoundPlayer(sSelectedAudio);
        //myPlayer.Play();
        
    }


   
}
