﻿/*
 * Created by CapinonMStudio.
 * User: CapinonM
 * Date: 14/11/2024
 * Time: 03:16 p. m.
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto_Transversal
{
	/// <summary>
	/// Ventana principal del proyecto transversal.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		// Muestra la ventana de cálculo de precios.
		void OpenCalculatorClick(object sender, EventArgs e)
		{
			OpenWindow(new Calc_precio());
		}
		
		// Cierra la aplicación
		void ExitProgramClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		// Abre el formulario de forma precavida
		private void OpenWindow(Form child)
		{
		    try
		    {
		        if (child == null) return;
		        this.Hide();
		        child.Show();
		        child.FormClosed += (s, args) => this.Show();
		    }
		    catch (Exception ex)
		    {
		        MessageBox.Show("Ocurrio un error: " + ex.Message);
		    }
		}
	}
}
