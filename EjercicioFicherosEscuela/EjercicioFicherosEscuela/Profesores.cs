using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFicherosEscuela
{
	class Profesores
	{
		private string dni;
		private string nombre;
		private string direccion;
		private int telefono;
		private string estudios;

		public Profesores()
		{
		}

		public Profesores(string dni, string nombre, string direccion, int telefono)
		{
			this.dni = dni;
			this.nombre = nombre;
			this.direccion = direccion;
			this.telefono = telefono;
			this.estudios = estudios;
		}

		public string Dni { get => dni; set => dni = value; }
		public string Nombre { get => nombre; set => nombre = value; }
		public string Direccion { get => direccion; set => direccion = value; }
		public int Telefono { get => telefono; set => telefono = value; }
		public string Estudios { get => estudios; set => estudios = value; }
	}
}
