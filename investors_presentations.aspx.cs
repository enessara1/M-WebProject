using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class investors_presentations : System.Web.UI.Page
{
    MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=mplus_Dyazilim;Uid=mplus_Uyazilim;Pwd=Fo7ye37_;");
    MySqlCommand komut = new MySqlCommand();
    string language = "ENG";
    static int tarih = 2021;
    protected void Page_Load(object sender, EventArgs e)
    {
        assemblyGetir();
    }

    private void assemblyGetir()
    {
        GeneralAssembly();
    }

    private void GeneralAssembly()
    {
        tarih = Convert.ToInt32(ddlYear.SelectedItem.Value);
        baglanti.Open();
        MySqlCommand komut = new MySqlCommand("SELECT * FROM files WHERE page='Presentation' AND year = '" + tarih + "'", baglanti);
        rptPresentation.DataSource = komut.ExecuteReader();
        rptPresentation.DataBind();
        baglanti.Close();
    }
}