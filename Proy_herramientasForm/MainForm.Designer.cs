/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 15/08/2024
 * Hora: 20:32
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Proy_herramientasForm
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label_MostrarCurso;
		private System.Windows.Forms.RadioButton rbt_1A;
		private System.Windows.Forms.RadioButton rbt_3A;
		private System.Windows.Forms.RadioButton rbt_2A;
		private System.Windows.Forms.Button btn_mostrar;
		private System.Windows.Forms.Label lbl_curso;
		private System.Windows.Forms.Label label_idioma;
		private System.Windows.Forms.CheckBox cbx_castellano;
		private System.Windows.Forms.CheckBox cbx_otro;
		private System.Windows.Forms.CheckBox cbx_ingles;
		private System.Windows.Forms.Button btn_idioma;
		private System.Windows.Forms.Label lbl_MostrarIdiomas;
		private System.Windows.Forms.Button btn_ventana2;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem ventanaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ventana1ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ventana2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ventana3ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label_MostrarCurso = new System.Windows.Forms.Label();
			this.rbt_1A = new System.Windows.Forms.RadioButton();
			this.rbt_3A = new System.Windows.Forms.RadioButton();
			this.rbt_2A = new System.Windows.Forms.RadioButton();
			this.btn_mostrar = new System.Windows.Forms.Button();
			this.lbl_curso = new System.Windows.Forms.Label();
			this.label_idioma = new System.Windows.Forms.Label();
			this.cbx_castellano = new System.Windows.Forms.CheckBox();
			this.cbx_otro = new System.Windows.Forms.CheckBox();
			this.cbx_ingles = new System.Windows.Forms.CheckBox();
			this.btn_idioma = new System.Windows.Forms.Button();
			this.lbl_MostrarIdiomas = new System.Windows.Forms.Label();
			this.btn_ventana2 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.ventanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ventana1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ventana2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ventana3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label_MostrarCurso
			// 
			this.label_MostrarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_MostrarCurso.Location = new System.Drawing.Point(88, 375);
			this.label_MostrarCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_MostrarCurso.Name = "label_MostrarCurso";
			this.label_MostrarCurso.Size = new System.Drawing.Size(165, 28);
			this.label_MostrarCurso.TabIndex = 0;
			this.label_MostrarCurso.Text = "CURSO";
			// 
			// rbt_1A
			// 
			this.rbt_1A.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbt_1A.Location = new System.Drawing.Point(100, 186);
			this.rbt_1A.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.rbt_1A.Name = "rbt_1A";
			this.rbt_1A.Size = new System.Drawing.Size(139, 30);
			this.rbt_1A.TabIndex = 1;
			this.rbt_1A.TabStop = true;
			this.rbt_1A.Text = "1er Año";
			this.rbt_1A.UseVisualStyleBackColor = true;
			// 
			// rbt_3A
			// 
			this.rbt_3A.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbt_3A.Location = new System.Drawing.Point(100, 260);
			this.rbt_3A.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.rbt_3A.Name = "rbt_3A";
			this.rbt_3A.Size = new System.Drawing.Size(139, 30);
			this.rbt_3A.TabIndex = 2;
			this.rbt_3A.TabStop = true;
			this.rbt_3A.Text = "3er Año";
			this.rbt_3A.UseVisualStyleBackColor = true;
			// 
			// rbt_2A
			// 
			this.rbt_2A.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbt_2A.Location = new System.Drawing.Point(100, 223);
			this.rbt_2A.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.rbt_2A.Name = "rbt_2A";
			this.rbt_2A.Size = new System.Drawing.Size(139, 30);
			this.rbt_2A.TabIndex = 3;
			this.rbt_2A.TabStop = true;
			this.rbt_2A.Text = "2do Año";
			this.rbt_2A.UseVisualStyleBackColor = true;
			// 
			// btn_mostrar
			// 
			this.btn_mostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btn_mostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_mostrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btn_mostrar.Location = new System.Drawing.Point(88, 297);
			this.btn_mostrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btn_mostrar.Name = "btn_mostrar";
			this.btn_mostrar.Size = new System.Drawing.Size(165, 46);
			this.btn_mostrar.TabIndex = 4;
			this.btn_mostrar.Text = "MOSTRAR";
			this.btn_mostrar.UseVisualStyleBackColor = false;
			this.btn_mostrar.Click += new System.EventHandler(this.Btn_mostrarClick);
			// 
			// lbl_curso
			// 
			this.lbl_curso.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_curso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lbl_curso.Location = new System.Drawing.Point(100, 123);
			this.lbl_curso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_curso.Name = "lbl_curso";
			this.lbl_curso.Size = new System.Drawing.Size(133, 38);
			this.lbl_curso.TabIndex = 5;
			this.lbl_curso.Text = "CURSO";
			// 
			// label_idioma
			// 
			this.label_idioma.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_idioma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label_idioma.Location = new System.Drawing.Point(400, 133);
			this.label_idioma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_idioma.Name = "label_idioma";
			this.label_idioma.Size = new System.Drawing.Size(149, 28);
			this.label_idioma.TabIndex = 6;
			this.label_idioma.Text = "IDIOMAS";
			// 
			// cbx_castellano
			// 
			this.cbx_castellano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbx_castellano.Location = new System.Drawing.Point(380, 187);
			this.cbx_castellano.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbx_castellano.Name = "cbx_castellano";
			this.cbx_castellano.Size = new System.Drawing.Size(139, 30);
			this.cbx_castellano.TabIndex = 7;
			this.cbx_castellano.Text = "Castellano";
			this.cbx_castellano.UseVisualStyleBackColor = true;
			// 
			// cbx_otro
			// 
			this.cbx_otro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbx_otro.Location = new System.Drawing.Point(380, 261);
			this.cbx_otro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbx_otro.Name = "cbx_otro";
			this.cbx_otro.Size = new System.Drawing.Size(139, 30);
			this.cbx_otro.TabIndex = 8;
			this.cbx_otro.Text = "Otro";
			this.cbx_otro.UseVisualStyleBackColor = true;
			// 
			// cbx_ingles
			// 
			this.cbx_ingles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbx_ingles.Location = new System.Drawing.Point(380, 224);
			this.cbx_ingles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbx_ingles.Name = "cbx_ingles";
			this.cbx_ingles.Size = new System.Drawing.Size(139, 30);
			this.cbx_ingles.TabIndex = 9;
			this.cbx_ingles.Text = "Ingles";
			this.cbx_ingles.UseVisualStyleBackColor = true;
			// 
			// btn_idioma
			// 
			this.btn_idioma.BackColor = System.Drawing.Color.Aqua;
			this.btn_idioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_idioma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btn_idioma.Location = new System.Drawing.Point(400, 298);
			this.btn_idioma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btn_idioma.Name = "btn_idioma";
			this.btn_idioma.Size = new System.Drawing.Size(165, 46);
			this.btn_idioma.TabIndex = 10;
			this.btn_idioma.Text = "MOSTRAR";
			this.btn_idioma.UseVisualStyleBackColor = false;
			this.btn_idioma.Click += new System.EventHandler(this.Btn_idiomaClick);
			// 
			// lbl_MostrarIdiomas
			// 
			this.lbl_MostrarIdiomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_MostrarIdiomas.Location = new System.Drawing.Point(359, 375);
			this.lbl_MostrarIdiomas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_MostrarIdiomas.Name = "lbl_MostrarIdiomas";
			this.lbl_MostrarIdiomas.Size = new System.Drawing.Size(505, 28);
			this.lbl_MostrarIdiomas.TabIndex = 11;
			this.lbl_MostrarIdiomas.Text = "IDIOMAS";
			// 
			// btn_ventana2
			// 
			this.btn_ventana2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.btn_ventana2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_ventana2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btn_ventana2.Location = new System.Drawing.Point(631, 132);
			this.btn_ventana2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btn_ventana2.Name = "btn_ventana2";
			this.btn_ventana2.Size = new System.Drawing.Size(189, 41);
			this.btn_ventana2.TabIndex = 12;
			this.btn_ventana2.Text = "VENTANA 2";
			this.btn_ventana2.UseVisualStyleBackColor = false;
			this.btn_ventana2.Click += new System.EventHandler(this.Btn_ventana2Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.ventanaToolStripMenuItem,
			this.archivoToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(900, 28);
			this.menuStrip1.TabIndex = 13;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// ventanaToolStripMenuItem
			// 
			this.ventanaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.ventana1ToolStripMenuItem,
			this.ventana2ToolStripMenuItem,
			this.ventana3ToolStripMenuItem});
			this.ventanaToolStripMenuItem.Name = "ventanaToolStripMenuItem";
			this.ventanaToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
			this.ventanaToolStripMenuItem.Text = "ventana";
			// 
			// ventana1ToolStripMenuItem
			// 
			this.ventana1ToolStripMenuItem.Name = "ventana1ToolStripMenuItem";
			this.ventana1ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
			this.ventana1ToolStripMenuItem.Text = "ventana1";
			// 
			// ventana2ToolStripMenuItem
			// 
			this.ventana2ToolStripMenuItem.Name = "ventana2ToolStripMenuItem";
			this.ventana2ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
			this.ventana2ToolStripMenuItem.Text = "ventana2";
			this.ventana2ToolStripMenuItem.Click += new System.EventHandler(this.Ventana2ToolStripMenuItemClick);
			// 
			// ventana3ToolStripMenuItem
			// 
			this.ventana3ToolStripMenuItem.Name = "ventana3ToolStripMenuItem";
			this.ventana3ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
			this.ventana3ToolStripMenuItem.Text = "ventana3";
			this.ventana3ToolStripMenuItem.Click += new System.EventHandler(this.Ventana3ToolStripMenuItemClick);
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.nuevoToolStripMenuItem,
			this.guardarToolStripMenuItem,
			this.imprimirToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
			this.archivoToolStripMenuItem.Text = "Archivo";
			// 
			// nuevoToolStripMenuItem
			// 
			this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
			this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
			this.nuevoToolStripMenuItem.Text = "nuevo";
			// 
			// guardarToolStripMenuItem
			// 
			this.guardarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.guardarComoToolStripMenuItem});
			this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
			this.guardarToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
			this.guardarToolStripMenuItem.Text = "guardar";
			// 
			// guardarComoToolStripMenuItem
			// 
			this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
			this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
			this.guardarComoToolStripMenuItem.Text = "guardar como";
			// 
			// imprimirToolStripMenuItem
			// 
			this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
			this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
			this.imprimirToolStripMenuItem.Text = "imprimir";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.GreenYellow;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(900, 463);
			this.Controls.Add(this.btn_ventana2);
			this.Controls.Add(this.lbl_MostrarIdiomas);
			this.Controls.Add(this.btn_idioma);
			this.Controls.Add(this.cbx_ingles);
			this.Controls.Add(this.cbx_otro);
			this.Controls.Add(this.cbx_castellano);
			this.Controls.Add(this.label_idioma);
			this.Controls.Add(this.lbl_curso);
			this.Controls.Add(this.btn_mostrar);
			this.Controls.Add(this.rbt_2A);
			this.Controls.Add(this.rbt_3A);
			this.Controls.Add(this.rbt_1A);
			this.Controls.Add(this.label_MostrarCurso);
			this.Controls.Add(this.menuStrip1);
			this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Proy_herramientasForm";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
