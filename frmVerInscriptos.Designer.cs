namespace Proyecto_integrador_club_deportivo
{
    partial class frmVerInscriptos
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
            components = new System.ComponentModel.Container();
            dvgInscriptos = new DataGridView();
            conexionBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dvgInscriptos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dvgInscriptos
            // 
            dvgInscriptos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgInscriptos.Dock = DockStyle.Fill;
            dvgInscriptos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dvgInscriptos.Location = new Point(0, 0);
            dvgInscriptos.Name = "dvgInscriptos";
            dvgInscriptos.ReadOnly = true;
            dvgInscriptos.Size = new Size(1184, 461);
            dvgInscriptos.TabIndex = 0;
            dvgInscriptos.CellContentClick += dvgInscriptos_CellContentClick;
            // 
            // conexionBindingSource
            // 
            conexionBindingSource.DataSource = typeof(Datos.Conexion);
            // 
            // frmVerInscriptos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 461);
            Controls.Add(dvgInscriptos);
            MinimizeBox = false;
            Name = "frmVerInscriptos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado de alumnos inscriptos";
            Load += frmVerInscriptos_Load;
            ((System.ComponentModel.ISupportInitialize)dvgInscriptos).EndInit();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dvgInscriptos;
        private BindingSource conexionBindingSource;
    }
}