/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 27/08/2024
 * Hora: 20:35
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Proy_herramientasForm
{
	partial class Ventana4
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.CheckedListBox clbx_escritorio;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_escritorio;
		private System.Windows.Forms.Button btn_adicionar;
		private System.Windows.Forms.Label lbl_escritorio;
		private System.Windows.Forms.DomainUpDown dupMarcas;
		private System.Windows.Forms.Button btnMarcas;
		private System.Windows.Forms.TextBox txtMarcas;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblMarca;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.NumericUpDown nupDia;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblDias;
		private System.Windows.Forms.Button btnMostrar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnNumero;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Label lblNumero;
		private System.Windows.Forms.Label lbl_Cadena;
		private System.Windows.Forms.TextBox txt_Cadena;
		private System.Windows.Forms.Button btn_Procesar;
		private System.Windows.Forms.ErrorProvider error_Cadena;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana4));
			this.clbx_escritorio = new System.Windows.Forms.CheckedListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_escritorio = new System.Windows.Forms.TextBox();
			this.btn_adicionar = new System.Windows.Forms.Button();
			this.lbl_escritorio = new System.Windows.Forms.Label();
			this.dupMarcas = new System.Windows.Forms.DomainUpDown();
			this.btnMarcas = new System.Windows.Forms.Button();
			this.txtMarcas = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lblMarca = new System.Windows.Forms.Label();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.nupDia = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.lblDias = new System.Windows.Forms.Label();
			this.btnMostrar = new System.Windows.Forms.Button();
			this.btnNumero = new System.Windows.Forms.Button();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lblNumero = new System.Windows.Forms.Label();
			this.lbl_Cadena = new System.Windows.Forms.Label();
			this.txt_Cadena = new System.Windows.Forms.TextBox();
			this.btn_Procesar = new System.Windows.Forms.Button();
			this.error_Cadena = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.nupDia)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.error_Cadena)).BeginInit();
			this.SuspendLayout();
			// 
			// clbx_escritorio
			// 
			this.clbx_escritorio.CheckOnClick = true;
			this.clbx_escritorio.FormattingEnabled = true;
			this.clbx_escritorio.Items.AddRange(new object[] {
			"Cuaderno",
			"Boligrafo",
			"Lapiz",
			"Estuche",
			"Regla"});
			this.clbx_escritorio.Location = new System.Drawing.Point(13, 100);
			this.clbx_escritorio.Name = "clbx_escritorio";
			this.clbx_escritorio.Size = new System.Drawing.Size(152, 109);
			this.clbx_escritorio.TabIndex = 0;
			this.clbx_escritorio.SelectedIndexChanged += new System.EventHandler(this.Clbx_escritorioSelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(215, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Material de Escritorio";
			// 
			// txt_escritorio
			// 
			this.txt_escritorio.Location = new System.Drawing.Point(13, 36);
			this.txt_escritorio.Multiline = true;
			this.txt_escritorio.Name = "txt_escritorio";
			this.txt_escritorio.Size = new System.Drawing.Size(214, 29);
			this.txt_escritorio.TabIndex = 2;
			this.txt_escritorio.TextChanged += new System.EventHandler(this.Txt_escritorioTextChanged);
			this.txt_escritorio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_escritorioKeyPress);
			// 
			// btn_adicionar
			// 
			this.btn_adicionar.Location = new System.Drawing.Point(13, 71);
			this.btn_adicionar.Name = "btn_adicionar";
			this.btn_adicionar.Size = new System.Drawing.Size(75, 23);
			this.btn_adicionar.TabIndex = 3;
			this.btn_adicionar.Text = "Adicionar";
			this.btn_adicionar.UseVisualStyleBackColor = true;
			this.btn_adicionar.Click += new System.EventHandler(this.Btn_adicionarClick);
			// 
			// lbl_escritorio
			// 
			this.lbl_escritorio.Location = new System.Drawing.Point(12, 233);
			this.lbl_escritorio.Name = "lbl_escritorio";
			this.lbl_escritorio.Size = new System.Drawing.Size(215, 87);
			this.lbl_escritorio.TabIndex = 4;
			// 
			// dupMarcas
			// 
			this.dupMarcas.Items.Add("suzuki");
			this.dupMarcas.Items.Add("audi");
			this.dupMarcas.Items.Add("toyota");
			this.dupMarcas.Location = new System.Drawing.Point(325, 143);
			this.dupMarcas.Name = "dupMarcas";
			this.dupMarcas.Size = new System.Drawing.Size(170, 20);
			this.dupMarcas.TabIndex = 5;
			this.dupMarcas.Text = "seleccione";
			this.dupMarcas.SelectedItemChanged += new System.EventHandler(this.DupMarcasSelectedItemChanged);
			// 
			// btnMarcas
			// 
			this.btnMarcas.Location = new System.Drawing.Point(325, 100);
			this.btnMarcas.Name = "btnMarcas";
			this.btnMarcas.Size = new System.Drawing.Size(75, 23);
			this.btnMarcas.TabIndex = 6;
			this.btnMarcas.Text = "Adicionar";
			this.btnMarcas.UseVisualStyleBackColor = true;
			this.btnMarcas.Click += new System.EventHandler(this.BtnMarcasClick);
			// 
			// txtMarcas
			// 
			this.txtMarcas.Location = new System.Drawing.Point(325, 47);
			this.txtMarcas.Multiline = true;
			this.txtMarcas.Name = "txtMarcas";
			this.txtMarcas.Size = new System.Drawing.Size(170, 26);
			this.txtMarcas.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(325, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(170, 23);
			this.label2.TabIndex = 8;
			this.label2.Text = "Marcas de automoviles";
			// 
			// lblMarca
			// 
			this.lblMarca.Location = new System.Drawing.Point(325, 211);
			this.lblMarca.Name = "lblMarca";
			this.lblMarca.Size = new System.Drawing.Size(170, 62);
			this.lblMarca.TabIndex = 9;
			this.lblMarca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(420, 100);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 10;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// nupDia
			// 
			this.nupDia.Location = new System.Drawing.Point(592, 74);
			this.nupDia.Maximum = new decimal(new int[] {
			7,
			0,
			0,
			0});
			this.nupDia.Name = "nupDia";
			this.nupDia.Size = new System.Drawing.Size(170, 20);
			this.nupDia.TabIndex = 11;
			this.nupDia.ValueChanged += new System.EventHandler(this.NupDiaValueChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(592, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(170, 34);
			this.label3.TabIndex = 12;
			this.label3.Text = "dias de la semana";
			// 
			// lblDias
			// 
			this.lblDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDias.Location = new System.Drawing.Point(592, 114);
			this.lblDias.Name = "lblDias";
			this.lblDias.Size = new System.Drawing.Size(169, 49);
			this.lblDias.TabIndex = 13;
			this.lblDias.Text = "Dia";
			this.lblDias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnMostrar
			// 
			this.btnMostrar.Location = new System.Drawing.Point(609, 185);
			this.btnMostrar.Name = "btnMostrar";
			this.btnMostrar.Size = new System.Drawing.Size(75, 23);
			this.btnMostrar.TabIndex = 14;
			this.btnMostrar.Text = "Mostrar";
			this.btnMostrar.UseVisualStyleBackColor = true;
			this.btnMostrar.Click += new System.EventHandler(this.Button1Click);
			// 
			// btnNumero
			// 
			this.btnNumero.Location = new System.Drawing.Point(592, 325);
			this.btnNumero.Name = "btnNumero";
			this.btnNumero.Size = new System.Drawing.Size(75, 23);
			this.btnNumero.TabIndex = 17;
			this.btnNumero.Text = "ver";
			this.btnNumero.UseVisualStyleBackColor = true;
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(593, 279);
			this.txtNumero.Multiline = true;
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(168, 40);
			this.txtNumero.TabIndex = 18;
			this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeroKeyPress);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(593, 233);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(91, 40);
			this.label4.TabIndex = 19;
			this.label4.Text = "Numero:";
			// 
			// lblNumero
			// 
			this.lblNumero.Location = new System.Drawing.Point(591, 365);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(170, 62);
			this.lblNumero.TabIndex = 20;
			this.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_Cadena
			// 
			this.lbl_Cadena.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Cadena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Cadena.ForeColor = System.Drawing.Color.FloralWhite;
			this.lbl_Cadena.Location = new System.Drawing.Point(813, 236);
			this.lbl_Cadena.Name = "lbl_Cadena";
			this.lbl_Cadena.Size = new System.Drawing.Size(107, 37);
			this.lbl_Cadena.TabIndex = 22;
			this.lbl_Cadena.Text = "cadena:";
			// 
			// txt_Cadena
			// 
			this.txt_Cadena.Location = new System.Drawing.Point(813, 282);
			this.txt_Cadena.Multiline = true;
			this.txt_Cadena.Name = "txt_Cadena";
			this.txt_Cadena.Size = new System.Drawing.Size(168, 40);
			this.txt_Cadena.TabIndex = 21;
			this.txt_Cadena.TextChanged += new System.EventHandler(this.Txt_CadenaTextChanged);
			// 
			// btn_Procesar
			// 
			this.btn_Procesar.Location = new System.Drawing.Point(844, 380);
			this.btn_Procesar.Name = "btn_Procesar";
			this.btn_Procesar.Size = new System.Drawing.Size(102, 35);
			this.btn_Procesar.TabIndex = 23;
			this.btn_Procesar.Text = "procesar";
			this.btn_Procesar.UseVisualStyleBackColor = true;
			this.btn_Procesar.Click += new System.EventHandler(this.Btn_ProcesarClick);
			// 
			// error_Cadena
			// 
			this.error_Cadena.ContainerControl = this;
			// 
			// Ventana4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(997, 485);
			this.Controls.Add(this.btn_Procesar);
			this.Controls.Add(this.lbl_Cadena);
			this.Controls.Add(this.txt_Cadena);
			this.Controls.Add(this.lblNumero);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.btnNumero);
			this.Controls.Add(this.btnMostrar);
			this.Controls.Add(this.lblDias);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.nupDia);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.lblMarca);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtMarcas);
			this.Controls.Add(this.btnMarcas);
			this.Controls.Add(this.dupMarcas);
			this.Controls.Add(this.lbl_escritorio);
			this.Controls.Add(this.btn_adicionar);
			this.Controls.Add(this.txt_escritorio);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.clbx_escritorio);
			this.Name = "Ventana4";
			this.Text = "Ventana4";
			((System.ComponentModel.ISupportInitialize)(this.nupDia)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.error_Cadena)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
