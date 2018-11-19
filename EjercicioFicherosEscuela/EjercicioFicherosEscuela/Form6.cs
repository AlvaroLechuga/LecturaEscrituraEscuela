using System;
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
	public partial class Form6 : Form
	{
		Profesores[] profesores = new Profesores[100];

		public Form6()
		{
			InitializeComponent();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			int pos = cbDniProfesores.Items.IndexOf(cbDniProfesores.SelectedItem);
			txtNombreProfesor.Text = profesores[pos].Nombre;
			txtDireccionProfesor.Text = profesores[pos].Direccion;
			txtTelefonoProfesor.Text = Convert.ToString(profesores[pos].Telefono);
			txtEstudiosProfesor.Text = profesores[pos].Estudios;

		}

		private void Form6_Load(object sender, EventArgs e)
		{
			StreamReader fichero;
			string linea = "";
			int con = 0;
			string[] palabras;			fichero = File.OpenText("Profesores.txt");

			while ((linea = fichero.ReadLine()) != null)
			{
				if(linea != "")
				{
					palabras = linea.Split('|');
					profesores[con] = new Profesores();
					profesores[con].Dni = palabras[0];
					profesores[con].Nombre = palabras[1];
					profesores[con].Direccion = palabras[2];
					profesores[con].Telefono = Convert.ToInt32(palabras[3]);
					profesores[con].Estudios = palabras[4];

					cbDniProfesores.Items.Add(profesores[con].Dni);
					con++;
				}

			}

		}
	}
}

