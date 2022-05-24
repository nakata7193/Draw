using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
	[Serializable]
    internal class examShape :Shape
    {
		public examShape(RectangleF rect) : base(rect)
		{
		}

		public examShape(RectangleShape rectangle) : base(rectangle)
		{
		}
		public override void DrawSelf(Graphics grfx)
		{
			base.DrawSelf(grfx);

			grfx.FillRectangle(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Height, Rectangle.Width);
			grfx.DrawRectangle(Pens.Black, Rectangle.X, Rectangle.Y, Rectangle.Height, Rectangle.Width);

			grfx.DrawLine(Pens.Black, Rectangle.X, Rectangle.Y + 50, Rectangle.X + 200, Rectangle.Y + 50);
			grfx.DrawLine(Pens.Black, Rectangle.X, Rectangle.Y + 50, Rectangle.X + 100, Rectangle.Y + 50);
			grfx.DrawLine(Pens.Black, Rectangle.X + 100, Rectangle.Y + 50, Rectangle.X + 100, Rectangle.Y + 100);
		}
		public override bool Contains(PointF point)
		{
			if (base.Contains(point))
				// Проверка дали е в обекта само, ако точката е в обхващащия правоъгълник.
				// В случая на правоъгълник - директно връщаме true
				return true;
			else
				// Ако не е в обхващащия правоъгълник, то неможе да е в обекта и => false
				return false;
		}
	}
}
