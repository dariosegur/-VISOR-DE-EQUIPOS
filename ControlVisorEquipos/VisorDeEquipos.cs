using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabManagerCliente.VisorEquiposService;

namespace ControlVisorEquipos
{
    public partial class VisorDeEquipos : UserControl
    {
        public VisorDeEquipos()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Actualizar();
            }
            catch (Exception ex)
            {
                var m = new MetroUI_Compuesto.Error();
                m.tbMensaje.Text = ex.ToString();
            }
        }

        public void Actualizar()
        {
            var cliente = new LabManagerCliente.VisorEquiposService.VisorEquiposClient();
            var listado = cliente.getEquiposPrestados();

            gridVisor.DataSource = Ordenar(listado.Items);
            gridVisor.Refresh();
            string[] columnas = {
                    "CodigoLaboratorio",
                    "UsuarioResponsableCodigoBarras",
                    "UsuarioResponsable"
                };
            gridVisor.SetVisibleColumns(columnas);
            lEquiposPrestados.Text = listado.Items.Count().ToString();
            var usuarios = listado.Items.Select(u => u.UsuarioResponsableId).Distinct();
            lUsuariosEquipos.Text = usuarios.Count().ToString();
            lActualizado.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private View_Equipo[] Ordenar(View_Equipo[] items)
        {
            if (shortColumn != null)
            {
                items = shortAsc ?
                    items.OrderBy(i => i.GetType().GetProperty(shortColumn).GetValue(i, null)).ToArray() :
                    items.OrderByDescending(i => i.GetType().GetProperty(shortColumn).GetValue(i, null)).ToArray();
            }
            return items;
        }

        private void VisorDeEquipos_Load(object sender, EventArgs e)
        {
            try
            {
                Actualizar();
            }
            catch (Exception ex)
            {
                var m = new MetroUI_Compuesto.Error();
                m.tbMensaje.Text = ex.ToString();
            }
        }

        string shortColumn = null;
        bool shortAsc = true;
        private void gridVisor_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (shortColumn != gridVisor.Columns[e.ColumnIndex].HeaderText)
                {
                    shortColumn = gridVisor.Columns[e.ColumnIndex].HeaderText;
                    shortAsc = true;
                }
                else {
                    shortAsc = !shortAsc;
                }
                Actualizar();
            }
            catch (Exception ex)
            {
                var m = new MetroUI_Compuesto.Error();
                m.tbMensaje.Text = ex.ToString();
            }
        }
    }
}
