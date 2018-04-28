using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bankivoide;

namespace SIGEA_PAA.User_Control
{
    public partial class Modulo_Reportes : MetroFramework.Controls.MetroUserControl
    {
        public Modulo_Reportes()
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
        private void Modulo_Reportes_Load(object sender, EventArgs e)
        {

        }

        private void metroTabPage6_Click(object sender, EventArgs e)
        {

        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void rListadoGeneralAsistencia_Click(object sender, EventArgs e)
        {

        }
    }
}
