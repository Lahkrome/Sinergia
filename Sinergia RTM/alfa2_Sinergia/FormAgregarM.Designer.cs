namespace alfa2_Sinergia
{
    partial class FormAgregarM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarM));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViñeta = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCalentario = new System.Windows.Forms.PictureBox();
            this.btnClean = new System.Windows.Forms.PictureBox();
            this.tbFech = new System.Windows.Forms.TextBox();
            this.tbVersion = new System.Windows.Forms.TextBox();
            this.tbPro = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.panelFecha = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalentario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            this.panelFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnViñeta);
            this.panel1.Controls.Add(this.btnGenerar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(25, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 237);
            this.panel1.TabIndex = 7;
            // 
            // btnViñeta
            // 
            this.btnViñeta.AutoSize = true;
            this.btnViñeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViñeta.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViñeta.Location = new System.Drawing.Point(27, 180);
            this.btnViñeta.Name = "btnViñeta";
            this.btnViñeta.Size = new System.Drawing.Size(153, 30);
            this.btnViñeta.TabIndex = 3;
            this.btnViñeta.Text = "Generar viñeta";
            // 
            // btnGenerar
            // 
            this.btnGenerar.AutoSize = true;
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(27, 78);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(227, 30);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar nueva version";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(27, 126);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(168, 30);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar Proyecto";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(25, 28);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(183, 30);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar Proyecto";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.Location = new System.Drawing.Point(55, 302);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(70, 70);
            this.btnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVolver.TabIndex = 8;
            this.btnVolver.TabStop = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnCalentario);
            this.panel2.Controls.Add(this.btnClean);
            this.panel2.Controls.Add(this.tbFech);
            this.panel2.Controls.Add(this.tbVersion);
            this.panel2.Controls.Add(this.tbPro);
            this.panel2.Controls.Add(this.btnAceptar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(337, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 239);
            this.panel2.TabIndex = 9;
            // 
            // btnCalentario
            // 
            this.btnCalentario.Image = ((System.Drawing.Image)(resources.GetObject("btnCalentario.Image")));
            this.btnCalentario.Location = new System.Drawing.Point(280, 103);
            this.btnCalentario.Name = "btnCalentario";
            this.btnCalentario.Size = new System.Drawing.Size(29, 30);
            this.btnCalentario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCalentario.TabIndex = 11;
            this.btnCalentario.TabStop = false;
            this.btnCalentario.Click += new System.EventHandler(this.btnCalentario_Click);
            // 
            // btnClean
            // 
            this.btnClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClean.Image = ((System.Drawing.Image)(resources.GetObject("btnClean.Image")));
            this.btnClean.Location = new System.Drawing.Point(48, 185);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(95, 32);
            this.btnClean.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClean.TabIndex = 9;
            this.btnClean.TabStop = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // tbFech
            // 
            this.tbFech.Location = new System.Drawing.Point(160, 106);
            this.tbFech.Name = "tbFech";
            this.tbFech.ReadOnly = true;
            this.tbFech.Size = new System.Drawing.Size(114, 20);
            this.tbFech.TabIndex = 7;
            // 
            // tbVersion
            // 
            this.tbVersion.Location = new System.Drawing.Point(160, 70);
            this.tbVersion.Name = "tbVersion";
            this.tbVersion.Size = new System.Drawing.Size(114, 20);
            this.tbVersion.TabIndex = 6;
            this.tbVersion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbVersion_MouseClick);
            this.tbVersion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbVersion_KeyPress);
            // 
            // tbPro
            // 
            this.tbPro.BackColor = System.Drawing.SystemColors.Window;
            this.tbPro.Location = new System.Drawing.Point(160, 37);
            this.tbPro.Name = "tbPro";
            this.tbPro.Size = new System.Drawing.Size(114, 20);
            this.tbPro.TabIndex = 5;
            this.tbPro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbPro_MouseClick);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(198, 187);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(96, 32);
            this.btnAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.TabStop = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha modificación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Version:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Proyecto:";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // panelFecha
            // 
            this.panelFecha.BackColor = System.Drawing.Color.Transparent;
            this.panelFecha.Controls.Add(this.monthCalendar1);
            this.panelFecha.Location = new System.Drawing.Point(290, 241);
            this.panelFecha.Name = "panelFecha";
            this.panelFecha.Size = new System.Drawing.Size(232, 173);
            this.panelFecha.TabIndex = 10;
            this.panelFecha.Visible = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(5, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged_1);
            // 
            // FormAgregarM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(675, 413);
            this.Controls.Add(this.panelFecha);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(950, 451);
            this.MinimumSize = new System.Drawing.Size(691, 451);
            this.Name = "FormAgregarM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sinergia Consultores";
            this.Load += new System.EventHandler(this.FormAgregarM_Load);
            this.Click += new System.EventHandler(this.FormAgregarM_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalentario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            this.panelFecha.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label btnViñeta;
        private System.Windows.Forms.Label btnGenerar;
        private System.Windows.Forms.Label btnBuscar;
        private System.Windows.Forms.Label btnAgregar;
        private System.Windows.Forms.PictureBox btnVolver;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnClean;
        private System.Windows.Forms.TextBox tbFech;
        private System.Windows.Forms.TextBox tbVersion;
        private System.Windows.Forms.TextBox tbPro;
        private System.Windows.Forms.PictureBox btnAceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Panel panelFecha;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.PictureBox btnCalentario;
    }
}