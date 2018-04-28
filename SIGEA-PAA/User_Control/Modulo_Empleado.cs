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
    public partial class Modulo_Empleado : UserControl
    {
        Mensajes msj = new Mensajes();
        public Modulo_Empleado()
        {
            InitializeComponent();
        }
        public string Sesion { get; set; }


        private static Modulo_Empleado _instancia;
        public static Modulo_Empleado Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new Modulo_Empleado();
                return _instancia;
            }
        }

        private void Btn_Registrar_Usuario_Click(object sender, EventArgs e)
        {
            string evaluador = "";
            Utilidades util = new Utilidades();
            evaluador=util.RegistrarEmpleado("spR_Empleado", Convert.ToInt32(Txt_Empleado_Registrar.Text.Trim()), Txt_Nombre_Registrar.Text.Trim(),Txt_Identidad_Registrar.Text.Trim(),Sesion);

            switch (evaluador)
            {
                case "0":
                    MetroFramework.MetroMessageBox.Show(this, "Este Usuario ya Existe");
                    break;
                case "1":
                    MetroFramework.MetroMessageBox.Show(this, "Usuario Creado con Exito");
                    break;

                case "2":
                    MetroFramework.MetroMessageBox.Show(this, "Algo Salio Mal");
                    break;

            }
        }

        private void Btn_Editar_Usuario_Click(object sender, EventArgs e)
        {
            bool estado;

            if (Cmb_TipoAcceso_Editar.Text == "ACTIVO")
            {
                estado = true;
            }
            else
            {
                estado = false;
            }
            string evaluador = "";
            Utilidades util = new Utilidades();
            evaluador = util.ActualizarEmpleado("spU_Empleado", Convert.ToInt32(Txt_Empleado_Editar.Text), Txt_Password_Editar.Text, Txt_Identidad_Editar.Text.ToString(), Sesion,estado);
            switch (evaluador)
            {
                case "0":
                    MetroFramework.MetroMessageBox.Show(this, "Este Usuario ya Existe");
                    break;
                case "1":
                    MetroFramework.MetroMessageBox.Show(this, "Usuario Editado con Exito");
                    break;

                case "2":
                    MetroFramework.MetroMessageBox.Show(this, "Algo Salio Mal");
                    break;

            }
           

        }

        private void Btn_Buscar_Empleado_Click(object sender, EventArgs e)
        {
            Utilidades util = new Utilidades();
            DataRow dr = util.busquedaEmpleado("spB_Empleado", Convert.ToInt32(Txt_Buscar_Empleado_Editar.Text), "@codigo").Rows[0];

            if (dr.Table.Columns.Count.ToString() == "1")
            {
                Btn_Editar_Usuario.Enabled = false;
                Controls.Add(msj.crearMensajeEnPantalla("ESTE ESTUDIANTE NO EXISTE", 115, 132, false, 9));
            }
            else
            {
                

                Txt_Empleado_Editar.Text = dr[0].ToString();
                Txt_Password_Editar.Text = dr[1].ToString();
                Txt_Identidad_Editar.Text = dr[2].ToString();
                if (dr[3].ToString() == "1")
                {
                    Cmb_TipoAcceso_Editar.Items.Add("Activo");
                }
                else
                {
                    Cmb_TipoAcceso_Editar.Items.Add("Inactivo");
                }


            }


        }
    }
}
