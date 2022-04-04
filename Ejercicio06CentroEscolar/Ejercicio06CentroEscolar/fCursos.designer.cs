
namespace Ejercicio06CentroEscolar
{
    partial class fCurso
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
            this.bNEWCurso = new System.Windows.Forms.Button();
            this.bEliminarCurso = new System.Windows.Forms.Button();
            this.bMostrarCursos = new System.Windows.Forms.Button();
            this.bMostrarAlumnos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bNEWCurso
            // 
            this.bNEWCurso.Location = new System.Drawing.Point(59, 29);
            this.bNEWCurso.Name = "bNEWCurso";
            this.bNEWCurso.Size = new System.Drawing.Size(116, 35);
            this.bNEWCurso.TabIndex = 0;
            this.bNEWCurso.Text = "Añadir Curso";
            this.bNEWCurso.UseVisualStyleBackColor = true;
            this.bNEWCurso.Click += new System.EventHandler(this.bNEWCurso_Click);
            // 
            // bEliminarCurso
            // 
            this.bEliminarCurso.Location = new System.Drawing.Point(59, 70);
            this.bEliminarCurso.Name = "bEliminarCurso";
            this.bEliminarCurso.Size = new System.Drawing.Size(116, 35);
            this.bEliminarCurso.TabIndex = 1;
            this.bEliminarCurso.Text = "Eliminar Curso";
            this.bEliminarCurso.UseVisualStyleBackColor = true;
            this.bEliminarCurso.Click += new System.EventHandler(this.bEliminarCurso_Click);
            // 
            // bMostrarCursos
            // 
            this.bMostrarCursos.Location = new System.Drawing.Point(59, 111);
            this.bMostrarCursos.Name = "bMostrarCursos";
            this.bMostrarCursos.Size = new System.Drawing.Size(116, 35);
            this.bMostrarCursos.TabIndex = 2;
            this.bMostrarCursos.Text = "Mostrar todos los cursos";
            this.bMostrarCursos.UseVisualStyleBackColor = true;
            this.bMostrarCursos.Click += new System.EventHandler(this.bMostrarCursos_Click);
            // 
            // bMostrarAlumnos
            // 
            this.bMostrarAlumnos.Location = new System.Drawing.Point(59, 152);
            this.bMostrarAlumnos.Name = "bMostrarAlumnos";
            this.bMostrarAlumnos.Size = new System.Drawing.Size(116, 71);
            this.bMostrarAlumnos.TabIndex = 3;
            this.bMostrarAlumnos.Text = "Mostrar todos los alumnos pertenecientes a un curso";
            this.bMostrarAlumnos.UseVisualStyleBackColor = true;
            this.bMostrarAlumnos.Click += new System.EventHandler(this.bMostrarAlumnos_Click);
            // 
            // fCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 255);
            this.Controls.Add(this.bMostrarAlumnos);
            this.Controls.Add(this.bMostrarCursos);
            this.Controls.Add(this.bEliminarCurso);
            this.Controls.Add(this.bNEWCurso);
            this.Name = "fCurso";
            this.Text = "Gestión de Cursos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bNEWCurso;
        private System.Windows.Forms.Button bEliminarCurso;
        private System.Windows.Forms.Button bMostrarCursos;
        private System.Windows.Forms.Button bMostrarAlumnos;
    }
}