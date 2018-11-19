namespace EjercicioFicherosEscuela
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.txtTelefonoAlumno = new System.Windows.Forms.TextBox();
			this.txtDireccionAlumno = new System.Windows.Forms.TextBox();
			this.txtNombreAlumno = new System.Windows.Forms.TextBox();
			this.txtDNIAlumno = new System.Windows.Forms.TextBox();
			this.btnLimpiarAlumno = new System.Windows.Forms.Button();
			this.btnGuardarAlumno = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtFechaNacimientoAlumno = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtTelefonoAlumno
			// 
			this.txtTelefonoAlumno.Location = new System.Drawing.Point(129, 257);
			this.txtTelefonoAlumno.Name = "txtTelefonoAlumno";
			this.txtTelefonoAlumno.Size = new System.Drawing.Size(198, 20);
			this.txtTelefonoAlumno.TabIndex = 23;
			// 
			// txtDireccionAlumno
			// 
			this.txtDireccionAlumno.Location = new System.Drawing.Point(129, 215);
			this.txtDireccionAlumno.Name = "txtDireccionAlumno";
			this.txtDireccionAlumno.Size = new System.Drawing.Size(251, 20);
			this.txtDireccionAlumno.TabIndex = 22;
			// 
			// txtNombreAlumno
			// 
			this.txtNombreAlumno.Location = new System.Drawing.Point(129, 136);
			this.txtNombreAlumno.Name = "txtNombreAlumno";
			this.txtNombreAlumno.Size = new System.Drawing.Size(251, 20);
			this.txtNombreAlumno.TabIndex = 21;
			// 
			// txtDNIAlumno
			// 
			this.txtDNIAlumno.Location = new System.Drawing.Point(129, 97);
			this.txtDNIAlumno.Name = "txtDNIAlumno";
			this.txtDNIAlumno.Size = new System.Drawing.Size(198, 20);
			this.txtDNIAlumno.TabIndex = 20;
			// 
			// btnLimpiarAlumno
			// 
			this.btnLimpiarAlumno.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiarAlumno.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarAlumno.Image")));
			this.btnLimpiarAlumno.Location = new System.Drawing.Point(394, 318);
			this.btnLimpiarAlumno.Name = "btnLimpiarAlumno";
			this.btnLimpiarAlumno.Size = new System.Drawing.Size(114, 34);
			this.btnLimpiarAlumno.TabIndex = 19;
			this.btnLimpiarAlumno.Text = "Limpiar";
			this.btnLimpiarAlumno.UseVisualStyleBackColor = true;
			this.btnLimpiarAlumno.Click += new System.EventHandler(this.btnLimpiarAlumno_Click);
			// 
			// btnGuardarAlumno
			// 
			this.btnGuardarAlumno.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardarAlumno.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarAlumno.Image")));
			this.btnGuardarAlumno.Location = new System.Drawing.Point(-1, 318);
			this.btnGuardarAlumno.Name = "btnGuardarAlumno";
			this.btnGuardarAlumno.Size = new System.Drawing.Size(114, 34);
			this.btnGuardarAlumno.TabIndex = 18;
			this.btnGuardarAlumno.Text = "GUARDAR";
			this.btnGuardarAlumno.UseVisualStyleBackColor = true;
			this.btnGuardarAlumno.Click += new System.EventHandler(this.btnGuardarAlumno_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(123, 4);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(230, 36);
			this.label6.TabIndex = 17;
			this.label6.Text = "Matricular Alumno";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(42, 257);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 18);
			this.label5.TabIndex = 16;
			this.label5.Text = "Telefono";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(42, 215);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 18);
			this.label4.TabIndex = 15;
			this.label4.Text = "Direccion";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(42, 175);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(142, 18);
			this.label3.TabIndex = 14;
			this.label3.Text = "Fecha de nacimiento";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(42, 136);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 18);
			this.label2.TabIndex = 13;
			this.label2.Text = "Nombre";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(42, 95);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 18);
			this.label1.TabIndex = 12;
			this.label1.Text = "DNI";
			// 
			// txtFechaNacimientoAlumno
			// 
			this.txtFechaNacimientoAlumno.Location = new System.Drawing.Point(190, 175);
			this.txtFechaNacimientoAlumno.Name = "txtFechaNacimientoAlumno";
			this.txtFechaNacimientoAlumno.Size = new System.Drawing.Size(206, 20);
			this.txtFechaNacimientoAlumno.TabIndex = 24;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(507, 350);
			this.Controls.Add(this.txtFechaNacimientoAlumno);
			this.Controls.Add(this.txtTelefonoAlumno);
			this.Controls.Add(this.txtDireccionAlumno);
			this.Controls.Add(this.txtNombreAlumno);
			this.Controls.Add(this.txtDNIAlumno);
			this.Controls.Add(this.btnLimpiarAlumno);
			this.Controls.Add(this.btnGuardarAlumno);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form2";
			this.Text = "Administrar Alumno";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtTelefonoAlumno;
		private System.Windows.Forms.TextBox txtDireccionAlumno;
		private System.Windows.Forms.TextBox txtNombreAlumno;
		private System.Windows.Forms.TextBox txtDNIAlumno;
		private System.Windows.Forms.Button btnLimpiarAlumno;
		private System.Windows.Forms.Button btnGuardarAlumno;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtFechaNacimientoAlumno;
	}
}