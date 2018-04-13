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
    public partial class Modulo_Inscripcion : UserControl
    {
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
        private void Modulo_Inscripcion_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Cuenta_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Conexiones.Conexion cone = new Conexiones.Conexion();
            DataRow dr = cone.busquedaDatos(Txt_Cuenta.Text, "spB_ConsultaEstudiante", "@Cuenta").Rows[0];

            if (dr.Table.Columns.Count.ToString() == "1")
            {
                Mensajes mensaje = new Mensajes();
                Controls["groupBox1"].Controls.Add(mensaje.crearMensajeEnPantalla("ESTE ESTUDIANTE NO ESTÁ REGISTRADO", 80, 132, false, 9));
            }

            /*Txt_Nombre.Text = dr[1].ToString();
            Txt_Cuenta2.Text = dr[2].ToString();
            Txt_Identidad.Text = dr[3].ToString();
            Txt_Estado.Text = dr[5].ToString();*/
            MessageBox.Show(dr.Table.Columns.Count.ToString());


    
            
                
        }

        private void Btn_Inscribir_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
