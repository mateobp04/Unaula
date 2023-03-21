using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEscuela
{
    public class ClsProfesor : ClsPersona
    {
        //Definir variable
        private double _dlbSueldo;

        public double DlbSueldo { get => _dlbSueldo; set => _dlbSueldo = value; }

        //iniciar variable
        public ClsProfesor()
        {
            DlbSueldo = 0;
        }
        //Metodo 
        public double TraerSueldo(double DlbSueldo)
        {
            return DlbSueldo;
        }
    }
}
