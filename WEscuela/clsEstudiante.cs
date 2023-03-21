using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEscuela
{
    public class clsEstudiante : clsPersona
    {   //Declarar variables
        private int _intCalificacion;

        //Constructor
        public clsEstudiante()
        {
            IntCalificacion = 0;
        }

        //Encapsulamiento
        public int IntCalificacion { get => _intCalificacion; set => _intCalificacion = value; }
        //Metodo
        public int calificacion(int calificacion)
        {
            return calificacion;
        }
    }
}
