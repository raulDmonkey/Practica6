using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06CentroEscolar
{
    public class tListaProfesores
    {
        private List<tProfesores> Profes;

        public tListaProfesores()
        {
            Profes = new List<tProfesores>();
        }
        public bool nuevoProfesor(string nombre, string dni, string telefono)
        {
            bool creado = false;

            int pos = existe(dni);

            if (pos == -1)
            {
                tProfesores profe = new tProfesores();
                profe.Nombre = nombre;
                profe.DNI = dni;
                profe.Telefono = telefono;

                string pregunta = "";
                do
                {
                    pregunta = Interaction.InputBox("¿Es tutor? SI o NO");

                    if(pregunta == "SI")
                    {
                        profe.Tutor = true;

                        profe.CODtutor = Interaction.InputBox("Codigo de la clase: ");
                    }

                } while (pregunta != "NO" && pregunta != "SI");

                
                Profes.Add(profe);
                creado = true;
            }

            return creado;
        }
        public bool borrarProfesor(string nombre)
        {
            bool borrado = false;

            int pos = buscarProfesor(nombre);

            if (pos != -1)
            {
                Profes.RemoveAt(pos);
                borrado = true;
            }

            return borrado;
        }
        public string mostrarLista()
        {
            string texto = "No hay profesores";

            if (Profes.Count > 0)
            {
                texto = "Lista de Profesores:\n";

                foreach (tProfesores curso in Profes)
                {
                    texto += curso.mostrarDatos() + "\n";
                }
            }

            return texto;
        }
        public void ordenarAlfabeticamente()
        {
            tProfesores aux;
            for (int i = 0; i < Profes.Count() - 1; i++)
                for (int j = i + 1; j < Profes.Count(); j++)
                    if (Profes[i].Nombre.CompareTo(Profes[j].Nombre) > 0)
                    {
                        aux = Profes[i];
                        Profes[i] = Profes[j];
                        Profes[j] = aux;
                    }
        }
        public string mostrarDatos(string nombre)
        {
            string datos = "El profesor no existe";
            int pos = buscarProfesor(nombre);
            if (pos != -1)
            {
                datos = Profes[pos].mostrarDatos();
            }

            return datos;
        }
        public bool anyadirAsignatura(string nombre, string asignatura)
        {
            int pos;
            tProfesores profe;
            bool encontrado = false;

            pos = buscarProfesor(nombre);
            if (pos >= 0)
            {
                profe = Profes[pos];
                profe.anyadirAsignatura(asignatura);
                encontrado = true;
            }

            return encontrado;
        }
        public bool borrarAsignaturas(string nombre)
        {
            bool borradas = false;
            int pos = buscarProfesor(nombre);

            if (pos != -1)
            {
                Profes[pos].eliminarAsignaturas();
                borradas = true;
            }

            return borradas;
        }
        public string mostrarImparten (string nombre)
        {
            string lista = "No hay profesor asignado";

            if (Profes.Count() > 0)
            {
                tProfesores profe;
                string datos = "Lista: \n\n";
                int i = 0;
                while (i < Profes.Count())
                {   
                    profe = Profes[i];
                    if (profe.imparte(nombre))
                        datos += profe.Nombre + "\n";    

                        i++;
                }

                lista = datos;
            }


            return lista;
        }
        private int buscarProfesor(string nombre)
        {
            int pos = -1;
            bool encontrado = false;
            tProfesores profe;

            int i = 0;
            while (i < Profes.Count() && !encontrado)
            {
                profe = Profes[i];
                if (profe.Nombre == nombre)
                {
                    pos = i;
                    encontrado = true;
                }
                else
                    i++;
            }

            return pos;
        }
        private int existe(string dni)
        {
            int pos = -1;
            bool encontrado = false;
            tProfesores profe;

            int i = 0;
            while (i < Profes.Count() && !encontrado)
            {
                profe = Profes[i];
                if (profe.DNI == dni)
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
