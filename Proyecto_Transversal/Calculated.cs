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
        private int _aserrin;
        private int _pintura;
        private int _litroagua;
        private int _kgfrutos;
		private int _area;

        public Calculated(int aserrin, int pintura, int litroagua, int kgfrutos, int area)
        {
            InitializeComponent();
			// Se cargan los valores
            _aserrin = aserrin;
            _pintura = pintura;
            _litroagua = litroagua;
            _kgfrutos = kgfrutos;
			_area = area;
            ShowValues();
        }

        private void ShowValues()
        {
            // Se muestran los valores
			LblTamano.Text = _area.ToString();
            LblAserrin.Text = "$" + _aserrin.ToString();
            LblPintura.Text = "$" + _pintura.ToString();
            LblAgua.Text = "$" + _litroagua.ToString();
            LblFrutos.Text = "$" + _kgfrutos.ToString();
        }

        void BtnRegresarClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}