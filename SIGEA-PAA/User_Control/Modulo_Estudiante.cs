using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGEA_PAA.User_Control
{
    public partial class Modulo_Estudiante : UserControl
    {
        public Modulo_Estudiante()
        {
            InitializeComponent();
        }
        private static Modulo_Estudiante _instancia;
        public static Modulo_Estudiante Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new Modulo_Estudiante();
                return _instancia;
            }
        }
        private void Modulo_Estudiante_Load(object sender, EventArgs e)
        {

        }

        private void Txt_Nombre_Click(object sender, EventArgs e)
        {

        }

        private void gb_Estudiante_Enter(object sender, EventArgs e)
        {

        }
    }
}
