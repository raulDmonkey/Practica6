namespace Ejercicio06CentroEscolar
{
    partial class fAlumnos
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bNEWAlumno = new System.Windows.Forms.Button();
            this.bBorrarAlumno = new System.Windows.Forms.Button();
            this.bListaAlumno = new System.Windows.Forms.Button();
            this.bOrdenAlfabetico = new System.Windows.Forms.Button();
            this.bDatosAlumno = new System.Windows.Forms.Button();
            this.bAlumnosCurso = new System.Windows.Forms.Button();
            this.groupBoxAlumnos = new System.Windows.Forms.GroupBox();
            this.bNEWNotas = new System.Windows.Forms.Button();
            this.bAprobados = new System.Windows.Forms.Button();
            this.bBorrarNota = new System.Windows.Forms.Button();
            this.bSuspendidos = new System.Windows.Forms.Button();
            this.groupBoxNotas = new System.Windows.Forms.GroupBox();
            this.groupBoxAlumnos.SuspendLayout();
            this.groupBoxNotas.SuspendLayout();
            this.SuspendLayout();
            // 
            // bNEWAlumno
            // 
            this.bNEWAlumno.Location = new System.Drawing.Point(22, 29);
            this.bNEWAlumno.Name = "bNEWAlumno";
            this.bNEWAlumno.Size = new System.Drawing.Size(198, 49);
            this.bNEWAlumno.TabIndex = 0;
            this.bNEWAlumno.Text = "Introducir Alumno";
            this.bNEWAlumno.UseVisualStyleBackColor = true;
            this.bNEWAlumno.Click += new System.EventHandler(this.bNEWAlumno_Click);
            // 
            // bBorrarAlumno
            // 
            this.bBorrarAlumno.Location = new System.Drawing.Point(226, 29);
            this.bBorrarAlumno.Name = "bBorrarAlumno";
            this.bBorrarAlumno.Size = new System.Drawing.Size(179, 49);
            this.bBorrarAlumno.TabIndex = 1;
            this.bBorrarAlumno.Text = "Eliminar Alumno";
            this.bBorrarAlumno.UseVisualStyleBackColor = true;
            this.bBorrarAlumno.Click += new System.EventHandler(this.bBorrarAlumno_Click);
            // 
            // bListaAlumno
            // 
            this.bListaAlumno.Location = new System.Drawing.Point(421, 29);
            this.bListaAlumno.Name = "bListaAlumno";
            this.bListaAlumno.Size = new System.Drawing.Size(146, 49);
            this.bListaAlumno.TabIndex = 2;
            this.bListaAlumno.Text = "Mostrar Lista Alumno";
            this.bListaAlumno.UseVisualStyleBackColor = true;
            this.bListaAlumno.Click += new System.EventHandler(this.bListaAlumno_Click);
            // 
            // bOrdenAlfabetico
            // 
            this.bOrdenAlfabetico.Location = new System.Drawing.Point(22, 84);
            this.bOrdenAlfabetico.Name = "bOrdenAlfabetico";
            this.bOrdenAlfabetico.Size = new System.Drawing.Size(293, 39);
            this.bOrdenAlfabetico.TabIndex = 3;
            this.bOrdenAlfabetico.Text = "Ordenar Alumnos por Orden Alfabetico";
            this.bOrdenAlfabetico.UseVisualStyleBackColor = true;
            this.bOrdenAlfabetico.Click += new System.EventHandler(this.bOrdenAlfabetico_Click);
            // 
            // bDatosAlumno
            // 
            this.bDatosAlumno.Location = new System.Drawing.Point(332, 84);
            this.bDatosAlumno.Name = "bDatosAlumno";
            this.bDatosAlumno.Size = new System.Drawing.Size(235, 39);
            this.bDatosAlumno.TabIndex = 4;
            this.bDatosAlumno.Text = "Mostrar Datos Alumno (por nombre)";
            this.bDatosAlumno.UseVisualStyleBackColor = true;
            this.bDatosAlumno.Click += new System.EventHandler(this.bDatosAlumno_Click);
            // 
            // bAlumnosCurso
            // 
            this.bAlumnosCurso.Location = new System.Drawing.Point(172, 129);
            this.bAlumnosCurso.Name = "bAlumnosCurso";
            this.bAlumnosCurso.Size = new System.Drawing.Size(297, 30);
            this.bAlumnosCurso.TabIndex = 5;
            this.bAlumnosCurso.Text = "Mostar alumnos pertenecientes a un curso";
            this.bAlumnosCurso.UseVisualStyleBackColor = true;
            this.bAlumnosCurso.Click += new System.EventHandler(this.bAlumnosCurso_Click);
            // 
            // groupBoxAlumnos
            // 
            this.groupBoxAlumnos.Controls.Add(this.bAlumnosCurso);
            this.groupBoxAlumnos.Controls.Add(this.bDatosAlumno);
            this.groupBoxAlumnos.Controls.Add(this.bOrdenAlfabetico);
            this.groupBoxAlumnos.Controls.Add(this.bListaAlumno);
            this.groupBoxAlumnos.Controls.Add(this.bBorrarAlumno);
            this.groupBoxAlumnos.Controls.Add(this.bNEWAlumno);
            this.groupBoxAlumnos.Location = new System.Drawing.Point(52, 31);
            this.groupBoxAlumnos.Name = "groupBoxAlumnos";
            this.groupBoxAlumnos.Size = new System.Drawing.Size(593, 182);
            this.groupBoxAlumnos.TabIndex = 6;
            this.groupBoxAlumnos.TabStop = false;
            this.groupBoxAlumnos.Text = "Alumnos";
            // 
            // bNEWNotas
            // 
            this.bNEWNotas.Location = new System.Drawing.Point(22, 34);
            this.bNEWNotas.Name = "bNEWNotas";
            this.bNEWNotas.Size = new System.Drawing.Size(182, 34);
            this.bNEWNotas.TabIndex = 7;
            this.bNEWNotas.Text = "Añadir notas al Alumno";
            this.bNEWNotas.UseVisualStyleBackColor = true;
            this.bNEWNotas.Click += new System.EventHandler(this.bNEWNotas_Click);
            // 
            // bAprobados
            // 
            this.bAprobados.Location = new System.Drawing.Point(210, 34);
            this.bAprobados.Name = "bAprobados";
            this.bAprobados.Size = new System.Drawing.Size(357, 34);
            this.bAprobados.TabIndex = 8;
            this.bAprobados.Text = "Mostrar alumnos con la nota media mayor o igual a 5";
            this.bAprobados.UseVisualStyleBackColor = true;
            this.bAprobados.Click += new System.EventHandler(this.bAprobados_Click);
            // 
            // bBorrarNota
            // 
            this.bBorrarNota.Location = new System.Drawing.Point(22, 74);
            this.bBorrarNota.Name = "bBorrarNota";
            this.bBorrarNota.Size = new System.Drawing.Size(212, 32);
            this.bBorrarNota.TabIndex = 9;
            this.bBorrarNota.Text = "Eliminar las notas de un alumno";
            this.bBorrarNota.UseVisualStyleBackColor = true;
            this.bBorrarNota.Click += new System.EventHandler(this.bBorrarNota_Click);
            // 
            // bSuspendidos
            // 
            this.bSuspendidos.Location = new System.Drawing.Point(240, 74);
            this.bSuspendidos.Name = "bSuspendidos";
            this.bSuspendidos.Size = new System.Drawing.Size(327, 32);
            this.bSuspendidos.TabIndex = 10;
            this.bSuspendidos.Text = "Mostrar alumnos con nota media menor a 5";
            this.bSuspendidos.UseVisualStyleBackColor = true;
            this.bSuspendidos.Click += new System.EventHandler(this.bSuspendidos_Click);
            // 
            // groupBoxNotas
            // 
            this.groupBoxNotas.Controls.Add(this.bSuspendidos);
            this.groupBoxNotas.Controls.Add(this.bBorrarNota);
            this.groupBoxNotas.Controls.Add(this.bAprobados);
            this.groupBoxNotas.Controls.Add(this.bNEWNotas);
            this.groupBoxNotas.Location = new System.Drawing.Point(52, 246);
            this.groupBoxNotas.Name = "groupBoxNotas";
            this.groupBoxNotas.Size = new System.Drawing.Size(592, 131);
            this.groupBoxNotas.TabIndex = 11;
            this.groupBoxNotas.TabStop = false;
            this.groupBoxNotas.Text = "Notas";
            // 
            // fAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 428);
            this.Controls.Add(this.groupBoxNotas);
            this.Controls.Add(this.groupBoxAlumnos);
            this.Name = "fAlumnos";
            this.Text = "Gestion de Alumnos";
            this.Load += new System.EventHandler(this.fAlumnos_Load);
            this.groupBoxAlumnos.ResumeLayout(false);
            this.groupBoxNotas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bNEWAlumno;
        private System.Windows.Forms.Button bBorrarAlumno;
        private System.Windows.Forms.Button bListaAlumno;
        private System.Windows.Forms.Button bOrdenAlfabetico;
        private System.Windows.Forms.Button bDatosAlumno;
        private System.Windows.Forms.Button bAlumnosCurso;
        private System.Windows.Forms.GroupBox groupBoxAlumnos;
        private System.Windows.Forms.Button bNEWNotas;
        private System.Windows.Forms.Button bAprobados;
        private System.Windows.Forms.Button bBorrarNota;
        private System.Windows.Forms.Button bSuspendidos;
        private System.Windows.Forms.GroupBox groupBoxNotas;
    }
}