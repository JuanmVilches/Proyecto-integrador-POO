namespace Proyecto_integrador_club_deportivo
{
    partial class frmVencimientos
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
            dgvVencimientos = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVencimientos).BeginInit();
            SuspendLayout();
            // 
            // dgvVencimientos
            // 
            dgvVencimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVencimientos.Location = new Point(2, 34);
            dgvVencimientos.Name = "dgvVencimientos";
            dgvVencimientos.Size = new Size(799, 415);
            dgvVencimientos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(249, 3);
            label1.Name = "label1";
            label1.Size = new Size(298, 28);
            label1.TabIndex = 1;
            label1.Text = "VENCIMIENTOS DEL DIA DE HOY";
            // 
            // frmVencimientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dgvVencimientos);
            Name = "frmVencimientos";
            Text = "frmVencimientos";
            Load += frmVencimientos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVencimientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVencimientos;
        private Label label1;
    }
}