namespace Proyecto_integrador_club_deportivo
{
    partial class frmIngresar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresar));
            pictureBox1 = new PictureBox();
            txtIngresarUsuario = new TextBox();
            txtIngresarContraseña = new TextBox();
            label1 = new Label();
            btnIngresar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(79, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 212);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtIngresarUsuario
            // 
            txtIngresarUsuario.Location = new Point(396, 137);
            txtIngresarUsuario.Name = "txtIngresarUsuario";
            txtIngresarUsuario.Size = new Size(280, 23);
            txtIngresarUsuario.TabIndex = 4;
            txtIngresarUsuario.Text = "Ingresar usuario";
            txtIngresarUsuario.Enter += txtIngresarUsuario_Enter;
            txtIngresarUsuario.Leave += txtIngresarUsuario_Leave;
            // 
            // txtIngresarContraseña
            // 
            txtIngresarContraseña.Location = new Point(396, 179);
            txtIngresarContraseña.Name = "txtIngresarContraseña";
            txtIngresarContraseña.Size = new Size(280, 23);
            txtIngresarContraseña.TabIndex = 5;
            txtIngresarContraseña.Text = "Ingresar contraseña";
            txtIngresarContraseña.Enter += txtIngresarContraseña_Enter;
            txtIngresarContraseña.Leave += txtIngresarContraseña_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(414, 73);
            label1.Name = "label1";
            label1.Size = new Size(245, 32);
            label1.TabIndex = 6;
            label1.Text = "INGRESO AL SISTEMA";
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Segoe UI", 12F);
            btnIngresar.Location = new Point(474, 241);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(112, 44);
            btnIngresar.TabIndex = 7;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 329);
            Controls.Add(btnIngresar);
            Controls.Add(label1);
            Controls.Add(txtIngresarContraseña);
            Controls.Add(txtIngresarUsuario);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private TextBox txtIngresarUsuario;
        private TextBox txtIngresarContraseña;
        private Label label1;
        private Button btnIngresar;
    }
}
