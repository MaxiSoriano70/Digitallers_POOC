using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm1
{
    public partial class Fin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["nombre"] == null & Request.QueryString["apellido"] == null)
            {
                if (PreviousPage != null)
                {
                    TextBox txt_nombre_resp = null;
                    TextBox txt_apellido_resp = null;
                    if (PreviousPage.Master.FindControl("ContentPlaceHolder1").FindControl("txt_nombre") != null)
                    {
                        txt_nombre_resp = (TextBox)PreviousPage.Master.FindControl("ContentPlaceHolder1").FindControl("txt_nombre");
                    }
                    if (PreviousPage.Master.FindControl("ContentPlaceHolder1").FindControl("txt_apellido") != null)
                    {
                        txt_apellido_resp = (TextBox)PreviousPage.Master.FindControl("ContentPlaceHolder1").FindControl("txt_apellido");
                    }
                    if (txt_nombre_resp != null & txt_apellido_resp != null)
                    {
                        txt_nombre.Text = txt_nombre_resp.Text;
                        txt_apellido.Text = txt_apellido_resp.Text;
                    }
                }
            }
            else
            {
                txt_nombre.Text = Request.QueryString["nombre"];
                txt_apellido.Text = Request.QueryString["apellido"];
            }
            if(Context.Items["Nombre"]!= null & Context.Items["Apellido"] != null)
            {
                txt_nombre.Text = Context.Items["Nombre"].ToString();
                txt_apellido.Text = Context.Items["Apellido"].ToString();
            }
        }
    }
}