using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace alfa2_Sinergia
{
    public partial class FormBuscarE : Form
    {
        public FormBuscarE()
        {
            InitializeComponent();
        }

        SqlConnection miconexion = new SqlConnection("Data Source=.;Initial Catalog=Sinergia;Integrated Security=True");

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            tbBuscar.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAgregarE abrir = new FormAgregarE();
            abrir.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal abrir = new FormPrincipal();
            abrir.Show();
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormBuscarE_Load(object sender, EventArgs e)
        {

        }

        public void llenar()
        {

            FormBusquedaE Buscar = new FormBusquedaE();
            Buscar.enviarDato = tbBuscar.Text; 
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            miconexion.Open();
            SqlCommand consulta = new SqlCommand("select * from tblEmpresa where Nombre = '"+tbBuscar.Text+ "'", miconexion);
            SqlDataReader ejecuta = consulta.ExecuteReader();
            if (ejecuta.Read() == true)
            {
                this.Hide();
                FormBusquedaE abrir = new FormBusquedaE();
                abrir.enviarDato = tbBuscar.Text;
                abrir.Show();
            }

            else
            {
                MessageBox.Show("Empresa no encontrada, verifique nuevamente",
                                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbBuscar.Clear();
            }

            miconexion.Close();
        }

        private void btnAgregar_CursorChanged(object sender, EventArgs e)
        {

        }
    }
}
