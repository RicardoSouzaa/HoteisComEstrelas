using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

namespace Hoteis
{
    public partial class _Default : Page
    {
        private string pais_filtro = "";
        private int estrelas_filtro = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            LabelIntro.Text = "Pesquisa de Hoteis";
            LabelPais.Text = "País";
            LabelClassific.Text = "Classificação (Mínima):";
            ImgButtons(ImageButton1);
            ImgButtons(ImageButton2);
            ImgButtons(ImageButton3);
            ImgButtons(ImageButton4);
            ImgButtons(ImageButton5);
            Pesquisar();
        }

        private void ImgButtons(ImageButton nButton)
        {
            nButton.ImageUrl = "/imagens/star_disabled.png";
            nButton.Height = new Unit(20);
            nButton.Width = new Unit(20);
        }

        protected void Pais(Object sender, EventArgs e)
        {
            Pesquisar();
        }

        protected void Pesquisar()
        {
            string connection = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = D:/DEV/dados/Hoteis.accdb";
            pais_filtro = ddlPais.SelectedItem.Value;
            string query = "SELECT * FROM Hoteis WHERE Pais Like '" + pais_filtro + "%' AND Estrelas >= " + estrelas_filtro;
            OleDbConnection con = new OleDbConnection(connection);
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();
            dtResultado.DataSource = dt;
            dtResultado.DataBind();
        }

        protected void Class1(Object sender, EventArgs e)
        {
            ImageButton1.ImageUrl = "/imagens/star_enabled.png";
            ImageButton2.ImageUrl = "/imagens/star_disabled.png";
            ImageButton3.ImageUrl = "/imagens/star_disabled.png";
            ImageButton4.ImageUrl = "/imagens/star_disabled.png";
            ImageButton5.ImageUrl = "/imagens/star_disabled.png";
            estrelas_filtro = 1;
            Pesquisar();
        }

        protected void Class2(Object sender, EventArgs e)
        {
            ImageButton1.ImageUrl = "/imagens/star_enabled.png";
            ImageButton2.ImageUrl = "/imagens/star_enabled.png";
            ImageButton3.ImageUrl = "/imagens/star_disabled.png";
            ImageButton4.ImageUrl = "/imagens/star_disabled.png";
            ImageButton5.ImageUrl = "/imagens/star_disabled.png";
            estrelas_filtro = 2;
            Pesquisar();
        }

        protected void Class3(Object sender, EventArgs e)
        {
            ImageButton1.ImageUrl = "/imagens/star_enabled.png";
            ImageButton2.ImageUrl = "/imagens/star_enabled.png";
            ImageButton3.ImageUrl = "/imagens/star_enabled.png";
            ImageButton4.ImageUrl = "/imagens/star_disabled.png";
            ImageButton5.ImageUrl = "/imagens/star_disabled.png";
            estrelas_filtro = 3;
            Pesquisar();
        }

        protected void Class4(Object sender, EventArgs e)
        {
            ImageButton1.ImageUrl = "/imagens/star_enabled.png";
            ImageButton2.ImageUrl = "/imagens/star_enabled.png";
            ImageButton3.ImageUrl = "/imagens/star_enabled.png";
            ImageButton4.ImageUrl = "/imagens/star_enabled.png";
            ImageButton5.ImageUrl = "/imagens/star_disabled.png";
            estrelas_filtro = 4;
            Pesquisar();
        }

        protected void Class5(Object sender, EventArgs e)
        {
            ImageButton1.ImageUrl = "/imagens/star_enabled.png";
            ImageButton2.ImageUrl = "/imagens/star_enabled.png";
            ImageButton3.ImageUrl = "/imagens/star_enabled.png";
            ImageButton4.ImageUrl = "/imagens/star_enabled.png";
            ImageButton5.ImageUrl = "/imagens/star_enabled.png";
            estrelas_filtro = 5;
            Pesquisar();
        }
    }
}