using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
using Logic;

namespace Capas
{
    public partial class Nuevo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            RellenarComboAutores();
            RellenarComboEditoriales();
            mensaje_error.Text = "";
        }

        protected void RellenarComboAutores()
        {
            List<Autor> autores = null;
            try
            {
                autores = AutorService.GetAutores();
                cmb_autores.DataSource = autores;
                cmb_autores.DataTextField = "Nombre";
                cmb_autores.DataValueField = "Id";
                cmb_autores.SelectedValue = "Id";

                cmb_autores.DataBind();
            }catch(Exception ex)
            {
                mensaje_error.Text = ex.Message;
            }
        }

        protected void RellenarComboEditoriales()
        {
            List<Editorial> editoriales = null;
            try
            {
                editoriales = EditorialService.ObtenerEditoriales();
                cmb_editoriales.DataSource = editoriales;
                cmb_editoriales.DataTextField = "Nombre";
                cmb_editoriales.DataValueField = "Id_editorial";
                cmb_editoriales.SelectedValue = "Id_editorial";
                cmb_editoriales.DataBind();
            }catch(Exception ex)
            {
                mensaje_error.Text = ex.Message;
            }
        }

        protected void EnvioForm(object sender, EventArgs e)
        {
            try
            {
                Libro libro = new Libro();
                libro.Titulo = txt_titulo.Text.Trim();
                libro.Editorial = cmb_editoriales.SelectedValue;
                libro.Autor = cmb_autores.SelectedValue;
                LibroService.NuevoLibro(libro);
                Server.Transfer("Inicio.aspx");
            }catch(Exception ex)
            {
                mensaje_error.Text = ex.Message;
            }
        }
    }
}