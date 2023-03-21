namespace WEscuela
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.RadProfesor = new System.Windows.Forms.RadioButton();
            this.RadEstudiante = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtCalificacion = new System.Windows.Forms.TextBox();
            this.TxtSueldo = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCapturar = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RadProfesor
            // 
            this.RadProfesor.AutoSize = true;
            this.RadProfesor.Location = new System.Drawing.Point(6, 30);
            this.RadProfesor.Name = "RadProfesor";
            this.RadProfesor.Size = new System.Drawing.Size(79, 20);
            this.RadProfesor.TabIndex = 0;
            this.RadProfesor.TabStop = true;
            this.RadProfesor.Text = "Profesor";
            this.RadProfesor.UseVisualStyleBackColor = true;
            this.RadProfesor.CheckedChanged += new System.EventHandler(this.RadProfesor_CheckedChanged);
            // 
            // RadEstudiante
            // 
            this.RadEstudiante.AutoSize = true;
            this.RadEstudiante.Location = new System.Drawing.Point(6, 65);
            this.RadEstudiante.Name = "RadEstudiante";
            this.RadEstudiante.Size = new System.Drawing.Size(91, 20);
            this.RadEstudiante.TabIndex = 1;
            this.RadEstudiante.TabStop = true;
            this.RadEstudiante.Text = "Estudiante";
            this.RadEstudiante.UseVisualStyleBackColor = true;
            this.RadEstudiante.CheckedChanged += new System.EventHandler(this.RadEstudiante_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadProfesor);
            this.groupBox1.Controls.Add(this.RadEstudiante);
            this.groupBox1.Location = new System.Drawing.Point(70, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 91);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo De Persona";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtCalificacion);
            this.groupBox2.Controls.Add(this.TxtSueldo);
            this.groupBox2.Controls.Add(this.TxtNombre);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(70, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 132);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos De La Persona";
            // 
            // TxtCalificacion
            // 
            this.TxtCalificacion.Location = new System.Drawing.Point(106, 101);
            this.TxtCalificacion.Name = "TxtCalificacion";
            this.TxtCalificacion.Size = new System.Drawing.Size(100, 22);
            this.TxtCalificacion.TabIndex = 9;
            // 
            // TxtSueldo
            // 
            this.TxtSueldo.Location = new System.Drawing.Point(106, 69);
            this.TxtSueldo.Name = "TxtSueldo";
            this.TxtSueldo.Size = new System.Drawing.Size(100, 22);
            this.TxtSueldo.TabIndex = 8;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(106, 34);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 22);
            this.TxtNombre.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Calificacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sueldo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // BtnCapturar
            // 
            this.BtnCapturar.Location = new System.Drawing.Point(406, 91);
            this.BtnCapturar.Name = "BtnCapturar";
            this.BtnCapturar.Size = new System.Drawing.Size(96, 55);
            this.BtnCapturar.TabIndex = 4;
            this.BtnCapturar.Text = "Capturar Datos";
            this.BtnCapturar.UseVisualStyleBackColor = true;
            this.BtnCapturar.Click += new System.EventHandler(this.BtnCapturar_Click);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(406, 217);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(96, 55);
            this.BtnMostrar.TabIndex = 5;
            this.BtnMostrar.Text = "Mostrar Datos";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 440);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.BtnCapturar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Personas de una escuela";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton RadProfesor;
        private System.Windows.Forms.RadioButton RadEstudiante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCalificacion;
        private System.Windows.Forms.TextBox TxtSueldo;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button BtnCapturar;
        private System.Windows.Forms.Button BtnMostrar;
    }
}

