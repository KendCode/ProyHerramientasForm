
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proy_herramientasForm
{
	
	public partial class Ventana2 : Form
	{
		public Ventana2()
		{
	
			InitializeComponent();
			
		}
		void Btn_agregarClick(object sender, EventArgs e)
		{
			String nom=txt_nombre.Text;
			cbB_Nombres.Items.Add(nom);
			txt_nombre.Clear();
			txt_nombre.Focus();
		}
		void Btn_numeroClick(object sender, EventArgs e)
		{
			try{
				int num=int.Parse(txt_numero.Text);
				lB_numeros.Items.Add(num);
			}
			catch(Exception){
				MessageBox.Show("error no se puede ingresar string");
			}
			finally{
				txt_numero.Clear();
				txt_numero.Focus();
			}
			
		}
		void Btn_posicionClick(object sender, EventArgs e)
		{
			try{
				short pos=Convert.ToInt16(txt_numero.Text);
				if(pos>lB_numeros.Items.Count)
					MessageBox.Show("la posicion ingresada no existe");
				else{
					String valor=lB_numeros.Items[pos-1].ToString();
					MessageBox.Show("el valor es "+valor);
				}
			
			}
			catch(Exception x){
				MessageBox.Show("Error ingrese un numero entero"+ x.Message);
			}
			finally{
				txt_numero.Clear();
				txt_numero.Focus();
			}
			
		}
		
	}
}
