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
using MetroFramework;

namespace SIGEA_PAA.User_Control
{
    public partial class Modulo_Estudiante : MetroFramework.Controls.MetroUserControl
    {

        bool hayModificaciones = false;
        public string Sesion { get; set; }
        Mensajes msjRetroalimentacion = new Mensajes();//OBJETO QUE SERVIRÁ PARA MOSTRAR MENSAJES EN PANTALLA.

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
            DataTable dt;
            Conexiones.Conexion conex = new Conexiones.Conexion();
            dt = new DataTable();
            dt.Load(conex.traerDatos("spV_MostrarCarrera"));

            Cmb_Carrera.ValueMember = "codigoCarrera";
            Cmb_Carrera.DisplayMember = "nombreCarrera";
            Cmb_Carrera.DataSource = dt;

            Cmb_Carrera_Edicion.ValueMember = "codigoCarrera";
            Cmb_Carrera_Edicion.DisplayMember = "nombreCarrera";
            Cmb_Carrera_Edicion.DataSource = dt;
            metroTabControl1.SelectedIndex = 0;
        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            hayModificaciones = false;
            string evaluador = "";
            Utilidades util = new Utilidades();
            evaluador = util.TransaccionEstudiante("spR_Estudiante", txtCuenta.Text.Trim(), Txt_Nombre.Text.Trim(), txtIdentidad.Text.Trim(), Convert.ToInt32(Cmb_Carrera.SelectedValue.ToString()),Txt_Telefono.Text,(Txt_Correo_Registro.Text + labelArroba.Text + Txt_Dominio.Text), Sesion);
            switch (evaluador)
            {

                case "0":
                    MetroFramework.MetroMessageBox.Show(this, "El estudiante ya está registrado, revise la información ingresada", "SIGEA-PPA", MessageBoxButtons.OK, MessageBoxIcon.Warning, 100);
                    
                    break;

                case "1":
                    MetroFramework.MetroMessageBox.Show(this, "Estudiante Registrado con éxito","SIGEA-PAA", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
                    LimpiarCajasTexto();
                    
                    break;
                case "2":
                    MetroFramework.MetroMessageBox.Show(this, "Algo salió mal, por favor, vuelva a intentarlo","SIGEA-PAA" ,MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                    break;

            }

        }

        private void Txt_Busqueda_Edicion_TextChanged(object sender, EventArgs e)
        {
            
            Txt_Cuenta_Edicion.Text = "";
            Txt_Identidad_Edicion.Text = "";
            Txt_Nombre_Edicion.Text = "";
            Cmb_Carrera_Edicion.Text = "";
            Txt_Correo_Editar.Text = "";
            Txt_Telefono_Editar.Text = "";
            Btn_Actualizar_Edicion.Enabled = false;

        }

        private void Btn_Actualizar_Edicion_Click(object sender, EventArgs e)
        {


            string evaluador = "";
            Utilidades util = new Utilidades();
            evaluador=util.TransaccionEstudiante("spU_Estudiante", Txt_Cuenta_Edicion.Text.Trim(), Txt_Nombre_Edicion.Text.Trim(), Txt_Identidad_Edicion.Text.Trim(), Convert.ToInt32(Cmb_Carrera.SelectedValue.ToString()), Txt_Telefono_Editar.Text.Trim(), Txt_Correo_Editar.Text.Trim(), Sesion);
            
            switch (evaluador)
            {

                case "1":
                    MetroFramework.MetroMessageBox.Show(this, "Estudiante Actualizado","SIGEA-PAA", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
                    limpiarDatos();
                    break;
                case "2":
                    MetroFramework.MetroMessageBox.Show(this, "Algo Paso","SIGEA-PAA", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                    break;

            }

        }

       

        private void Btn_Buscar_Edicion_Click(object sender, EventArgs e)
        {
            
            Conexiones.Conexion cone = new Conexiones.Conexion();
            DataRow dr = cone.busquedaDatos(Txt_Busqueda_Edicion.Text, "spB_ConsultaEstudiante", "@Cuenta").Rows[0];
            limpiarDatos();
            //SI EL NÚMERO DE COLUMNAS QUE DEVUELVE LA FUNCION "busquedaDatos" A TRAVÉS DEL DATATABLE ES IGUAL A 1, SIGNIFICA QUE
            //EL ESTUDIANTE NO EXISTE. CASO CONTRARIO, EL ESTUDIANTE SE ENCONTRÓ, Y SE LLENAN LAS CAJAS DE TEXTO CON SU INFORMACIÓN.

            /*if (dr.Table.Columns.Count.ToString() == "1")
            {
                Btn_Actualizar_Edicion.Enabled = false;
                Controls.Add(msjRetroalimentacion.crearMensajeEnPantalla("ESTE ESTUDIANTE NO EXISTE", 115, 132, false, 9));
            }
            else
            {
                //MOSTRANDO INFORMACION DE ESTUDIANTE

                Txt_Cuenta_Edicion.Text = dr[2].ToString();
                Txt_Nombre_Edicion.Text = dr[1].ToString();
                Txt_Identidad_Edicion.Text = dr[3].ToString();
                Cmb_Carrera_Edicion.Text = dr[4].ToString();
               Txt_Telefono_Editar.Text = dr[7].ToString();
               Txt_Correo_Editar.Text = dr[8].ToString();
                Btn_Actualizar_Edicion.Enabled = true;
                

            }*/

            if (dr[0].ToString() == "1")
            {
                //MOSTRANDO INFORMACION DE ESTUDIANTE

                Txt_Cuenta_Edicion.Text = dr[2].ToString();
                Txt_Nombre_Edicion.Text = dr[1].ToString();
                Txt_Identidad_Edicion.Text = dr[3].ToString();
                Cmb_Carrera_Edicion.Text = dr[4].ToString();
                Txt_Telefono_Editar.Text = dr[7].ToString();
                Txt_Correo_Editar.Text = dr[8].ToString();
                Btn_Actualizar_Edicion.Enabled = true;
            }
            else
            {
                Btn_Actualizar_Edicion.Enabled = false;
                //Controls.Add(msjRetroalimentacion.crearMensajeEnPantalla("ESTE ESTUDIANTE NO EXISTE", 281, 102, false, 9));
                MetroMessageBox.Show(this, "Este estudiante no existe", "SIGEA-PAA", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
            }
        }

      

        public void LimpiarCajasTexto()
        {
            txtCuenta.Text = "";
            Txt_Nombre.Text = "";
            txtIdentidad.Text = "";
            Txt_Correo_Registro.Text = "";
            Txt_Telefono.Text = "";
            
        }

       

        private void Txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar));
            Txt_Telefono.Text= Txt_Telefono.Text.Replace("  ", " ");
           Txt_Telefono.Select(Txt_Telefono.Text.Length, 0);
        }


        private void Cmb_Carrera_KeyDown(object sender, KeyEventArgs e)
        {
            Cmb_Carrera.DroppedDown = true;
        }

        

        private void Cmb_Carrera_Edicion_KeyDown(object sender, KeyEventArgs e)
        {
            Cmb_Carrera.DroppedDown = true;

        }

       

        private void Txt_Busqueda_Edicion_TextChanged_1(object sender, EventArgs e)
        {
            if (Txt_Busqueda_Edicion.MaskCompleted == true)
                Btn_Buscar_Edicion.Enabled = true;
            else
                Btn_Buscar_Edicion.Enabled = false;
        }

        private void Txt_Nombre_Edicion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Txt_Nombre_Edicion.Text = Txt_Nombre_Edicion.Text.Replace("  ", " ");
            Txt_Nombre_Edicion.Select(Txt_Nombre_Edicion.Text.Length, 0);

            //e.Handled = !(char.IsLetter(e.KeyChar));
            if (Char.IsLetter(e.KeyChar))
            {

                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }


        }

        private void Txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Txt_Nombre.Text = Txt_Nombre.Text.Replace("  ", " ");
            Txt_Nombre.Select(Txt_Nombre.Text.Length, 0);

            //e.Handled = !(char.IsLetter(e.KeyChar));
            if (Char.IsLetter(e.KeyChar))
            {

                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void Txt_Correo_Editar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Txt_Correo_Editar.Text = Txt_Correo_Editar.Text.Replace(" ", "");
            Txt_Correo_Editar.Select(Txt_Correo_Editar.Text.Length, 0);

            //e.Handled = !(char.IsLetter(e.KeyChar));
            
            
        }

        public void limpiarDatos()
        {
            Txt_Busqueda_Edicion.Text = "";
            Txt_Cuenta_Edicion.Text = "";
            Txt_Identidad_Edicion.Text = "";
            Txt_Correo_Editar.Text = "";
            Txt_Telefono_Editar.Text = "";
            Txt_Nombre_Edicion.Text = "";
            Txt_Dominio.Text = "";
            Btn_Buscar_Edicion.Enabled = false;

        }

        private void txtCuenta_TextChanged(object sender, EventArgs e)
        {
            activarBoton();    
        }

        public void activarBoton()
        {
            if(Txt_Nombre.Text.Length > 0 &&
                txtCuenta.MaskCompleted == true &&
                txtIdentidad.MaskCompleted == true &&
                Txt_Telefono.Text.Length > 0 &&
                Txt_Correo_Registro.Text.Length > 0 &&
                Txt_Dominio.Text.Length > 0)
            {
                Btn_Registrar.Enabled = true;
                msjRetroalimentacion.limpiarMensajeEnPantalla();
            }
            else
            {
                if (Txt_Nombre.Text.Length > 0 &&
                txtCuenta.Text.Length >0 == true &&
                txtIdentidad.Text.Length >0 == true &&
                Txt_Telefono.Text.Length > 0 &&
                Txt_Correo_Registro.Text.Length > 0 &&
                Txt_Dominio.Text.Length > 0 && Btn_Registrar.Enabled == false)
                {
                    Controls["GroupBox_Estudiante"].Controls["metroTabControl1"].Controls["metroTabPage1"].Controls.Add(msjRetroalimentacion.crearMensajeEnPantalla("Existen campos sin completar", 214, 411, false, 9));
                }



                    
                
            }
                
        }

        private void Txt_Correo_Registro_KeyPress(object sender, KeyPressEventArgs e)
        {
            Txt_Correo_Registro.Text = Txt_Correo_Registro.Text.Replace(" ", "");
            Txt_Correo_Registro.Select(Txt_Correo_Registro.Text.Length, 0);
        }

        private void Txt_Dominio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Txt_Dominio.Text = Txt_Dominio.Text.Replace(" ", "");
            Txt_Dominio.Select(Txt_Dominio.Text.Length, 0);
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

        }

        private void Txt_Nombre_TextChanged(object sender, EventArgs e)
        {
            
            activarBoton();
        }

        private void txtIdentidad_TextChanged(object sender, EventArgs e)
        {
         
            activarBoton();
        }

        private void Cmb_Carrera_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            activarBoton();
        }

        private void Txt_Telefono_TextChanged(object sender, EventArgs e)
        {
           
            activarBoton();
        }

        private void Txt_Correo_Registro_TextChanged(object sender, EventArgs e)
        {
          

            activarBoton();
        }

        private void Txt_Dominio_TextChanged(object sender, EventArgs e)
        {
         
            activarBoton();
        }

        private void txtCuenta_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void txtIdentidad_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void txtCuenta_Enter(object sender, EventArgs e)
        {

            txtCuenta.SelectionStart = 0;
        }

        private void txtIdentidad_Enter(object sender, EventArgs e)
        {
            txtIdentidad.SelectionStart = 0;
        }
    }
}
