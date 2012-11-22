using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace alfa2_Sinergia
{
    public partial class FormAgregarP : Form
    {
        public FormAgregarP()
        {
            InitializeComponent();
        }

        public SqlConnection miconexion = new SqlConnection();
        public string CadenaConexion ="Data Source=.;Initial Catalog=Sinergia;Integrated Security=True";
        public SqlCommand comando;
        public SqlDataReader leer;
        
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal abrir = new FormPrincipal();
            abrir.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CargaDatos();
            Ccarpeta();
        }

        public void cargaEmpleado()
        {
            miconexion.ConnectionString = CadenaConexion;
            SqlCommand comando = new SqlCommand();
            comando = new SqlCommand(" Select Nombre From tblEmpleado ", miconexion);
            miconexion.Open();
            leer = comando.ExecuteReader();
            while (leer.Read())
            { 
                cmbEmpleado.Items.Add(leer.GetString(leer.GetOrdinal("Nombre")));
            }
            miconexion.Close();
            
        }

        public void cargaEmpresa()
        {
            miconexion.ConnectionString = CadenaConexion;
            SqlCommand comando = new SqlCommand();
            comando = new SqlCommand(" Select Nombre From tblEmpresa ", miconexion);
            miconexion.Open();
            leer = comando.ExecuteReader();
            while (leer.Read())
            {
                cmbEmpresa.Items.Add(leer.GetString(leer.GetOrdinal("Nombre")));
            } 
            miconexion.Close();

        }

        public void CargaDatos()
        {
           if (tbId.Text.Length > 0 && tbNombre.Text.Length > 0 && cmbEmpleado.Text.Length > 0 && cmbEmpresa.Text.Length > 0)
            {
                if (tbId.Text.Length < 16 && tbNombre.Text.Length < 51 && cmbEmpleado.Text.Length < 51 && cmbEmpresa.Text.Length < 26)
                {

                    try
                    {
                        //Obtener id de empleado de lo ingresado en un combobox
                        string S, Q;
                        miconexion.ConnectionString = CadenaConexion;
                        SqlCommand comando1 = new SqlCommand();
                        miconexion.Open();
                        comando1 = new SqlCommand(" Select idEmpleado From tblEmpleado where Nombre= @name", miconexion);
                        comando1.Parameters.AddWithValue("name", cmbEmpleado.Text);
                        S = comando1.ExecuteScalar().ToString();
                        leer = comando1.ExecuteReader();
                        miconexion.Close();
                        
                        //Obtener id de empresa de lo ingresado en un combobox
                        SqlCommand comando2 = new SqlCommand();
                        miconexion.Open();
                        comando2 = new SqlCommand(" Select idEmpresa From tblEmpresa where Nombre = @name1", miconexion);
                        comando2.Parameters.AddWithValue("name1", cmbEmpresa.Text);
                        Q = comando2.ExecuteScalar().ToString();
                        leer = comando2.ExecuteReader();
                        miconexion.Close();

                        //Insertar fecha desde calendario de inicio 
                        tbFechini.Text = monthCalendar1.SelectionEnd.ToShortDateString();
                        monthCalendar1.Show();

                        //Insertar fecha desde calendario de final
                        tbFechfin.Text = monthCalendarFechter.SelectionEnd.ToShortDateString();
                        monthCalendarFechter.Show();
                        
                        //Insertar datos de proyectos en la bd
                        SqlCommand comando = new SqlCommand("Insert into tblProyecto (idProyecto, Nombre, FechIni, FechFin, idEmpl, idEmp) values (@id, @name, @fechi, @fechf, @idempl, @idemp)", miconexion);
                        comando.Parameters.AddWithValue("id", tbId.Text);
                        comando.Parameters.AddWithValue("name", tbNombre.Text);
                        comando.Parameters.AddWithValue("fechi", tbFechini.Text);
                        comando.Parameters.AddWithValue("fechf", tbFechfin.Text);
                        comando.Parameters.AddWithValue("idempl", S);
                        comando.Parameters.AddWithValue("idemp", Q);
                        miconexion.Open();
                        comando.ExecuteNonQuery();
                        miconexion.Close();

                        //Insertar relaciones en tabla linkeadora proyecto/empresa

                        SqlCommand comando4 = new SqlCommand("Insert into tblProEmp (idPro, idEmp) values (@idP, @idE)", miconexion);
                        comando4.Parameters.AddWithValue("idP",tbId.Text);
                        comando4.Parameters.AddWithValue("idE",Q);
                        miconexion.Open();
                        comando4.ExecuteNonQuery();
                        miconexion.Close();
                        
                        MessageBox.Show("Ingresado satifactoriamente");
                    }

                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message,
                            "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    finally
                    {
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
  }


        private void FormAgregarP_Load(object sender, EventArgs e)
        {
            cargaEmpleado();
            cargaEmpresa();
            
            
            
        }

        private void btnViñeta_Click(object sender, EventArgs e)
        {
            this.Close();
            Reporte abrir = new Reporte();
            abrir.Show();
        }

        void Ccarpeta()
        {
            string A;
            A = tbNombre.Text;
            CrearCarpeta(A);

        }

        public void CrearCarpeta(string nombre)
        {
            string nombre1;
            nombre1 = nombre;

            try
            {
                //En caso de nuevas carpetas bases , en caso de posibles errores, evaluar try catch
                //si no existe la carpeta temporal la creamos 
                if (!(Directory.Exists(@"C:\ProyectosSC\" + nombre)))
                {
                    // Especificar directorio base
                    string activeDir = @"C:\ProyectosSC";

                    //Crear subdirectorio dentro de lo espeficicado
                    nombre = System.IO.Path.Combine(activeDir, nombre);

                    // Crear subdirectorio
                    System.IO.Directory.CreateDirectory(nombre);
                    MessageBox.Show("Carpeta Creada Exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string fileName = nombre + ".txt";
                    string Directorio = @"C:\ProyectosSC\" + nombre;
                    File.CreateText(Directorio + fileName);


                }

                else
                {
                    MessageBox.Show("Ya Existe una carpeta con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            tbFechfin.Clear();
            tbFechini.Clear();
            tbId.Clear();
            tbNombre.Clear();
        }

        private void tbFechini_TextChanged(object sender, EventArgs e)
        {
            panel3.Show();
            tbFechini.Text = monthCalendar1.SelectionEnd.ToShortDateString();
        }

        private void tbFechfin_TextChanged(object sender, EventArgs e)
        {
            panelFechTer.Show();
            tbFechfin.Text = monthCalendarFechter.SelectionEnd.ToShortDateString();
        }

        private void btnCalentarioInicio_Click(object sender, EventArgs e)
        {
            this.Size = new Size(950, 483);
            panel3.Location = new Point(688, 41);
            panel3.Visible = true;
        }

        private void btnCalendarioFin_Click(object sender, EventArgs e)
        {
            panelFechIni.Visible = false;
            this.Size = new Size(950, 483);
            panelFechTer.Location = new Point(688, 41);
            panelFechTer.Visible = true;
         
        }

        private void FormAgregarP_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            this.Size = new Size(691, 451);

            panelFechTer.Visible = false;
            this.Size = new Size(691, 451);
        }

        private void monthCalendarFechter_DateChanged(object sender, DateRangeEventArgs e)
        {
            tbFechfin.Text = monthCalendarFechter.SelectionEnd.ToShortDateString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            tbFechini.Text = monthCalendar1.SelectionEnd.ToShortDateString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormBuscarP abrir = new FormBuscarP();
            abrir.Show();
        }

       
    }
}
