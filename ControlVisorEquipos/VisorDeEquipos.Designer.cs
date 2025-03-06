namespace ControlVisorEquipos
{
    partial class VisorDeEquipos
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lActualizado = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lUsuariosEquipos = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lEquiposPrestados = new MetroFramework.Controls.MetroLabel();
            this.gridVisor = new LabManager.General.GridView();
            this.btnActualizar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridVisor)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(711, 220);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(164, 25);
            this.metroLabel3.TabIndex = 40;
            this.metroLabel3.Text = "Ultima actualización";
            // 
            // lActualizado
            // 
            this.lActualizado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lActualizado.AutoSize = true;
            this.lActualizado.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lActualizado.Location = new System.Drawing.Point(711, 245);
            this.lActualizado.Name = "lActualizado";
            this.lActualizado.Size = new System.Drawing.Size(19, 25);
            this.lActualizado.TabIndex = 39;
            this.lActualizado.Text = "-";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(711, 120);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(175, 25);
            this.metroLabel2.TabIndex = 38;
            this.metroLabel2.Text = "Usuarios con equipos";
            // 
            // lUsuariosEquipos
            // 
            this.lUsuariosEquipos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lUsuariosEquipos.AutoSize = true;
            this.lUsuariosEquipos.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lUsuariosEquipos.Location = new System.Drawing.Point(711, 145);
            this.lUsuariosEquipos.Name = "lUsuariosEquipos";
            this.lUsuariosEquipos.Size = new System.Drawing.Size(19, 25);
            this.lUsuariosEquipos.TabIndex = 37;
            this.lUsuariosEquipos.Text = "-";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(711, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(150, 25);
            this.metroLabel1.TabIndex = 36;
            this.metroLabel1.Text = "Equipos prestados";
            // 
            // lEquiposPrestados
            // 
            this.lEquiposPrestados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lEquiposPrestados.AutoSize = true;
            this.lEquiposPrestados.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lEquiposPrestados.Location = new System.Drawing.Point(711, 48);
            this.lEquiposPrestados.Name = "lEquiposPrestados";
            this.lEquiposPrestados.Size = new System.Drawing.Size(19, 25);
            this.lEquiposPrestados.TabIndex = 35;
            this.lEquiposPrestados.Text = "-";
            // 
            // gridVisor
            // 
            this.gridVisor.AllowUserToAddRows = false;
            this.gridVisor.AllowUserToDeleteRows = false;
            this.gridVisor.AllowUserToResizeRows = false;
            this.gridVisor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridVisor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridVisor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridVisor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridVisor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridVisor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridVisor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridVisor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridVisor.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridVisor.EnableHeadersVisualStyles = false;
            this.gridVisor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridVisor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridVisor.Location = new System.Drawing.Point(0, 3);
            this.gridVisor.Name = "gridVisor";
            this.gridVisor.ReadOnly = true;
            this.gridVisor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridVisor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridVisor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridVisor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridVisor.Size = new System.Drawing.Size(705, 555);
            this.gridVisor.TabIndex = 34;
            this.gridVisor.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridVisor_ColumnHeaderMouseClick);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(711, 535);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(175, 25);
            this.btnActualizar.TabIndex = 33;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseSelectable = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // VisorDeEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.lActualizado);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lUsuariosEquipos);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lEquiposPrestados);
            this.Controls.Add(this.gridVisor);
            this.Controls.Add(this.btnActualizar);
            this.Name = "VisorDeEquipos";
            this.Size = new System.Drawing.Size(889, 561);
            this.Load += new System.EventHandler(this.VisorDeEquipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridVisor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lActualizado;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lUsuariosEquipos;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lEquiposPrestados;
        private LabManager.General.GridView gridVisor;
        private MetroFramework.Controls.MetroButton btnActualizar;
    }
}
