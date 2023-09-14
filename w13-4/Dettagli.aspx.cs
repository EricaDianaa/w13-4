using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace w13_4
{
    public partial class Dettagli : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
  string connection = ConfigurationManager.ConnectionStrings["ConnectionDB"]
          .ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("select * from Rubrica where Id=@id", conn);
            cmd.Parameters.AddWithValue("id", Request.QueryString["IdPersona"]);
            conn.Open();
            SqlDataReader sqlreader;
            sqlreader = cmd.ExecuteReader();
            while (sqlreader.Read())
            {
                Nome.Text = $"{sqlreader["Nome"]}";
                Cognome.Text = $"{sqlreader["Cognome"]}";
                Indirizzo.Text = $"{sqlreader["Indirizzo"]}";
                NumeroTelefono.Text = $"{sqlreader["NumeroTelefono"]}";
                Email.Text = $"{sqlreader["Email"]}";

            }
            }
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string connection = ConfigurationManager.ConnectionStrings["ConnectionDB"]
            .ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connection);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE Rubrica SET Nome=@Nome, Cognome=@Cognome, Indirizzo=@Indirizzo, NumeroTelefono=@numeroTelefono,Email=@email,Foto=@foto where Id=@id";
            cmd.Parameters.AddWithValue("Nome", Nome.Text);
            cmd.Parameters.AddWithValue("Cognome", Cognome.Text);
            cmd.Parameters.AddWithValue("Indirizzo", Indirizzo.Text);
            cmd.Parameters.AddWithValue("numeroTelefono", NumeroTelefono.Text);
            cmd.Parameters.AddWithValue("Email", Email.Text);
            string filename = "";
            if (FileUpload1.HasFile)
            {
                filename = FileUpload1.FileName;
                FileUpload1.SaveAs(Server.MapPath($"/Content/img/{FileUpload1.FileName}"));
            }
            cmd.Parameters.AddWithValue("foto", filename);
            cmd.Parameters.AddWithValue("id", Request.QueryString["IdPersona"]);

           
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
            Response.Redirect($"Dettagli.aspx?idPersona={Request.QueryString["IdPersona"]}");
        }

        protected void Elimina_Click(object sender, EventArgs e)
        {

            string connection = ConfigurationManager.ConnectionStrings["ConnectionDB"]
            .ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connection);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE FROM Rubrica where Id=@id";
            cmd.Parameters.AddWithValue("id", Request.QueryString["IdPersona"]);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
            Response.Redirect($"Rubrica.aspx");
        }
    }
}