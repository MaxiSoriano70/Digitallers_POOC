using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp1
{
    public partial class Form1 : Form /*Form1 HEREDA Form*/
    {
        //CONSTRUCTOR DE LA CLASE Form1
        public Form1()
        {
            InitializeComponent();/*METODO que pertenece a la clase Fom1 <Clase compilado propia de Csharp>*/
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
        }
    }
}
