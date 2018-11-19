using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioFicherosEscuela
{
	public partial class Form5 : Form
	{

		Alumnos [] alumno = new Alumnos[100];

		public Form5()
		{
			InitializeComponent();
		}

		private void Form5_Load(object sender, EventArgs e)
		{
			int con = 0;
			StreamReader fichero;
			string linea;
			fichero = File.OpenText("Alumnos.txt");			string[] palabras;			while ((linea = fichero.ReadLine()) != null)
			{
				
				if(linea != "")
				{
					palabras = linea.Split('|');
					alumno[con] = new Alumnos();
					alumno[con].Dni = palabras[0];
					alumno[con].Nombre = palabras[1];
					alumno[con].Fecha = palabras[2];
					alumno[con].Direccion = palabras[3];
					alumno[con].Telefono = Convert.ToInt32(palabras[4]);

					cbDniAlumno.Items.Add(alumno[con].Dni);
					con++;
				}
			}

		}

		private void cbDniAlumno_SelectedIndexChanged(object sender, EventArgs e)
		{
			int pos = cbDniAlumno.Items.IndexOf(cbDniAlumno.SelectedItem);
			
			txtNombreAlumno.Text = alumno[pos].Nombre;
			txtFechaNacimientoAlumno.Text = alumno[pos].Fecha;
			txtDireccionAlumno.Text = alumno[pos].Direccion;
			txtTelefonoAlumno.Text = Convert.ToString(alumno[pos].Telefono);
		}
	}
}
