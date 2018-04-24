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
        public string Sesion { get; set; }


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
            string evaluador = "";   
            
            Utilidades util = new Utilidades();
            evaluador = util.RegistrarAsistencia("spIns_Asistencia", Txt_Cuenta.Text,Sesion);

            switch (evaluador)
            {
                case "1": MetroFramework.MetroMessageBox.Show(this, "ASISTENCIA REGISTRADA CON EXITO");
                          break;
                case "2": MetroFramework.MetroMessageBox.Show(this, "NO SE PUEDE REGISTRAR MÁS DE UNA ASISTENCIA EN EL DÍA");
                          break;
                case "3": MetroFramework.MetroMessageBox.Show(this, "ALGO SALIÓ MAL");
                          break;
                case "0": MetroFramework.MetroMessageBox.Show(this, "ESTE ESTUDIANTE YA TIENE COMPLETADA SU ASISTENCIA");
                          break;
            }
           
        }
    }
}
