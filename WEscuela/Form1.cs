using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WEscuela
{/// <summary>
/// Mateo_Becerra, Samuel_Galvis, Alejandro_Ramírez
/// 21/03/2023
/// Trabajo que muestra un mensaje donde si es profesor aparece el nombre y el sueldo, si es estudiante aparece el nombre y la calificacion.
/// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

      
                
        private void BtnMostrar_Click(object sender, EventArgs e)
        {


            //Traigo la clase
            ClsPersona Persona;
            Persona = new ClsPersona();

            //Excepciones 
            try
            {
                //Condiconal si elije estudiante o profesor
                if (RadEstudiante.Checked == true)
                {

                    //Traigo la clase
                    ClsEstudiante Estudiante;
                    Estudiante = new ClsEstudiante();

                    //Lo del formulario a las variables de las clases

                    Estudiante.StrNombre = TxtNombre.Text;
                    Estudiante.IntCalificacion = Convert.ToInt16(TxtCalificacion.Text);

                    //Mensaje
                    MessageBox.Show("Nombre: " + Estudiante.StrNombre + "\nCalificacion: " + Estudiante.TraerCalificacion(Estudiante.IntCalificacion)+"\n" + Estudiante.TraerNombre(Estudiante.StrNombre) + " asiste a la escuela..." + "\n"+ Estudiante.TraerNombre(Estudiante.StrNombre) + " esta estudiando...");
                }
                else if (RadProfesor.Checked == true)
                {

                    //Traigo la clase
                    ClsProfesor Profesor;
                    Profesor = new ClsProfesor();


                    //Lo del formulario a las variables de las clases
                    Profesor.StrNombre = TxtNombre.Text;
                    Profesor.DlbSueldo = Convert.ToDouble(TxtSueldo.Text);

                    //Mensaje
                    MessageBox.Show("Nombre: " + Profesor.StrNombre + "\nSueldo: " + Profesor.TraerSueldo(Profesor.DlbSueldo) + "\n" + Profesor.TraerNombre(Profesor.StrNombre) + " asiste a la escuela..." + "\n" + Profesor.TraerNombre(Profesor.StrNombre) + " esta enseñando...");

                }

            }
            catch (Exception)
            {

                //Excepcion estudiante 
                if (RadEstudiante.Checked == true)
                { MessageBox.Show("Solo digite numeros enteros en este campo"); }
                //Excepcion estudiante 
                else if (RadProfesor.Checked == true)
                { MessageBox.Show("Solo digite numeros en este campo"); }
            }
        }


        //Limpiar
        private void BtnCapturar_Click(object sender, EventArgs e)
        {
            TxtNombre.Clear();
            TxtCalificacion.Clear();
            TxtSueldo.Clear();
           
        }


        //Deshabilitar y habilitar los controles
        private void RadEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            TxtSueldo.Enabled = false;
            TxtCalificacion.Enabled = true;

        }

        //Deshabilitar y habilitar los controles
        private void RadProfesor_CheckedChanged(object sender, EventArgs e)
        {
            TxtCalificacion.Enabled = false;
            TxtSueldo.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
