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
    public partial class Modulo_PAA : UserControl
    {
        Mensajes msjP = new Mensajes(); //MOSTRARÁ LOS MENSAJES EN EL GROUPBOX DE PAA,
        Mensajes msjRetroalimentacion = new Mensajes(); //MOSTRARÁ LOS MENSAJES EN EL GROUPBOX DE INSCRIPCION.
        Mensajes msjInscripcion = new Mensajes();

        bool j = false; //SIRVE PARA VALIDAR SI LAS DOS FECHAS (INCIAL Y FINAL) DE LA PAA ESTÁN EN INGRESADAS CORRECTAMENTE.  
        bool i = false; //SRIVE PARA VLIDAD SI LAS DOS FECHAS(INCIAL Y FINAL) DE LA INSCRIPCION PAA ESTÁ INGRESADAS CORRECTAMENTE.
        
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

        private void Modulo_PAA_Load(object sender, EventArgs e)
        {
            int Año = Convert.ToInt32(DateTime.Now.Year.ToString())+1;
            for (int i = 1990; i <Año; i++)
            {
                Cmb_Año_Busqueda.Items.Add(i.ToString());
                
            }
            Lbl_Año.Text = "";
            Lbl_Año.Text = DateTime.Now.Year.ToString();
           
            
            
        }

        private void Dt_PAA_Inicio_ValueChanged(object sender, EventArgs e)
        {
            msjP.limpiarMensajeEnPantalla();
            Utilidades diferencia = new Utilidades();
            int x;
            x = diferencia.Diferencia_Fechas(Dt_PAA_Inicio.Value.Date, Dt_PAA_Final.Value.Date);
            Determinar_Fechas(x, "groupBoxPAA");
        }

        private void Dt_PAA_Final_ValueChanged(object sender, EventArgs e)
        {
            msjP.limpiarMensajeEnPantalla();
            Utilidades diferencia = new Utilidades();
            int x;
            x = diferencia.Diferencia_Fechas(Dt_PAA_Inicio.Value.Date, Dt_PAA_Final.Value.Date);
            Determinar_Fechas(x, "groupBoxPAA");
        }

        private void Dt_Inscripcion_Inicio_ValueChanged(object sender, EventArgs e)
        {
            msjInscripcion.limpiarMensajeEnPantalla();
            Utilidades diferencia = new Utilidades();
            int x;
            x = diferencia.Diferencia_Fechas(Dt_Inscripcion_Inicio.Value.Date, Dt_Inscripcion_Final.Value.Date);
            Determinar_Fechas(x, "groupBoxInscripcion");
        }

        private void Dt_Inscripcion_Final_ValueChanged(object sender, EventArgs e)
        {
            msjInscripcion.limpiarMensajeEnPantalla();
            Utilidades diferencia = new Utilidades();
            int x;
            x = diferencia.Diferencia_Fechas(Dt_Inscripcion_Inicio.Value.Date, Dt_Inscripcion_Final.Value.Date);
            Determinar_Fechas(x, "groupBoxInscripcion");

        }

        private void Btn_Registrar_PAA_Click(object sender, EventArgs e)
        {
            string evaluador = "";
            string codigo = Cmb_PAA.Text.ToString() + Lbl_Guion.Text.ToString() + Lbl_Año.Text.ToString();
            Utilidades util = new Utilidades();
            evaluador = util.RegistrarPAA("spR_CrearPAA", _paa: codigo, _inicioPaa: Dt_PAA_Inicio.Value.ToString(), _finalPaa: Dt_PAA_Final.Value.ToString(), _inicioInscripcion: Dt_Inscripcion_Inicio.Value.ToString(), _finalInscripcion: Dt_Inscripcion_Final.Value.ToString(), _cupos: Convert.ToInt32(Txt_Cupos.Text), _usuario: Sesion);
            switch (evaluador)
            {

                case "0":
                    MetroFramework.MetroMessageBox.Show(this, "Esta Prueba de Aptitud ya fue Registrada","SIGEA-PAA",MessageBoxButtons.OK,MessageBoxIcon.Information,100);
                    break;

                case "1":
                    MetroFramework.MetroMessageBox.Show(this, "Prueba de Aptitud registrada con éxito", "SIGEA-PAA", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
                    break;
                case "2":
                    MetroFramework.MetroMessageBox.Show(this, "Algo Salió mal con el registro de esta prueba de Aptitud", "SIGEA-PAA", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
                    break;

            }
        }
        public void Determinar_Fechas(int _x, string _control)
        {


            if (_control == "groupBoxPAA")
            {
                if (_x < 0 || _x > 2 || _x < 2)
                {
                    Controls["tabControlAdmonPAA"].Controls["tabPageRegistrar"].Controls["groupBoxPAA"].Controls.Add(msjP.crearMensajeEnPantalla("Seleccione Fecha Correcta", 296, 81, false, 11));
                    j = false;
                }
                else
                {
                    Controls["tabControlAdmonPAA"].Controls["tabPageRegistrar"].Controls["groupBoxPAA"].Controls.Add(msjP.crearMensajeEnPantalla("Periodo de " + (_x + 1) + " dias", 296, 81, true, 11));
                    j = true;
                }

            }
            if (_control == "groupBoxInscripcion")
            {
                if (_x < 0 || _x < 15)
                {
                    Controls["tabControlAdmonPAA"].Controls["tabPageRegistrar"].Controls["groupBoxInscripcion"].Controls.Add(msjInscripcion.crearMensajeEnPantalla("Seleccione Fecha Correcta", 296, 81, false, 11));
                    i = false;
                }
                else
                {
                    Controls["tabControlAdmonPAA"].Controls["tabPageRegistrar"].Controls["groupBoxInscripcion"].Controls.Add(msjInscripcion.crearMensajeEnPantalla("Periodo de " + (_x) + " dias", 296, 81, true, 11));
                    i = true;
                }

            }
            validarIngresoDatosPAA();//VALIDANDO QUE ESTÉN COMPLETOS CAMPOS OBLOGATORIOS PARA ACTIVAR BOTON DE REGISTRAR
          
        }

        public void Determinar_FechasParaEditar(int _x, string _control)
        {


            if (_control == "groupBoxPAA_Editar")
            {
                if (_x < 0 || _x > 2 || _x < 2)
                {
                    Controls["tabControlAdmonPAA"].Controls["tabPageEditar"].Controls["groupBoxPAA_Editar"].Controls.Add(msjP.crearMensajeEnPantalla("Seleccione Fecha Correcta", 296, 81, false, 11));
                    j = false;
                }
                else
                {
                    Controls["tabControlAdmonPAA"].Controls["tabPageEditar"].Controls["groupBoxPAA_Editar"].Controls.Add(msjP.crearMensajeEnPantalla("Periodo de " + (_x + 1) + " dias", 296, 81, true, 11));
                    j = true;
                }

            }
            if (_control == "groupBoxInscripcion_Editar")
            {
                if (_x < 0 || _x < 15)
                {
                    Controls["tabControlAdmonPAA"].Controls["tabPageEditar"].Controls["groupBoxInscripcion_Editar"].Controls.Add(msjInscripcion.crearMensajeEnPantalla("Seleccione Fecha Correcta", 296, 81, false, 11));
                    i = false;
                }
                else
                {
                    Controls["tabControlAdmonPAA"].Controls["tabPageEditar"].Controls["groupBoxInscripcion_Editar"].Controls.Add(msjInscripcion.crearMensajeEnPantalla("Periodo de " + (_x) + " dias", 296, 81, true, 11));
                    i = true;
                }

            }
            validarIngresoDatosPAA();//VALIDANDO QUE ESTÉN COMPLETOS CAMPOS OBLOGATORIOS PARA ACTIVAR BOTON DE REGISTRAR

        }

        private void Btn_Buscar_PAA_Click(object sender, EventArgs e)
        {
            string codigo = Cmb_Codigo_Busqueda.Text + Lbl_Guion_Busqueda.Text + Cmb_Año_Busqueda.Text;
            Conexiones.Conexion cone = new Conexiones.Conexion();
            DataRow dr = cone.busquedaDatos(codigo, "spB_PAA", "@PAA").Rows[0];

            //SI EL NÚMERO DE COLUMNAS QUE DEVUELVE LA FUNCION "busquedaDatos" A TRAVÉS DEL DATATABLE ES IGUAL A 1, SIGNIFICA QUE
            //LA PAA NO EXISTE. CASO CONTRARIO, LA PAA SE ENCONTRÓ, Y SE LLENAN LAS CAJAS DE TEXTO CON SU INFORMACIÓN.

            if (dr.Table.Columns.Count.ToString() == "1")
            {
                Btn_Actualizar.Enabled = false;
                MetroFramework.MetroMessageBox.Show(this, "Esta Prueba No existe o Esta Activa", "SIGEA-PAA", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
            }
            else
            {
                //MOSTRANDO INFORMACION DE LA PRUEBA DE APTITUD ACADÉMICA

                Txt_PAA_Editar.Text = dr[1].ToString();
                Dt_PAA_Inicio_Editar.Text = dr[2].ToString();
                Dt_PAA_Final_Editar.Text = dr[3].ToString();
                Dt_Inscripcion_Inicio_Editar.Text = dr[4].ToString();
                Dt_Inscripcion_Final_Editar.Text = dr[5].ToString();
                Txt_Cupos_Editar.Text = dr[6].ToString();
                Btn_Actualizar.Enabled = true;

                Txt_PAA_Editar.Enabled = true;
                Dt_PAA_Inicio_Editar.Enabled = true;
                Dt_PAA_Final_Editar.Enabled = true;
                Dt_Inscripcion_Inicio_Editar.Enabled = true;
                Dt_Inscripcion_Final_Editar.Enabled = true;
                Txt_Cupos_Editar.Enabled = true;



            }
        }

        private void Dt_PAA_Inicio_Editar_ValueChanged(object sender, EventArgs e)
        {
            msjP.limpiarMensajeEnPantalla();
            Utilidades diferencia = new Utilidades();
            int x;
            x = diferencia.Diferencia_Fechas(Dt_PAA_Inicio_Editar.Value.Date, Dt_PAA_Final_Editar.Value.Date);
            Determinar_FechasParaEditar(x, "groupBoxPAA_Editar");
        }

        private void Dt_PAA_Final_Editar_ValueChanged(object sender, EventArgs e)
        {
            msjP.limpiarMensajeEnPantalla();
            Utilidades diferencia = new Utilidades();
            int x;
            x = diferencia.Diferencia_Fechas(Dt_PAA_Inicio_Editar.Value.Date, Dt_PAA_Final_Editar.Value.Date);
            Determinar_FechasParaEditar(x, "groupBoxPAA_Editar");
        }

        private void Dt_Inscripcion_Inicio_Editar_ValueChanged(object sender, EventArgs e)
        {
             msjInscripcion.limpiarMensajeEnPantalla();
            Utilidades diferencia = new Utilidades();
            int x;
            x = diferencia.Diferencia_Fechas(Dt_Inscripcion_Inicio_Editar.Value.Date, Dt_Inscripcion_Final_Editar.Value.Date);
            Determinar_FechasParaEditar(x, "groupBoxInscripcion_Editar");
        }

        private void Dt_Inscripcion_Final_Editar_ValueChanged(object sender, EventArgs e)
        {
            msjInscripcion.limpiarMensajeEnPantalla();
            Utilidades diferencia = new Utilidades();
            int x;
            x = diferencia.Diferencia_Fechas(Dt_Inscripcion_Inicio_Editar.Value.Date, Dt_Inscripcion_Final_Editar.Value.Date);
            Determinar_FechasParaEditar(x, "groupBoxInscripcion_Editar");
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            string evaluador = "";
            string codigo = Cmb_Año_Busqueda.Text.ToString() + Lbl_Guion_Busqueda.Text.ToString() + Cmb_Año_Busqueda.Text;
            
            Utilidades util = new Utilidades();
            evaluador = util.ActualizarPAA("spU_PAA", _paa: codigo, _paainicio: Dt_PAA_Inicio_Editar.Value.ToString(), _paafinal: Dt_PAA_Final_Editar.Value.ToString(), _inscripcioninicio: Dt_Inscripcion_Inicio_Editar.Value.ToString(), _inscripcionfinal: Dt_Inscripcion_Final_Editar.Value.ToString(), _cupos: Convert.ToInt32(Txt_Cupos_Editar.Text), _sesion: Sesion);
            switch (evaluador)
            {

                
                case "1":
                    MetroFramework.MetroMessageBox.Show(this, "Prueba de Aptitud Actualizada con éxito", "SIGEA-PAA", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
                    break;
                case "2":
                    MetroFramework.MetroMessageBox.Show(this, "Algo Salió Mal, Valide la información ingresada", "SIGEA-PAA", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
                    break;

            }
        }

        private void Cmb_Codigo_Busqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarIngresoDatosBusquedaPAA();
        }

        private void Cmb_Año_Busqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarIngresoDatosBusquedaPAA();  
        }

        private void Txt_Cupos_TextChanged(object sender, EventArgs e)
        {
            validarIngresoDatosPAA(); 
        }

        public void validarIngresoDatosPAA()
        {
            //SE EVALÚA SI LOS DATOS INGRESADOS ESTÁN CORRECTOS EN LONGITUD Y DIFERENCIA DE FECHAS, DE SER ASI, SE ACTIVARÁ BOTÓN PARA REGISTRA PAA.
            if (i == true && j == true && Txt_Cupos.Text.Length > 0)
            {
                Btn_Registrar_PAA.Enabled = true;
            }
            else
            {
                Btn_Registrar_PAA.Enabled = false;
            }
        }
        public void validarIngresoDatosBusquedaPAA()
        {
            //SE EVALÚA SI LOS COMBOBOX PARA BUSCAR PAA HAN SIDO UTILIZADOS PARA SELECCIONAR LA INFORMACIÓN NECESARIA PARA BUSCAR PAA, SI ESTO ES CORRECTO, EL BOTON BUSCAR SE ACTIVA.
            //CASO CONTRARIO SE DESACTIVA EL BOTON BUSCAR
            if (Cmb_Codigo_Busqueda.Text != "" && Cmb_Año_Busqueda.Text != "")
            {
                Btn_Buscar_PAA.Enabled = true;
            }
            else
            {
                Btn_Buscar_PAA.Enabled = false;
            }
        }

        private void Txt_Cupos_Editar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //VALIDANDO QUE NO SE INGRESE NADA QUE NO SEA NUMEROS
           if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
           else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }  
            else
            {
                e.Handled = true;
            }
          
            
        }

        private void Txt_Cupos_KeyPress(object sender, KeyPressEventArgs e)
        {
            //VALIDANDO QUE NO SE INGRESE NADA QUE NO SEA NUMEROS
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tabControlAdmonPAA_Enter(object sender, EventArgs e)
        {
            /*ESTABLECIENDO ORDEN DE TABULACION PARA COMODIDAD MIENTRAS SE TRABAJA SOBRE EDITAR REGISTRO DE PRUEBA DE APTITUD*/
            Cmb_PAA.TabIndex = 0;
            Cmb_Año_Busqueda.TabIndex = 1;
            Btn_Buscar_PAA.TabIndex = 2;
            Txt_PAA_Editar.TabIndex = 3;
            Dt_PAA_Inicio_Editar.TabIndex = 4;
            Dt_PAA_Final_Editar.TabIndex = 5;
            Dt_Inscripcion_Inicio_Editar.TabIndex = 6;
            Dt_Inscripcion_Final_Editar.TabIndex = 7;
            Txt_Cupos_Editar.TabIndex = 8;
            Btn_Actualizar.TabIndex = 9;

            /*ESTABLECIENDO ORDEN DE TABULACIÓN PARA COMODIDAD MIENTRAS SE TRABAJA SOBRE EL REGISTRO DE PRUEBA DE APTITUD.*/
            Cmb_PAA.TabIndex = 10;
            Dt_PAA_Inicio.TabIndex = 11;
            Dt_PAA_Final.TabIndex = 12;
            Dt_Inscripcion_Inicio.TabIndex = 13;
            Dt_Inscripcion_Final.TabIndex = 14;
            Txt_Cupos.TabIndex = 15;
            Btn_Registrar_PAA.TabIndex = 16;

        }

        private void tabPageEditar_Enter(object sender, EventArgs e)
        {
            
        }

        private void tabPageRegistrar_Enter(object sender, EventArgs e)
        {
          
        }
    }
}
