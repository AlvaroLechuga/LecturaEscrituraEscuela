namespace EjercicioFicherosEscuela
{
	partial class Form4
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
			this.label6 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtIdAsignatura = new System.Windows.Forms.TextBox();
			this.txtNombreAsignatura = new System.Windows.Forms.TextBox();
			this.txtDepartamentoAsignatura = new System.Windows.Forms.ComboBox();
			this.txtHorasAsignatura = new System.Windows.Forms.TextBox();
			this.btnLimpiarAsignatura = new System.Windows.Forms.Button();
			this.btnGuardarAsignatura = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(105, 4);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(234, 36);
			this.label6.TabIndex = 19;
			this.label6.Text = "Agregar Asignatura";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(34, 92);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 18);
			this.label1.TabIndex = 20;
			this.label1.Text = "ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(34, 133);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 18);
			this.label2.TabIndex = 21;
			this.label2.Text = "Nombre";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(34, 178);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 18);
			this.label3.TabIndex = 22;
			this.label3.Text = "Departamento";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(34, 226);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(115, 18);
			this.label4.TabIndex = 23;
			this.label4.Text = "Horas semanales";
			// 
			// txtIdAsignatura
			// 
			this.txtIdAsignatura.Location = new System.Drawing.Point(111, 92);
			this.txtIdAsignatura.Name = "txtIdAsignatura";
			this.txtIdAsignatura.Size = new System.Drawing.Size(180, 20);
			this.txtIdAsignatura.TabIndex = 24;
			// 
			// txtNombreAsignatura
			// 
			this.txtNombreAsignatura.Location = new System.Drawing.Point(111, 133);
			this.txtNombreAsignatura.Name = "txtNombreAsignatura";
			this.txtNombreAsignatura.Size = new System.Drawing.Size(216, 20);
			this.txtNombreAsignatura.TabIndex = 25;
			// 
			// txtDepartamentoAsignatura
			// 
			this.txtDepartamentoAsignatura.FormattingEnabled = true;
			this.txtDepartamentoAsignatura.Items.AddRange(new object[] {
            "",
            "Orientación",
            "Biología y Geología",
            "Dibujo",
            "Educación Física",
            "Física y Química",
            "Geografía e Historia",
            "Francés",
            "Informática",
            "Inglés",
            "Lengua Española y Literatura",
            "Matemáticas",
            "Música",
            "Orientación",
            "Religión",
            "Tecnología"});
			this.txtDepartamentoAsignatura.Location = new System.Drawing.Point(164, 177);
			this.txtDepartamentoAsignatura.Name = "txtDepartamentoAsignatura";
			this.txtDepartamentoAsignatura.Size = new System.Drawing.Size(200, 21);
			this.txtDepartamentoAsignatura.TabIndex = 26;
			// 
			// txtHorasAsignatura
			// 
			this.txtHorasAsignatura.Location = new System.Drawing.Point(184, 226);
			this.txtHorasAsignatura.Name = "txtHorasAsignatura";
			this.txtHorasAsignatura.Size = new System.Drawing.Size(79, 20);
			this.txtHorasAsignatura.TabIndex = 27;
			// 
			// btnLimpiarAsignatura
			// 
			this.btnLimpiarAsignatura.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiarAsignatura.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarAsignatura.Image")));
			this.btnLimpiarAsignatura.Location = new System.Drawing.Point(393, 317);
			this.btnLimpiarAsignatura.Name = "btnLimpiarAsignatura";
			this.btnLimpiarAsignatura.Size = new System.Drawing.Size(114, 34);
			this.btnLimpiarAsignatura.TabIndex = 32;
			this.btnLimpiarAsignatura.Text = "LIMPIAR";
			this.btnLimpiarAsignatura.UseVisualStyleBackColor = true;
			this.btnLimpiarAsignatura.Click += new System.EventHandler(this.btnLimpiarAsignatura_Click);
			// 
			// btnGuardarAsignatura
			// 
			this.btnGuardarAsignatura.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardarAsignatura.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarAsignatura.Image")));
			this.btnGuardarAsignatura.Location = new System.Drawing.Point(-1, 318);
			this.btnGuardarAsignatura.Name = "btnGuardarAsignatura";
			this.btnGuardarAsignatura.Size = new System.Drawing.Size(114, 34);
			this.btnGuardarAsignatura.TabIndex = 31;
			this.btnGuardarAsignatura.Text = "GUARDAR";
			this.btnGuardarAsignatura.UseVisualStyleBackColor = true;
			this.btnGuardarAsignatura.Click += new System.EventHandler(this.btnGuardarAsignatura_Click);
			// 
			// Form4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(507, 350);
			this.Controls.Add(this.btnLimpiarAsignatura);
			this.Controls.Add(this.btnGuardarAsignatura);
			this.Controls.Add(this.txtHorasAsignatura);
			this.Controls.Add(this.txtDepartamentoAsignatura);
			this.Controls.Add(this.txtNombreAsignatura);
			this.Controls.Add(this.txtIdAsignatura);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label6);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form4";
			this.Text = "Administrar Asignatura";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtIdAsignatura;
		private System.Windows.Forms.TextBox txtNombreAsignatura;
		private System.Windows.Forms.ComboBox txtDepartamentoAsignatura;
		private System.Windows.Forms.TextBox txtHorasAsignatura;
		private System.Windows.Forms.Button btnLimpiarAsignatura;
		private System.Windows.Forms.Button btnGuardarAsignatura;
	}
}