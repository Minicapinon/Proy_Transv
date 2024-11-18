/*
 * Created by SharpDevelop.
 * User: cc2-pc06
 * Date: 14/11/2024
 * Time: 03:16 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Proyecto_Transversal
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox OpenCalculator;
		private System.Windows.Forms.PictureBox ExitProgram;
		private System.Windows.Forms.Label lbltitle;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.OpenCalculator = new System.Windows.Forms.PictureBox();
			this.ExitProgram = new System.Windows.Forms.PictureBox();
			this.lbltitle = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.OpenCalculator)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ExitProgram)).BeginInit();
			this.SuspendLayout();
			// 
			// OpenCalculator
			// 
			this.OpenCalculator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpenCalculator.BackgroundImage")));
			this.OpenCalculator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.OpenCalculator.Location = new System.Drawing.Point(118, 390);
			this.OpenCalculator.MaximumSize = new System.Drawing.Size(175, 110);
			this.OpenCalculator.MinimumSize = new System.Drawing.Size(175, 110);
			this.OpenCalculator.Name = "OpenCalculator";
			this.OpenCalculator.Size = new System.Drawing.Size(175, 110);
			this.OpenCalculator.TabIndex = 0;
			this.OpenCalculator.TabStop = false;
			this.OpenCalculator.Click += new System.EventHandler(this.OpenCalculatorClick);
			// 
			// ExitProgram
			// 
			this.ExitProgram.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitProgram.BackgroundImage")));
			this.ExitProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ExitProgram.Location = new System.Drawing.Point(490, 390);
			this.ExitProgram.MaximumSize = new System.Drawing.Size(175, 110);
			this.ExitProgram.MinimumSize = new System.Drawing.Size(175, 110);
			this.ExitProgram.Name = "ExitProgram";
			this.ExitProgram.Size = new System.Drawing.Size(175, 110);
			this.ExitProgram.TabIndex = 1;
			this.ExitProgram.TabStop = false;
			this.ExitProgram.Click += new System.EventHandler(this.ExitProgramClick);
			// 
			// lbltitle
			// 
			this.lbltitle.Font = new System.Drawing.Font("JetBrainsMono NFM SemiBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbltitle.ForeColor = System.Drawing.Color.White;
			this.lbltitle.Location = new System.Drawing.Point(0, 60);
			this.lbltitle.Name = "lbltitle";
			this.lbltitle.Size = new System.Drawing.Size(795, 150);
			this.lbltitle.TabIndex = 2;
			this.lbltitle.Text = "¿Qué desea hacer?";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
			this.ClientSize = new System.Drawing.Size(778, 744);
			this.Controls.Add(this.lbltitle);
			this.Controls.Add(this.ExitProgram);
			this.Controls.Add(this.OpenCalculator);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(800, 800);
			this.MinimumSize = new System.Drawing.Size(800, 800);
			this.Name = "MainForm";
			this.Text = "Menu";
			((System.ComponentModel.ISupportInitialize)(this.OpenCalculator)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ExitProgram)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
