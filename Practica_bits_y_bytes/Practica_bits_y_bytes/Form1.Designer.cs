namespace Practica_bits_y_bytes
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtentrada = new System.Windows.Forms.TextBox();
			this.btnprocesar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtreadDate = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btndateChange = new System.Windows.Forms.Button();
			this.txtChangedDate = new System.Windows.Forms.TextBox();
			this.txtsensores1 = new System.Windows.Forms.TextBox();
			this.txtnivel = new System.Windows.Forms.TextBox();
			this.txtdireccion = new System.Windows.Forms.TextBox();
			this.txtsensores2 = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.lbltest = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Entrada:";
			// 
			// txtentrada
			// 
			this.txtentrada.Location = new System.Drawing.Point(87, 13);
			this.txtentrada.Name = "txtentrada";
			this.txtentrada.Size = new System.Drawing.Size(140, 22);
			this.txtentrada.TabIndex = 1;
			// 
			// btnprocesar
			// 
			this.btnprocesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnprocesar.Location = new System.Drawing.Point(233, 12);
			this.btnprocesar.Name = "btnprocesar";
			this.btnprocesar.Size = new System.Drawing.Size(112, 33);
			this.btnprocesar.TabIndex = 2;
			this.btnprocesar.Text = "Procesar";
			this.btnprocesar.UseVisualStyleBackColor = true;
			this.btnprocesar.Click += new System.EventHandler(this.btnprocesar_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Sensores";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(180, 102);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Nivel";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(344, 102);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "Direccion";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 318);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(117, 20);
			this.label5.TabIndex = 6;
			this.label5.Text = "FechaLectura:";
			// 
			// txtreadDate
			// 
			this.txtreadDate.Location = new System.Drawing.Point(136, 318);
			this.txtreadDate.Name = "txtreadDate";
			this.txtreadDate.Size = new System.Drawing.Size(208, 22);
			this.txtreadDate.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(13, 371);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 20);
			this.label6.TabIndex = 8;
			this.label6.Text = "Fecha";
			// 
			// btndateChange
			// 
			this.btndateChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btndateChange.Location = new System.Drawing.Point(75, 400);
			this.btndateChange.Name = "btndateChange";
			this.btndateChange.Size = new System.Drawing.Size(151, 38);
			this.btndateChange.TabIndex = 10;
			this.btndateChange.Text = "Ajustar Fecha";
			this.btndateChange.UseVisualStyleBackColor = true;
			this.btndateChange.Click += new System.EventHandler(this.btndateChange_Click);
			// 
			// txtChangedDate
			// 
			this.txtChangedDate.Location = new System.Drawing.Point(75, 444);
			this.txtChangedDate.Name = "txtChangedDate";
			this.txtChangedDate.Size = new System.Drawing.Size(152, 22);
			this.txtChangedDate.TabIndex = 11;
			// 
			// txtsensores1
			// 
			this.txtsensores1.Location = new System.Drawing.Point(12, 146);
			this.txtsensores1.Name = "txtsensores1";
			this.txtsensores1.Size = new System.Drawing.Size(34, 22);
			this.txtsensores1.TabIndex = 12;
			// 
			// txtnivel
			// 
			this.txtnivel.Location = new System.Drawing.Point(163, 145);
			this.txtnivel.Name = "txtnivel";
			this.txtnivel.Size = new System.Drawing.Size(86, 22);
			this.txtnivel.TabIndex = 13;
			// 
			// txtdireccion
			// 
			this.txtdireccion.Location = new System.Drawing.Point(336, 145);
			this.txtdireccion.Name = "txtdireccion";
			this.txtdireccion.Size = new System.Drawing.Size(100, 22);
			this.txtdireccion.TabIndex = 14;
			// 
			// txtsensores2
			// 
			this.txtsensores2.Location = new System.Drawing.Point(52, 146);
			this.txtsensores2.Name = "txtsensores2";
			this.txtsensores2.Size = new System.Drawing.Size(34, 22);
			this.txtsensores2.TabIndex = 15;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(75, 372);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
			this.dateTimePicker1.TabIndex = 16;
			// 
			// lbltest
			// 
			this.lbltest.AutoSize = true;
			this.lbltest.Location = new System.Drawing.Point(378, 27);
			this.lbltest.Name = "lbltest";
			this.lbltest.Size = new System.Drawing.Size(46, 17);
			this.lbltest.TabIndex = 17;
			this.lbltest.Text = "label7";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(578, 590);
			this.Controls.Add(this.lbltest);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.txtsensores2);
			this.Controls.Add(this.txtdireccion);
			this.Controls.Add(this.txtnivel);
			this.Controls.Add(this.txtsensores1);
			this.Controls.Add(this.txtChangedDate);
			this.Controls.Add(this.btndateChange);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtreadDate);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnprocesar);
			this.Controls.Add(this.txtentrada);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtentrada;
		private System.Windows.Forms.Button btnprocesar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtreadDate;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btndateChange;
		private System.Windows.Forms.TextBox txtChangedDate;
		private System.Windows.Forms.TextBox txtsensores1;
		private System.Windows.Forms.TextBox txtnivel;
		private System.Windows.Forms.TextBox txtdireccion;
		private System.Windows.Forms.TextBox txtsensores2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label lbltest;
	}
}

