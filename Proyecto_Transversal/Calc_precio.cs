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
        
        // Precios que pueden cambiar
        private const int comida = 0;
        private const int manoobra = 0;
        private int numeropersonal = 0;
        private const int costodiseno = 0;
        
        // Otros
        private int area = 0;
        private int cantidadAserrin = 0;
        private int cantidadPintura = 0;
        private int cantidadLitroAgua = 0;
        private int cantidadKgFrutos = 0;

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
            CalculatePrices();
            Calculated calculatedForm = new Calculated(cantidadAserrin, cantidadPintura, cantidadLitroAgua, cantidadKgFrutos,area);
            OpenWindow(calculatedForm);
        }

        private void CalculatePrices()
        {
        	int bulto = 0, pinturaCant=0, aguaCant=0, frutosCant=0,altura=0,anchura=0;

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
        }

        private void OpenWindow(Form miniform)
        {
            this.Hide();
            miniform.Show();
            miniform.FormClosed += (s, args) => this.Show();
        }
    }
}