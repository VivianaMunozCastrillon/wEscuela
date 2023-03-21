using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEscuela
{
    public class clsProfesor : clsPersona
    {
        //Declaracion de variables
        private double _dlbSueldo;
       
        //Constructor
        public clsProfesor()
        {
            _dlbSueldo = 0.0;
        }

  




        //Encapsulamiento
        public double DlbSueldo { get => _dlbSueldo; set => _dlbSueldo = value; }
        //Metodo 
        public double sueldo(double sueldo)
        {
            return sueldo;
        }
    }
}
