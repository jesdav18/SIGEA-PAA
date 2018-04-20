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
    public partial class Modulo_Reportes_Supervisor : UserControl
    {
        public Modulo_Reportes_Supervisor()
        {
            InitializeComponent();
        }
        private static Modulo_Reportes _instancia;
        public static Modulo_Reportes Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new Modulo_Reportes();
                return _instancia;
            }
        }
        private void Modulo_Reportes_Supervisor_Load(object sender, EventArgs e)
        {

        }
    }
}
