/*
 * Created by SharpDevelop.
 * User: cc2-pc06
 * Date: 20/11/2024
 * Time: 02:20 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Proyecto_Transversal
{
	partial class ListPrices
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbltitle;
		private System.Windows.Forms.PictureBox BtnRegresar;
		private Proyecto_Transversal.CustomLabel LblAgua;
		private Proyecto_Transversal.CustomLabel LblFlores;
		private Proyecto_Transversal.CustomLabel LblFrutos;
		private Proyecto_Transversal.CustomLabel LblPintura;
		private Proyecto_Transversal.CustomLabel LblAserrin;
		private Proyecto_Transversal.CustomLabel customLabel8;
		private Proyecto_Transversal.CustomLabel customLabel9;
		private Proyecto_Transversal.CustomLabel customLabel10;
		private Proyecto_Transversal.CustomLabel customLabel3;
		private Proyecto_Transversal.CustomLabel customLabel2;
		private Proyecto_Transversal.CustomButton BtnInfo;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListPrices));
			this.lbltitle = new System.Windows.Forms.Label();
			this.BtnRegresar = new System.Windows.Forms.PictureBox();
			this.LblAgua = new Proyecto_Transversal.CustomLabel();
			this.LblFlores = new Proyecto_Transversal.CustomLabel();
			this.LblFrutos = new Proyecto_Transversal.CustomLabel();
			this.LblPintura = new Proyecto_Transversal.CustomLabel();
			this.LblAserrin = new Proyecto_Transversal.CustomLabel();
			this.customLabel8 = new Proyecto_Transversal.CustomLabel();
			this.customLabel9 = new Proyecto_Transversal.CustomLabel();
			this.customLabel10 = new Proyecto_Transversal.CustomLabel();
			this.customLabel3 = new Proyecto_Transversal.CustomLabel();
			this.customLabel2 = new Proyecto_Transversal.CustomLabel();
			this.BtnInfo = new Proyecto_Transversal.CustomButton();
			((System.ComponentModel.ISupportInitialize)(this.BtnRegresar)).BeginInit();
			this.SuspendLayout();
			// 
			// lbltitle
			// 
			this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbltitle.ForeColor = System.Drawing.Color.White;
			this.lbltitle.Location = new System.Drawing.Point(0, 65);
			this.lbltitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbltitle.Name = "lbltitle";
			this.lbltitle.Size = new System.Drawing.Size(467, 71);
			this.lbltitle.TabIndex = 4;
			this.lbltitle.Text = "Listar Precios";
			// 
			// BtnRegresar
			// 
			this.BtnRegresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegresar.BackgroundImage")));
			this.BtnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.BtnRegresar.Location = new System.Drawing.Point(545, 65);
			this.BtnRegresar.Margin = new System.Windows.Forms.Padding(2);
			this.BtnRegresar.MaximumSize = new System.Drawing.Size(73, 52);
			this.BtnRegresar.MinimumSize = new System.Drawing.Size(73, 52);
			this.BtnRegresar.Name = "BtnRegresar";
			this.BtnRegresar.Size = new System.Drawing.Size(73, 52);
			this.BtnRegresar.TabIndex = 31;
			this.BtnRegresar.TabStop = false;
			this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// LblAgua
			// 
			this.LblAgua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(2)))), ((int)(((byte)(34)))));
			this.LblAgua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(2)))), ((int)(((byte)(34)))));
			this.LblAgua.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.LblAgua.BorderRadius = 26;
			this.LblAgua.BorderSize = 0;
			this.LblAgua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(82)))), ((int)(((byte)(119)))));
			this.LblAgua.Location = new System.Drawing.Point(420, 250);
			this.LblAgua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblAgua.MaximumSize = new System.Drawing.Size(100, 26);
			this.LblAgua.MinimumSize = new System.Drawing.Size(100, 26);
			this.LblAgua.Name = "LblAgua";
			this.LblAgua.Size = new System.Drawing.Size(100, 26);
			this.LblAgua.TabIndex = 71;
			this.LblAgua.Text = "$15";
			this.LblAgua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.LblAgua.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(82)))), ((int)(((byte)(119)))));
			// 
			// LblFlores
			// 
			this.LblFlores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(2)))), ((int)(((byte)(34)))));
			this.LblFlores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(2)))), ((int)(((byte)(34)))));
			this.LblFlores.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.LblFlores.BorderRadius = 26;
			this.LblFlores.BorderSize = 0;
			this.LblFlores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(82)))), ((int)(((byte)(119)))));
			this.LblFlores.Location = new System.Drawing.Point(420, 204);
			this.LblFlores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblFlores.MaximumSize = new System.Drawing.Size(100, 26);
			this.LblFlores.MinimumSize = new System.Drawing.Size(100, 26);
			this.LblFlores.Name = "LblFlores";
			this.LblFlores.Size = new System.Drawing.Size(100, 26);
			this.LblFlores.TabIndex = 70;
			this.LblFlores.Text = "$120";
			this.LblFlores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.LblFlores.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(82)))), ((int)(((byte)(119)))));
			// 
			// LblFrutos
			// 
			this.LblFrutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(2)))), ((int)(((byte)(34)))));
			this.LblFrutos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(2)))), ((int)(((byte)(34)))));
			this.LblFrutos.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.LblFrutos.BorderRadius = 26;
			this.LblFrutos.BorderSize = 0;
			this.LblFrutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(82)))), ((int)(((byte)(119)))));
			this.LblFrutos.Location = new System.Drawing.Point(175, 301);
			this.LblFrutos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblFrutos.MaximumSize = new System.Drawing.Size(100, 26);
			this.LblFrutos.MinimumSize = new System.Drawing.Size(100, 26);
			this.LblFrutos.Name = "LblFrutos";
			this.LblFrutos.Size = new System.Drawing.Size(100, 26);
			this.LblFrutos.TabIndex = 69;
			this.LblFrutos.Text = "$160";
			this.LblFrutos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.LblFrutos.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(82)))), ((int)(((byte)(119)))));
			// 
			// LblPintura
			// 
			this.LblPintura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(2)))), ((int)(((byte)(34)))));
			this.LblPintura.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(2)))), ((int)(((byte)(34)))));
			this.LblPintura.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.LblPintura.BorderRadius = 26;
			this.LblPintura.BorderSize = 0;
			this.LblPintura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(82)))), ((int)(((byte)(119)))));
			this.LblPintura.Location = new System.Drawing.Point(175, 250);
			this.LblPintura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblPintura.MaximumSize = new System.Drawing.Size(100, 26);
			this.LblPintura.MinimumSize = new System.Drawing.Size(100, 26);
			this.LblPintura.Name = "LblPintura";
			this.LblPintura.Size = new System.Drawing.Size(100, 26);
			this.LblPintura.TabIndex = 66;
			this.LblPintura.Text = "$125";
			this.LblPintura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.LblPintura.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(82)))), ((int)(((byte)(119)))));
			// 
			// LblAserrin
			// 
			this.LblAserrin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(2)))), ((int)(((byte)(34)))));
			this.LblAserrin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(2)))), ((int)(((byte)(34)))));
			this.LblAserrin.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.LblAserrin.BorderRadius = 26;
			this.LblAserrin.BorderSize = 0;
			this.LblAserrin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(82)))), ((int)(((byte)(119)))));
			this.LblAserrin.Location = new System.Drawing.Point(175, 204);
			this.LblAserrin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblAserrin.MaximumSize = new System.Drawing.Size(100, 26);
			this.LblAserrin.MinimumSize = new System.Drawing.Size(100, 26);
			this.LblAserrin.Name = "LblAserrin";
			this.LblAserrin.Size = new System.Drawing.Size(100, 26);
			this.LblAserrin.TabIndex = 65;
			this.LblAserrin.Text = "$150";
			this.LblAserrin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.LblAserrin.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(82)))), ((int)(((byte)(119)))));
			// 
			// customLabel8
			// 
			this.customLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(2)))), ((int)(((byte)(34)))));
			this.customLabel8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(2)))), ((int)(((byte)(34)))));
			this.customLabel8.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.customLabel8.BorderRadius = 26;
			this.customLabel8.BorderSize = 0;
			this.customLabel8.ForeColor = System.Drawing.Color.White;
			this.customLabel8.Location = new System.Drawing.Point(304, 250);
			this.customLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.customLabel8.MaximumSize = new System.Drawing.Size(100, 26);
			this.customLabel8.MinimumSize = new System.Drawing.Size(100, 26);
			this.customLabel8.Name = "customLabel8";
			this.customLabel8.Size = new System.Drawing.Size(100, 26);
			this.customLabel8.TabIndex = 61;
			this.customLabel8.Text = "Agua";
			this.customLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.customLabel8.TextColor = System.Drawing.Color.White;
			// 
			// customLabel9
			// 
			this.customLabel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(2)))), ((int)(((byte)(34)))));
			this.customLabel9.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(2)))), ((int)(((byte)(34)))));
			this.customLabel9.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.customLabel9.BorderRadius = 26;
			this.customLabel9.BorderSize = 0;
			this.customLabel9.ForeColor = System.Drawing.Color.White;
			this.customLabel9.Location = new System.Drawing.Point(304, 204);
			this.customLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.customLabel9.MaximumSize = new System.Drawing.Size(100, 26);
			this.customLabel9.MinimumSize = new System.Drawing.Size(100, 26);
			this.customLabel9.Name = "customLabel9";
			this.customLabel9.Size = new System.Drawing.Size(100, 26);
			this.customLabel9.TabIndex = 60;
			this.customLabel9.Text = "Flores";
			this.customLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.customLabel9.TextColor = System.Drawing.Color.White;
			// 
			// customLabel10
			// 
			this.customLabel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(2)))), ((int)(((byte)(34)))));
			this.customLabel10.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(2)))), ((int)(((byte)(34)))));
			this.customLabel10.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.customLabel10.BorderRadius = 26;
			this.customLabel10.BorderSize = 0;
			this.customLabel10.ForeColor = System.Drawing.Color.White;
			this.customLabel10.Location = new System.Drawing.Point(60, 301);
			this.customLabel10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.customLabel10.MaximumSize = new System.Drawing.Size(100, 26);
			this.customLabel10.MinimumSize = new System.Drawing.Size(100, 26);
			this.customLabel10.Name = "customLabel10";
			this.customLabel10.Size = new System.Drawing.Size(100, 26);
			this.customLabel10.TabIndex = 59;
			this.customLabel10.Text = "Frutos secos";
			this.customLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.customLabel10.TextColor = System.Drawing.Color.White;
			// 
			// customLabel3
			// 
			this.customLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(2)))), ((int)(((byte)(34)))));
			this.customLabel3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(2)))), ((int)(((byte)(34)))));
			this.customLabel3.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.customLabel3.BorderRadius = 26;
			this.customLabel3.BorderSize = 0;
			this.customLabel3.ForeColor = System.Drawing.Color.White;
			this.customLabel3.Location = new System.Drawing.Point(63, 250);
			this.customLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.customLabel3.MaximumSize = new System.Drawing.Size(100, 26);
			this.customLabel3.MinimumSize = new System.Drawing.Size(100, 26);
			this.customLabel3.Name = "customLabel3";
			this.customLabel3.Size = new System.Drawing.Size(100, 26);
			this.customLabel3.TabIndex = 56;
			this.customLabel3.Text = "Pintura";
			this.customLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.customLabel3.TextColor = System.Drawing.Color.White;
			// 
			// customLabel2
			// 
			this.customLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(2)))), ((int)(((byte)(34)))));
			this.customLabel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(2)))), ((int)(((byte)(34)))));
			this.customLabel2.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.customLabel2.BorderRadius = 26;
			this.customLabel2.BorderSize = 0;
			this.customLabel2.ForeColor = System.Drawing.Color.White;
			this.customLabel2.Location = new System.Drawing.Point(63, 204);
			this.customLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.customLabel2.MaximumSize = new System.Drawing.Size(100, 26);
			this.customLabel2.MinimumSize = new System.Drawing.Size(100, 26);
			this.customLabel2.Name = "customLabel2";
			this.customLabel2.Size = new System.Drawing.Size(100, 26);
			this.customLabel2.TabIndex = 55;
			this.customLabel2.Text = "Aserrín";
			this.customLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.customLabel2.TextColor = System.Drawing.Color.White;
			// 
			// BtnInfo
			// 
			this.BtnInfo.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.BtnInfo.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
			this.BtnInfo.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.BtnInfo.BorderRadius = 20;
			this.BtnInfo.BorderSize = 0;
			this.BtnInfo.FlatAppearance.BorderSize = 0;
			this.BtnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnInfo.ForeColor = System.Drawing.Color.White;
			this.BtnInfo.Location = new System.Drawing.Point(545, 440);
			this.BtnInfo.Margin = new System.Windows.Forms.Padding(2);
			this.BtnInfo.MaximumSize = new System.Drawing.Size(73, 52);
			this.BtnInfo.MinimumSize = new System.Drawing.Size(73, 52);
			this.BtnInfo.Name = "BtnInfo";
			this.BtnInfo.Size = new System.Drawing.Size(73, 52);
			this.BtnInfo.TabIndex = 74;
			this.BtnInfo.Text = "Informacion";
			this.BtnInfo.TextColor = System.Drawing.Color.White;
			this.BtnInfo.UseVisualStyleBackColor = false;
			this.BtnInfo.Click += new System.EventHandler(this.BtnInfoClick);
			// 
			// ListPrices
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
			this.ClientSize = new System.Drawing.Size(684, 561);
			this.Controls.Add(this.BtnInfo);
			this.Controls.Add(this.LblAgua);
			this.Controls.Add(this.LblFlores);
			this.Controls.Add(this.LblFrutos);
			this.Controls.Add(this.LblPintura);
			this.Controls.Add(this.LblAserrin);
			this.Controls.Add(this.customLabel8);
			this.Controls.Add(this.customLabel9);
			this.Controls.Add(this.customLabel10);
			this.Controls.Add(this.customLabel3);
			this.Controls.Add(this.customLabel2);
			this.Controls.Add(this.BtnRegresar);
			this.Controls.Add(this.lbltitle);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(700, 600);
			this.MinimumSize = new System.Drawing.Size(700, 600);
			this.Name = "ListPrices";
			this.Text = "Listar Precios";
			((System.ComponentModel.ISupportInitialize)(this.BtnRegresar)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
