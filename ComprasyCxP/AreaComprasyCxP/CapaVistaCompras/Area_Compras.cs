using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistaSeguridadHSC;
using CapaVista;
using CapaVistaReporte;

namespace CapaVistaCompras
{

    public partial class Area_Compras : Form
    {

        public Area_Compras()
        {
            InitializeComponent();
        }

        private void Area_Compras_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtusuario.Text = form.usuario();
                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtusuario.Text = form.usuario();
                this.Show();
            }
            else
            { this.Close();
                txtusuario.Text = "";
                this.Close();
            }

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void consultasInteligentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuconsultas formulario = new menuconsultas();
            formulario.Show();
        }

        private void reporteadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteadorAdmin formulario = new ReporteadorAdmin();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void moduloDeSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMIDSeguridad formulario = new frmMIDSeguridad();
            formulario.Show();
        }

    
        

       

        

    

        
        private void ayudasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


       

        

        private void bodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoBodega2030 formulario = new MantenimientoBodega2030();
            formulario.MdiParent = this;
            formulario.Show();
            formulario.funActualizarUsuario(txtusuario.Text);

        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MantenimientoProveedores2020 formulario = new MantenimientoProveedores2020();
            formulario.MdiParent = this;
            formulario.Show();
            formulario.funActualizarUsuario(txtusuario.Text);

        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoProducto2025 formulario = new MantenimientoProducto2025();
            formulario.MdiParent = this;
            formulario.Show();
            formulario.funActualizarUsuario(txtusuario.Text);
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoInventario2035 formulario = new MantenimientoInventario2035();
            formulario.MdiParent = this;
            formulario.Show();
            formulario.funActualizarUsuario(txtusuario.Text);
        }

        private void tipoInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoTipoInventario2040 formulario = new MantenimientoTipoInventario2040();
            formulario.MdiParent = this;
            formulario.Show();
            formulario.funActualizarUsuario(txtusuario.Text);
        }

       

        private void cuentasPorPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void movimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoMovimientos2055 formulario = new MantenimientoMovimientos2055();
            formulario.MdiParent = this;
            formulario.Show();
            formulario.funActualizarUsuario(txtusuario.Text);

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoCliente2060 formulario = new MantenimientoCliente2060();
            formulario.MdiParent = this;
            formulario.Show();
            formulario.funActualizarUsuario(txtusuario.Text);
        }
    }
}
