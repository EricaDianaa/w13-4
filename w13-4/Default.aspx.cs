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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connection = ConfigurationManager.ConnectionStrings["ConnectionDB"]
            .ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connection);
            try 
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO Rubrica VALUES(@nome,@cognome,@indirizzo,@numerotelefono,@email,@foto)";
                cmd.Parameters.AddWithValue("nome", Nome.Text);
                cmd.Parameters.AddWithValue("cognome", Cognome.Text);
                cmd.Parameters.AddWithValue("indirizzo", Indirizzo.Text);
                cmd.Parameters.AddWithValue("numerotelefono", NumeroTelefono.Text);
                cmd.Parameters.AddWithValue("email", Email.Text);

                string filename = "";
                if (FileUpload1.HasFile)
                {
                    filename= FileUpload1.FileName;
                    FileUpload1.SaveAs(Server.MapPath($"/Content/img/{FileUpload1.FileName}"));
                }
                cmd.Parameters.AddWithValue("foto", filename);

                int inserimentoEffettuato = cmd.ExecuteNonQuery();

                if (inserimentoEffettuato > 0)
                {
                    Response.Write("Inserimento effettuato con successo");
                }

            }
            catch (Exception ex) { Response.Write(ex.Message); }
            finally { conn.Close(); }




        }

        protected void Dettagli_Click(object sender, EventArgs e)
        {
            Response.Redirect("Rubrica.aspx");
        }
    }
}