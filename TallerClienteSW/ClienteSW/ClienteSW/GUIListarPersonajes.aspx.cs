using ClienteSW.SWpersonaje;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteSW
{
    public partial class ListarPersonajes : System.Web.UI.Page
    {
        PersonajeWebServiceClient cliente = new PersonajeWebServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Fuerza");
            dt.Columns.Add("Mana");
            dt.Columns.Add("Energia");
            dt.Columns.Add("Estado Registro");
            dt.Columns.Add("Fecha Modificacion");

            /**
            dt.Rows.Add(1, "John Hammond", "United States");
            dt.Rows.Add(2, "Mudassar Khan", "India");
            dt.Rows.Add(3, "Suzanne Mathews", "France");
            dt.Rows.Add(4, "Robert Schidner", "Russia");
            */
            IList lista = ListaPersonajes();
            foreach (personajeVO personaje in lista)
            {
                DataRow row = dt.NewRow();
                dt.Rows.Add(personaje.id, personaje.nombre, personaje.fuerza, personaje.mana, personaje.energia, personaje.estadoRegistro, personaje.fechaModificacion);

            }
            GridView1.DataSource = lista;
            GridView1.DataBind();
          //  GridView1.UseAccessibleHeader = true;
           // GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
        public List<personajeVO> ListaPersonajes()
        {
            personajeVO[] personajess;

            personajess = cliente.listarPersonaje();
            List<personajeVO> listafachera = new List<personajeVO>(personajess);
            return listafachera;
        }
        protected void LbtnCrearJugador_Click(object sender, EventArgs e)
        {
            Response.Redirect("GUICrearJugador.aspx");

        }

        protected void LbtnEliminarJugador_Click(object sender, EventArgs e)
        {
            Response.Redirect("GUIEliminarJugador.aspx");
        }

        protected void LbtnActualizarJugador_Click(object sender, EventArgs e)
        {
            Response.Redirect("GUIActualizarJugador.aspx");
        }

        protected void LbtnCrearPersonaje_Click(object sender, EventArgs e)
        {
            Response.Redirect("GUICrearPersonaje.aspx");
        }

        protected void LbtinEliminarPersonaje_Click(object sender, EventArgs e)
        {
            Response.Redirect("GUIEliminarPersonaje.aspx");
        }

        protected void LbtnActualizarPersonaje_Click(object sender, EventArgs e)
        {
            Response.Redirect("GUIActualizarPersonaje.aspx");
        }

        protected void LbtnirListar_Click(object sender, EventArgs e)
        {
            Response.Redirect("GUIListarJugadores.aspx");
        }

        protected void LbtnirGraficar_Click(object sender, EventArgs e)
        {
            Response.Redirect("GUIEliminarJugador.aspx");
        }
        protected void LbtnGraficarP_Click(object sender, EventArgs e)
        {
            Response.Redirect("GUIListarPersonajes.aspx");
        }

       
    }
}