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
    public partial class FormAgregarE : Form
    {
        public FormAgregarE()
        {
            InitializeComponent();
        }

        SqlConnection miconexion = new SqlConnection("Data Source=.;Initial Catalog=Sinergia;Integrated Security=True");
        
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal abrir = new FormPrincipal();
            abrir.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormBuscarE abrir = new FormBuscarE();
            abrir.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tbContacto.Clear();
            tbNombre.Clear();
            tbFono.Clear();
        }


        public int num(int a)
        {
            int numero = 0;
            Random objeto = new Random();
            numero = objeto.Next(123, 1230000000);
            MessageBox.Show("Numero: " + numero);
            return numero;
        }
        

        void Ingreso()
        {
            if (tbContacto.Text.Length > 0 && tbFono.Text.Length > 0 && tbNombre.Text.Length > 0)
            {
                if (tbContacto.Text.Length < 26 && tbFono.Text.Length < 26 && tbNombre.Text.Length < 26)
                {
                    try
                    {
                        int b = num(0);
                        miconexion.Open();
                        SqlCommand consulta = new SqlCommand(" select * from tblEmpresa where idEmpresa = '" + b.ToString() + "'", miconexion);
                        SqlDataReader ejecuta = consulta.ExecuteReader();
                        while (ejecuta.Read() == true)
                        {
                            b = num(0);
                        }

                        miconexion.Close();
                       
                        SqlCommand comando = new SqlCommand("Insert into tblEmpresa (idEmpresa, Nombre, Contacto, Fono) values(@id, @name, @con, @fono)", miconexion);
                        comando.Parameters.AddWithValue("id", b);
                        comando.Parameters.AddWithValue("name", tbNombre.Text);
                        comando.Parameters.AddWithValue("con", tbContacto.Text);
                        comando.Parameters.AddWithValue("fono", tbFono.Text);
                        miconexion.Open();
                        comando.ExecuteNonQuery();
                        miconexion.Close();
                        //this.Hide();
                        MessageBox.Show("Ingresado satifactoriamente");
                        this.Close();
                    }

                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message,
                            "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Por si se produce un error,
                        // comprobar si la conexión está abierta
                        if (miconexion.State == ConnectionState.Open)
                        {
                            miconexion.Close();
                        }
                    }

                }

                else
                {
                    MessageBox.Show("Por Favor rellene los campos con la cantidad \npermitida descrita en el manual",
                                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }

            else 
            {
                MessageBox.Show("Por Favor rellene los campos para ingresar",
                                      "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
                
            }

            this.Close();
            FormAgregarE abrir = new FormAgregarE();
            abrir.Show();
        
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Ingreso();
        }

        private void tbFono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

    }
}
