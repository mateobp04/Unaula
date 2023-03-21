using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEscuela
{

    public class ClsPersona

    
    {

        //Defininir variable
        private string _strNombre;

        public string StrNombre { get => _strNombre; set => _strNombre = value; }


        //iniciar variable
        public ClsPersona()
        {
            StrNombre = "";
        }

        //Metodo 
        public string TraerNombre(string StrNombre)
        { 
            return StrNombre;
        }



    }
}
