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
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		private void btnLimpiarProfesor_Click(object sender, EventArgs e)
		{
			txtDNIProfesor.Text = "";
			txtNombreProfesor.Text = "";
			txtDireccionProfesor.Text = "";
			txtTelefonoProfesor.Text = "";
			txtEstudiosProfesor.Text = "";
		}

		private void btnGuardarProfesor_Click(object sender, EventArgs e)
		{
			if(txtDNIProfesor.Text.Equals("") || txtNombreProfesor.Text.Equals("") || txtDireccionProfesor.Text.Equals("") || txtTelefonoProfesor.Text.Equals("") || txtEstudiosProfesor.Text.Equals(""))
			{
				MessageBox.Show("No has completado algun campo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				int number1 = 0;
				bool canConvert = int.TryParse(txtTelefonoProfesor.Text, out number1);

				if (canConvert)
				{
					StreamWriter fichero;
					string profesor = txtDNIProfesor.Text + "|" + txtNombreProfesor.Text + "|" + txtDireccionProfesor.Text + "|" + txtTelefonoProfesor.Text + "|" + txtEstudiosProfesor.Text;

					if (File.Exists("Profesores.txt"))
					{
						try
						{
							fichero = File.AppendText("Profesores.txt");
							fichero.WriteLine(profesor);
							fichero.Close();
						}
						catch (PathTooLongException ptle)
						{
							MessageBox.Show("Nombre demasiado largo");
						}
						catch (IOException ioe)
						{
							MessageBox.Show("No se ha podido escribir");
							MessageBox.Show("Error exacto: {0}", ioe.Message);
						}
					}
					else
					{
						try
						{
							fichero = File.CreateText("Profesores.txt");
							fichero.WriteLine(profesor);
							fichero.Close();
						}
						catch (PathTooLongException ptle)
						{
							MessageBox.Show("Nombre demasiado largo");
						}
						catch (IOException ioe)
						{
							MessageBox.Show("No se ha podido escribir");
							MessageBox.Show("Error exacto: {0}", ioe.Message);
						}

					}
				}
				else
				{
					MessageBox.Show("Has introducido una letra en el telefono", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}		
	}
}
