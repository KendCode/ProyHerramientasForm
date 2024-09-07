using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Proy_herramientasForm
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void Btn_mostrarClick(object sender, EventArgs e)
		{
			if(rbt_1A.Checked)
				label_MostrarCurso.Text = "1er Año";
			if(rbt_2A.Checked)
				label_MostrarCurso.Text = "2do Año";
			if(rbt_3A.Checked)
				label_MostrarCurso.Text = "3er Año";
		}
		void Btn_idiomaClick(object sender, EventArgs e)
		{
			string idiomaSeleccionado="";
			if(cbx_castellano.Checked)
				idiomaSeleccionado+="Castellano  ";
				//lbl_MostrarIdiomas.Text = "CASTELLANO";
			if(cbx_ingles.Checked)
				idiomaSeleccionado+="Ingles  ";
				//lbl_MostrarIdiomas.Text = "INGLES" +"";
			if(cbx_otro.Checked){
				idiomaSeleccionado=" ";
				idiomaSeleccionado+="Otros  ";
			}
				
				//lbl_MostrarIdiomas.Text = "OTROS";
			//if(cbx_castellano.Checked && cbx_ingles.Checked)
				//lbl_MostrarIdiomas.Text = "CASTELLANO - INGLES";
			lbl_MostrarIdiomas.Text=idiomaSeleccionado;
		}
		void Btn_ventana2Click(object sender, EventArgs e)
		{
			Ventana2 v2=new Ventana2();//se esta instanciando un nuevo objeto de ventana2
			this.Hide();//es para ocultar la primera ventana o la ventana actual antes de mostrar la segunda ventana
			v2.ShowDialog();//mostrar el nuevo formulario(ventana 2)
			this.Show();//mostrar el formulario el primer formulario otra vez luego de cerrar el segundo formulario
		}
		void Ventana2ToolStripMenuItemClick(object sender, EventArgs e)
		{
			Ventana2 v2=new Ventana2();
			this.Hide();
			v2.ShowDialog();
			this.Show();
		}
		void Ventana3ToolStripMenuItemClick(object sender, EventArgs e)
		{
			ventana3 v3=new ventana3();
			this.Hide();
			v3.ShowDialog();
			this.Show();
		}
		
	}
}
