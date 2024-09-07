using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proy_herramientasForm
{
	public partial class Ventana4 : Form
	{
		public Ventana4()
		{
			InitializeComponent();
		}
		void Btn_adicionarClick(object sender, EventArgs e)
		{
			if(txt_escritorio.Text.Equals(""))
				MessageBox.Show("Debe ingresar un material de escritorio");
			else
				clbx_escritorio.Items.Add(txt_escritorio.Text);
			txt_escritorio.Clear();
			txt_escritorio.Focus();
		}
		void Clbx_escritorioSelectedIndexChanged(object sender, EventArgs e)
		{
			int indice=clbx_escritorio.SelectedIndex;
			//if(indice!=-1){
			lbl_escritorio.Text=clbx_escritorio.Items[indice].ToString();
			if(clbx_escritorio.GetItemChecked(2)==true)
				MessageBox.Show("Material seleccionado es lápiz");
		}
		void DupMarcasSelectedItemChanged(object sender, EventArgs e)
		{
			string auto = (string)dupMarcas.SelectedItem;
			lblMarca.Text = string.Format("Seleciono la marca {0} como favorito",auto);
		}
		void BtnMarcasClick(object sender, EventArgs e)
		{
			if(txtMarcas.Text != "")
				dupMarcas.Items.Add(txtMarcas.Text);
			else
				MessageBox.Show("Debe ingresar una marca de automovil");
			txtMarcas.Clear();
			txtMarcas.Focus();
		}
		void BtnEliminarClick(object sender, EventArgs e)
		{
			//selecionamos el indice 
			try{
			int indice = dupMarcas.SelectedIndex;
			dupMarcas.Items.RemoveAt(indice);
			dupMarcas.SelectedIndex = 0;
			}
			catch(Exception){
				MessageBox.Show("Existio un error");
			}
		}
		void Button1Click(object sender, EventArgs e)
		{
			// se recuperas de dato dacimal hay q convetir
			int d = Convert.ToInt32(nupDia.Value);
			switch(d){
				case 1:
					lblDias.Text = "Lunes";
					break;
				case 2:
					lblDias.Text = "Martes";
					break;
				case 3:
					lblDias.Text = "Miercoles";
					break;
				case 4:
					lblDias.Text = "Jeuves";
					break;
				case 5:
					lblDias.Text = "Viernes";
					break;
				case 6:
					lblDias.Text = "Sabado";
					break;
				case 7:
					lblDias.Text = "Domingo";
					break;
			}
		}
		void TxtNumeroKeyPress(object sender, KeyPressEventArgs e)
		{
			if((e.KeyChar >= 32 && e.KeyChar <= 47)  || (e.KeyChar >=58 && e.KeyChar <= 255)){
				MessageBox.Show("Error debe introducir un numeros...");
				e.Handled = true;
				return;
			}
			else{
				lblNumero.Text = txtNumero.Text;
			}
		}
		void Txt_escritorioTextChanged(object sender, EventArgs e)
		{
	
		}
		void Txt_escritorioKeyPress(object sender, KeyPressEventArgs e)
		{
			if((e.KeyChar >= 32 && e.KeyChar <= 64)  || (e.KeyChar >=91 && e.KeyChar <= 96)){
				MessageBox.Show("Error debe introducir latras...");
				e.Handled = true;
				return;
			}
			else{
				lbl_escritorio.Text = txt_escritorio.Text;
			}
		}
		void NupDiaValueChanged(object sender, EventArgs e)
		{
	
		}
		void Btn_ProcesarClick(object sender, EventArgs e)
		{
			bool error = false;
			foreach(char caracter in txt_Cadena.Text){
				if(char.IsDigit(caracter)){
					error = true;
					break;
				}
			}
			//verificamos la condicion de error
			if(error){
				error_Cadena.SetError(txt_Cadena,"No se admite numeros ");
			}
			else{
				error_Cadena.Clear();
			}
		}
		void Txt_CadenaTextChanged(object sender, EventArgs e)
		{
			bool error = false;
			foreach(char caracter in txt_Cadena.Text){
				if(char.IsDigit(caracter)){
					error = true;
					break;
				}
			}
			//verificamos la condicion de error
			if(error){
				error_Cadena.SetError(txt_Cadena,"No se admite numeros ");
			}
			else{
				error_Cadena.Clear();
			}
		}
		}
	
	}

