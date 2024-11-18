﻿	/*
 * Created by CapinonMStudio
 * User: angel
 * Date: 01/11/2024
 * version 5.1 of Sharpdevelop
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Proyecto_Transversal
{
	/// <summary>
	/// </summary>
	public class CustomButton : Button
	{
		// Field
		private int _borderSize = 0;
		private int _borderRadius = 40;
		private Color _borderColor = Color.PaleVioletRed;

		[Category("Boton personalizado")]
		public int BorderSize
		{
			get { return _borderSize; }
			set
			{
				_borderSize = value;
				this.Invalidate();
			}
		}

		[Category("Boton personalizado")]
		public int BorderRadius
		{
			get { return _borderRadius; }
			set
			{
				_borderRadius = value;
				this.Invalidate();
			}
		}

		[Category("Boton personalizado")]
		public Color BorderColor
		{
			get { return _borderColor; }
			set
			{
				_borderColor = value;
				this.Invalidate();
			}
		}

		[Category("Boton personalizado")]
		public Color BackgroundColor
		{
			get { return this.BackColor; }
			set { this.BackColor = value; }
		}

		[Category("Boton personalizado")]
		public Color TextColor
		{
			get { return this.ForeColor; }
			set { this.ForeColor = value; }
		}
		
		// Constructor
		public CustomButton()
		{
			this.FlatStyle = FlatStyle.Flat;
			this.FlatAppearance.BorderSize = 0;
			this.Size = new Size(150, 40);
			this.BackColor = Color.MediumSlateBlue;
			this.ForeColor = Color.White;
			this.Resize += new EventHandler(Button_Resize);
		}

		private void Button_Resize(object sender, EventArgs e)
		{
			if(_borderRadius>this.Height)
				BorderRadius=this.Height;
		}

		// Methods
		private GraphicsPath GetFigurePath(RectangleF rect, float radius)
		{
			GraphicsPath path = new GraphicsPath();
			path.StartFigure();
			path.AddArc(rect.X,rect.Y, radius, radius, 180,90);
			path.AddArc(rect.Width-radius,rect.Y, radius, radius, 270,90);
			path.AddArc(rect.Width-radius,rect.Height-radius, radius, radius, 0,90);
			path.AddArc(rect.X,rect.Height - radius, radius, radius, 90,90);
			path.CloseFigure();

			return path;
		}

		protected override void OnPaint(PaintEventArgs pevent)
		{
			base.OnPaint(pevent);
			pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

			RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
			RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

			if (_borderRadius > 2) //Rounded Button
			{
				using (GraphicsPath pathSurface = GetFigurePath(rectSurface, _borderRadius))
				using (GraphicsPath pathBorder = GetFigurePath(rectBorder, _borderRadius - 1F))
				using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
				using (Pen penBorder = new Pen(_borderColor, _borderSize))
				{
					penBorder.Alignment = PenAlignment.Inset;
					// Button surface
					this.Region = new Region(pathSurface);
					
					// Draw surface border for HD result
					pevent.Graphics.DrawPath(penSurface, pathBorder);

					// Draw control border
					if (_borderSize >= 1)
					{
						pevent.Graphics.DrawPath(penBorder, pathBorder);
					}
				}
			}
			else //Normal Button
			{
				this.Region = new Region(rectSurface);
				if (_borderSize >= 1)
				{
					using (Pen penBorder = new Pen(_borderColor, _borderSize))
					{
						penBorder.Alignment = PenAlignment.Inset;
						pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
					}
				}
			}
		}

		protected override void OnHandleCreated(EventArgs e)
		{
			base.OnHandleCreated(e);
			this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
		}

		private void Container_BackColorChanged(object sender, EventArgs e)
		{
			if(this.DesignMode)
			{
				this.Invalidate();
			}
		}
	}
}