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

        private void dgNombre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormBusquedaE_Load(object sender, EventArgs e)
        {
            carga();
            carga1();
        }

        void carga()
        {
            miconexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = miconexion;
            cmd.CommandText = "Select Nombre from tblProyecto where idProyecto = (Select idPro from tblProEmp where idEmp = (select idEmpresa from tblEmpresa where Nombre = " + "'" + dato + "'));";

            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            dgProyecto.DataSource = dt;
            dgProyecto.Update();
            miconexion.Close();
        }

        void carga1()
        {
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal abrir = new FormPrincipal();
            abrir.Show();
        }
    }
}
