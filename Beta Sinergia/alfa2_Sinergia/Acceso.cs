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
    public partial class Acceso : Form
    {
        SqlConnection miconexion = new SqlConnection("Data Source=.;Initial Catalog=Sinergia;Integrated Security=True");

        public Acceso()
        {
            InitializeComponent();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            tbUser.Text = " ";
        }

        private void tbPass_MouseClick(object sender, MouseEventArgs e)
        {
            tbPass.Text = " ";
        }

        private void tbUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            acceso();
        }

        void acceso()
        {
            try
            {
                if (tbUser.Text.Length > 0 || tbPass.Text.Length > 0)
                {
                    miconexion.Open();
                    SqlCommand consulta = new SqlCommand(" select * from tblUser where Usuario='" + tbUser.Text + "'and Password='" + tbPass.Text + "'", miconexion);
                    SqlDataReader ejecuta = consulta.ExecuteReader();
                    if (ejecuta.Read() == true)
                    {
                        MessageBox.Show("Bienvenido Admin");
                        this.Hide();
                        FormPrincipal abrir = new FormPrincipal();
                        abrir.Show();
                    }

                    else
                    {
                        MessageBox.Show("Acceso Denegado");
                        tbUser.Clear();
                        tbPass.Clear();
                        tbUser.Focus();
                        miconexion.Close();
                    }
                }

                else
                {
                    MessageBox.Show("Por Favor rellene los campos para acceder",
                                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                if (miconexion.State == ConnectionState.Open)
                {
                    miconexion.Close();
                }
            }


        }
    }

}