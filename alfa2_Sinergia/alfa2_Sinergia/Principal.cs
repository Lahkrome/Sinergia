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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Acerca de Sinergia: \nDirección: Alameda 1315 Of 32\nFono: 6989029",
                        "Acerca de:",MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            this.Close();
            FormEmpresaPrincipal abrir = new FormEmpresaPrincipal();
            abrir.Show();

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
