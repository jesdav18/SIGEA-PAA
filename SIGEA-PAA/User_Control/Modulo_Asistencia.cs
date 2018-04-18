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
    public partial class Modulo_Asistencia : UserControl
    {
        public Modulo_Asistencia()
        {
            InitializeComponent();
        }
        private static Modulo_Asistencia _instancia;
        public static Modulo_Asistencia Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new Modulo_Asistencia();
                return _instancia;
            }
        }
        private void Modulo_Asistencia_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Asistencia_Click(object sender, EventArgs e)
        {
            //----
            try
            {
                Utilidades util = new Utilidades();
                util.RegistrarAsistencia("spIns_Asistencia", Txt_Cuenta.Text);
                MetroFramework.MetroMessageBox.Show(this, "ESTUDIANTE INCRITO CON EXITO");
            }
            catch (Exception E)
            {

                MetroFramework.MetroMessageBox.Show(this, "ALGO SALIO MAL " + E.ToString());
            }
        }
    }
}
