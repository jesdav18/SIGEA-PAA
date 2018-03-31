namespace SIGEA_PAA
{
    partial class formLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.textBoxUsuario = new MetroFramework.Controls.MetroTextBox();
            this.textBoxContrasenia = new MetroFramework.Controls.MetroTextBox();
            this.btnIngresar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(98, 109);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Usuario";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(76, 157);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Contraseña";
            // 
            // textBoxUsuario
            // 
            // 
            // 
            // 
            this.textBoxUsuario.CustomButton.Image = null;
            this.textBoxUsuario.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.textBoxUsuario.CustomButton.Name = "";
            this.textBoxUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxUsuario.CustomButton.TabIndex = 1;
            this.textBoxUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxUsuario.CustomButton.UseSelectable = true;
            this.textBoxUsuario.CustomButton.Visible = false;
            this.textBoxUsuario.Lines = new string[0];
            this.textBoxUsuario.Location = new System.Drawing.Point(157, 105);
            this.textBoxUsuario.MaxLength = 32767;
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.PasswordChar = '\0';
            this.textBoxUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxUsuario.SelectedText = "";
            this.textBoxUsuario.SelectionLength = 0;
            this.textBoxUsuario.SelectionStart = 0;
            this.textBoxUsuario.ShortcutsEnabled = true;
            this.textBoxUsuario.Size = new System.Drawing.Size(200, 23);
            this.textBoxUsuario.TabIndex = 2;
            this.textBoxUsuario.UseSelectable = true;
            this.textBoxUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxUsuario.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged);
            // 
            // textBoxContrasenia
            // 
            // 
            // 
            // 
            this.textBoxContrasenia.CustomButton.Image = null;
            this.textBoxContrasenia.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.textBoxContrasenia.CustomButton.Name = "";
            this.textBoxContrasenia.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxContrasenia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxContrasenia.CustomButton.TabIndex = 1;
            this.textBoxContrasenia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxContrasenia.CustomButton.UseSelectable = true;
            this.textBoxContrasenia.CustomButton.Visible = false;
            this.textBoxContrasenia.Lines = new string[0];
            this.textBoxContrasenia.Location = new System.Drawing.Point(157, 153);
            this.textBoxContrasenia.MaxLength = 32767;
            this.textBoxContrasenia.Name = "textBoxContrasenia";
            this.textBoxContrasenia.PasswordChar = '*';
            this.textBoxContrasenia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxContrasenia.SelectedText = "";
            this.textBoxContrasenia.SelectionLength = 0;
            this.textBoxContrasenia.SelectionStart = 0;
            this.textBoxContrasenia.ShortcutsEnabled = true;
            this.textBoxContrasenia.Size = new System.Drawing.Size(200, 23);
            this.textBoxContrasenia.TabIndex = 3;
            this.textBoxContrasenia.UseSelectable = true;
            this.textBoxContrasenia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxContrasenia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxContrasenia.TextChanged += new System.EventHandler(this.textBoxContrasenia_TextChanged);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(98, 213);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(117, 23);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseSelectable = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(240, 213);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 290);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.textBoxContrasenia);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "formLogin";
            this.Text = "SIGEA-PAA | Acceso";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.formLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox textBoxUsuario;
        private MetroFramework.Controls.MetroTextBox textBoxContrasenia;
        private MetroFramework.Controls.MetroButton btnIngresar;
        private MetroFramework.Controls.MetroButton btnCancelar;
    }
}