using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06CentroEscolar
{
    class tProfesores
    {
        private string nombre;
        private string dni;
        private string telefono;
        private List<string> asignaturas;
        private bool tutor;
        private string codTutor;

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
        public bool Tutor
        {
            get { return tutor; }
            set { tutor = true; }
        }
        public string CODtutor
        {
            get { return codTutor; }
            set
            { 
                if(tutor)

                    codTutor = value;
            }
        }
        public bool imparte(string nombre)
        {
            bool imparte = false;

            for(int i = 0;i < asignaturas.Count() && !imparte; i++)
            {
                if (nombre == asignaturas[i])
                {
                    imparte = true;
                }
            }

            return imparte;
        }
        public tProfesores()
        {
            nombre = "";
            dni = "";
            telefono = "";
            asignaturas = new List<string>();
            tutor = false;
            codTutor = "";
        }

        public void anyadirAsignatura (string asignatura)
        {

                asignaturas.Add(asignatura);
        }
        public string mostrarDatos()
        {
            string texto;

            texto = "Datos del Profesor:\n";
            texto += "Nombre: " + nombre + "\n";
            texto += "DNI: " + dni + "\n";
            texto += "Telefono: " + telefono + "\n";
            if (asignaturas.Count() > 0)
            {
                texto += "Asignaturas: \n";
                foreach (string asignatura in asignaturas)
                {
                    texto += asignatura + "\n";
                }
            }
            texto += "Tutor del curso: " + codTutor + "\n";

            return texto;
        }
        public void eliminarAsignaturas()
        {
            asignaturas.Clear();
        }
    }
}
