/*
 * Created by CapinonMStudio.
 * User: CapinonM
 * Date: 14/11/2024
 * Time: 03:16 p. m.
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
        private int _aserrin = 0;
        private int _pintura = 0;
        private int _litroagua = 0;
        private int _kgfrutos = 0;
		private int _area = 0;
		private int _numerodepersonal = 0;
		private int _diseno = 0;
        private int _mano = 0;
        private int _flores = 0;
        private int _comida = 0;

        public Calculated(int aserrin, int pintura, int litroagua, int kgfrutos, int area, int numeropersonal, int costototdiseno, int costototmano, int floresdecenas, int costocomida)
        {
            InitializeComponent();
			// Se cargan los valores
            _aserrin = aserrin;
            _pintura = pintura;
            _litroagua = litroagua;
            _kgfrutos = kgfrutos;
			_area = area;
			_numerodepersonal = numeropersonal;
			_diseno = costototdiseno;
            _mano = costototmano;
            _flores = floresdecenas;
            _comida = costocomida;
            ShowValues();
            UpdatePrice();
        }

        private void ShowValues()
        {
            // Se muestran los valores
			LblTamano.Text = _area.ToString();
            LblAserrin.Text = "$" + _aserrin.ToString();
            LblPintura.Text = "$" + _pintura.ToString();
            LblAgua.Text = "$" + _litroagua.ToString();
            LblFrutos.Text = "$" + _kgfrutos.ToString();
			LblPersonal.Text = _numerodepersonal.ToString();
			LblDiseno.Text = "$" + _diseno.ToString();
            LblObra.Text = "$" + _mano.ToString();
            LblFlores.Text = "$" + _flores.ToString();
            LblComida.Text = "$" + _comida.ToString();
        }

        //Muestra el costo total
        private void UpdatePrice()
        {
            int suma = _aserrin + _pintura + _litroagua + _kgfrutos + _diseno + _mano + _flores + _comida;
            lblPrecio.Text = suma.ToString();
        }

        void BtnRegresarClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}