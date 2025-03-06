namespace VisoDeEquipos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tActualizar = new System.Windows.Forms.Timer(this.components);
            this.visorEquipos = new ControlVisorEquipos.VisorDeEquipos();
            this.SuspendLayout();
            // 
            // tActualizar
            // 
            this.tActualizar.Enabled = true;
            this.tActualizar.Interval = 30000;
            this.tActualizar.Tick += new System.EventHandler(this.tActualizar_Tick);
            // 
            // visorEquipos
            // 
            this.visorEquipos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visorEquipos.Location = new System.Drawing.Point(23, 63);
            this.visorEquipos.Name = "visorEquipos";
            this.visorEquipos.Size = new System.Drawing.Size(835, 448);
            this.visorEquipos.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.ClientSize = new System.Drawing.Size(881, 520);
            this.Controls.Add(this.visorEquipos);
            this.Name = "Form1";
            this.Text = "Visor De Equipos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tActualizar;
        private ControlVisorEquipos.VisorDeEquipos visorEquipos;
    }
}

