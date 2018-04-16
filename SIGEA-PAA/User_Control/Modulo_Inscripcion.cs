using System;
using System.Data;
using System.Windows.Forms;
using Bankivoide;

namespace SIGEA_PAA.User_Control
{
    public partial class Modulo_Inscripcion : UserControl
    {
        Mensajes msjRetroalimentacion = new Mensajes();//OBJETO QUE SERVIRÁ PARA MOSTRAR MENSAJES EN PANTALLA.

        public Modulo_Inscripcion()
        {
            InitializeComponent();
        }
        private static Modulo_Inscripcion _instancia;
        public static Modulo_Inscripcion Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new Modulo_Inscripcion();
                return _instancia;
            }
        }
       
        

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            int tipoEstado;
            Conexiones.Conexion cone = new Conexiones.Conexion();
            DataRow dr = cone.busquedaDatos(Txt_Cuenta.Text, "spB_ConsultaEstudiante", "@Cuenta").Rows[0];

            //SI EL NÚMERO DE COLUMNAS QUE DEVUELVE LA FUNCION "busquedaDatos" A TRAVÉS DEL DATATABLE ES IGUAL A 1, SIGNIFICA QUE
            //EL ESTUDIANTE NO EXISTE. CASO CONTRARIO, EL ESTUDIANTE SE ENCONTRÓ, Y SE LLENAN LAS CAJAS DE TEXTO CON SU INFORMACIÓN.

            if (dr.Table.Columns.Count.ToString() == "1")
            {
                linkRegistrarEstudiante.Visible = true;
                Controls["groupBox1"].Controls.Add(msjRetroalimentacion.crearMensajeEnPantalla("ESTE ESTUDIANTE NO ESTÁ REGISTRADO", 115, 132, false, 9));
            }
            else
            {
                //MOSTRANDO INFORMACION DE ESTUDIANTE
                
                Txt_Nombre.Text = dr[1].ToString();
                Txt_Cuenta2.Text = dr[2].ToString();
                Txt_Identidad.Text = dr[3].ToString();
                Txt_Estado.Text = dr[5].ToString();
                Txt_Carrera.Text = dr[4].ToString();
                tipoEstado = Convert.ToInt32(dr[6].ToString());

                switch (tipoEstado)
                {
                    case 1: Controls["groupBox1"].Controls.Add(msjRetroalimentacion.crearMensajeEnPantalla("ESTE ESTUDIANTE ESTÁ ACTIVO, Y PUEDE SER INSCRITO", 115, 140, true, 9));
                            Btn_Inscribir.Enabled = true;
                           break;
                    case 2:
                            Controls["groupBox1"].Controls.Add(msjRetroalimentacion.crearMensajeEnPantalla("ESTE ESTUDIANTE YA HA CUMPLIDO CON ART 140 DE LAS NORMAS ACADÉMICAS DE LA UNAH,\n SIN EMBARGO, PUEDE SER INSCRITO.", 60, 140, true, 9));
                            Btn_Inscribir.Enabled = true;
                            break;
                    case 3:
                            Controls["groupBox1"].Controls.Add(msjRetroalimentacion.crearMensajeEnPantalla("ESTE ESTUDIANTE ESTÁ SUSPENDIDO TEMPORALMENTE Y NO PODRÁ SER INSCRITO.",115,140, false,9));
                            break;
                    case 4:
                            Controls["groupBox1"].Controls.Add(msjRetroalimentacion.crearMensajeEnPantalla("ESTE ESTUDIANTE ESTÁ EN UN ESTADO CONDICIONADO, PERO, PODRÁ SER INSCRITO", 115, 140, true, 9));
                            Btn_Inscribir.Enabled = true;
                            break;
                    
                }


            } 
        }

        private void Txt_Cuenta_TextChanged(object sender, EventArgs e)
        {
            //CUANDO SE EMPIEZA A MODIFICAR TEXTO DE LA MASCARA DEL NUMERO DE CUENTA ESTUDIANTE SE LIMPIAN CAJAS DE TEXTO
            Txt_Cuenta2.Text = "";
            Txt_Estado.Text = "";
            Txt_Identidad.Text = "";
            Txt_Nombre.Text = "";
            Txt_Carrera.Text = "";
            msjRetroalimentacion.limpiarMensajeEnPantalla();
            linkRegistrarEstudiante.Visible = false;
        }

        private void Modulo_Inscripcion_Load(object sender, EventArgs e)
        {
            //CUANDO SE CREA ESTE MÓDULO, LA MASCARA PARA INGRESAR EL NUMERO DE CUENTA TENDRÁ EL FOCUS
            Txt_Cuenta.Focus();
        }

        private void Btn_Inscribir_Click(object sender, EventArgs e)
        {
            
        }

        private void linkRegistrarEstudiante_Click(object sender, EventArgs e)
        {
            //CREAR UNA INSTANCIA DEL FORMULARIO PARA REGISTRAR ESTUDIANTE
        }

        
    }
    
}
