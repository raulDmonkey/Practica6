using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio06CentroEscolar
{
    public partial class fCurso : Form
    {
        public fCurso()
        {
            InitializeComponent();
        }
        public tListaCursos colegio;
        public tListaAlumnos Lista;
        private void fCursos_Load(object sender, EventArgs e)
        {
        }
        private void bNEWCurso_Click(object sender, EventArgs e)
        {

            string nombre, codigo;

            nombre = Interaction.InputBox("Introduzca el nombre.");
            codigo = Interaction.InputBox("Introduzca el codigo.");

            if (colegio.anyadirCurso(nombre, codigo))
                MessageBox.Show("Curso creado");
            else
                MessageBox.Show("Ya existe otro curso con ese codigo");
            
        }
        private void bEliminarCurso_Click(object sender, EventArgs e) 
        {
            string codigo;

            codigo = Interaction.InputBox("Introduzca el codigo del curso: ");

            if (colegio.eliminarCurso(codigo))
            {
                MessageBox.Show("El curso no existe");
            }
            else
            {
                MessageBox.Show("Eliminación correcta");

            }
        }
        private void bMostrarCursos_Click(object sender, EventArgs e)
        {
            string texto;

            texto = colegio.mostrarListaCursos();

            MessageBox.Show(texto);
        }
        private void bMostrarAlumnos_Click(object sender, EventArgs e)
        {
            string texto;

            string codigo = Interaction.InputBox("Introduzca el codigo del curso: ");

            texto = colegio.mostrarAlumnos(codigo);

            MessageBox.Show(texto);
        }

       
    }
}
