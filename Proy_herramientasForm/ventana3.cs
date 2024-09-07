using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proy_herramientasForm
{
	public partial class ventana3 : Form
	{
		public ventana3()
		{
			InitializeComponent();
			
		}
		void Btn_guardarClick(object sender, EventArgs e)
		{
			string nom=txt_nombre.Text;
			string ape=txt_apellidos.Text;
			//genero
			string genero;
			if(rbt_femenino.Checked)
				genero="Femenino";
			else
				genero="Masculino";
			//fecha de nacimiento
			DateTime fecha=dtp_fecha.Value;
			
			//Estudio
			int indice=cbbx_estudio.SelectedIndex;
			string estudio=cbbx_estudio.Items[indice].ToString();
			//tipo de trabajo
			string trabajo="";
			if(rbt_sinTrabajo.Checked)
				trabajo="sin trabajo";
			if(rbt_Indepep.Checked)
				trabajo="Independiente";
			if(rbt_asalariado.Checked)
				trabajo="Asalariado";
			//Mostrar
			lbl_datos.Text="Su nombre es "+nom+" "+ape+" de genero "+genero+" con fecha de nacimiento "
				+fecha.ToString()+" su nivel de estudio es "+estudio+" y trabajo "+trabajo;
			
		}
		void LinkwasapLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			linkwasap.LinkVisited=true;
			System.Diagnostics.Process.Start("https://web.whatsapp.com/");
			
		}
		void LinkyoutubeLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			linkyoutube.LinkVisited=true;
			System.Diagnostics.Process.Start("https://www.youtube.com/");
		}
		void LinkfacebookLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			linkfacebook.LinkVisited=true;
			System.Diagnostics.Process.Start("https://www.facebook.com/");
		}
		void Rbt_masculinoCheckedChanged(object sender, EventArgs e)
		{
	
		}
	
	}
}
