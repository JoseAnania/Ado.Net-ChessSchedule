using AppChessSchedule.Controlador;
using AppChessSchedule.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppChessSchedule.Vista
{
    public partial class VentanaPais : Form
    {
        GestorPais gp = new GestorPais();
        private bool btnAgregarClick=false;
        private bool btnModificarClick = false;
        private bool btnEliminarClick = false;
        public VentanaPais()
        {
            InitializeComponent();
            ActivarCampos(true);
            ListarPais();
        }
        private void ActivarCampos(bool x)
        {
            btnAgregar.Enabled = x;
            btnModificar.Enabled = x;
            btnEliminar.Enabled = x;
            btnSalir.Enabled = x;
            txtNombre.Enabled = !x;
            btnAceptar.Enabled = !x;
            btnCancelar.Enabled = !x;
        }
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
        }
        private void ListarPais()
        {
            List<Pais> lista = gp.ListarPais();
            DataTable modelo = new DataTable();
            modelo.Columns.Add("País");
            dgvLista.DataSource = modelo;
            foreach (Pais p in lista)
            {
                DataRow fila = modelo.NewRow();
                fila[0] = p.nombre;
                modelo.Rows.Add(fila);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (btnAgregarClick==true)
            {
                int idPais = 0;
                string nombre = txtNombre.Text;
                Pais p = new Pais(idPais, nombre);
                gp.AgregarPais(p);
                ListarPais();
                LimpiarCampos();
                ActivarCampos(true);

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ActivarCampos(false);
            btnAgregarClick = true;
            btnModificarClick = false;
            btnEliminarClick = false;
            LimpiarCampos();
        }
    }
}
