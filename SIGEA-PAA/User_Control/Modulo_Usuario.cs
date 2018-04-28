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
    public partial class Modulo_Usuario : UserControl
    {
        public Modulo_Usuario()
        {
            InitializeComponent();
        }
        public string Sesion { get; set; }
        Mensajes msjRetroalimentacion = new Mensajes();//OBJETO QUE SERVIRÁ PARA MOSTRAR MENSAJES EN PANTALLA.

        private static Modulo_Usuario _instancia;
        public static Modulo_Usuario Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new Modulo_Usuario();
                return _instancia;
            }
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Registrar_Usuario_Click(object sender, EventArgs e)
        {
            string evaluador = "";
            Utilidades util = new Utilidades();
            evaluador = util.RegistrarUsuario("spR_Usuario", Txt_Usuario_Registrar.Text.Trim(), Txt_Password_Registrar.Text.Trim(), Convert.ToInt32(Txt_Empleado_Registrar.Text.Trim()), Convert.ToInt32(Cmb_TipoAcceso_Registrar.SelectedValue.ToString()), Sesion);
            switch (evaluador)
            {
                case "0":
                    MetroFramework.MetroMessageBox.Show(this, "Esta Usuario ya Existe");
                    break;
                case "1":
                    MetroFramework.MetroMessageBox.Show(this, "Usuario Registrado con Exito");
                    break;
                case "2":
                    MetroFramework.MetroMessageBox.Show(this, "Algo salio Mal");
                    break;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Modulo_Usuario_Load(object sender, EventArgs e)
        {
            DataTable dt;
            Utilidades util = new Utilidades();

            dt = new DataTable();
            dt.Load(util.TraerDatos("Select * from TiposAcceso"));

            Cmb_TipoAcceso_Registrar.ValueMember = "codigoTipoAcceso";
            Cmb_TipoAcceso_Registrar.DisplayMember = "descripcionTipoAcceso";
            Cmb_TipoAcceso_Registrar.DataSource = dt;

            Cmb_TipoAcceso_Editar.ValueMember = "codigoTipoAcceso";
            Cmb_TipoAcceso_Editar.DisplayMember = "descripcionTipoAcceso";
            Cmb_TipoAcceso_Editar.DataSource = dt;


        }

        private void Btn_Buscar_Usuario_Click(object sender, EventArgs e)
        {

            Conexiones.Conexion cone = new Conexiones.Conexion();
            DataRow dr = cone.busquedaDatos(Txt_Buscar_Usuario_Editar.Text, "spB_Usuario", "@codigoUsuario").Rows[0];

            //SI EL NÚMERO DE COLUMNAS QUE DEVUELVE LA FUNCION "busquedaDatos" A TRAVÉS DEL DATATABLE ES IGUAL A 1, SIGNIFICA QUE
            //EL ESTUDIANTE NO EXISTE. CASO CONTRARIO, EL ESTUDIANTE SE ENCONTRÓ, Y SE LLENAN LAS CAJAS DE TEXTO CON SU INFORMACIÓN.

            if (dr.Table.Columns.Count.ToString() == "1")
            {
                Btn_Editar_Usuario.Enabled = false;
                Controls.Add(msjRetroalimentacion.crearMensajeEnPantalla("ESTE USUARIO NO EXISTE", 115, 132, false, 9));
            }
            else
            {
                //MOSTRANDO INFORMACION DE ESTUDIANTE

                Txt_Usuario_Editar.Text = dr[1].ToString();
                Txt_Password_Editar.Text = dr[2].ToString();
                Txt_Empleado_Editar.Text = dr[3].ToString();
                Cmb_TipoAcceso_Editar.Text = dr[4].ToString();
                Btn_Editar_Usuario.Enabled = true;


            }

        }

        private void Btn_Editar_Usuario_Click(object sender, EventArgs e)
        {
            string evaluador = "";
            Utilidades util = new Utilidades();
            evaluador = util.ActualizarUsuario("spU_Usuario", (Txt_Usuario_Editar.Text), Txt_Password_Editar.Text, Convert.ToInt32(Cmb_TipoAcceso_Editar.SelectedValue), Sesion,Txt_Buscar_Usuario_Editar.Text.Trim());
            switch (evaluador)
            {

                case "1":
                    MetroFramework.MetroMessageBox.Show(this, "Usuario Editado con Exito");
                    break;

                case "2":
                    MetroFramework.MetroMessageBox.Show(this, "Algo Salio Mal");
                    break;

            }
        }

        private void Txt_Buscar_Usuario_Editar_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Usuario_Editar_Usuario_Click(object sender, EventArgs e)
        {

        }
    }
}
