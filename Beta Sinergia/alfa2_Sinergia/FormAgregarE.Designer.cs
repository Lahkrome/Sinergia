namespace alfa2_Sinergia
{
    partial class FormAgregarE
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarE));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClean = new System.Windows.Forms.PictureBox();
            this.tbFono = new System.Windows.Forms.TextBox();
            this.tbContacto = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Location = new System.Drawing.Point(25, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 176);
            this.panel1.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(25, 97);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(164, 30);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar Empresa";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(25, 28);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(179, 30);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar Empresa";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnClean);
            this.panel2.Controls.Add(this.tbFono);
            this.panel2.Controls.Add(this.tbContacto);
            this.panel2.Controls.Add(this.tbNombre);
            this.panel2.Controls.Add(this.tbId);
            this.panel2.Controls.Add(this.btnAceptar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(339, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 324);
            this.panel2.TabIndex = 2;
            // 
            // btnClean
            // 
            this.btnClean.Image = ((System.Drawing.Image)(resources.GetObject("btnClean.Image")));
            this.btnClean.Location = new System.Drawing.Point(81, 278);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(95, 32);
            this.btnClean.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClean.TabIndex = 9;
            this.btnClean.TabStop = false;
            this.btnClean.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // tbFono
            // 
            this.tbFono.Location = new System.Drawing.Point(141, 145);
            this.tbFono.Name = "tbFono";
            this.tbFono.Size = new System.Drawing.Size(114, 20);
            this.tbFono.TabIndex = 8;
            this.tbFono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFono_KeyPress);
            // 
            // tbContacto
            // 
            this.tbContacto.Location = new System.Drawing.Point(141, 113);
            this.tbContacto.Name = "tbContacto";
            this.tbContacto.Size = new System.Drawing.Size(114, 20);
            this.tbContacto.TabIndex = 7;
            this.tbContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbContacto_KeyPress);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(141, 79);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(114, 20);
            this.tbNombre.TabIndex = 6;
            this.tbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombre_KeyPress);
            // 
            // tbId
            // 
            this.tbId.BackColor = System.Drawing.SystemColors.Window;
            this.tbId.Location = new System.Drawing.Point(141, 44);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(114, 20);
            this.tbId.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(200, 278);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(96, 32);
            this.btnAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.TabStop = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contacto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificación:";
            // 
            // btnVolver
            // 
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.Location = new System.Drawing.Point(55, 302);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(70, 70);
            this.btnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVolver.TabIndex = 3;
            this.btnVolver.TabStop = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormAgregarE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(675, 413);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAgregarE";
            this.Text = "Sinergia Consultores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label btnBuscar;
        private System.Windows.Forms.Label btnAgregar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbFono;
        private System.Windows.Forms.TextBox tbContacto;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.PictureBox btnAceptar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnClean;
        private System.Windows.Forms.PictureBox btnVolver;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}