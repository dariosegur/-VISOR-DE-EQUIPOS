using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisoDeEquipos
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public bool HideOnClose { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                visorEquipos.Actualizar();
            }
            catch (Exception ex)
            {
                var m = new MetroUI_Compuesto.Error();
                m.tbMensaje.Text = ex.ToString();
            }
        }

        private void tActualizar_Tick(object sender, EventArgs e)
        {
            try
            {
                visorEquipos.Actualizar();
            }
            catch (Exception ex)
            {
                var m = new MetroUI_Compuesto.Error();
                m.tbMensaje.Text = ex.ToString();
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (HideOnClose)
            {
                e.Cancel = true;
                Visible = false;
            }            
        }
    }
}
