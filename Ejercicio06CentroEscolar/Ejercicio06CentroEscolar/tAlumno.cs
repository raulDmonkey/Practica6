using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06CentroEscolar
{
    class tAlumno
    {
        private string nombre;
        private string dni;
        private string telefono;
        private List<double> notas;
        private string curso;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string DNI
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }
        public tAlumno()
        {
            nombre = "";
            dni = "";
            telefono = "";
            curso = "";
            notas = new List<double>();
        }
        public void anyadirNota(double nota)
        {
            if (nota > 0)
                notas.Add(nota);
        }
        public string mostrarDatos()
        {
            string texto;

            texto = "Datos del Alumno:\n";
            texto += "Nombre: " + nombre + "\n";
            texto += "DNI: " + dni + "\n";
            texto += "Telefono: " + telefono + "\n";
            if (notas.Count() > 0)
            {
                texto += "Notas: \n";
                foreach (double nota in notas)
                {
                    texto += nota.ToString() + "\n";
                }
            }
            texto += "Codigo del curso: " + curso + "\n";

            return texto;
        }
        public bool aprobado()
        {
            bool aprobado = false;

            double suma = 0;

            if (notas.Count() > 0)
            {
                foreach (double nota in notas)
                {
                    suma += nota;
                }

                suma /= notas.Count();
            }
            if (suma >= 5)
                aprobado = true;

            return aprobado;

        }
        public void eliminarNotas()
        {
            notas.Clear();
        }
    }
}
