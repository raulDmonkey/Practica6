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
    public partial class fProfesores : Form
    {
        public fProfesores()
        {
            InitializeComponent();
        }
        public tListaProfesores Profes;
        private void fProfesores_Load(object sender, EventArgs e)
        {
        }
        private void bNEWProfesor_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Introduzca el nombre.");
            string dni = Interaction.InputBox("Introduzca el DNI.");
            string telefono = Interaction.InputBox("Introduzca el telefono.");

            bool creado = Profes.nuevoProfesor(nombre, dni, telefono);

            if (creado)
                MessageBox.Show("Nuevo profesor creado");
            else
                MessageBox.Show("Ya existe otro profesor con el mismo DNI");

        }

        private void bBorrarProfesor_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Introduzca el nombre.");

            bool eliminado = Profes.borrarProfesor(nombre);

            if (eliminado)
                MessageBox.Show("Profesor eliminado");
            else
                MessageBox.Show("No existe profesor con ese nombre");
        }

        private void bListaProfes_Click(object sender, EventArgs e)
        {
            string texto;

            texto = Profes.mostrarLista();

            MessageBox.Show(texto);
        }

        private void bOrdenar_Click(object sender, EventArgs e)
        {
            Profes.ordenarAlfabeticamente();

            MessageBox.Show("Profesores ordenados Alfabeticamente");
        }

        private void bDatosProfes_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Introduzca el nombre.");
            string datos = Profes.mostrarDatos(nombre);
            MessageBox.Show(datos);
        }

        private void bAgregarAsignatura_Click(object sender, EventArgs e)
        {
            string nombre;
            string asignatura;
            bool correcto;

            nombre = Interaction.InputBox("Introduzca el nombre.");
            asignatura = Interaction.InputBox("Introduzca la asignatura.");

            correcto = Profes.anyadirAsignatura(nombre, asignatura);
            if (correcto)
                MessageBox.Show("Se ha añadido correctamente la asignatura.");
            else
                MessageBox.Show("No se ha encontrado el profesor.");
        }

        private void bEliminarAsignaturas_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Introduzca el nombre.");

            if (Profes.borrarAsignaturas(nombre))

                MessageBox.Show("Asignaturas del profesor " + nombre + " borradas.");

            else
                MessageBox.Show("El profesor " + nombre + " no existe");
        }

        private void bMostrarImparten_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Introduzca el nombre de la asignatura.");

            string datos = Profes.mostrarImparten(nombre);
            MessageBox.Show(datos);

        }
    }
}
