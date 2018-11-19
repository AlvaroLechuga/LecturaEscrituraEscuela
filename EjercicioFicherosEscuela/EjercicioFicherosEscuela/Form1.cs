﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioFicherosEscuela
{
	public partial class Escuela : Form
	{
		public Escuela()
		{
			InitializeComponent();
		}

		private void tAdministrarAlumno_Click(object sender, EventArgs e)
		{
			
			Form2 form2 = new Form2();
			form2.ShowDialog();
		}

		private void tAdministrarProfesor_Click(object sender, EventArgs e)
		{
			Form3 form3 = new Form3();
			form3.ShowDialog();
		}

		private void tAdministrarAsignatura_Click(object sender, EventArgs e)
		{
			Form4 form4 = new Form4();
			form4.ShowDialog();
		}

		private void tDatosAlumno_Click(object sender, EventArgs e)
		{
			Form5 form5 = new Form5();
			form5.ShowDialog();
		}

		private void tDatosProfesor_Click(object sender, EventArgs e)
		{
			Form6 form6 = new Form6();
			form6.ShowDialog();
		}

		private void tDatosAsignatura_Click(object sender, EventArgs e)
		{
			Form7 form7 = new Form7();
			form7.ShowDialog();
		}
	}
}
