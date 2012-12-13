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
    public partial class FormBusquedaE : Form
    {
        public FormBusquedaE()
        {
            InitializeComponent();
        }

        private string dato;


        public string enviarDato
        {
            get { return dato;}
            set { dato = value;}
        }

        SqlConnection miconexion = new SqlConnection("Data Source=.;Initial Catalog=Sinergia;Integrated Security=True");

       
        private void FormBusquedaE_Load(object sender, EventArgs e)
        {
            carga3();
            carga1();
            carga();
        }

        void carga()
        {
            try
            {
                //Carga de datos de proyectos a cargo de una empresa
                miconexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = miconexion;
                cmd.CommandText = "select nombre from tblProyecto where idEmp =( select idEmp from tblEmpresa where Nombre = " +"'" + dato + "');";
                SqlDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);
                dgProyecto.DataSource = dt;
                dgProyecto.Update();
                miconexion.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message,
                            "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void carga1()
        {
            //Carga de datos de contacto y fono de la empresa
            miconexion.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = miconexion;
            cmd1.CommandText = "Select Contacto, Fono from tblEmpresa where Nombre = " + "'" + dato + "';";
            SqlDataReader dr1 = cmd1.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Load(dr1);
            dgContacto.DataSource = dt1;
            dgContacto.Update();
            miconexion.Close(); 
        }

        void carga3()
        {
            //Carga de datos en Nombre
            miconexion.Open();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = miconexion;
            cmd2.CommandText = "select nombre from tblEmpresa where Nombre = " + "'" + dato + "';";
            SqlDataReader dr2 = cmd2.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(dr2);
            dgNombre.DataSource = dt2;
            dgNombre.Update();
            miconexion.Close(); 
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal abrir = new FormPrincipal();
            abrir.ShowDialog();
        }
    }
}
