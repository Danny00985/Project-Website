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
using System.DirectoryServices;

public partial class LDAP : System.Web.UI.Page
{
    DataSet oDsUser;
    DataSet oDs;
    DataTable oTb;
    DirectoryEntry oDE = null;
    DirectorySearcher oDS = null;
    SearchResultCollection oResults = null;
    DataRow oRwUser = null;
    String Query = "";

    private string sADPath = "DC=rootca,DC=org,DC=mm";

    private string sADUser = "administrator";
    private string sADPassword = "p@ssw0rd2";
    string dom = "DC=rootca,DC=org,DC=mm";

    protected void Page_Load(object sender, EventArgs e)
    {
        SetPageTitle();
        if (!IsPostBack)
        {

            ddlCA_DataBind();
           
            dvCertificate.Visible = false;

        }
    }

    private void SetPageTitle()
    {
        this.Title = "Myanmar Root CA Certifying Authorities"; 
    }

    private void ddlCA_DataBind()
    {
        ddlCA.Items.Insert(0, "");
        System.DirectoryServices.DirectoryEntry direntry = new System.DirectoryServices.DirectoryEntry("LDAP://" + dom);
        System.DirectoryServices.DirectorySearcher mySearcher = new System.DirectoryServices.DirectorySearcher(direntry);
        mySearcher.Filter = ("(objectClass=organizationalUnit)");
        foreach (System.DirectoryServices.SearchResult resEnt in mySearcher.FindAll())
        {
            try
            {
                System.DirectoryServices.DirectoryEntry de = resEnt.GetDirectoryEntry();

                ddlCA.Items.Add(de.Name.ToString());

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }

        }
    }
    protected void butName_Click1(object sender, EventArgs e)
    {
        if (txtCommonName.Text != "")
        {
            Query = "(displayName=" + txtCommonName.Text + ")";
            dvCertificate_DataBindByName();
        }
        else
            return;
    }

    private void dvCertificate_DataBindByName()
    {
        dvCertificate.Visible = true;
        dvCertificate.DataSource = GetUsersDataSet(txtCommonName.Text);
        dvCertificate.DataBind();
    }

    public DataSet GetUsersDataSet(string sCriteria)
    {
        oDE = GetDirectoryObject();


        //Create Instance fo the Direcory Searcher
        oDS = new DirectorySearcher();
        oDS.SearchRoot = oDE;

        //Set the Search Filter
        oDS.Filter = "((objectClass=user))";
        oDS.SearchScope = SearchScope.Subtree;
        // oDS.PageSize = 10000;
        oDS.Filter = Query;

        //Find the First Instance
        oResults = oDS.FindAll();
        //Create Empty User Dataset
        oDsUser = CreateUserDataSet();

        //If Record is not Null, Then Populate DataSet
        try
        {
            if (oResults.Count > 0)
            {
                foreach (SearchResult oResult in oResults)
                {
                    oDE = oResult.GetDirectoryEntry();
                    oDsUser.Tables["User"].Rows.Add(PopulateUserDataSet(oResult, oDsUser.Tables["User"]));

                }
            }
        }
        catch (Exception ex)
        {
            ex.Message.ToString();
        }

        oDE.Close();
        return oDsUser;

    }

    private DirectoryEntry GetDirectoryObject()
    {
        oDE = new DirectoryEntry("LDAP://" + ddlCA.SelectedItem.Text + "," + sADPath, sADUser, sADPassword, AuthenticationTypes.Secure);
        return oDE;
    }

    private DataSet CreateUserDataSet()
    {
        oDs = new DataSet();

        oTb = oDs.Tables.Add("User");

        //Create All the Columns
        //oTb.Columns.Add("company");
        //oTb.Columns.Add("department");
        //oTb.Columns.Add("description");
        oTb.Columns.Add("displayName");
        //oTb.Columns.Add("facsimileTelephoneNumber");
        //oTb.Columns.Add("givenName");
        //oTb.Columns.Add("homePhone");
        //oTb.Columns.Add("employeeNumber");
        //oTb.Columns.Add("initials");
        //oTb.Columns.Add("ipPhone");
        //oTb.Columns.Add("l");
        oTb.Columns.Add("mail");
        //oTb.Columns.Add("manager");
        //oTb.Columns.Add("mobile");
        //oTb.Columns.Add("name");
        //oTb.Columns.Add("pager");
        //oTb.Columns.Add("physicalDeliveryOfficeName");
        //oTb.Columns.Add("postalAddress");
        //oTb.Columns.Add("postalCode");
        //oTb.Columns.Add("postOfficeBox");
        //oTb.Columns.Add("sAMAccountName");
        //oTb.Columns.Add("sn");
        //oTb.Columns.Add("st");
        //oTb.Columns.Add("street");
        //oTb.Columns.Add("streetAddress");
        //oTb.Columns.Add("telephoneNumber");
        //oTb.Columns.Add("title");
        //oTb.Columns.Add("userPrincipalName");
        //oTb.Columns.Add("wWWHomePage");
        //oTb.Columns.Add("whenCreated");
        //oTb.Columns.Add("whenChanged");
        //oTb.Columns.Add("distinguishedName");
        //oTb.Columns.Add("info");

        return oDs;
    }

    private DataRow PopulateUserDataSet(SearchResult oUserSearchResult, DataTable oUserTable)
    {
        //Sets a New Empty Row
        oRwUser = oUserTable.NewRow();

        //oRwUser["company"] = GetProperty(oUserSearchResult, "company");
        //oRwUser["department"] = GetProperty(oUserSearchResult, "department");
        //oRwUser["description"] = GetProperty(oUserSearchResult, "description");
        oRwUser["displayName"] = GetProperty(oUserSearchResult, "displayName");
        //oRwUser["facsimileTelephoneNumber"] = GetProperty(oUserSearchResult, "facsimileTelephoneNumber");
        //oRwUser["givenName"] = GetProperty(oUserSearchResult, "givenName");
        //oRwUser["homePhone"] = GetProperty(oUserSearchResult, "homePhone");
        //oRwUser["employeeNumber"] = GetProperty(oUserSearchResult, "employeeNumber");
        //oRwUser["initials"] = GetProperty(oUserSearchResult, "initials");
        //oRwUser["ipPhone"] = GetProperty(oUserSearchResult, "ipPhone");
        //oRwUser["l"] = GetProperty(oUserSearchResult, "l");
        oRwUser["mail"] = GetProperty(oUserSearchResult, "mail");
        //oRwUser["manager"] = GetProperty(oUserSearchResult, "manager");
        //oRwUser["mobile"] = GetProperty(oUserSearchResult, "mobile");
        //oRwUser["name"] = GetProperty(oUserSearchResult, "name");
        //oRwUser["pager"] = GetProperty(oUserSearchResult, "pager");
        //oRwUser["physicalDeliveryOfficeName"] = GetProperty(oUserSearchResult, "physicalDeliveryOfficeName");
        //oRwUser["postalAddress"] = GetProperty(oUserSearchResult, "postalAddress");
        //oRwUser["postalCode"] = GetProperty(oUserSearchResult, "postalCode");
        //oRwUser["postOfficeBox"] = GetProperty(oUserSearchResult, "postOfficeBox");
        //oRwUser["sAMAccountName"] = GetProperty(oUserSearchResult, "sAMAccountName");
        //oRwUser["sn"] = GetProperty(oUserSearchResult, "sn");
        //oRwUser["st"] = GetProperty(oUserSearchResult, "st");
        //oRwUser["street"] = GetProperty(oUserSearchResult, "street");
        //oRwUser["streetAddress"] = GetProperty(oUserSearchResult, "streetAddress");
        //oRwUser["telephoneNumber"] = GetProperty(oUserSearchResult, "telephoneNumber");
        //oRwUser["title"] = GetProperty(oUserSearchResult, "title");
        //oRwUser["userPrincipalName"] = GetProperty(oUserSearchResult, "userPrincipalName");
        //oRwUser["wWWHomePage"] = GetProperty(oUserSearchResult, "wWWHomePage");
        //oRwUser["whenCreated"] = GetProperty(oUserSearchResult, "whenCreated");
        //oRwUser["whenChanged"] = GetProperty(oUserSearchResult, "whenChanged");
        //oRwUser["distinguishedName"] = GetProperty(oUserSearchResult, "distinguishedName");
        //oRwUser["info"] = GetProperty(oUserSearchResult, "info");

        return oRwUser;

    }

    public string GetProperty(SearchResult oSearchResult, string sPropertyName)
    {
        if (oSearchResult.Properties.Contains(sPropertyName))
        {
            return oDE.Properties[sPropertyName].Value.ToString();

        }
        else
        {
            return string.Empty;
        }


    }

    protected void butEmail_Click(object sender, EventArgs e)
    {
        if (txtEmail.Text != "")
        {
            Query = "(mail=" + txtEmail.Text + ")";
            dvCertificate_DataBindByEmail();
        }
        else
            return;
    }

    private void dvCertificate_DataBindByEmail()
    {
        dvCertificate.Visible = true;
        dvCertificate.DataSource = GetUsersDataSet(txtEmail.Text);
        dvCertificate.DataBind();

    }
}
