using ClienteSW.SWJugador;
using ClienteSW.SWpersonaje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteSW
{
    public partial class GUIEliminarPersonaje : System.Web.UI.Page
    {
        PersonajeWebServiceClient cliente = new PersonajeWebServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

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

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            String id = txtId.Text.Trim();
            personajeVO buscar = new personajeVO();
            buscar.id = id;
            personajeVO buscado = null;
            try
            {
                buscado = cliente.buscarporIdPersonaje(id);
                txtNombre.Text = buscado.nombre;
                txtFuerza.Text = Convert.ToString(buscado.fuerza);
                txtMana.Text = Convert.ToString(buscado.mana);
                txtEnergia.Text = Convert.ToString(buscado.energia);
                txtEspecie.Text = buscado.id_especie;
                txtJugador.Text = buscado.id_jugador;


            }
            catch(Exception xe)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "No esta mi pana" + "');", true);
            }
            
            
            
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            personajeVO eliminar = new personajeVO();
            string idd = txtId.Text.Trim();
            try
            {
                cliente.eliminarPersonaje(idd);
                ClientScript.RegisterStartupScript(this.GetType(), "Eliminacion", "alert('" + "Se elimino el personaje mi pana" + "');", true);
                txtNombre.Text = "";
                txtFuerza.Text = "";
                txtMana.Text = "";
                txtEnergia.Text = "";
                txtEspecie.Text = "";
                txtJugador.Text = "";
                txtId.Focus();
            }
            catch(Exception xe)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "No se pudo elminar mi pana" + "');", true);
            }
            
        }

        
    }
}