namespace EjercicioFicherosEscuela
{
	partial class Form7
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
			this.txtHorasAsignatura = new System.Windows.Forms.TextBox();
			this.txtDepartamentoAsignatura = new System.Windows.Forms.TextBox();
			this.txtNombreAsignatura = new System.Windows.Forms.TextBox();
			this.cbIdAsignatura = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtHorasAsignatura
			// 
			this.txtHorasAsignatura.Location = new System.Drawing.Point(134, 257);
			this.txtHorasAsignatura.Name = "txtHorasAsignatura";
			this.txtHorasAsignatura.Size = new System.Drawing.Size(221, 20);
			this.txtHorasAsignatura.TabIndex = 47;
			// 
			// txtDepartamentoAsignatura
			// 
			this.txtDepartamentoAsignatura.Location = new System.Drawing.Point(201, 219);
			this.txtDepartamentoAsignatura.Name = "txtDepartamentoAsignatura";
			this.txtDepartamentoAsignatura.Size = new System.Drawing.Size(219, 20);
			this.txtDepartamentoAsignatura.TabIndex = 46;
			// 
			// txtNombreAsignatura
			// 
			this.txtNombreAsignatura.Location = new System.Drawing.Point(153, 177);
			this.txtNombreAsignatura.Name = "txtNombreAsignatura";
			this.txtNombreAsignatura.Size = new System.Drawing.Size(207, 20);
			this.txtNombreAsignatura.TabIndex = 45;
			// 
			// cbIdAsignatura
			// 
			this.cbIdAsignatura.FormattingEnabled = true;
			this.cbIdAsignatura.Location = new System.Drawing.Point(105, 137);
			this.cbIdAsignatura.Name = "cbIdAsignatura";
			this.cbIdAsignatura.Size = new System.Drawing.Size(148, 21);
			this.cbIdAsignatura.TabIndex = 44;
			this.cbIdAsignatura.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(71, 257);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 18);
			this.label4.TabIndex = 43;
			this.label4.Text = "Horas";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(71, 217);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 18);
			this.label3.TabIndex = 42;
			this.label3.Text = "Departamento";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(71, 178);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 18);
			this.label2.TabIndex = 41;
			this.label2.Text = "Nombre";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(71, 137);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(27, 18);
			this.label7.TabIndex = 40;
			this.label7.Text = "ID";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(135, 58);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(236, 36);
			this.label6.TabIndex = 39;
			this.label6.Text = "Mostrar Asignatura";
			// 
			// Form7
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(507, 350);
			this.Controls.Add(this.txtHorasAsignatura);
			this.Controls.Add(this.txtDepartamentoAsignatura);
			this.Controls.Add(this.txtNombreAsignatura);
			this.Controls.Add(this.cbIdAsignatura);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form7";
			this.Text = "Mostrar datos Asignatura";
			this.Load += new System.EventHandler(this.Form7_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtHorasAsignatura;
		private System.Windows.Forms.TextBox txtDepartamentoAsignatura;
		private System.Windows.Forms.TextBox txtNombreAsignatura;
		private System.Windows.Forms.ComboBox cbIdAsignatura;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
	}
}