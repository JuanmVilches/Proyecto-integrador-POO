namespace Proyecto_integrador_club_deportivo
{
    partial class frmMenu
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
            btnSalir = new Button();
            btnInscribir = new Button();
            btnVerInscriptos = new Button();
            btnEmitirComprobante = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(13, 42);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 18F);
            btnSalir.Location = new Point(613, 31);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(153, 65);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnInscribir
            // 
            btnInscribir.BackColor = SystemColors.GradientActiveCaption;
            btnInscribir.BackgroundImageLayout = ImageLayout.None;
            btnInscribir.Font = new Font("Segoe UI", 18F);
            btnInscribir.Location = new Point(13, 142);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(355, 88);
            btnInscribir.TabIndex = 2;
            btnInscribir.Text = "Inscribir Postulante";
            btnInscribir.UseVisualStyleBackColor = false;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // btnVerInscriptos
            // 
            btnVerInscriptos.BackColor = SystemColors.GradientActiveCaption;
            btnVerInscriptos.BackgroundImageLayout = ImageLayout.None;
            btnVerInscriptos.Font = new Font("Segoe UI", 18F);
            btnVerInscriptos.Location = new Point(433, 142);
            btnVerInscriptos.Name = "btnVerInscriptos";
            btnVerInscriptos.Size = new Size(355, 88);
            btnVerInscriptos.TabIndex = 3;
            btnVerInscriptos.Text = "Ver inscriptos";
            btnVerInscriptos.UseVisualStyleBackColor = false;
            btnVerInscriptos.Click += btnVerInscriptos_Click;
            // 
            // btnEmitirComprobante
            // 
            btnEmitirComprobante.BackColor = SystemColors.GradientActiveCaption;
            btnEmitirComprobante.BackgroundImageLayout = ImageLayout.None;
            btnEmitirComprobante.Font = new Font("Segoe UI", 18F);
            btnEmitirComprobante.Location = new Point(13, 285);
            btnEmitirComprobante.Name = "btnEmitirComprobante";
            btnEmitirComprobante.Size = new Size(775, 88);
            btnEmitirComprobante.TabIndex = 5;
            btnEmitirComprobante.Text = "Emitir Listado de Vencimientos";
            btnEmitirComprobante.UseVisualStyleBackColor = false;
            btnEmitirComprobante.Click += btnEmitirComprobante_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEmitirComprobante);
            Controls.Add(btnVerInscriptos);
            Controls.Add(btnInscribir);
            Controls.Add(btnSalir);
            Controls.Add(label1);
            Name = "frmMenu";
            Text = "frmMenu";
            Load += frmMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSalir;
        private Button btnInscribir;
        private Button btnVerInscriptos;
        private Button btnPagarCuota;
        private Button btnEmitirComprobante;
    }
}