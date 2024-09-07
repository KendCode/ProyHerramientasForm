
namespace Proy_herramientasForm
{
	partial class Ventana2
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_nombre;
		private System.Windows.Forms.Button btn_agregar;
		private System.Windows.Forms.ComboBox cbB_Nombres;
		private System.Windows.Forms.Button btn_numero;
		private System.Windows.Forms.TextBox txt_numero;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox lB_numeros;
		private System.Windows.Forms.Button btn_posicion;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txt_nombre = new System.Windows.Forms.TextBox();
			this.btn_agregar = new System.Windows.Forms.Button();
			this.cbB_Nombres = new System.Windows.Forms.ComboBox();
			this.btn_numero = new System.Windows.Forms.Button();
			this.txt_numero = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lB_numeros = new System.Windows.Forms.ListBox();
			this.btn_posicion = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(95, 31);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre";
			// 
			// txt_nombre
			// 
			this.txt_nombre.Location = new System.Drawing.Point(95, 85);
			this.txt_nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txt_nombre.Name = "txt_nombre";
			this.txt_nombre.Size = new System.Drawing.Size(132, 22);
			this.txt_nombre.TabIndex = 1;
			// 
			// btn_agregar
			// 
			this.btn_agregar.Location = new System.Drawing.Point(95, 150);
			this.btn_agregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btn_agregar.Name = "btn_agregar";
			this.btn_agregar.Size = new System.Drawing.Size(100, 28);
			this.btn_agregar.TabIndex = 2;
			this.btn_agregar.Text = "AGREGAR";
			this.btn_agregar.UseVisualStyleBackColor = true;
			this.btn_agregar.Click += new System.EventHandler(this.Btn_agregarClick);
			// 
			// cbB_Nombres
			// 
			this.cbB_Nombres.FormattingEnabled = true;
			this.cbB_Nombres.Items.AddRange(new object[] {
			"Maria",
			"Luis",
			"Sara",
			"Lisbeth"});
			this.cbB_Nombres.Location = new System.Drawing.Point(95, 212);
			this.cbB_Nombres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbB_Nombres.Name = "cbB_Nombres";
			this.cbB_Nombres.Size = new System.Drawing.Size(160, 24);
			this.cbB_Nombres.TabIndex = 3;
			// 
			// btn_numero
			// 
			this.btn_numero.Location = new System.Drawing.Point(352, 150);
			this.btn_numero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btn_numero.Name = "btn_numero";
			this.btn_numero.Size = new System.Drawing.Size(100, 28);
			this.btn_numero.TabIndex = 6;
			this.btn_numero.Text = "AGREGAR";
			this.btn_numero.UseVisualStyleBackColor = true;
			this.btn_numero.Click += new System.EventHandler(this.Btn_numeroClick);
			// 
			// txt_numero
			// 
			this.txt_numero.Location = new System.Drawing.Point(352, 85);
			this.txt_numero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txt_numero.Name = "txt_numero";
			this.txt_numero.Size = new System.Drawing.Size(132, 22);
			this.txt_numero.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(352, 31);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 28);
			this.label2.TabIndex = 4;
			this.label2.Text = "NUMERO";
			// 
			// lB_numeros
			// 
			this.lB_numeros.FormattingEnabled = true;
			this.lB_numeros.ItemHeight = 16;
			this.lB_numeros.Items.AddRange(new object[] {
			"2",
			"3",
			"4",
			"5"});
			this.lB_numeros.Location = new System.Drawing.Point(352, 186);
			this.lB_numeros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.lB_numeros.Name = "lB_numeros";
			this.lB_numeros.Size = new System.Drawing.Size(159, 116);
			this.lB_numeros.TabIndex = 7;
			// 
			// btn_posicion
			// 
			this.btn_posicion.Location = new System.Drawing.Point(460, 150);
			this.btn_posicion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btn_posicion.Name = "btn_posicion";
			this.btn_posicion.Size = new System.Drawing.Size(171, 28);
			this.btn_posicion.TabIndex = 8;
			this.btn_posicion.Text = "MOSTRAR POSICION";
			this.btn_posicion.UseVisualStyleBackColor = true;
			this.btn_posicion.Click += new System.EventHandler(this.Btn_posicionClick);
			// 
			// Ventana2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(672, 363);
			this.Controls.Add(this.btn_posicion);
			this.Controls.Add(this.lB_numeros);
			this.Controls.Add(this.btn_numero);
			this.Controls.Add(this.txt_numero);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbB_Nombres);
			this.Controls.Add(this.btn_agregar);
			this.Controls.Add(this.txt_nombre);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Ventana2";
			this.Text = "Ventana2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
