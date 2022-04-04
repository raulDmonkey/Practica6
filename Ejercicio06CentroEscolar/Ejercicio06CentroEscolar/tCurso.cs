using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06CentroEscolar
{
    class tCurso
    {
        // Declaración de miembros de la clase.
        private string mNombre;
        private string codigo;

        public string Nombre
        {
            get { return mNombre; }
            set { mNombre = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public tCurso()
        {
            mNombre = "";
            codigo = "";
        }
        public string mostrarDatos()
        {
            string texto;

            texto = "Datos del curso:\n";
            texto += "Nombre: " + mNombre + "\n";
            texto += "Codigo: " + codigo + "\n";
            
            return texto;
        }
    }
   
}
