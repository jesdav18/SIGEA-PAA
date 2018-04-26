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
    public partial class Modulo_PAA : UserControl
    {
        public string Sesion { get; set; }

        public Modulo_PAA()
        {
            InitializeComponent();
        }
        private static Modulo_PAA _instancia;
        public static Modulo_PAA Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new Modulo_PAA();
                return _instancia;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Modulo_PAA_Load(object sender, EventArgs e)
        {
            Lbl_PAA.Text = "";
            Lbl_PAA.Text = DateTime.Now.Year.ToString();

        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            string evaluador = "";
            string codigo = Cmb_PAA.Text.ToString() + Lbl_guion.Text.ToString() + Lbl_PAA.Text.ToString();
            Utilidades util = new Utilidades();
            evaluador = util.RegistrarPAA("spR_CrearPAA", _paa: codigo, _inicioPaa: Dt_PAA_Inicio.Value.ToString(), _finalPaa: Dt_PAA_Final.Value.ToString(), _inicioInscripcion: Dt_Inscripcion_Inicio.Value.ToString(), _finalInscripcion: Dt_Inscripcion_Final.Value.ToString(), _cupos: Convert.ToInt32(Txt_Voluntarios.Text), _usuario: Sesion);
            switch (evaluador)
            {

                case "0":
                    MetroFramework.MetroMessageBox.Show(this, "Esta Prueba de Actitud ya Existe");
                    break;

                case "1":
                    MetroFramework.MetroMessageBox.Show(this, "Prueba de Aptitud REGISTRADA CON EXITO");
                    break;
                case "2":
                    MetroFramework.MetroMessageBox.Show(this, "Algo Paso");
                    break;

            }



        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {

        }


        private void Dt_PAA_Inicio_ValueChanged(object sender, EventArgs e)
        {
            Utilidades diferencia = new Utilidades();
            Lbl_Diferencia.Text = diferencia.Diferencia_Fechas(Dt_Inscripcion_Inicio.Value.Date, Dt_Inscripcion_Final.Value.Date);
            //DateTime fecha1 = Dt_PAA_Inicio.Value.Date;
            //DateTime fecha2 = Dt_PAA_Final.Value.Date;

            //TimeSpan diferencia = fecha2 - fecha1;
            //int dias = diferencia.Days;
            //if (dias <= 0)
            //{
            //    Lbl_Diferencia.ForeColor = Color.Red;
            //    Lbl_Diferencia.Text = "Seleccione una Fecha Correcta";

            //}
            //else
            //{
            //    Lbl_Diferencia.ForeColor = Color.Black;
            //    Lbl_Diferencia.Text = dias.ToString() + " Dias";
            //}

        }

        private void Dt_PAA_Final_ValueChanged(object sender, EventArgs e)
        {
            Utilidades diferencia = new Utilidades();
            Lbl_Diferencia.Text = diferencia.Diferencia_Fechas(Dt_PAA_Inicio.Value.Date, Dt_PAA_Final.Value.Date);
            //Lbl_Diferencia.ForeColor = Color.Black;
            //Lbl_Diferencia.Text = "Diferencia";
            //DateTime fecha1 = Dt_PAA_Inicio.Value.Date;
            //DateTime fecha2 = Dt_PAA_Final.Value.Date;

            //TimeSpan diferencia = fecha2 - fecha1;
            //int dias = diferencia.Days;
            //if (dias <= 0)
            //{
            //    Lbl_Diferencia.ForeColor = Color.Red;
            //    Lbl_Diferencia.Text = "Seleccione una Fecha Correcta";

            //}
            //else
            //{
            //    Lbl_Diferencia.ForeColor = Color.Black;
            //    Lbl_Diferencia.Text = dias.ToString() + " Dias";
            //}
        }

        private void Dt_Inscripcion_Inicio_ValueChanged(object sender, EventArgs e)
        {
            Utilidades diferencia = new Utilidades();
            Lbl_Diferencia2.Text = diferencia.Diferencia_Fechas(Dt_Inscripcion_Inicio.Value.Date, Dt_Inscripcion_Final.Value.Date);
        }

        private void Dt_Inscripcion_Final_ValueChanged(object sender, EventArgs e)
        {
            Utilidades diferencia = new Utilidades();
            Lbl_Diferencia2.Text = diferencia.Diferencia_Fechas(Dt_Inscripcion_Inicio.Value.Date, Dt_Inscripcion_Final.Value.Date);
        }
    }
}
