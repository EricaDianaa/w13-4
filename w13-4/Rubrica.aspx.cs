using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace w13_4
{
    public partial class Rubrica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connection = ConfigurationManager.ConnectionStrings["ConnectionDB"]
           .ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connection);

            SqlCommand cmd = new SqlCommand("select * from Rubrica order by Nome ", conn);
            SqlDataReader sqlreader;

            conn.Open();
            List<Persona> listaPersone = new List<Persona>();
            sqlreader = cmd.ExecuteReader();

            while (sqlreader.Read())
            {
              // int idCliente = Convert.ToInt32(sqlreader["Id"].ToString());
               // Result.InnerHtml += $"<h3>{sqlreader["Nome"]} {sqlreader["Cognome"]}</h3>" +
               //$"<p>{sqlreader["Indirizzo"]}</p><p>{sqlreader["NumeroTelefono"]}</p><p>{sqlreader["Email"]}</p><a href='Dettagli.aspx?IdPersona={idCliente}'>Dettagli</a> <hr>";

            
             Persona persona = new Persona();
                persona.IdPersona = Convert.ToInt32(sqlreader["Id"]);
                persona.Nome = sqlreader["Nome"].ToString();
                persona.Cognome = sqlreader["Cognome"].ToString();
                persona.Indirizzo = sqlreader["Indirizzo"].ToString();
                persona.NumeroTelefono = sqlreader["NumeroTelefono"].ToString();
                persona.Email = sqlreader["Email"].ToString();
                persona.Foto = sqlreader["Foto"].ToString();
                listaPersone.Add(persona);
            
            }

            Repeater1.DataSource = listaPersone;
            Repeater1.DataBind();




            conn.Close();
        }
    }


    public class Persona
    {
        public int IdPersona { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Indirizzo { get; set; }
        public string Email { get; set; }
        public string NumeroTelefono { get; set; }

        public string Foto { get; set; }
    }
}
