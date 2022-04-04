
namespace Ejercicio06CentroEscolar
{
    partial class fProfesores
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
            this.bNEWProfesor = new System.Windows.Forms.Button();
            this.bBorrarProfesor = new System.Windows.Forms.Button();
            this.bListaProfes = new System.Windows.Forms.Button();
            this.bOrdenar = new System.Windows.Forms.Button();
            this.bDatosProfes = new System.Windows.Forms.Button();
            this.bMostrarImparten = new System.Windows.Forms.Button();
            this.groupBoxProfes = new System.Windows.Forms.GroupBox();
            this.bAgregarAsignatura = new System.Windows.Forms.Button();
            this.bEliminarAsignaturas = new System.Windows.Forms.Button();
            this.groupBoxAsignaturas = new System.Windows.Forms.GroupBox();
            this.groupBoxProfes.SuspendLayout();
            this.groupBoxAsignaturas.SuspendLayout();
            this.SuspendLayout();
            // 
            // bNEWProfesor
            // 
            this.bNEWProfesor.Location = new System.Drawing.Point(21, 18);
            this.bNEWProfesor.Name = "bNEWProfesor";
            this.bNEWProfesor.Size = new System.Drawing.Size(100, 35);
            this.bNEWProfesor.TabIndex = 0;
            this.bNEWProfesor.Text = "Introducir Profesor";
            this.bNEWProfesor.UseVisualStyleBackColor = true;
            this.bNEWProfesor.Click += new System.EventHandler(this.bNEWProfesor_Click);
            // 
            // bBorrarProfesor
            // 
            this.bBorrarProfesor.Location = new System.Drawing.Point(145, 17);
            this.bBorrarProfesor.Name = "bBorrarProfesor";
            this.bBorrarProfesor.Size = new System.Drawing.Size(99, 36);
            this.bBorrarProfesor.TabIndex = 1;
            this.bBorrarProfesor.Text = "Eliminar Profesor";
            this.bBorrarProfesor.UseVisualStyleBackColor = true;
            this.bBorrarProfesor.Click += new System.EventHandler(this.bBorrarProfesor_Click);
            // 
            // bListaProfes
            // 
            this.bListaProfes.Location = new System.Drawing.Point(279, 18);
            this.bListaProfes.Name = "bListaProfes";
            this.bListaProfes.Size = new System.Drawing.Size(92, 35);
            this.bListaProfes.TabIndex = 2;
            this.bListaProfes.Text = "Mostrar Lista Profesores";
            this.bListaProfes.UseVisualStyleBackColor = true;
            this.bListaProfes.Click += new System.EventHandler(this.bListaProfes_Click);
            // 
            // bOrdenar
            // 
            this.bOrdenar.Location = new System.Drawing.Point(20, 74);
            this.bOrdenar.Name = "bOrdenar";
            this.bOrdenar.Size = new System.Drawing.Size(151, 37);
            this.bOrdenar.TabIndex = 3;
            this.bOrdenar.Text = "Ordenar Profesores por Orden Alfabetico";
            this.bOrdenar.UseVisualStyleBackColor = true;
            this.bOrdenar.Click += new System.EventHandler(this.bOrdenar_Click);
            // 
            // bDatosProfes
            // 
            this.bDatosProfes.Location = new System.Drawing.Point(216, 73);
            this.bDatosProfes.Name = "bDatosProfes";
            this.bDatosProfes.Size = new System.Drawing.Size(155, 38);
            this.bDatosProfes.TabIndex = 4;
            this.bDatosProfes.Text = "Mostrar Datos Profesores";
            this.bDatosProfes.UseVisualStyleBackColor = true;
            this.bDatosProfes.Click += new System.EventHandler(this.bDatosProfes_Click);
            // 
            // bMostrarImparten
            // 
            this.bMostrarImparten.Location = new System.Drawing.Point(67, 137);
            this.bMostrarImparten.Name = "bMostrarImparten";
            this.bMostrarImparten.Size = new System.Drawing.Size(269, 40);
            this.bMostrarImparten.TabIndex = 7;
            this.bMostrarImparten.Text = "Mostrar profesores que imparten una asignatura";
            this.bMostrarImparten.UseVisualStyleBackColor = true;
            this.bMostrarImparten.Click += new System.EventHandler(this.bMostrarImparten_Click);
            // 
            // groupBoxProfes
            // 
            this.groupBoxProfes.Controls.Add(this.bDatosProfes);
            this.groupBoxProfes.Controls.Add(this.bOrdenar);
            this.groupBoxProfes.Controls.Add(this.bListaProfes);
            this.groupBoxProfes.Controls.Add(this.bBorrarProfesor);
            this.groupBoxProfes.Controls.Add(this.bNEWProfesor);
            this.groupBoxProfes.Location = new System.Drawing.Point(45, 36);
            this.groupBoxProfes.Name = "groupBoxProfes";
            this.groupBoxProfes.Size = new System.Drawing.Size(398, 128);
            this.groupBoxProfes.TabIndex = 8;
            this.groupBoxProfes.TabStop = false;
            this.groupBoxProfes.Text = "Profesores";
            // 
            // bAgregarAsignatura
            // 
            this.bAgregarAsignatura.Location = new System.Drawing.Point(67, 31);
            this.bAgregarAsignatura.Name = "bAgregarAsignatura";
            this.bAgregarAsignatura.Size = new System.Drawing.Size(269, 35);
            this.bAgregarAsignatura.TabIndex = 5;
            this.bAgregarAsignatura.Text = "Agregar Asignatura a Profesor";
            this.bAgregarAsignatura.UseVisualStyleBackColor = true;
            this.bAgregarAsignatura.Click += new System.EventHandler(this.bAgregarAsignatura_Click);
            // 
            // bEliminarAsignaturas
            // 
            this.bEliminarAsignaturas.Location = new System.Drawing.Point(67, 82);
            this.bEliminarAsignaturas.Name = "bEliminarAsignaturas";
            this.bEliminarAsignaturas.Size = new System.Drawing.Size(269, 38);
            this.bEliminarAsignaturas.TabIndex = 6;
            this.bEliminarAsignaturas.Text = "Eliminar las asignaturas de un profesor";
            this.bEliminarAsignaturas.UseVisualStyleBackColor = true;
            this.bEliminarAsignaturas.Click += new System.EventHandler(this.bEliminarAsignaturas_Click);
            // 
            // groupBoxAsignaturas
            // 
            this.groupBoxAsignaturas.Controls.Add(this.bMostrarImparten);
            this.groupBoxAsignaturas.Controls.Add(this.bEliminarAsignaturas);
            this.groupBoxAsignaturas.Controls.Add(this.bAgregarAsignatura);
            this.groupBoxAsignaturas.Location = new System.Drawing.Point(45, 192);
            this.groupBoxAsignaturas.Name = "groupBoxAsignaturas";
            this.groupBoxAsignaturas.Size = new System.Drawing.Size(397, 201);
            this.groupBoxAsignaturas.TabIndex = 9;
            this.groupBoxAsignaturas.TabStop = false;
            this.groupBoxAsignaturas.Text = "Asignaturas";
            // 
            // Profesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 423);
            this.Controls.Add(this.groupBoxAsignaturas);
            this.Controls.Add(this.groupBoxProfes);
            this.Name = "Profesores";
            this.Text = "Profesores";
            this.groupBoxProfes.ResumeLayout(false);
            this.groupBoxAsignaturas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bNEWProfesor;
        private System.Windows.Forms.Button bBorrarProfesor;
        private System.Windows.Forms.Button bListaProfes;
        private System.Windows.Forms.Button bOrdenar;
        private System.Windows.Forms.Button bDatosProfes;
        private System.Windows.Forms.Button bMostrarImparten;
        private System.Windows.Forms.GroupBox groupBoxProfes;
        private System.Windows.Forms.Button bAgregarAsignatura;
        private System.Windows.Forms.Button bEliminarAsignaturas;
        private System.Windows.Forms.GroupBox groupBoxAsignaturas;
    }
}