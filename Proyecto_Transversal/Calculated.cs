/*
 * Created by CapinonMStudio
 * User: angel
 * Date: 18/11/2024
 * version 5.1 of Sharpdevelop
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Transversal
{
	/// <summary>
	/// Muestra los precios calculados 
	/// </summary>
	public partial class Calculated : Form
	{
		public Calculated()
		{
			InitializeComponent();
		}
		
		void BtnRegresarClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
