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
        Mensajes msjP = new Mensajes();
        Mensajes msjRetroalimentacion = new Mensajes();
        Mensajes msjPAA = new Mensajes();
        Mensajes msjInscripcion = new Mensajes();
        bool j = false; //paa
        bool i = false; //inscripcion
        int contador = 0;
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
            Controls["metroTabControl1"].Controls["metroTabPage2"].Controls.Add( msjP.crearMensajeEnPantalla("Seleccione fecha correcta", 210, 450, false, 11));
            
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
        public void Determinar_Fechas(int _x, string _control)
        {


            if (_control == "groupBoxPAA")
            {
                if (_x < 0 || _x > 2 || _x < 2)
                {
                    Control dep = new Control();
                    dep = msjP.crearMensajeEnPantalla("Seleccione fecha correcta", 0, 0, false, 11);
                    Controls[_control].Controls.Add(dep);

                   
                    j = false;


                }
                else
                {

                    Controls["groupBoxPAA"].Controls.Add(msjP.crearMensajeEnPantalla((_x + 1) + " dias", 296, 81, true, 11));
                    j = true;

                }

            }
            if (_control == "groupBoxInscripcion")
            {
                if (_x < 0 || _x < 15)
                {
                    Controls[_control].Controls.Add(msjInscripcion.crearMensajeEnPantalla("Seleccione Fecha Correcta", 296, 81, false, 11));
                    i = false;
                }
                else
                {
                    Controls[_control].Controls.Add(msjInscripcion.crearMensajeEnPantalla((_x) + " dias", 296, 81, true, 11));
                    i = true;
                }

            }

            if (i == true && j == true)
            {
                Btn_Registrar_PAA.Enabled = true;
            }
            else
            {
                Btn_Registrar_PAA.Enabled = false;
            }


        }

        private void Btn_Buscar_PAA_Click(object sender, EventArgs e)
        {
            string codigo = Cmb_Codigo_Busqueda.Text + Lbl_Guion_Busqueda.Text + Cmb_Año_Busqueda.Text;
            Conexiones.Conexion cone = new Conexiones.Conexion();
            DataRow dr = cone.busquedaDatos(codigo, "spB_PAA", "@PAA").Rows[0];

            //SI EL NÚMERO DE COLUMNAS QUE DEVUELVE LA FUNCION "busquedaDatos" A TRAVÉS DEL DATATABLE ES IGUAL A 1, SIGNIFICA QUE
            //EL ESTUDIANTE NO EXISTE. CASO CONTRARIO, EL ESTUDIANTE SE ENCONTRÓ, Y SE LLENAN LAS CAJAS DE TEXTO CON SU INFORMACIÓN.

            if (dr.Table.Columns.Count.ToString() == "1")
            {
                Btn_Actualizar.Enabled = false;
                MetroFramework.MetroMessageBox.Show(this, "Esta Prueba No existe o Esta Activa");
            }
            else
            {
                //MOSTRANDO INFORMACION DE ESTUDIANTE

                Txt_PAA_Editar.Text = dr[1].ToString();
                Dt_PAA_Inicio_Editar.Text = dr[2].ToString();
                Dt_PAA_Final_Editar.Text = dr[3].ToString();
                Dt_Inscripcion_Inicio_Editar.Text = dr[4].ToString();
                Dt_Inscripcion_Final_Editar.Text = dr[5].ToString();
                Txt_Cupos_Editar.Text = dr[6].ToString();
                Btn_Actualizar.Enabled = true;


            }
        }

        private void Dt_PAA_Inicio_Editar_ValueChanged(object sender, EventArgs e)
        {
            msjPAA.limpiarMensajeEnPantalla();
            Utilidades diferencia = new Utilidades();
            int x;
            x = diferencia.Diferencia_Fechas(Dt_PAA_Inicio_Editar.Value.Date, Dt_PAA_Final_Editar.Value.Date);
            Determinar_Fechas(x, "groupBoxPAA_Editar");
        }

        private void Dt_PAA_Final_Editar_ValueChanged(object sender, EventArgs e)
        {
            msjPAA.limpiarMensajeEnPantalla();
            Utilidades diferencia = new Utilidades();
            int x;
            x = diferencia.Diferencia_Fechas(Dt_PAA_Inicio_Editar.Value.Date, Dt_PAA_Final_Editar.Value.Date);
            Determinar_Fechas(x, "groupBoxPAA_Editar");
        }

        private void Dt_Inscripcion_Inicio_Editar_ValueChanged(object sender, EventArgs e)
        {
             msjInscripcion.limpiarMensajeEnPantalla();
            Utilidades diferencia = new Utilidades();
            int x;
            x = diferencia.Diferencia_Fechas(Dt_Inscripcion_Inicio_Editar.Value.Date, Dt_Inscripcion_Final_Editar.Value.Date);
            Determinar_Fechas(x, "groupBoxInscripcion_Editar");
        }

        private void Dt_Inscripcion_Final_Editar_ValueChanged(object sender, EventArgs e)
        {
            msjInscripcion.limpiarMensajeEnPantalla();
            Utilidades diferencia = new Utilidades();
            int x;
            x = diferencia.Diferencia_Fechas(Dt_Inscripcion_Inicio_Editar.Value.Date, Dt_Inscripcion_Final_Editar.Value.Date);
            Determinar_Fechas(x, "groupBoxInscripcion_Editar");
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            string evaluador = "";
            string codigo = Cmb_Año_Busqueda.Text.ToString() + Lbl_Guion_Busqueda.Text.ToString() + Cmb_Año_Busqueda.Text;
            
            Utilidades util = new Utilidades();
            evaluador = util.ActualizarPAA("spU_PAA", _paa: codigo, _paainicio: Dt_PAA_Inicio_Editar.Value.ToString(), _paafinal: Dt_PAA_Final_Editar.Value.ToString(), _inscripcioninicio: Dt_Inscripcion_Inicio_Editar.Value.ToString(), _inscripcionfinal: Dt_Inscripcion_Final_Editar.Value.ToString(), _cupos: Convert.ToInt32(Txt_Cupos_Editar), _sesion: Sesion);
            switch (evaluador)
            {

                
                case "1":
                    MetroFramework.MetroMessageBox.Show(this, "Prueba de Aptitud Actualizada CON EXITO");
                    break;
                case "2":
                    MetroFramework.MetroMessageBox.Show(this, "Algo Paso");
                    break;

            }
        }
    }
}
