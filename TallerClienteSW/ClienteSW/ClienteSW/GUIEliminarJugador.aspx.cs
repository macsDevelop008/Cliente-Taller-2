﻿using ClienteSW.SWJugador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteSW
{
    public partial class WebForm2 : System.Web.UI.Page
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
            try
            {
                buscado = cliente.buscarporIdJugador(id);
                txtCuenta.Text = buscado.cuenta;
                txtEmail.Text = buscado.email;
                txtContrasena.Text = buscado.contraseña;
                txtApodo.Text = buscado.apodo;
            }catch(Exception xe)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "No esta mi pana" + "');", true);
            }
        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
             jugadorVO eliminar = new jugadorVO();
            string idd = txtId.Text.Trim();
            try
            {
                cliente.eliminarJugador(idd);
                ClientScript.RegisterStartupScript(this.GetType(), "Eliminacion", "alert('" + "Se elimino el jugador mi pana" + "');", true);
                txtCuenta.Text = "";
                txtEmail.Text = "";
                txtContrasena.Text = "";
                txtApodo.Text = "";
                txtId.Focus();
            }
            catch(Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "No se pudo eliminar mi pana" + "');", true);
            }
           
        }

       
    }
}