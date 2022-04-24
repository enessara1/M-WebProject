using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
public partial class fileUpload : System.Web.UI.Page
{
    MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=mplus_Dyazilim;Uid=mplus_Uyazilim;Pwd=Fo7ye37_;");
    MySqlCommand komut = new MySqlCommand();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        string lang = ddlLanguage.SelectedItem.Value.ToString();
        string date = txtDate.Text;
        string year = txtYear.Text;
        string name = txtName.Text;
        string link = txtLink.Text;
        string page = ddlPage.SelectedItem.Value.ToString();
        string headerFinancial = ddlHeaderFinancial.SelectedItem.Value.ToString();
        string headerDocuments = ddlHeaderDocuments.SelectedItem.Value.ToString();
        string secilen = ddlPage.SelectedItem.Value.ToString();

        if (secilen == "Documents")
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("INSERT INTO files (language, date, year, name, link, page, header) VALUES (@language, @date, @year, @name, @link, @page, @header)", baglanti);
            komut.Parameters.AddWithValue("language", lang);
            komut.Parameters.AddWithValue("date", date);
            komut.Parameters.AddWithValue("year", year);
            komut.Parameters.AddWithValue("name", name);
            komut.Parameters.AddWithValue("link", link);
            komut.Parameters.AddWithValue("page", page);
            komut.Parameters.AddWithValue("header", headerDocuments);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Response.Redirect(Request.RawUrl);
        }
        if (secilen == "Financial Reports")
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("INSERT INTO files (language, date, year, name, link, page, header) VALUES (@language, @date, @year, @name, @link, @page, @header)", baglanti);
            komut.Parameters.AddWithValue("language", lang);
            komut.Parameters.AddWithValue("date", date);
            komut.Parameters.AddWithValue("year", year);
            komut.Parameters.AddWithValue("name", name);
            komut.Parameters.AddWithValue("link", link);
            komut.Parameters.AddWithValue("page", page);
            komut.Parameters.AddWithValue("header", headerFinancial);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Response.Redirect(Request.RawUrl);
        }
        if (secilen != "Financial Reports" && secilen != "Documents")
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("INSERT INTO files (language, date, year, name, link, page, header) VALUES (@language, @date, @year, @name, @link, @page, @header)", baglanti);
            komut.Parameters.AddWithValue("language", lang);
            komut.Parameters.AddWithValue("date", date);
            komut.Parameters.AddWithValue("year", year);
            komut.Parameters.AddWithValue("name", name);
            komut.Parameters.AddWithValue("link", link);
            komut.Parameters.AddWithValue("page", page);
            komut.Parameters.AddWithValue("header", "");
            komut.ExecuteNonQuery();
            baglanti.Close();
            Response.Redirect(Request.RawUrl);
        }
    }

    protected void ddlPage_SelectedIndexChanged(object sender, EventArgs e)
    {
        string secilen = ddlPage.SelectedItem.Value.ToString();
        if (secilen == "Documents")
        {
            ddlHeaderDocuments.Attributes.Add("style", "display:block");
            ddlHeaderFinancial.Attributes.Add("style", "display:none");
        }
        if (secilen == "Financial Reports")
        {
            ddlHeaderFinancial.Attributes.Add("style", "display:block");
            ddlHeaderDocuments.Attributes.Add("style", "display:none");
        }
        if (secilen != "Financial Reports" && secilen != "Documents")
        {
            ddlHeaderFinancial.Attributes.Add("style", "display:none");
            ddlHeaderDocuments.Attributes.Add("style", "display:none");
        }
    }
}