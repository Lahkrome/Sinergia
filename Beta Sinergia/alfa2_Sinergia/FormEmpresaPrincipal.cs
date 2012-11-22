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
    public partial class FormEmpresaPrincipal : Form
    {
        public FormEmpresaPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAgregarE abrir = new FormAgregarE();
            abrir.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormBuscarE abrir = new FormBuscarE();
            abrir.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal abrir = new FormPrincipal();
            abrir.Show();
        }
    }
}
