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
            ((System.ComponentModel.ISupportInitialize)dgvVencimientos).BeginInit();
            SuspendLayout();
            // 
            // dgvVencimientos
            // 
            dgvVencimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVencimientos.Dock = DockStyle.Fill;
            dgvVencimientos.Location = new Point(0, 0);
            dgvVencimientos.Name = "dgvVencimientos";
            dgvVencimientos.Size = new Size(1184, 461);
            dgvVencimientos.TabIndex = 0;
            // 
            // frmVencimientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 461);
            Controls.Add(dgvVencimientos);
            MinimizeBox = false;
            Name = "frmVencimientos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vencimientos del dia de hoy";
            Load += frmVencimientos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVencimientos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvVencimientos;
    }
}