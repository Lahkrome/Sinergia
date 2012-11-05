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

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal abrir = new FormPrincipal();
            abrir.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAgregarP abrir = new FormAgregarP();
            abrir.Show();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAgregarM abrir = new FormAgregarM();
            abrir.Show();
        }
    }
}
