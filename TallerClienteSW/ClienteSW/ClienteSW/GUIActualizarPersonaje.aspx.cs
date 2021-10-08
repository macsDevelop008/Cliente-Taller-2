
using ClienteSW.SWpersonaje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteSW
{
    public partial class GUIActualizarPersonaje : System.Web.UI.Page
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
            string id = txtId.Text.Trim();
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
            }catch(Exception xe)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "No se encontro mi pana" + "');", true);
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            personajeVO actualizar = new personajeVO();
            string nombre = txtNombre.Text.Trim();
            string fuerza = txtFuerza.Text.Trim();
            string mana = txtMana.Text.Trim();
            string energia = txtEnergia.Text.Trim();
            string idespe = txtEspecie.Text.Trim();
            string idjuga = txtJugador.Text.Trim();
            string idd = txtId.Text.Trim();
            DateTime fecha = DateTime.Now;
            // fecha = Calenfecha.SelectedDate;
            //fecha.ToString("yyyy-MM-dd");
            actualizar.id = idd;
            actualizar.nombre = nombre;
            actualizar.fuerza = Convert.ToDouble(fuerza);
            actualizar.mana = Convert.ToDouble(mana);
            actualizar.energia = Convert.ToDouble(energia);
            actualizar.id_especie = idespe;
            actualizar.id_jugador = idjuga;
            actualizar.estadoRegistro = 1.0;
            actualizar.fechaModificacion = Convert.ToDateTime(fecha.Date.ToString("yyyy-MM-dd"));
            try
            {
                cliente.actualizarPersonaje(actualizar);
            }catch(Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "No se pudo mi pana" + "');", true);
            }
        }

        
    }
}