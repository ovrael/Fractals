using System.Drawing;

namespace Fractals.Utilities
{
	class GraphicsHelper
	{
		public static float Map(float value, float minValue, float maxValue, float newMinValue, float newMaxValue)
		{
			return newMinValue + (newMaxValue - newMinValue) * ((value - minValue) / (maxValue - minValue));
		}

		public static void PutPixel(Graphics drawing, SolidBrush brush, float x, float y)
		{
			drawing.FillRectangle(brush, x, y, 1, 1);
		}

		public static void DrawCircle(Graphics drawing, Pen pen, float x, float y, float size)
		{
			drawing.DrawEllipse(pen, x, y, size, size);
		}
		public static void DrawCircleInXY(Graphics drawing, Pen pen, float x, float y, float size)
		{
			int correct = (int)size / 2;
			drawing.DrawEllipse(pen, x - correct, y - correct, size, size);
		}
		public static void DrawBigPoint(Graphics drawing, SolidBrush fill, float x, float y, float size)
		{
			drawing.FillEllipse(fill, x, y, size, size);
		}
		public static void DrawBigPointInXY(Graphics drawing, SolidBrush fill, float x, float y, float size)
		{
			int correct = (int)size / 2;
			drawing.FillEllipse(fill, x - correct, y - correct, size, size);
		}
	}
}
