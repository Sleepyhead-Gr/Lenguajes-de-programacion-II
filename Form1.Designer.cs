namespace Coppel
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEmpleado = new System.Windows.Forms.TabPage();
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            this.tabPageCentroTrabajo = new System.Windows.Forms.TabPage();
            this.dgvCentroTrabajo = new System.Windows.Forms.DataGridView();
            this.tabPagePuestos = new System.Windows.Forms.TabPage();
            this.dgvPuestos = new System.Windows.Forms.DataGridView();
            this.tabPageDirectivos = new System.Windows.Forms.TabPage();
            this.dgvDirectivos = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPageEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
            this.tabPageCentroTrabajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCentroTrabajo)).BeginInit();
            this.tabPagePuestos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).BeginInit();
            this.tabPageDirectivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectivos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageEmpleado);
            this.tabControl1.Controls.Add(this.tabPageCentroTrabajo);
            this.tabControl1.Controls.Add(this.tabPagePuestos);
            this.tabControl1.Controls.Add(this.tabPageDirectivos);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1024, 600);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageEmpleado
            // 
            this.tabPageEmpleado.Controls.Add(this.dgvEmpleado);
            this.tabPageEmpleado.Location = new System.Drawing.Point(4, 25);
            this.tabPageEmpleado.Name = "tabPageEmpleado";
            this.tabPageEmpleado.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmpleado.Size = new System.Drawing.Size(1016, 571);
            this.tabPageEmpleado.TabIndex = 0;
            this.tabPageEmpleado.Text = "Empleados";
            this.tabPageEmpleado.UseVisualStyleBackColor = true;
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.AllowUserToAddRows = false;
            this.dgvEmpleado.AllowUserToDeleteRows = false;
            this.dgvEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmpleado.Location = new System.Drawing.Point(3, 3);
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.ReadOnly = true;
            this.dgvEmpleado.RowHeadersWidth = 51;
            this.dgvEmpleado.RowTemplate.Height = 24;
            this.dgvEmpleado.Size = new System.Drawing.Size(1010, 565);
            this.dgvEmpleado.TabIndex = 0;
            // 
            // tabPageCentroTrabajo
            // 
            this.tabPageCentroTrabajo.Controls.Add(this.dgvCentroTrabajo);
            this.tabPageCentroTrabajo.Location = new System.Drawing.Point(4, 25);
            this.tabPageCentroTrabajo.Name = "tabPageCentroTrabajo";
            this.tabPageCentroTrabajo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCentroTrabajo.Size = new System.Drawing.Size(1016, 571);
            this.tabPageCentroTrabajo.TabIndex = 1;
            this.tabPageCentroTrabajo.Text = "Centros de Trabajo";
            this.tabPageCentroTrabajo.UseVisualStyleBackColor = true;
            // 
            // dgvCentroTrabajo
            // 
            this.dgvCentroTrabajo.AllowUserToAddRows = false;
            this.dgvCentroTrabajo.AllowUserToDeleteRows = false;
            this.dgvCentroTrabajo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCentroTrabajo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCentroTrabajo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCentroTrabajo.Location = new System.Drawing.Point(3, 3);
            this.dgvCentroTrabajo.Name = "dgvCentroTrabajo";
            this.dgvCentroTrabajo.ReadOnly = true;
            this.dgvCentroTrabajo.RowHeadersWidth = 51;
            this.dgvCentroTrabajo.RowTemplate.Height = 24;
            this.dgvCentroTrabajo.Size = new System.Drawing.Size(1010, 565);
            this.dgvCentroTrabajo.TabIndex = 0;
            // 
            // tabPagePuestos
            // 
            this.tabPagePuestos.Controls.Add(this.dgvPuestos);
            this.tabPagePuestos.Location = new System.Drawing.Point(4, 25);
            this.tabPagePuestos.Name = "tabPagePuestos";
            this.tabPagePuestos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePuestos.Size = new System.Drawing.Size(1016, 571);
            this.tabPagePuestos.TabIndex = 2;
            this.tabPagePuestos.Text = "Puestos";
            this.tabPagePuestos.UseVisualStyleBackColor = true;
            // 
            // dgvPuestos
            // 
            this.dgvPuestos.AllowUserToAddRows = false;
            this.dgvPuestos.AllowUserToDeleteRows = false;
            this.dgvPuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuestos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPuestos.Location = new System.Drawing.Point(3, 3);
            this.dgvPuestos.Name = "dgvPuestos";
            this.dgvPuestos.ReadOnly = true;
            this.dgvPuestos.RowHeadersWidth = 51;
            this.dgvPuestos.RowTemplate.Height = 24;
            this.dgvPuestos.Size = new System.Drawing.Size(1010, 565);
            this.dgvPuestos.TabIndex = 0;
            // 
            // tabPageDirectivos
            // 
            this.tabPageDirectivos.Controls.Add(this.dgvDirectivos);
            this.tabPageDirectivos.Location = new System.Drawing.Point(4, 25);
            this.tabPageDirectivos.Name = "tabPageDirectivos";
            this.tabPageDirectivos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDirectivos.Size = new System.Drawing.Size(1016, 571);
            this.tabPageDirectivos.TabIndex = 3;
            this.tabPageDirectivos.Text = "Directivos";
            this.tabPageDirectivos.UseVisualStyleBackColor = true;
            // 
            // dgvDirectivos
            // 
            this.dgvDirectivos.AllowUserToAddRows = false;
            this.dgvDirectivos.AllowUserToDeleteRows = false;
            this.dgvDirectivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDirectivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirectivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDirectivos.Location = new System.Drawing.Point(3, 3);
            this.dgvDirectivos.Name = "dgvDirectivos";
            this.dgvDirectivos.ReadOnly = true;
            this.dgvDirectivos.RowHeadersWidth = 51;
            this.dgvDirectivos.RowTemplate.Height = 24;
            this.dgvDirectivos.Size = new System.Drawing.Size(1010, 565);
            this.dgvDirectivos.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Control de Empleados Coppel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageEmpleado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            this.tabPageCentroTrabajo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCentroTrabajo)).EndInit();
            this.tabPagePuestos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).EndInit();
            this.tabPageDirectivos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectivos)).EndInit();
            this.ResumeLayout(false);
            this.Load += new System.EventHandler(this.Form1_Load);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEmpleado;
        private System.Windows.Forms.DataGridView dgvEmpleado;
        private System.Windows.Forms.TabPage tabPageCentroTrabajo;
        private System.Windows.Forms.DataGridView dgvCentroTrabajo;
        private System.Windows.Forms.TabPage tabPagePuestos;
        private System.Windows.Forms.DataGridView dgvPuestos;
        private System.Windows.Forms.TabPage tabPageDirectivos;
        private System.Windows.Forms.DataGridView dgvDirectivos;
    }
}
