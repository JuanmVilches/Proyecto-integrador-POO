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
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(85, 28);
            label1.TabIndex = 0;
            label1.Text = "Alumno:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 15F);
            lblNombre.Location = new Point(154, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(20, 28);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "_";
            // 
            // cmbCuotas
            // 
            cmbCuotas.Enabled = false;
            cmbCuotas.FormattingEnabled = true;
            cmbCuotas.Location = new Point(6, 46);
            cmbCuotas.Name = "cmbCuotas";
            cmbCuotas.Size = new Size(188, 23);
            cmbCuotas.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbTarjeta);
            groupBox1.Controls.Add(rbEfectivo);
            groupBox1.Location = new Point(12, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Modo de pago";
            // 
            // rbTarjeta
            // 
            rbTarjeta.AutoSize = true;
            rbTarjeta.Location = new Point(6, 72);
            rbTarjeta.Name = "rbTarjeta";
            rbTarjeta.Size = new Size(60, 19);
            rbTarjeta.TabIndex = 1;
            rbTarjeta.TabStop = true;
            rbTarjeta.Text = "Tarjeta";
            rbTarjeta.UseVisualStyleBackColor = true;
            rbTarjeta.CheckedChanged += rbTarjeta_CheckedChanged;
            // 
            // rbEfectivo
            // 
            rbEfectivo.AutoSize = true;
            rbEfectivo.Location = new Point(6, 47);
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
            btnConfirmarPago.Font = new Font("Segoe UI", 15F);
            btnConfirmarPago.Location = new Point(272, 306);
            btnConfirmarPago.Name = "btnConfirmarPago";
            btnConfirmarPago.Size = new Size(200, 43);
            btnConfirmarPago.TabIndex = 4;
            btnConfirmarPago.Text = "Confirmar Pago";
            btnConfirmarPago.UseVisualStyleBackColor = true;
            btnConfirmarPago.Click += btnConfirmarPago_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(12, 221);
            label2.Name = "label2";
            label2.Size = new Size(132, 28);
            label2.TabIndex = 5;
            label2.Text = "Total a Pagar: ";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 15F);
            lblPrecio.Location = new Point(224, 221);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(20, 28);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "_";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(12, 37);
            label3.Name = "label3";
            label3.Size = new Size(119, 28);
            label3.TabIndex = 7;
            label3.Text = "Documento:";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI", 15F);
            lblDocumento.Location = new Point(154, 37);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(20, 28);
            lblDocumento.TabIndex = 8;
            lblDocumento.Text = "_";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbCuotas);
            groupBox2.Location = new Point(218, 91);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cuotas";
            // 
            // frmPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(groupBox2);
            Controls.Add(lblDocumento);
            Controls.Add(label3);
            Controls.Add(lblPrecio);
            Controls.Add(label2);
            Controls.Add(btnConfirmarPago);
            Controls.Add(groupBox1);
            Controls.Add(lblNombre);
            Controls.Add(label1);
            Name = "frmPago";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registro de pago";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
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
        private GroupBox groupBox2;
    }
}