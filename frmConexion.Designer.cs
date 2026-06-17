namespace Proyecto_integrador_club_deportivo
{
    partial class frmConexion
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
            lblBaseDatos = new Label();
            lblServidor = new Label();
            lblPuerto = new Label();
            btnConfirmar = new Button();
            lwcboServidor = new TextBox();
            lwcboPuerto = new TextBox();
            lwcboUsuario = new TextBox();
            lblUsuario = new Label();
            lwcboClave = new TextBox();
            lwcboBasedatos = new TextBox();
            lblClave = new Label();
            SuspendLayout();
            // 
            // lblBaseDatos
            // 
            lblBaseDatos.AutoSize = true;
            lblBaseDatos.Location = new Point(12, 125);
            lblBaseDatos.Name = "lblBaseDatos";
            lblBaseDatos.Size = new Size(79, 15);
            lblBaseDatos.TabIndex = 0;
            lblBaseDatos.Text = "Base de datos";
            // 
            // lblServidor
            // 
            lblServidor.AutoSize = true;
            lblServidor.Location = new Point(12, 9);
            lblServidor.Name = "lblServidor";
            lblServidor.Size = new Size(50, 15);
            lblServidor.TabIndex = 1;
            lblServidor.Text = "Servidor";
            // 
            // lblPuerto
            // 
            lblPuerto.AutoSize = true;
            lblPuerto.Location = new Point(12, 38);
            lblPuerto.Name = "lblPuerto";
            lblPuerto.Size = new Size(42, 15);
            lblPuerto.TabIndex = 2;
            lblPuerto.Text = "Puerto";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(12, 151);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(260, 53);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "Confirmar datos de conexión";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lwcboServidor
            // 
            lwcboServidor.Location = new Point(97, 6);
            lwcboServidor.Name = "lwcboServidor";
            lwcboServidor.Size = new Size(175, 23);
            lwcboServidor.TabIndex = 4;
            lwcboServidor.Text = "localhost";
            // 
            // lwcboPuerto
            // 
            lwcboPuerto.Location = new Point(97, 35);
            lwcboPuerto.Name = "lwcboPuerto";
            lwcboPuerto.Size = new Size(175, 23);
            lwcboPuerto.TabIndex = 5;
            lwcboPuerto.Text = "3306";
            // 
            // lwcboUsuario
            // 
            lwcboUsuario.Location = new Point(97, 64);
            lwcboUsuario.Name = "lwcboUsuario";
            lwcboUsuario.Size = new Size(175, 23);
            lwcboUsuario.TabIndex = 6;
            lwcboUsuario.Text = "root";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(12, 67);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 7;
            lblUsuario.Text = "Usuario";
            // 
            // lwcboClave
            // 
            lwcboClave.Location = new Point(97, 93);
            lwcboClave.Name = "lwcboClave";
            lwcboClave.Size = new Size(175, 23);
            lwcboClave.TabIndex = 8;
            lwcboClave.Text = "SuperSegura1234";
            // 
            // lwcboBasedatos
            // 
            lwcboBasedatos.Location = new Point(97, 122);
            lwcboBasedatos.Name = "lwcboBasedatos";
            lwcboBasedatos.Size = new Size(175, 23);
            lwcboBasedatos.TabIndex = 9;
            lwcboBasedatos.Text = "Proyecto";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(12, 96);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(36, 15);
            lblClave.TabIndex = 10;
            lblClave.Text = "Clave";
            // 
            // frmConexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 214);
            Controls.Add(lblClave);
            Controls.Add(lwcboBasedatos);
            Controls.Add(lwcboClave);
            Controls.Add(lblUsuario);
            Controls.Add(lwcboUsuario);
            Controls.Add(lwcboPuerto);
            Controls.Add(lwcboServidor);
            Controls.Add(btnConfirmar);
            Controls.Add(lblPuerto);
            Controls.Add(lblServidor);
            Controls.Add(lblBaseDatos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmConexion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conexión a la Base de Datos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaseDatos;
        private Label lblServidor;
        private Label lblPuerto;
        private Button btnConfirmar;
        private TextBox lwcboServidor;
        private TextBox lwcboPuerto;
        private TextBox lwcboUsuario;
        private Label lblUsuario;
        private TextBox lwcboClave;
        private TextBox lwcboBasedatos;
        private Label lblClave;
    }
}