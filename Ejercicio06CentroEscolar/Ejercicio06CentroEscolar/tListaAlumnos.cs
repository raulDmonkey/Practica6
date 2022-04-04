using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06CentroEscolar
{
    public class tListaAlumnos
    {
        private List<tAlumno> Lista;
        private List<tCurso> colegio;

        public tListaAlumnos()
        {
            Lista = new List<tAlumno>();
        }
        public bool nuevoAlumno(string nombre, string dni,string telefono)
        {
            bool creado = false;

            int pos = existe(dni);

            if (pos == -1)
            {
                tAlumno alumno = new tAlumno();
                alumno.Nombre = nombre;
                alumno.DNI = dni;
                alumno.Telefono = telefono;
                string curso = Interaction.InputBox("Introduzca el curso.");
                /*do
                {
                    curso = Interaction.InputBox("Introduzca el curso.");

                } while (!registrado(curso));
                */
                alumno.Curso = curso;

                Lista.Add(alumno);
                creado = true;
            }

            return creado;
        }
        /*private bool registrado (string curso) // Esto es para comprobar que exista el curso en el que lo quiero matricular
        {
            bool registrado = false;
            tCurso aux;
            foreach (string aux.codigo in colegio)
            {
                if(curso == codigo)
            }

            return registrado;
        }*/
        public bool borrarAlumno(string nombre)
        {
            bool borrado = false;

            int pos = buscarAlumno(nombre);

            if (pos != -1)
            {
                Lista.RemoveAt(pos);
                borrado = true;
            }

            return borrado;
        }
        public string mostrarLista()
        {
            string texto = "No hay alumnos";

            if(Lista.Count > 0)
            {
                texto = "Lista de Alumnos:\n";

                foreach (tAlumno curso in Lista)
                {
                    texto += curso.mostrarDatos() + "\n";
                } 
            }

            return texto;
        }
        public void ordenarAlfabeticamente()
        {
            tAlumno aux;
            for (int i = 0; i < Lista.Count() - 1; i++)
                for (int j = i + 1; j < Lista.Count(); j++)
                    if (Lista[i].Nombre.CompareTo(Lista[j].Nombre) > 0)
                    {
                        aux = Lista[i];
                        Lista[i] = Lista[j];
                        Lista[j] = aux;
                    }
        }
        public string mostrarDatos(string nombre)
        {
            string datos = "El alumno no existe";
            int pos = buscarAlumno(nombre);
            if (pos != -1)
            {
                datos = Lista[pos].mostrarDatos();
            }

            return datos;
        }
        public string mostrarAlumnos(string codigo)
        {
            string texto = "No hay Alumnos"; //Comprobar si existe curso??

            if (Lista.Count() > 0)
            {
                texto = "Lista de Alumnos:\n";

                foreach (tAlumno alumno in Lista)
                {
                    if(alumno.Curso == codigo)

                        texto += alumno.mostrarDatos() + "\n";
                }
            }

            return texto;
        }
        public bool anyadirNota (string nombre, double nota)
        {
            int pos;
            tAlumno alum;
            bool encontrado = false;

            pos = buscarAlumno(nombre);
            if (pos >= 0)
            {
                alum = Lista[pos];
                alum.anyadirNota(nota);
                encontrado = true;
            }

            return encontrado;
        }
        public string mostrarAprobados(string codigo)
        {
            string texto = "No hay alumnos aprobados";

            if (Lista.Count() > 0) //Que existan alumnos
            {
                string datos = "";

                foreach (tAlumno alumno in Lista)
                {
                    if (alumno.Curso == codigo && alumno.aprobado()) //Que pertenezcan al curso y esten aprobados

                        datos += alumno.mostrarDatos() + "\n";
                }

                if (datos != "")//Si hay aprobados se cambia la respuesta por defecto
                    texto = datos;
                    
            }

            return texto;
        }
        public string mostrarSuspendidos(string codigo)
        {
            string texto = "No hay alumnos suspenmdidos";

            if (Lista.Count() > 0) //Que existan alumnos
            {
                string datos = "";

                foreach (tAlumno alumno in Lista)
                {
                    if (alumno.Curso == codigo && !alumno.aprobado()) //Que pertenezcan al curso y esten suspendidos

                        datos = alumno.mostrarDatos() + "\n";
                }

                if (datos != "")//Si hay suspendidos se cambia la respuesta por defecto
                    texto = datos;

            }

            return texto;
        }
        public bool borrarNotas (string nombre)
        {
            bool borradas = false;
            int pos = buscarAlumno(nombre);

            if (pos!= -1)
            {
                Lista[pos].eliminarNotas();
                borradas = true;
            }

            return borradas;
        }
        private int existe(string dni)
        {
            int pos = -1;
            bool encontrado = false;
            tAlumno alum;

            int i = 0;
            while (i < Lista.Count() && !encontrado)
            {
                alum = Lista[i];
                if (alum.DNI == dni)
                {
                    pos = i;
                    encontrado = true;
                }
                else
                    i++;
            }

            return pos;
        }
        private int buscarAlumno(string nombre)
        {
            int pos = -1;
            bool encontrado = false;
            tAlumno alum;

            int i = 0;
            while (i < Lista.Count() && !encontrado)
            {
                alum = Lista[i];
                if (alum.Nombre == nombre)
                {
                    pos = i;
                    encontrado = true;
                }
                else
                    i++;
            }

            return pos;
        }
        

    }
   

}
