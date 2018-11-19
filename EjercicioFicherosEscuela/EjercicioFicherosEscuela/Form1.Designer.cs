namespace EjercicioFicherosEscuela
{
	partial class Escuela
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tAlumno = new System.Windows.Forms.ToolStripMenuItem();
			this.tAdministrarAlumno = new System.Windows.Forms.ToolStripMenuItem();
			this.tDatosAlumno = new System.Windows.Forms.ToolStripMenuItem();
			this.tProfesor = new System.Windows.Forms.ToolStripMenuItem();
			this.tAdministrarProfesor = new System.Windows.Forms.ToolStripMenuItem();
			this.tDatosProfesor = new System.Windows.Forms.ToolStripMenuItem();
			this.tAsignatura = new System.Windows.Forms.ToolStripMenuItem();
			this.tAdministrarAsignatura = new System.Windows.Forms.ToolStripMenuItem();
			this.tDatosAsignatura = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tProfesor,
            this.tAlumno,
            this.tAsignatura});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(553, 27);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tAlumno
			// 
			this.tAlumno.BackColor = System.Drawing.SystemColors.HotTrack;
			this.tAlumno.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tAdministrarAlumno,
            this.tDatosAlumno});
			this.tAlumno.Font = new System.Drawing.Font("Montserrat", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tAlumno.Name = "tAlumno";
			this.tAlumno.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.tAlumno.Size = new System.Drawing.Size(87, 23);
			this.tAlumno.Text = "Alumno";
			// 
			// tAdministrarAlumno
			// 
			this.tAdministrarAlumno.Font = new System.Drawing.Font("Montserrat", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tAdministrarAlumno.Name = "tAdministrarAlumno";
			this.tAdministrarAlumno.Size = new System.Drawing.Size(227, 22);
			this.tAdministrarAlumno.Text = "Administrar Alumno";
			this.tAdministrarAlumno.Click += new System.EventHandler(this.tAdministrarAlumno_Click);
			// 
			// tDatosAlumno
			// 
			this.tDatosAlumno.Font = new System.Drawing.Font("Montserrat", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tDatosAlumno.Name = "tDatosAlumno";
			this.tDatosAlumno.Size = new System.Drawing.Size(227, 22);
			this.tDatosAlumno.Text = "Mostrar datos Alumno";
			this.tDatosAlumno.Click += new System.EventHandler(this.tDatosAlumno_Click);
			// 
			// tProfesor
			// 
			this.tProfesor.BackColor = System.Drawing.SystemColors.HotTrack;
			this.tProfesor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tAdministrarProfesor,
            this.tDatosProfesor});
			this.tProfesor.Font = new System.Drawing.Font("Montserrat", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tProfesor.Name = "tProfesor";
			this.tProfesor.Size = new System.Drawing.Size(85, 23);
			this.tProfesor.Text = "Profesor";
			// 
			// tAdministrarProfesor
			// 
			this.tAdministrarProfesor.Font = new System.Drawing.Font("Montserrat", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tAdministrarProfesor.Name = "tAdministrarProfesor";
			this.tAdministrarProfesor.Size = new System.Drawing.Size(230, 22);
			this.tAdministrarProfesor.Text = "Administrar Profesor";
			this.tAdministrarProfesor.Click += new System.EventHandler(this.tAdministrarProfesor_Click);
			// 
			// tDatosProfesor
			// 
			this.tDatosProfesor.Font = new System.Drawing.Font("Montserrat", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tDatosProfesor.Name = "tDatosProfesor";
			this.tDatosProfesor.Size = new System.Drawing.Size(230, 22);
			this.tDatosProfesor.Text = "Mostrar datos Profesor";
			this.tDatosProfesor.Click += new System.EventHandler(this.tDatosProfesor_Click);
			// 
			// tAsignatura
			// 
			this.tAsignatura.BackColor = System.Drawing.SystemColors.HotTrack;
			this.tAsignatura.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tAdministrarAsignatura,
            this.tDatosAsignatura});
			this.tAsignatura.Font = new System.Drawing.Font("Montserrat", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tAsignatura.Name = "tAsignatura";
			this.tAsignatura.Size = new System.Drawing.Size(112, 23);
			this.tAsignatura.Text = "Asignatura";
			// 
			// tAdministrarAsignatura
			// 
			this.tAdministrarAsignatura.Font = new System.Drawing.Font("Montserrat", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tAdministrarAsignatura.Name = "tAdministrarAsignatura";
			this.tAdministrarAsignatura.Size = new System.Drawing.Size(249, 22);
			this.tAdministrarAsignatura.Text = "Administrar Asignatura";
			this.tAdministrarAsignatura.Click += new System.EventHandler(this.tAdministrarAsignatura_Click);
			// 
			// tDatosAsignatura
			// 
			this.tDatosAsignatura.Font = new System.Drawing.Font("Montserrat", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tDatosAsignatura.Name = "tDatosAsignatura";
			this.tDatosAsignatura.Size = new System.Drawing.Size(249, 22);
			this.tDatosAsignatura.Text = "Mostrar datos Asignatura";
			this.tDatosAsignatura.Click += new System.EventHandler(this.tDatosAsignatura_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(61, 124);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(413, 36);
			this.label1.TabIndex = 1;
			this.label1.Text = "Administracion secretaria del centro";
			// 
			// Escuela
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(553, 257);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Escuela";
			this.Text = "Escuela";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tAlumno;
		private System.Windows.Forms.ToolStripMenuItem tProfesor;
		private System.Windows.Forms.ToolStripMenuItem tAsignatura;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripMenuItem tAdministrarAlumno;
		private System.Windows.Forms.ToolStripMenuItem tDatosAlumno;
		private System.Windows.Forms.ToolStripMenuItem tAdministrarProfesor;
		private System.Windows.Forms.ToolStripMenuItem tDatosProfesor;
		private System.Windows.Forms.ToolStripMenuItem tAdministrarAsignatura;
		private System.Windows.Forms.ToolStripMenuItem tDatosAsignatura;
	}
}

