using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio06CentroEscolar
{
    public partial class fInicial : Form
    {
        public fInicial()
        {
            InitializeComponent();
        }

        // Creamos la lista de cursos.
        tListaCursos listaCursos = new tListaCursos();
        // Crear aquí también la lista de profesores y de alumnos.
        tListaAlumnos listaAlumnos = new tListaAlumnos();
        tListaProfesores listaProfesores = new tListaProfesores();

        private void bCursos_Click(object sender, EventArgs e)
        {
            fCurso fCur = new fCurso();

            // Aquí le pasamos la lista de cursos para poder utilizarla luego en el formulario de cursos.
            fCur.colegio = listaCursos;
            fCur.Lista = listaAlumnos;

            fCur.ShowDialog();

        }

        private void bAlumnos_Click(object sender, EventArgs e)
        {
            fAlumnos fAlum = new fAlumnos();
            fAlum.Lista = listaAlumnos;
            fAlum.ShowDialog();
        }

        private void bProfesores_Click(object sender, EventArgs e)
        {
            fProfesores fProfe = new fProfesores();
            fProfe.Profes = listaProfesores;

            fProfe.ShowDialog();
        }
    }
}
