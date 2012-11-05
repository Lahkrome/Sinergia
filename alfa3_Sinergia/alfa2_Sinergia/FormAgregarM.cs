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
            //Guardar en S el contenido de la consulta
            string S;
            miconexion.ConnectionString = CadenaConexion;
            SqlCommand comando1 = new SqlCommand();
            miconexion.Open();
            //comando1 = new SqlCommand(" Select idEmpleado From tblEmpleado where Nombre= @name", miconexion);
            
            comando1 = new SqlCommand(" Select idPro From tblModPro where idPro = (select idProyecto from tblProyecto where Nombre = @idProyecto)", miconexion);
            comando1.Parameters.AddWithValue("idProyecto", tbPro.Text);
            S = comando1.ExecuteScalar().ToString();
            leer = comando1.ExecuteReader();
            miconexion.Close();

            //Insertar datos de proyectos en la bd
            SqlCommand comando = new SqlCommand("Insert into tblModPro (idPro,Version, FechMod) values ( @idP, @ver, @fech)", miconexion);
            comando.Parameters.AddWithValue("idP", S);
            comando.Parameters.AddWithValue("ver",tbVersion.Text);
            comando.Parameters.AddWithValue("fech", tbFech.Text);
            miconexion.Open();
            comando.ExecuteNonQuery();
            miconexion.Close();
            MessageBox.Show("Ingresado satifactoriamente");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            carga();
        }
    }
}
