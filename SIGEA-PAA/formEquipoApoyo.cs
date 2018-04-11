using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bankivoide;
namespace SIGEA_PAA
{
    public partial class formEquipoApoyo : MetroFramework.Forms.MetroForm
    {
        string sesion;

        public formEquipoApoyo(string _sesion, string _nombreusuariosesion)
        {
            InitializeComponent();
            sesion = _sesion;
            labelUsuario.Text = "Bienvenido " + _nombreusuariosesion;
        }

        private void formEquipoApoyo_Load(object sender, EventArgs e)
        {
        

        }

        private void btn_Inscripcion_Click(object sender, EventArgs e)
        {
             
        }
    }
}
