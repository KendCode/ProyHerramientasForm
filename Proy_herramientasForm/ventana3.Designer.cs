/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 20/08/2024
 * Hora: 20:14
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Proy_herramientasForm
{
	partial class ventana3
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label lbl_datos;
		private System.Windows.Forms.Button btn_guardar;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rbt_asalariado;
		private System.Windows.Forms.RadioButton rbt_Indepep;
		private System.Windows.Forms.RadioButton rbt_sinTrabajo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbbx_estudio;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DateTimePicker dtp_fecha;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton rbt_femenino;
		private System.Windows.Forms.RadioButton rbt_masculino;
		private System.Windows.Forms.TextBox txt_apellidos;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.TextBox txt_nombre;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.LinkLabel linkwasap;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.LinkLabel linkfacebook;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.LinkLabel linkyoutube;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventana3));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.lbl_datos = new System.Windows.Forms.Label();
			this.btn_guardar = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rbt_asalariado = new System.Windows.Forms.RadioButton();
			this.rbt_Indepep = new System.Windows.Forms.RadioButton();
			this.rbt_sinTrabajo = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.cbbx_estudio = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.rbt_femenino = new System.Windows.Forms.RadioButton();
			this.rbt_masculino = new System.Windows.Forms.RadioButton();
			this.txt_apellidos = new System.Windows.Forms.TextBox();
			this.label = new System.Windows.Forms.Label();
			this.txt_nombre = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.linkfacebook = new System.Windows.Forms.LinkLabel();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.linkyoutube = new System.Windows.Forms.LinkLabel();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.linkwasap = new System.Windows.Forms.LinkLabel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(1, 1);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(772, 407);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.lbl_datos);
			this.tabPage1.Controls.Add(this.btn_guardar);
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 27);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tabPage1.Size = new System.Drawing.Size(764, 376);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Datos";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// lbl_datos
			// 
			this.lbl_datos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.lbl_datos.Location = new System.Drawing.Point(229, 275);
			this.lbl_datos.Name = "lbl_datos";
			this.lbl_datos.Size = new System.Drawing.Size(526, 101);
			this.lbl_datos.TabIndex = 3;
			// 
			// btn_guardar
			// 
			this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_guardar.Location = new System.Drawing.Point(63, 275);
			this.btn_guardar.Name = "btn_guardar";
			this.btn_guardar.Size = new System.Drawing.Size(112, 36);
			this.btn_guardar.TabIndex = 2;
			this.btn_guardar.Text = "GUARDAR";
			this.btn_guardar.UseVisualStyleBackColor = true;
			this.btn_guardar.Click += new System.EventHandler(this.Btn_guardarClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rbt_asalariado);
			this.groupBox2.Controls.Add(this.rbt_Indepep);
			this.groupBox2.Controls.Add(this.rbt_sinTrabajo);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.cbbx_estudio);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(385, 7);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBox2.Size = new System.Drawing.Size(370, 247);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Academicos";
			// 
			// rbt_asalariado
			// 
			this.rbt_asalariado.Location = new System.Drawing.Point(52, 169);
			this.rbt_asalariado.Name = "rbt_asalariado";
			this.rbt_asalariado.Size = new System.Drawing.Size(104, 24);
			this.rbt_asalariado.TabIndex = 5;
			this.rbt_asalariado.TabStop = true;
			this.rbt_asalariado.Text = "Asalariado";
			this.rbt_asalariado.UseVisualStyleBackColor = true;
			// 
			// rbt_Indepep
			// 
			this.rbt_Indepep.Location = new System.Drawing.Point(52, 145);
			this.rbt_Indepep.Name = "rbt_Indepep";
			this.rbt_Indepep.Size = new System.Drawing.Size(121, 24);
			this.rbt_Indepep.TabIndex = 4;
			this.rbt_Indepep.TabStop = true;
			this.rbt_Indepep.Text = "Independiente";
			this.rbt_Indepep.UseVisualStyleBackColor = true;
			// 
			// rbt_sinTrabajo
			// 
			this.rbt_sinTrabajo.Location = new System.Drawing.Point(52, 121);
			this.rbt_sinTrabajo.Name = "rbt_sinTrabajo";
			this.rbt_sinTrabajo.Size = new System.Drawing.Size(121, 24);
			this.rbt_sinTrabajo.TabIndex = 3;
			this.rbt_sinTrabajo.TabStop = true;
			this.rbt_sinTrabajo.Text = "Sin Trabajo";
			this.rbt_sinTrabajo.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(20, 95);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(121, 23);
			this.label5.TabIndex = 2;
			this.label5.Text = "Tipo de Trabajo";
			// 
			// cbbx_estudio
			// 
			this.cbbx_estudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.cbbx_estudio.FormattingEnabled = true;
			this.cbbx_estudio.Items.AddRange(new object[] {
			"Bachilles",
			"Tec. Basico",
			"Tec. Medio",
			"Tec. Superior",
			"Licenciatura",
			"Maestria",
			"Doctorado"});
			this.cbbx_estudio.Location = new System.Drawing.Point(20, 62);
			this.cbbx_estudio.Name = "cbbx_estudio";
			this.cbbx_estudio.Size = new System.Drawing.Size(121, 26);
			this.cbbx_estudio.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(20, 36);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 0;
			this.label4.Text = "Estudio";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.dtp_fecha);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.rbt_femenino);
			this.groupBox1.Controls.Add(this.rbt_masculino);
			this.groupBox1.Controls.Add(this.txt_apellidos);
			this.groupBox1.Controls.Add(this.label);
			this.groupBox1.Controls.Add(this.txt_nombre);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(9, 7);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBox1.Size = new System.Drawing.Size(368, 247);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Personales";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(188, 11);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(115, 121);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// dtp_fecha
			// 
			this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_fecha.Location = new System.Drawing.Point(188, 169);
			this.dtp_fecha.Name = "dtp_fecha";
			this.dtp_fecha.Size = new System.Drawing.Size(133, 24);
			this.dtp_fecha.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(174, 142);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(147, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Fecha de Nacimiento";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(9, 142);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 27);
			this.label2.TabIndex = 6;
			this.label2.Text = "Genero";
			// 
			// rbt_femenino
			// 
			this.rbt_femenino.Location = new System.Drawing.Point(8, 196);
			this.rbt_femenino.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.rbt_femenino.Name = "rbt_femenino";
			this.rbt_femenino.Size = new System.Drawing.Size(139, 28);
			this.rbt_femenino.TabIndex = 5;
			this.rbt_femenino.TabStop = true;
			this.rbt_femenino.Text = "Femenino";
			this.rbt_femenino.UseVisualStyleBackColor = true;
			// 
			// rbt_masculino
			// 
			this.rbt_masculino.Location = new System.Drawing.Point(8, 162);
			this.rbt_masculino.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.rbt_masculino.Name = "rbt_masculino";
			this.rbt_masculino.Size = new System.Drawing.Size(139, 28);
			this.rbt_masculino.TabIndex = 4;
			this.rbt_masculino.TabStop = true;
			this.rbt_masculino.Text = "Masculino";
			this.rbt_masculino.UseVisualStyleBackColor = true;
			this.rbt_masculino.CheckedChanged += new System.EventHandler(this.Rbt_masculinoCheckedChanged);
			// 
			// txt_apellidos
			// 
			this.txt_apellidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.txt_apellidos.Location = new System.Drawing.Point(8, 111);
			this.txt_apellidos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txt_apellidos.Name = "txt_apellidos";
			this.txt_apellidos.Size = new System.Drawing.Size(132, 24);
			this.txt_apellidos.TabIndex = 3;
			// 
			// label
			// 
			this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label.Location = new System.Drawing.Point(8, 92);
			this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(133, 27);
			this.label.TabIndex = 2;
			this.label.Text = "Apellidos";
			// 
			// txt_nombre
			// 
			this.txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.txt_nombre.Location = new System.Drawing.Point(8, 55);
			this.txt_nombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txt_nombre.Name = "txt_nombre";
			this.txt_nombre.Size = new System.Drawing.Size(132, 24);
			this.txt_nombre.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 36);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.tabPage2.Controls.Add(this.monthCalendar1);
			this.tabPage2.Controls.Add(this.linkfacebook);
			this.tabPage2.Controls.Add(this.pictureBox4);
			this.tabPage2.Controls.Add(this.linkyoutube);
			this.tabPage2.Controls.Add(this.pictureBox3);
			this.tabPage2.Controls.Add(this.linkwasap);
			this.tabPage2.Controls.Add(this.pictureBox2);
			this.tabPage2.Location = new System.Drawing.Point(4, 27);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tabPage2.Size = new System.Drawing.Size(764, 376);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "imagenes";
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Location = new System.Drawing.Point(559, 20);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 6;
			// 
			// linkfacebook
			// 
			this.linkfacebook.Location = new System.Drawing.Point(406, 159);
			this.linkfacebook.Name = "linkfacebook";
			this.linkfacebook.Size = new System.Drawing.Size(100, 23);
			this.linkfacebook.TabIndex = 5;
			this.linkfacebook.TabStop = true;
			this.linkfacebook.Text = "FACEBOOK";
			this.linkfacebook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkfacebookLinkClicked);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(377, 19);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(155, 137);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 4;
			this.pictureBox4.TabStop = false;
			// 
			// linkyoutube
			// 
			this.linkyoutube.LinkColor = System.Drawing.Color.Red;
			this.linkyoutube.Location = new System.Drawing.Point(227, 159);
			this.linkyoutube.Name = "linkyoutube";
			this.linkyoutube.Size = new System.Drawing.Size(100, 23);
			this.linkyoutube.TabIndex = 3;
			this.linkyoutube.TabStop = true;
			this.linkyoutube.Text = "YOUTUBE";
			this.linkyoutube.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkyoutubeLinkClicked);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(192, 19);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(158, 137);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			// 
			// linkwasap
			// 
			this.linkwasap.LinkColor = System.Drawing.Color.Green;
			this.linkwasap.Location = new System.Drawing.Point(36, 159);
			this.linkwasap.Name = "linkwasap";
			this.linkwasap.Size = new System.Drawing.Size(100, 23);
			this.linkwasap.TabIndex = 1;
			this.linkwasap.TabStop = true;
			this.linkwasap.Text = "WHATSHAP";
			this.linkwasap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkwasapLinkClicked);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(7, 19);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(152, 137);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// ventana3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(783, 432);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "ventana3";
			this.Text = "ventana3";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
