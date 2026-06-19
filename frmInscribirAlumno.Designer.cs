namespace Proyecto_integrador_club_deportivo
{
    partial class frmInscribirAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInscribirAlumno));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtApellido = new TextBox();
            label4 = new Label();
            txtDocumento = new TextBox();
            btnIngresar = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            chkSocio = new CheckBox();
            chkAptoFisico = new CheckBox();
            cmbActividad = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 178);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(348, 55);
            label1.Name = "label1";
            label1.Size = new Size(232, 32);
            label1.TabIndex = 1;
            label1.Text = "Registrar un Alumno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(318, 120);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(320, 144);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(308, 23);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(318, 174);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 4;
            label3.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(320, 198);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(306, 23);
            txtApellido.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(318, 231);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 6;
            label4.Text = "Documento";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(320, 255);
            txtDocumento.MaxLength = 8;
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(308, 23);
            txtDocumento.TabIndex = 7;
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Segoe UI", 12F);
            btnIngresar.Location = new Point(320, 358);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(101, 40);
            btnIngresar.TabIndex = 8;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 12F);
            btnLimpiar.Location = new Point(492, 358);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(101, 40);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(658, 358);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(101, 40);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // chkSocio
            // 
            chkSocio.AutoSize = true;
            chkSocio.Location = new Point(322, 322);
            chkSocio.Name = "chkSocio";
            chkSocio.Size = new Size(126, 19);
            chkSocio.TabIndex = 11;
            chkSocio.Text = "Marcar si es SOCIO";
            chkSocio.UseVisualStyleBackColor = true;
            // 
            // chkAptoFisico
            // 
            chkAptoFisico.AutoSize = true;
            chkAptoFisico.Location = new Point(477, 322);
            chkAptoFisico.Name = "chkAptoFisico";
            chkAptoFisico.Size = new Size(85, 19);
            chkAptoFisico.TabIndex = 12;
            chkAptoFisico.Text = "Apto Físico";
            chkAptoFisico.UseVisualStyleBackColor = true;
            // 
            // cmbActividad
            // 
            cmbActividad.FormattingEnabled = true;
            cmbActividad.Location = new Point(467, 287);
            cmbActividad.Name = "cmbActividad";
            cmbActividad.Size = new Size(121, 23);
            cmbActividad.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(320, 285);
            label5.Name = "label5";
            label5.Size = new Size(141, 21);
            label5.TabIndex = 14;
            label5.Text = "Actividad a realizar";
            // 
            // frmInscribirPostulante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(label5);
            Controls.Add(cmbActividad);
            Controls.Add(chkAptoFisico);
            Controls.Add(chkSocio);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresar);
            Controls.Add(txtDocumento);
            Controls.Add(label4);
            Controls.Add(txtApellido);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmInscribirPostulante";
            Text = "Inscribir Postulante";
            Load += frmInscribirPostulante_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtApellido;
        private Label label4;
        private TextBox txtDocumento;
        private Button btnIngresar;
        private Button btnLimpiar;
        private Button btnVolver;
        private CheckBox chkSocio;
        private CheckBox chkAptoFisico;
        private ComboBox cmbActividad;
        private Label label5;
    }
}