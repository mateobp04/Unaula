using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEscuela
{
     public class ClsEstudiante : ClsPersona
    {
        //Definir variable
        private int _intCalificacion;

        public int IntCalificacion { get => _intCalificacion; set => _intCalificacion = value; }
        //iniciar variable
        public ClsEstudiante()
        {
            IntCalificacion = 0;
        }

        //Metodo 
        public int TraerCalificacion(int IntCalificacion)
        {
           
            return IntCalificacion;

        }

      
    }
}
