using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WEscuela
    /// Fecha: 21-03-2023
    /// Nombres: Viviana Muñoz Castrillon, Juan Esteban Ortiz Rendon, Laura Serena
    /// Rivera Mejia
    /// Descripcion: Este programa recibe datos de Sueldo, Calificacion y Nombre de acuerdo 
    /// a un boton de radio e imprime el rol y el estado de la persona sea profesor o estudiante.
    ///
{
    public partial class frmEscuela : Form
    {
        public frmEscuela()
        {
            InitializeComponent();
        }

        

        private void btnCapturarDatos_Click(object sender, EventArgs e)
        {
            txtCalificacion.Clear();
            txtNombre.Clear();
            txtSueldo.Clear();
            radEstudiante.Checked = false;
            radProfesor.Checked = false;
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            clsProfesor persona = new clsProfesor();
            

            clsEstudiante estudiante = new clsEstudiante();

            //Bloque Try-Catch, controla errores durante la ejecucion.
            try 
            { 

            // Ciclo If
            if (radProfesor.Checked == true)
            {
                //Datos de entrada
                persona.StrNombre = txtNombre.Text;
                persona.DlbSueldo = double.Parse(txtSueldo.Text);
                //Mensaje de salida
                MessageBox.Show("Nombre:" + persona.StrNombre + "\nSueldo: " + persona.sueldo(persona.DlbSueldo) + "\n "
                    + persona.asistir(persona.StrNombre) + " asiste a la escuela " + "\n" + persona.asistir(persona.StrNombre) + " esta enseñando ","DATOS DEL PROFESOR",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
             
            else if (radEstudiante.Checked == true)
            {
                //Datos de entrada
                estudiante.StrNombre = txtNombre.Text;
                estudiante.IntCalificacion = int.Parse(txtCalificacion.Text);
                //Mensaje de salida
                MessageBox.Show("Nombre:" + estudiante.StrNombre + "\nCalificacion: " + estudiante.calificacion(estudiante.IntCalificacion) + "\n "
                    + estudiante.asistir(estudiante.StrNombre) + " asiste a la escuela " + "\n" + estudiante.asistir(estudiante.StrNombre) + " esta estudiando","DATOS DEL ESTUDIANTE",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            }
            catch (Exception)
            {

                MessageBox.Show("Digite el valor correctamente","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            


        }
        //Esta instruccion muestra o oculta textbox y labels
        private void radProfesor_CheckedChanged(object sender, EventArgs e)
        {
            txtCalificacion.Hide();
            txtSueldo.Show();
            lblCalificacion.Hide() ;
            lblSueldo.Show() ;    
        }
        //Esta instruccion muestra o oculta textbox y labels
        private void radEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            txtSueldo.Hide();
            txtCalificacion.Show();
            lblSueldo.Hide() ;
            lblCalificacion.Show() ;
        }
    }
}
