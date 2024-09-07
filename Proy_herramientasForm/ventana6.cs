/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 05/09/2024
 * Hora: 20:29
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proy_herramientasForm
{
	/// <summary>
	/// Description of ventana6.
	/// </summary>
	public partial class ventana6 : Form
	{
		public ventana6()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnPanel2Click(object sender, EventArgs e)
		{
			panel2.Visible=true;
		}
		void BtnPanel3Click(object sender, EventArgs e)
		{
			panel3.Visible=true;
		}
		void BtnVolverPanel1Click(object sender, EventArgs e)
		{
			panel2.Visible=false;
		}
		void BtnVolverPanel2Click(object sender, EventArgs e)
		{
			panel3.Visible=false;
		}
		
	}
}
