using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEscuela
{
    //Clase padre
    public class clsPersona
    {
        //Declaracion de variables
        private string _strNombre;
        //Constructor
        public clsPersona()
        {
            _strNombre = "";
        }
        //Encapsulamiento
        public string StrNombre { get => _strNombre; set => _strNombre = value; }

        //Metodo
        public string asistir(string nombre)
        {
            return _strNombre;
        }
    }
}
