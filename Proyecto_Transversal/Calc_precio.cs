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
	/// Calculadora de Precios
	/// </summary>
	public partial class Calc_precio : Form
	{
		public Calc_precio()
		{
			InitializeComponent();
		}
		
		void BtnCleanClick(object sender, EventArgs e)
		{
			CleanTextBox();
		}
		
		private void CleanTextBox()
		{
			TxtBoxAltura.Texts = "";
			TxtBoxAnchura.Texts = "";
			TxtBoxAgua.Texts = "";
			TxtBoxBulto.Texts = "";
			TxtBoxDisenoCosto.Texts = "";
			TxtBoxPersonal.Texts = "";
			TxtBoxFrutos.Texts = "";
			TxtBoxDecenas.Texts = "";
			TxtBoxComida.Texts = "";
			TxtBoxObraHoras.Texts = "";
			TxtBoxObraCosto.Texts = "";
			TxtBoxDisenoHoras.Texts = "";
			TxtBoxPintura.Texts = "";
		}
		
		void BtnRegresarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void BtnVerPreciosClick(object sender, EventArgs e)
		{
			//
		}
		void BtnCalcularClick(object sender, EventArgs e)
		{
			OpenWindow(new Calculated());
		}

		private void OpenWindow(Form child)
		{
			if(child == null) return;
			this.Hide();
            child.Show();
            child.FormClosed += (s, args) => this.Show();
		}
	}
}
