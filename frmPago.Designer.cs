namespace Proyecto_integrador_club_deportivo
{
    partial class frmPago
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
            lblNombre = new Label();
            cmbCuotas = new ComboBox();
            groupBox1 = new GroupBox();
            rbTarjeta = new RadioButton();
            rbEfectivo = new RadioButton();
            btnConfirmarPago = new Button();
            label2 = new Label();
            lblPrecio = new Label();
            label3 = new Label();
            lblDocumento = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(98, 66);
            label1.Name = "label1";
            label1.Size = new Size(85, 28);
            label1.TabIndex = 0;
            label1.Text = "Alumno:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 15F);
            lblNombre.Location = new Point(232, 66);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(65, 28);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "label2";
            // 
            // cmbCuotas
            // 
            cmbCuotas.FormattingEnabled = true;
            cmbCuotas.Location = new Point(98, 296);
            cmbCuotas.Name = "cmbCuotas";
            cmbCuotas.Size = new Size(121, 23);
            cmbCuotas.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbTarjeta);
            groupBox1.Controls.Add(rbEfectivo);
            groupBox1.Location = new Point(97, 146);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // rbTarjeta
            // 
            rbTarjeta.AutoSize = true;
            rbTarjeta.Location = new Point(24, 66);
            rbTarjeta.Name = "rbTarjeta";
            rbTarjeta.Size = new Size(59, 19);
            rbTarjeta.TabIndex = 1;
            rbTarjeta.TabStop = true;
            rbTarjeta.Text = "Tarjeta";
            rbTarjeta.UseVisualStyleBackColor = true;
            rbTarjeta.CheckedChanged += rbTarjeta_CheckedChanged;
            // 
            // rbEfectivo
            // 
            rbEfectivo.AutoSize = true;
            rbEfectivo.Location = new Point(24, 41);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(67, 19);
            rbEfectivo.TabIndex = 0;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo";
            rbEfectivo.UseVisualStyleBackColor = true;
            rbEfectivo.CheckedChanged += rbEfectivo_CheckedChanged;
            // 
            // btnConfirmarPago
            // 
            btnConfirmarPago.Location = new Point(97, 339);
            btnConfirmarPago.Name = "btnConfirmarPago";
            btnConfirmarPago.Size = new Size(122, 28);
            btnConfirmarPago.TabIndex = 4;
            btnConfirmarPago.Text = "Confirmar Pago";
            btnConfirmarPago.UseVisualStyleBackColor = true;
            btnConfirmarPago.Click += btnConfirmarPago_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 262);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 5;
            label2.Text = "Total a Pagar: ";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(189, 262);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(38, 15);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(97, 105);
            label3.Name = "label3";
            label3.Size = new Size(119, 28);
            label3.TabIndex = 7;
            label3.Text = "Documento:";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI", 15F);
            lblDocumento.Location = new Point(232, 105);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(65, 28);
            lblDocumento.TabIndex = 8;
            lblDocumento.Text = "label4";
            // 
            // frmPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDocumento);
            Controls.Add(label3);
            Controls.Add(lblPrecio);
            Controls.Add(label2);
            Controls.Add(btnConfirmarPago);
            Controls.Add(cmbCuotas);
            Controls.Add(groupBox1);
            Controls.Add(lblNombre);
            Controls.Add(label1);
            Name = "frmPago";
            Text = "frmPago";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNombre;
        private ComboBox cmbCuotas;
        private GroupBox groupBox1;
        private RadioButton rbTarjeta;
        private RadioButton rbEfectivo;
        private Button btnConfirmarPago;
        private Label label2;
        private Label lblPrecio;
        private Label label3;
        private Label lblDocumento;
    }
}