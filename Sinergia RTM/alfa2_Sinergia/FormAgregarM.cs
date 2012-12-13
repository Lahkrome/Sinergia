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
    public partial class FormAgregarM : Form
    {
        public FormAgregarM()
        {
            InitializeComponent();
        }

        public SqlConnection miconexion = new SqlConnection();
        public string CadenaConexion = "Data Source=.;Initial Catalog=Sinergia;Integrated Security=True";
        public SqlCommand comando;
        public SqlDataReader leer;

        void carga()
        {
            if (tbPro.Text.Length > 0 && tbFech.Text.Length > 0 && tbVersion.Text.Length > 0)
            {
                if (tbPro.Text.Length < 16 && tbFech.Text.Length < 16 && tbVersion.Text.Length < 16)
                {

                    try
                    {
                        //Guardar en S el contenido de la consulta
                        string S;
                        miconexion.ConnectionString = CadenaConexion;
                        SqlCommand comando1 = new SqlCommand();
                        miconexion.Open();
                        comando1 = new SqlCommand("select idProyecto from tblProyecto where Nombre = '" + tbPro.Text + "'", miconexion);
                        S = comando1.ExecuteScalar().ToString();
                        miconexion.Close();

                        //Insertar datos de proyectos en la bd
                        SqlCommand comando = new SqlCommand("Insert into tblModPro (idPro,Ver, FechMod) values ( @idP, @ver, @fech)", miconexion);
                        comando.Parameters.AddWithValue("idP", S);
                        comando.Parameters.AddWithValue("ver", tbVersion.Text);
                        comando.Parameters.AddWithValue("fech", tbFech.Text);
                        miconexion.Open();
                        comando.ExecuteNonQuery();
                        miconexion.Close();
                        MessageBox.Show("Ingresado satifactoriamente");
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Proyecto inexistente ",
                           "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Numero de caracteres exedido",
                                 "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Por Favor rellenar los campos faltantes",
                                "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            carga();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            tbFech.Clear();
            tbPro.Clear();
            tbVersion.Clear();
        }

        
        private void FormAgregarM_Click(object sender, EventArgs e)
        {
            panelFecha.Visible = false;
            this.Size = new Size(691, 451);
        }

        private void btnCalentario_Click(object sender, EventArgs e)
        {
            this.Size = new Size(950, 451);
            panelFecha.Location = new Point(688, 41);
            panelFecha.Visible = true;
        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            tbFech.Text = monthCalendar1.SelectionEnd.ToShortDateString();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FormProyectoPrincipal abrir = new FormProyectoPrincipal();
            abrir.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormBuscarP abrir = new FormBuscarP();
            abrir.ShowDialog();
        }

        private void tbVersion_MouseClick(object sender, MouseEventArgs e)
        {
            panelFecha.Visible = false;
        }

        private void tbPro_MouseClick(object sender, MouseEventArgs e)
        {
            panelFecha.Visible = false;
        }

        private void tbVersion_KeyPress(object sender, KeyPressEventArgs e)
        {
            panelFecha.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAgregarP abrir = new FormAgregarP();
            abrir.ShowDialog();
        }

        private void FormAgregarM_Load(object sender, EventArgs e)
        {

        }

        

    

        
    }
}
