using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace alfa2_Sinergia
{
    public partial class FormBuscarP : Form
    {
        public FormBuscarP()
        {
            InitializeComponent();
        }
        private String dato;

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                dato = tbBuscar.Text;
                System.Diagnostics.Process.Start(@"C:\ProyectosSC\" + dato + "");
                // El Codigo permite abrir una carpeta por direccion escrita textualmente,
                //Este ejemplo te abrira de la carpeta C la carpeta archivo de programas
                //consejo: Buscar en la base de datos la carpeta antes de abrirla para evitar errores y en el dato se guarda el nombre del proyecto =D
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAgregarP abrir = new FormAgregarP();
            abrir.ShowDialog();
        }

        private void btnViñeta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reporte abrir = new Reporte();
            abrir.ShowDialog();
            this.Show();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAgregarM abrir = new FormAgregarM();
            abrir.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FormProyectoPrincipal abrir = new FormProyectoPrincipal();
            abrir.ShowDialog();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbBuscar.Clear();
        }

        private void FormBuscarP_Load(object sender, EventArgs e)
        {

        }
    }
}
