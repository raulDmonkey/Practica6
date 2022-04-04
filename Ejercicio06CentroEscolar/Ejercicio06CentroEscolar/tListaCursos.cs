using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio06CentroEscolar
{
    public class tListaCursos
    {
        private List<tCurso> colegio;
        private List<tAlumno> Lista;
        public tListaCursos()
        {
            colegio = new List<tCurso>();
            
        }
        public bool anyadirCurso(string nombre, string codigo)
        {
            bool creado = false;

            int pos = buscarCurso(codigo);

            if (pos == -1)
            {
                tCurso curso = new tCurso();
                curso.Nombre = nombre;
                curso.Codigo = codigo;

                // Añadimos el objeto recién creado a la lista.
                colegio.Add(curso);
                creado = true;
            }
            return creado;
        }

        public string mostrarListaCursos()
        {
            string texto = "No hay cursos";

            if (colegio.Count() > 0)
            {
                texto = "Lista de Cursos:\n";

                foreach (tCurso curso in colegio)
                {
                    texto += curso.mostrarDatos() + "\n";
                }
            }

            return texto;
        }
        public bool eliminarCurso(string codigo)
        {
            bool eliminado = false;
            int pos = buscarCurso(codigo);

            if(pos != -1)
            {
                colegio.RemoveAt(pos);
                eliminado = true;
            }

            return eliminado;
        }
        private int buscarCurso(string codigo)
        {
            int pos = -1;
            bool encontrado = false;
            tCurso curso;

            int i = 0;
            while (i < colegio.Count() && !encontrado)
            {
                curso = colegio[i];
                if (curso.Codigo == codigo)
                {
                    pos = i;
                    encontrado = true;
                }
                else
                    i++;
            }

            return pos;
        }
        public string mostrarAlumnos(string codigo)
        {
            string texto = "";

            int pos = buscarCurso(codigo);

            if (pos < 0)

                texto = "El curso no existe";

            else
            {
                if (Lista.Count() > 0) //Que existan alumnos 
                {
                    string datos = "";   //me acabo de cargar el crear alumnos asi que no se si esta bien esto

                    foreach (tAlumno alumno in Lista)
                    {
                        if (alumno.Curso == codigo) 

                            datos += alumno.mostrarDatos() + "\n";
                    }

                    

                }
            }

            return texto;
        }
    }
}
