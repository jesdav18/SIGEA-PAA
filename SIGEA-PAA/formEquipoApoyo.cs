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
using MetroFramework;
using MetroFramework.Forms;

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
        private void formEquipoApoyo_FormClosing(Object sender, FormClosingEventArgs e)
        {

            Btn_Salir.PerformClick();

        }

        private void btn_Inscripcion_Click(object sender, EventArgs e)
        {
            Panel1.Controls.Clear();
            if (!Panel1.Controls.Contains(User_Control.Modulo_Inscripcion.Instancia))  /*Determina si el Panel Contiene el Modulo X  */
            {
                Panel1.Controls.Add(User_Control.Modulo_Inscripcion.Instancia);       /*Si no esta, lo Carga*/

                User_Control.Modulo_Inscripcion.Instancia.Dock = DockStyle.Fill;
                User_Control.Modulo_Inscripcion.Instancia.Sesion = sesion;
                BringToFront();
            }
            else
                User_Control.Modulo_Inscripcion.Instancia.BringToFront();


            /*Si ya estaba cargado canteriormente lo trae al frente*/
        }

        
        private void Btn_Salir_Click(object sender, EventArgs e)
        {

                Close();               
        }

        private void btn_Asistencia_Click_1(object sender, EventArgs e)
        {
            Panel1.Controls.Clear();
            if (!Panel1.Controls.Contains(User_Control.Modulo_Asistencia.Instancia))
            {
                Panel1.Controls.Add(User_Control.Modulo_Asistencia.Instancia);
                User_Control.Modulo_Asistencia.Instancia.Dock = DockStyle.Fill;
                BringToFront();
            }
            else
                User_Control.Modulo_Asistencia.Instancia.BringToFront();
        }

        private void btn_Reportes_Click_1(object sender, EventArgs e)
        {
            Panel1.Controls.Clear();
            if (!Panel1.Controls.Contains(User_Control.Modulo_Reportes.Instancia))
            {
                Panel1.Controls.Add(User_Control.Modulo_Reportes.Instancia);

                User_Control.Modulo_Reportes.Instancia.Dock = DockStyle.Fill;
                BringToFront();
            }
            else
                User_Control.Modulo_Reportes.Instancia.BringToFront();
        }

        private void btn_Estudiante_Click_1(object sender, EventArgs e)
        {
            Panel1.Controls.Clear();
            if (!Panel1.Controls.Contains(User_Control.Modulo_Estudiante.Instancia))
            {
                Panel1.Controls.Add(User_Control.Modulo_Estudiante.Instancia);
                User_Control.Modulo_Estudiante.Instancia.Dock = DockStyle.Fill;
                User_Control.Modulo_Estudiante.Instancia.Sesion = sesion;
                BringToFront();
            }
            else
                User_Control.Modulo_Estudiante.Instancia.BringToFront();
        }
    }
}
