using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankivoide
{
   public class Validaciones
    {
        public void ValidacionCajaTexto()
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





    }
}
