﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGEA_PAA
{
    public partial class formEquipoApoyo : MetroFramework.Forms.MetroForm
    {
        string sesion;

        public formEquipoApoyo(string _sesion, string _nombreUsuarioSesion)
        {
            InitializeComponent();
            sesion = _sesion;
            labelUsuario.Text = "Bienvenido " + _nombreUsuarioSesion;
        }

        private void formEquipoApoyo_Load(object sender, EventArgs e)
        {
            
        }
    }
}