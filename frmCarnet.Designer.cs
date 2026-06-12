namespace Proyecto_integrador_club_deportivo
{
    partial class frmCarnet
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblNombre = new Label();
            lblDocumento = new Label();
            lblActividad = new Label();
            lblTipo = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(287, 46);
            label1.Name = "label1";
            label1.Size = new Size(201, 32);
            label1.TabIndex = 0;
            label1.Text = "CLUB DEPORTIVO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(73, 112);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(73, 187);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 2;
            label3.Text = "Actividad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(73, 228);
            label4.Name = "label4";
            label4.Size = new Size(55, 28);
            label4.TabIndex = 3;
            label4.Text = "Tipo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(73, 146);
            label5.Name = "label5";
            label5.Size = new Size(119, 28);
            label5.TabIndex = 4;
            label5.Text = "Documento:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 15F);
            lblNombre.Location = new Point(247, 112);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(65, 28);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "label6";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI", 15F);
            lblDocumento.Location = new Point(247, 151);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(65, 28);
            lblDocumento.TabIndex = 6;
            lblDocumento.Text = "label7";
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Font = new Font("Segoe UI", 15F);
            lblActividad.Location = new Point(247, 187);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(65, 28);
            lblActividad.TabIndex = 7;
            lblActividad.Text = "label8";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 15F);
            lblTipo.Location = new Point(247, 228);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(65, 28);
            lblTipo.TabIndex = 8;
            lblTipo.Text = "label9";
            // 
            // frmCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTipo);
            Controls.Add(lblActividad);
            Controls.Add(lblDocumento);
            Controls.Add(lblNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCarnet";
            Text = "frmCarnet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblNombre;
        private Label lblDocumento;
        private Label lblActividad;
        private Label lblTipo;
    }
}