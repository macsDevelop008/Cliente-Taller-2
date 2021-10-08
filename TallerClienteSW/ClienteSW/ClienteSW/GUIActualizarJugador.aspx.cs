using ClienteSW.SWJugador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteSW
{
    public partial class GUIActualizarJugador : System.Web.UI.Page
    {
        JugadorWebServiceClient cliente = new JugadorWebServiceClient();
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
            jugadorVO buscar = new jugadorVO();
            buscar.id = id;
            jugadorVO buscado = null;
            try { 
            buscado = cliente.buscarporIdJugador(id);
            txtCuenta.Text = buscado.cuenta;
            txtEmail.Text = buscado.email;
            txtContrasena.Text = buscado.contraseña;

            txtApodo.Text = buscado.apodo;
        }catch(Exception xe)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "No se encontro mi pana" + "');", true);
            }
        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            
            jugadorVO actualizar = new jugadorVO();
            string cuenta = txtCuenta.Text.Trim();
            string email = txtEmail.Text.Trim();
            string contr = txtContrasena.Text.Trim();
            string apodo = txtApodo.Text.Trim();
            string idd = txtId.Text.Trim();
            DateTime fecha = DateTime.Now;
           // fecha = Calenfecha.SelectedDate;
            //fecha.ToString("yyyy-MM-dd");
            actualizar.id = idd;
            actualizar.cuenta = cuenta;
            actualizar.email = email;
            actualizar.contraseña = contr;
            actualizar.apodo = apodo;
            actualizar.estadoRegistro = 1.0;
            actualizar.fechaModificacion = Convert.ToDateTime(fecha.Date.ToString("yyyy-MM-dd"));
            try
            {
                cliente.actualizarJugador(actualizar);
            }catch(Exception xe)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "No se pudo mi pana" + "');", true);
            }
            
        }

    }
}