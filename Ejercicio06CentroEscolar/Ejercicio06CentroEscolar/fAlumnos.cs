using Microsoft.VisualBasic;
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
    public partial class fAlumnos : Form
    {
        public fAlumnos()
        {
            InitializeComponent();
        }
        public tListaAlumnos Lista;
        public tListaCursos colegio;
        private void fAlumnos_Load(object sender, EventArgs e)
        {
            
        }

        private void bNEWAlumno_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Introduzca el nombre.");
            string dni = Interaction.InputBox("Introduzca el DNI.");
            string telefono = Interaction.InputBox("Introduzca el telefono.");


            bool creado = Lista.nuevoAlumno(nombre, dni, telefono);

            if (creado)
                MessageBox.Show("Nuevo alumno creado");
            else
                MessageBox.Show("Ya existe otro alumno con el mismo DNI");

        }
        private void bBorrarAlumno_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Introduzca el nombre.");

            bool eliminado = Lista.borrarAlumno(nombre);

            if (eliminado)
                MessageBox.Show("Alumno eliminado");
            else
                MessageBox.Show("No existe alumno con ese nombre");
        }
        private void bListaAlumno_Click(object sender, EventArgs e)
        {
            string texto;

            texto = Lista.mostrarLista();

            MessageBox.Show(texto);
        }
        private void bOrdenAlfabetico_Click(object sender, EventArgs e)
        {
            Lista.ordenarAlfabeticamente();

            MessageBox.Show("Alumnos ordenados Alfabeticamente");
        }
        private void bDatosAlumno_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Introduzca el nombre.");
            string datos = Lista.mostrarDatos(nombre);
            MessageBox.Show(datos);
        }
        private void bAlumnosCurso_Click(object sender, EventArgs e)
        {
            string texto;

            string codigo = Interaction.InputBox("Introduzca el codigo del curso: ");

            texto = Lista.mostrarAlumnos(codigo);

            MessageBox.Show(texto);
        }
        private void bNEWNotas_Click(object sender, EventArgs e)
        {
            string nombre;
            double nota;
            bool correcto;

            nombre = Interaction.InputBox("Introduzca el nombre.");
            nota = double.Parse(Interaction.InputBox("Introduzca la nota."));

            correcto = Lista.anyadirNota(nombre, nota);
            if (correcto)
                MessageBox.Show("Se ha añadido correctamente la nota.");
            else
                MessageBox.Show("No se ha encontrado el alumno.");
        }
        private void bAprobados_Click(object sender, EventArgs e)
        {
            string codigo = Interaction.InputBox("Introduzca el codigo del curso: ");
            string texto = Lista.mostrarAprobados(codigo);
            MessageBox.Show(texto);
        }
        private void bSuspendidos_Click(object sender, EventArgs e)
        {
            string codigo = Interaction.InputBox("Introduzca el codigo del curso: ");
            string texto = Lista.mostrarSuspendidos(codigo);
            MessageBox.Show(texto);
        }
        private void bBorrarNota_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Introduzca el nombre.");

            if (Lista.borrarNotas(nombre))

                MessageBox.Show("Notas del alumno " + nombre + " borradas.");

            else
                MessageBox.Show("El alumno " + nombre + " no existe");
        }


    }
}
