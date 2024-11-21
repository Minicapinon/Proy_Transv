/*
 * Created by CapinonMStudio.
 * User: CapinonM
 * Date: 14/11/2024
 * Time: 03:16 p. m.
 */
using System;
using System.Windows.Forms;

namespace Proyecto_Transversal
{
	/// <summary>
	/// Solo muestra los precios.
	/// </summary>
	public partial class ListPrices : Form
	{
		public ListPrices()
		{
			InitializeComponent();
		}
		void BtnRegresarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void BtnInfoClick(object sender, EventArgs e)
		{
			Message4user();
		}
		
		// Muestra la informacion al usuario
		private void Message4user()
		{
			const string title = "Información de precios";
			MessageBox.Show("Los demás precios no se listaron ya que pueden variar", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}