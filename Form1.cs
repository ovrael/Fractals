using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fractals.Utilities;


namespace Fractals
{
	public partial class Form1 : Form
	{
		Thread graphThread;         // Thread that uses Draw method and draws objects
		Graphics drawing;           // Graphics object for drawing
		Graphics background;        // Graphics object for background
		Bitmap backgroundBitmap;    // Bitmap used as clearing canvas

		// Brushes
		Pen linePen = new Pen(Color.FromArgb(100, Color.White), 1);

		// Brushes
		SolidBrush pixelBrush = new SolidBrush(Color.FromArgb(0, 0, 0, 0));

		// Window size
		static int width = 1200;
		static int height = 900;

		// Data
		static float minX = -width / 2;
		static float minY = -height / 2;
		static float maxX = width / 2;
		static float maxY = height / 2;
		static float minMapVal = -2;
		static float maxMapVal = 2;
		static float ratioMinMapVal = minMapVal * height / width;
		static float ratioMaxMapVal = maxMapVal * height / width;

		public Form1()
		{
			InitializeComponent();
		}

		public void AskForSize()
		{
			int minW = 200;
			int minH = 200;
			Console.WriteLine("-=-=- Window's size -=-=-");
			Console.Write($"Provide window's width (min = {minW}): ");
			string readWidth = Console.ReadLine();
			Console.Write($"Provide window's height (min = {minH}): ");
			string readHeight = Console.ReadLine();

			if (int.TryParse(readWidth, out int iWidth) && int.TryParse(readHeight, out int iHeight))
			{
				if (iWidth >= minW && iHeight >= minH)
				{
					width = iWidth;
					height = iHeight;
					minX = -width / 2;
					minY = -height / 2;
					maxX = width / 2;
					maxY = height / 2;
					ratioMinMapVal = minMapVal * height / width;
					ratioMaxMapVal = maxMapVal * height / width;
				}
			}
			Console.WriteLine($"Window's size: {width} x {height}" + Environment.NewLine);
		}
		public void Setup()
		{
			Console.WriteLine("-=-=- Choose fractal to render -=-=-");

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// Custom options
			//AskForSize();
			//Setup();
			width = 200;
			height = 200;
			minX = -width / 2;
			minY = -height / 2;
			maxX = width / 2;
			maxY = height / 2;
			ratioMinMapVal = minMapVal * height / width;
			ratioMaxMapVal = maxMapVal * height / width;


			// Disable resize window
			FormBorderStyle = FormBorderStyle.FixedSingle;

			// Setup size
			ClientSize = new Size(width, height);

			// Setup graphics
			backgroundBitmap = new Bitmap(width, height);
			drawing = Graphics.FromImage(backgroundBitmap);
			background = CreateGraphics();

			// Transform to cartisian plane
			//drawing.TranslateTransform(0, -ClientRectangle.Height);
			//drawing.ScaleTransform(Width, Height);
			drawing.TranslateTransform(width / 2, height / 2);
			drawing.ScaleTransform(1f, -1f);
			drawing.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			drawing.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;

			// Run Draw
			graphThread = new Thread(Draw);
			graphThread.IsBackground = true;
			graphThread.Start();
		}

		private void AskForDataMandelbrotSet(ref float breakpoint, ref int maxIterations, ref float realPart, ref float imaginaryPart, out bool isMandelbrot)
		{
			isMandelbrot = true;
			Console.WriteLine(" -=-=- Mandelbrot set setup -=-=-");

			Console.Write("Provide breakpoint value (min = 2): ");
			string bpString = Console.ReadLine();
			if (float.TryParse(bpString, out float bpValue) && bpValue >= 2)
				breakpoint = bpValue;
			else
				Console.WriteLine($"Wrong breakpoint value. Sets to default: {breakpoint}");

			Console.Write("Provide max iterations value (min = 10; max = 5000): ");
			string miString = Console.ReadLine();
			if (int.TryParse(miString, out int miValue) && miValue >= 10 && miValue <= 5000)
				maxIterations = miValue;
			else
				Console.WriteLine($"Wrong max iterations value. Sets to default: {maxIterations}");

			Console.Write("Provide a real part value (or leave for clear mandelbrot set): ");
			string realString = Console.ReadLine();
			if (float.TryParse(realString, out float realValue))
			{
				realPart = realValue;

				Console.Write("Provide an imaginary part value: ");
				string imaginaryString = Console.ReadLine();
				if (float.TryParse(imaginaryString, out float imaginaryValue))
				{
					imaginaryPart = imaginaryValue;
					isMandelbrot = false;
				}
				else
					Console.WriteLine($"The real and imaginary part will be adjust to create mandelbrot set.");
			}
			else
				Console.WriteLine($"The real and imaginary part will be adjust to create mandelbrot set.");

			Console.WriteLine();
		}
		public void MandelbrotSet()
		{
			// Data
			float breakpoint = 50;
			int maxIterations = 100;

			float realPart = 0;
			float imaginaryPart = 0;
			bool isMandelbrot = true;

			AskForDataMandelbrotSet(ref breakpoint, ref maxIterations, ref realPart, ref imaginaryPart, out isMandelbrot);

			for (float x = minX; x < maxX; x += 1.0f)
			{
				for (float y = minY; y < maxY; y += 1.0f)
				{
					float a = GraphicsHelper.Map(x, minX, maxX, minMapVal, maxMapVal);
					float b = GraphicsHelper.Map(y, minY, maxY, ratioMinMapVal, ratioMaxMapVal);

					if (isMandelbrot)
					{
						realPart = a;
						imaginaryPart = b;
					}

					int n = 0;

					for (n = 0; n < maxIterations; n++)
					{
						float aSquare = a * a;
						float bSquare = b * b;
						float twoAB = 2 * a * b;

						a = aSquare - bSquare + realPart;
						b = twoAB + imaginaryPart;

						if (Math.Abs(a + b) > breakpoint)
						{
							break;
						}
					}
					float brightness = GraphicsHelper.Map(n, 0, maxIterations, 0, 1);
					brightness = GraphicsHelper.Map((float)Math.Sqrt(brightness), 0, 1, 0, 255);
					if (n == maxIterations)
						brightness = 0f;

					pixelBrush = new SolidBrush(Color.FromArgb(255, 0, 0, (int)brightness));
					GraphicsHelper.PutPixel(drawing, pixelBrush, x, y);
				}
			}

			//drawing.DrawLine(linePen, minX, 0, maxX, 0);
			//drawing.DrawLine(linePen, 0, minY, 0, maxY);
			//drawing.DrawLine(linePen, GraphicsHelper.Map(-0.75f, minMapVal, maxMapVal, minX, maxX), -50, GraphicsHelper.Map(-0.75f, minMapVal, maxMapVal, minX, maxX), 50);
		}
		public void AnimatedMandelbrotSet(float rVal, float iVal)
		{
			// Data
			float breakpoint = 16;
			int maxIterations = 100;

			for (float x = minX; x < maxX; x += 1.0f)
			{
				for (float y = minY; y < maxY; y += 1.0f)
				{
					float a = GraphicsHelper.Map(x, minX, maxX, minMapVal, maxMapVal);
					float b = GraphicsHelper.Map(y, minY, maxY, ratioMinMapVal, ratioMaxMapVal);

					int n = 0;

					for (n = 0; n < maxIterations; n++)
					{
						float aSquare = a * a;
						float bSquare = b * b;
						float twoAB = 2 * a * b;

						a = aSquare - bSquare + rVal;
						b = twoAB + iVal;

						if (Math.Abs(a + b) > breakpoint)
						{
							break;
						}
					}
					float brightness = GraphicsHelper.Map(n, 0, maxIterations, 0, 1);
					brightness = GraphicsHelper.Map((float)Math.Sqrt(brightness), 0, 1, 0, 255);
					if (n == maxIterations)
						brightness = 0f;

					pixelBrush = new SolidBrush(Color.FromArgb(255, 0, 0, (int)brightness));
					GraphicsHelper.PutPixel(drawing, pixelBrush, x, y);
				}
			}
		}

		public void Draw()
		{
			// Prevents graphics artifacts
			background.Clear(Color.Black);

			double angle = 0;
			float real = 0;
			float imaginary = 0;
			float rSpeed = 3.253f;
			float iSpeed = 6.1f;

			while (true)
			{
				real = (float)Math.Cos(angle * rSpeed);
				imaginary = (float)Math.Sin(angle * iSpeed);

				drawing.Clear(Color.Black);
				AnimatedMandelbrotSet(real, imaginary);
				background.DrawImage(backgroundBitmap, new PointF(0, 0));
				angle += 0.03f;
			}
		}
	}
}
