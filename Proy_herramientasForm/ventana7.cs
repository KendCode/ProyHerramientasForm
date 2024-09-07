/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 05/09/2024
 * Hora: 21:03
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proy_herramientasForm
{
	/// <summary>
	/// Description of ventana7.
	/// </summary>
	public partial class ventana7 : Form
	{
		public ventana7()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnFuenteClick(object sender, EventArgs e)
		{
			if(fontTexto.ShowDialog()==DialogResult.OK){
				lblTexto.Font = fontTexto.Font;
			}
		}
		
	}
}
