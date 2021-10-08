
using ClienteSW.SWJugador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteSW
{
    public partial class GUICrearJugador : System.Web.UI.Page
    {
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

        protected void btnCrear_Click(object sender, EventArgs e)
        {

            JugadorWebServiceClient jugador2;
            jugador2 = new JugadorWebServiceClient();
            jugadorVO jugador = new jugadorVO();
            

            String id;
            String cuen;
            String con;
            String apo;
            String email;
            double reg = 1;
            DateTime da = DateTime.UtcNow;
          
            id = txtId.Text.Trim();
            cuen = txtCuenta.Text.Trim();
            con = txtContrasena.Text.Trim();
            apo = txtApodo.Text.Trim();
            email = txtEmail.Text.Trim();

           
            jugador.id = id;
            jugador.cuenta = cuen;
            jugador.contraseña = con;
            jugador.apodo = apo;
            jugador.email = email;
            jugador.estadoRegistro = reg;
            jugador.fechaModificacion = da;
            jugador.fechaModificacionSpecified = true;

            try
            {
                Boolean ae = jugador2.insertarJugador(jugador);
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Se creo el jugador" + "');", true);
                txtId.Text = "";
                txtCuenta.Text = "";
                txtApodo.Text = "";
                txtContrasena.Text = "";
                txtEmail.Text = "";
                txtId.Focus();
            }
            catch(Exception xe)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "No se pudo insertar mi pana" + "');", true);
            }
        }

        
    }
}