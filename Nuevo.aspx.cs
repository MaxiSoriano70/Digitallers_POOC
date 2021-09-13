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
                cmb_editoriales.DataBind();
            }catch(Exception ex)
            {
                mensaje_error.Text = ex.Message;
            }
        }
    }
}