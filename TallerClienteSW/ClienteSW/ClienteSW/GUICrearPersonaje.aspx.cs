using ClienteSW.SWEspecie;
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
    public partial class WebForm1 : System.Web.UI.Page
    {
        JugadorWebServiceClient cliente = new JugadorWebServiceClient();
        EspecieWebServiceClient clienteEsp = new EspecieWebServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                jugadorVO[] jugadoress;
                especieVO[] especies;
                jugadoress = cliente.listarJugadores();
                especies = clienteEsp.listarEspecies();
                List<string> listjugadores = new List<string>();
                List<string> listespecies = new List<string>();
                foreach (jugadorVO jugador in jugadoress)
                {
                    listjugadores.Add(jugador.id + ". " + jugador.apodo);
                }
                foreach (especieVO especie in especies)
                {
                    listespecies.Add(especie.id + ". " + especie.nombre);
                }
                ListJuga.DataSource = listjugadores;
                ListEspe.DataSource = listespecies;
                ListEspe.DataBind();
                ListJuga.DataBind();
            }
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
            SWpersonaje.personajeVO perso;
            PersonajeWebServiceClient personaje;
            personaje = new PersonajeWebServiceClient();
            personajeVO personaje2 = new personajeVO();


            String id;
            String nom;
            double fue;
            double mana;
            double ener;
            String esp;
            String jug;
            double reg = 1;
            DateTime da = new DateTime();

            id = txtId.Text.Trim();
            nom = txtNombre.Text.Trim();
            fue = Convert.ToDouble(txtFuerza.Text.Trim());
            mana = Convert.ToDouble(txtMana.Text.Trim());
            ener = Convert.ToDouble(txtEnergia.Text.Trim());
            jug = ListJuga.SelectedItem.Value.Split('.')[0];
            //.split("\\.")[0];.Split('.')[0];
            esp = ListEspe.SelectedItem.Value.Split('.')[0];
            personaje2.id = id;
            personaje2.nombre = nom;
            personaje2.fuerza = fue;
            personaje2.mana = mana;
            personaje2.energia = ener;
            personaje2.id_jugador = jug;
            personaje2.id_especie = esp;
            personaje2.estadoRegistro = reg;
            try
            {
                personaje.insertarPersonaje(personaje2);
                ClientScript.RegisterStartupScript(this.GetType(), "Felicidades Shinji", "alert('" + "Se creo el jugador" + "');", true);
                txtId.Text = "";
                txtNombre.Text = ""; 
                txtFuerza.Text = "";
                txtMana.Text = "";
                txtEnergia.Text = "";
                txtId.Focus();
            }
            catch(Exception xe)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "No se pudo insertar mi pana" + "');", true);
            }
        }

    } 
}