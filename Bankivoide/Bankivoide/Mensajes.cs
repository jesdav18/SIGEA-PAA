using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bankivoide
{
    public class Mensajes
    {

        Label labelMensaje;
        public Mensajes()
        {
            
            labelMensaje = new Label();  
        }
        public Control crearMensajeEnPantalla(string _texto, int _x, int _y, bool _det, float _tam)
        {
            /*CON ESTA FUNCIÓN SE PRETENDE MOSTRAR MENSAJES PERSONALIZADOS DE ERROR Y DE EXITO EN LOS DISTINTOS FORMULARIOS.
             
             LA DINÁMICA DE LA FUNCIÓN CONSISTE EN CREAR UN OBJETO LABEL EN TIEMPO DE EJECUCIÓN, LA FUNCIÓN RECIBIRÁ COMO PARÁMETRO EL TEXTO QUE 
             SE DESEE MOSTRAR, LAS COORDENADAS DONDE SE QUIERE MOSTRAR DENTRO DEL FORMULARIO, EL TAMAÑO DE LA LETRA Y TAMBIÉN RECIBIRÁ UNA BANDERA (_det);
             ESTA BANDERA PERMITIRÁ SABER SI EL MENSAJE ES DE ERROR O EXITO.
             SI EL _det es "True" EL MENSAJE SE MOSTRARÁ EN COLOR VERDE, SI EL _det es "false" EL MENSAJE SE MOSTRARÁ EN COLOR ROJO.
             AL FINAL SE RETORNA EL OBJETO CREADO.
             
             CONSTANTES 
             ->Tipo de Letra = "Arial"
             ->FontStyle (Estilo de Fuente) = Bold */
            
            labelMensaje.Location = new Point(_x, _y);
            labelMensaje.Text = _texto;
            labelMensaje.Font = new Font("Arial",_tam, FontStyle.Bold);
            labelMensaje.AutoSize = true;
            if (_det)
                labelMensaje.ForeColor = Color.Green;
            else
                labelMensaje.ForeColor = Color.Red;

            return labelMensaje;
            
           
        }

        public void limpiarMensajeEnPantalla()
        {
            labelMensaje.Text = "";
        }

        public void destruirObjetoMensajeEnPantalla()
        {
            labelMensaje.Controls.Remove(labelMensaje);
            labelMensaje.Dispose();
            
        }
   
    }//FIN DE CLASE "Mensajes"

    //-------------------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------------------

   
    //-------------------------------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------------------------------

}//FIN NAMESPACE "Vankiboide"
