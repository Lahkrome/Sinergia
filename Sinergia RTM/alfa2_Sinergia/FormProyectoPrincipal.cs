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
    public partial class FormProyectoPrincipal : Form
    {
        public FormProyectoPrincipal()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormBuscarP abrir = new FormBuscarP();
            abrir.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal abrir = new FormPrincipal();
            abrir.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAgregarP abrir = new FormAgregarP();
            abrir.ShowDialog();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAgregarM abrir = new FormAgregarM();
            abrir.ShowDialog();
        }

        private void btnViñeta_Click(object sender, EventArgs e)
        {
            
            Reporte abrir = new Reporte();
            abrir.ShowDialog();
        }

        private void FormProyectoPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
