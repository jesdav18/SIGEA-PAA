﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGEA_PAA.User_Control
{
    public partial class Modulo_Asistencia : UserControl
    {
        public Modulo_Asistencia()
        {
            InitializeComponent();
        }
        private static Modulo_Asistencia _instancia;
        public static Modulo_Asistencia Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new Modulo_Asistencia();
                return _instancia;
            }
        }
        private void Modulo_Asistencia_Load(object sender, EventArgs e)
        {

        }
    }
}
