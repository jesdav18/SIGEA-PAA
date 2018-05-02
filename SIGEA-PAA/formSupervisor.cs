using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGEA_PAA
{
    public partial class formSupervisor : MetroFramework.Forms.MetroForm
    {
        string sesion;
        public formSupervisor()
        {
            InitializeComponent();
        }
        public formSupervisor(string _sesion, string _nombreusuariosesion)
        {
            InitializeComponent();
            sesion = _sesion;
            labelUsuario.Text = "Bienvenido " + _nombreusuariosesion;
        }

        private void formSupervisor_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_Inscripcion_Click(object sender, EventArgs e)
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

        private void Btn_Administracion_Estudiante_Click(object sender, EventArgs e)
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

        private void Btn_Asistencia_Click(object sender, EventArgs e)
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

        //private void Btn_Reportes_Click(object sender, EventArgs e)
        //{
        //    Panel1.Controls.Clear();
        //    if (!Panel1.Controls.Contains(User_Control.Modulo_Reportes.Instancia))
        //    {
        //        Panel1.Controls.Add(User_Control.Modulo_Reportes.Instancia);

        //        User_Control.Modulo_Reportes.Instancia.Dock = DockStyle.Fill;
        //        BringToFront();
        //    }
        //    else
        //        User_Control.Modulo_Reportes.Instancia.BringToFront();
        //}

        private void Btn_Reportes_Click_1(object sender, EventArgs e)
        {
            Panel1.Controls.Clear();
            if (!Panel1.Controls.Contains(User_Control.Modulo_Reportes_Supervisor.Instancia))
            {
                Panel1.Controls.Add(User_Control.Modulo_Reportes_Supervisor.Instancia);

                User_Control.Modulo_Reportes_Supervisor.Instancia.Dock = DockStyle.Fill;
                BringToFront();
            }
            else
                User_Control.Modulo_Reportes_Supervisor.Instancia.BringToFront();
        }

        private void Btn_PAA_Click(object sender, EventArgs e)
        {
            Panel1.Controls.Clear();
            if (!Panel1.Controls.Contains(User_Control.Modulo_PAA.Instancia))
            {
                Panel1.Controls.Add(User_Control.Modulo_PAA.Instancia);
                User_Control.Modulo_PAA.Instancia.Sesion = sesion;
                User_Control.Modulo_PAA.Instancia.Dock = DockStyle.Fill;
                BringToFront();
            }
            else
                User_Control.Modulo_PAA.Instancia.BringToFront();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
