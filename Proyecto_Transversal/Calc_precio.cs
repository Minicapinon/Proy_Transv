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
    /// Calculadora de Precios
    /// </summary>
    public partial class Calc_precio : Form
    {
        public Calc_precio()
        {
            InitializeComponent();
        }
        
        // Precios en mxn
        private const int aserrin = 150;
        private const int pintura = 125;
        private const int litroagua = 15;
        private const int kgfrutos= 160;
        private const int decflores = 120;
        
        // Precios que pueden cambiar
        private int comida = 0;
        private int manoobra = 0;
        private int numeropersonal = 0;
        
        // Otros
        private int area = 0;
        private int cantidadAserrin = 0;
        private int cantidadPintura = 0;
        private int cantidadLitroAgua = 0;
        private int cantidadKgFrutos = 0;
        private int costototdisen = 0;
        private int costototmano = 0;
        private int floresdecenas = 0;

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
        	ListPrices prices = new ListPrices();
        	OpenWindow(prices);
        }

        void BtnCalcularClick(object sender, EventArgs e)
        {
			UpdateValues();
            CalculatePrices();
            Calculated calculatedForm = new Calculated(cantidadAserrin, cantidadPintura, cantidadLitroAgua, cantidadKgFrutos, area, numeropersonal, costototdisen, costototmano, floresdecenas, comida);
            OpenWindow(calculatedForm);
        }

        // Actualiza los precios que pueden cambiar
		private void UpdateValues()
		{
            int costocomida = 0;
			if(int.TryParse(TxtBoxPersonal.Texts, out numeropersonal) && int.TryParse(TxtBoxComida.Texts, out costocomida))
            {
                comida = numeropersonal * costocomida;
            }
			
			int disehoras = 0;
			if(int.TryParse(TxtBoxDisenoCosto.Texts, out manoobra) && int.TryParse(TxtBoxDisenoHoras.Texts, out disehoras))
			{
				costototdisen = manoobra * disehoras;
			}

            int Obracosto = 0;
            int Obrahora = 0;
            if(int.TryParse(TxtBoxObraCosto.Texts, out Obracosto) && int.TryParse(TxtBoxObraHoras.Texts, out Obrahora))
            {
                costototmano = Obracosto * Obrahora;
            }
		}

        // Calcula los precios
        private void CalculatePrices()
        {
        	int bulto = 0, pinturaCant=0, aguaCant=0, frutosCant=0,altura=0,anchura=0, flores = 0;

        	if(int.TryParse(TxtBoxBulto.Texts, out bulto))
            {
                cantidadAserrin = aserrin * bulto;
            }
        	if(int.TryParse(TxtBoxPintura.Texts, out pinturaCant))
            {
                cantidadPintura = pintura * pinturaCant;
            }
        	if(int.TryParse(TxtBoxAgua.Texts, out aguaCant))
            {
                cantidadLitroAgua = litroagua * aguaCant;
            }
        	if(int.TryParse(TxtBoxFrutos.Texts, out frutosCant))
            {
                cantidadKgFrutos = kgfrutos * frutosCant;
            }
        	if(int.TryParse(TxtBoxAltura.Texts, out altura) && int.TryParse(TxtBoxAnchura.Texts, out anchura))
            {
                area = altura * anchura;
            }
        	if(int.TryParse(TxtBoxDecenas.Texts, out flores))
            {
                floresdecenas = flores * decflores;
            }
        }

        private void OpenWindow(Form miniform)
        {
            this.Hide();
            miniform.Show();
            miniform.FormClosed += (s, args) => this.Show();
        }
    }
}