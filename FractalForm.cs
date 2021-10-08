using Fractals.Utilities;
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

namespace Fractals
{
	public enum RenderFractal
	{
		MandelbrotSet,
		GivenJuliaSet,
		AnimatedJuliaSet,
		BarnsleyFern
	}
	public partial class FractalForm : Form
	{
		Thread graphThread;         // Thread that uses Draw method and draws objects
		Graphics drawing;           // Graphics object for drawing
		Graphics background;        // Graphics object for background
		Bitmap backgroundBitmap;    // Bitmap used as clearing canvas
		Pen linePen = new Pen(Color.White, 5);

		// Brushes
		SolidBrush pixelBrush = new SolidBrush(Color.FromArgb(0, 0, 0, 0));
		SolidBrush fernBrush = new SolidBrush(Color.FromArgb(0, 0, 0, 0));

		// Message
		string errorMessage = string.Empty;

		// Window Data
		static float width;
		static float height;
		static float minX;
		static float minY;
		static float maxX;
		static float maxY;
		static float minMapVal;
		static float maxMapVal;
		static float ratioMinMapVal;
		static float ratioMaxMapVal;

		// Fractal Data
		static int maxIterations;
		static float breakpoint;
		static float realPart;
		static float imaginaryPart;

		float fernMinXMap;
		float fernMinYMap;
		float fernMaxXMap;
		float fernMaxYMap;

		static RenderFractal fractalToDraw;

		public FractalForm()
		{
			InitializeComponent();
			this.DoubleBuffered = true;
		}

		private void ControlForm_Load(object sender, EventArgs e)
		{
			// Disable resize window
			FormBorderStyle = FormBorderStyle.FixedSingle;

			// Setup size
			width = canvas.Width;
			height = canvas.Height;
			minX = -width / 2;
			minY = -height / 2;
			maxX = width / 2;
			maxY = height / 2;
			minMapVal = -2;
			maxMapVal = 2;
			ratioMinMapVal = minMapVal * height / width;
			ratioMaxMapVal = maxMapVal * height / width;

			// Setup graphics
			backgroundBitmap = new Bitmap((int)width, (int)height);
			canvas.Image = backgroundBitmap;
			drawing = Graphics.FromImage(backgroundBitmap);
			background = canvas.CreateGraphics();

			// Transform to cartisian plane
			drawing.TranslateTransform(width / 2, height / 2);
			drawing.ScaleTransform(1f, -1f);
			drawing.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			drawing.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
		}

		private void BarnsleyFern(float[,] data)
		{
			Random rand = new Random();


			float x = 0.0f;
			float nextX = 0.0f;
			float y = 0.0f;
			float nextY = 0.0f;
			int iterations = (int)fernIterations.Value;

			double prob1 = Math.Round(data[6, 0], 2);
			double prob2 = Math.Round(prob1 + data[6, 1], 2);
			double prob3 = Math.Round(prob2 + data[6, 2], 2);

			for (int i = 0; i < iterations; i++)
			{
				float px = GraphicsHelper.Map(x, fernMinXMap, fernMaxXMap, minX, maxX);
				float py = GraphicsHelper.Map(y, fernMinYMap, fernMaxYMap, minY, maxY);
				GraphicsHelper.PutPixel(drawing, fernBrush, px, py);

				double random = Math.Round(rand.NextDouble(), 2);
				if (random < prob1)
				{
					nextX = data[0, 0] * x + data[1, 0] * y + data[4, 0];
					nextY = data[2, 0] * x + data[3, 0] * y + data[5, 0];
				}
				else if (random < prob2)
				{
					nextX = data[0, 1] * x + data[1, 1] * y + data[4, 1];
					nextY = data[2, 1] * x + data[3, 1] * y + data[5, 1];
				}
				else if (random < prob3)
				{
					nextX = data[0, 2] * x + data[1, 2] * y + data[4, 2];
					nextY = data[2, 2] * x + data[3, 2] * y + data[5, 2];
				}
				else
				{
					nextX = data[0, 3] * x + data[1, 3] * y + data[4, 3];
					nextY = data[2, 3] * x + data[3, 3] * y + data[5, 3];
				}

				x = nextX;
				y = nextY;

			}

			// Translate image back to set point (0,0) in the middle middle
			//drawing.TranslateTransform(1, height / 2);
		}

		private int[] SortFernData(float[,] data)
		{
			int[] indexes = new int[4];
			float[] probabilities = new float[4];
			float[] sortedProbabilities = new float[4];

			for (int i = 0; i < 4; i++)
			{
				probabilities[i] = data[6, i];
				sortedProbabilities[i] = data[6, i];
			}

			Array.Sort(sortedProbabilities);


			for (int i = 0; i < 4; i++)
			{
				indexes[i] = Array.IndexOf(probabilities, sortedProbabilities[i]);
				probabilities[indexes[i]] = -1f;
			}

			return indexes;
		}

		private void SetDefaultFern()
		{
			fernBrush = new SolidBrush(Color.ForestGreen);

			fernMinXMap = -2.25f;
			fernMaxXMap = 2.75f;
			fernMinYMap = 0;
			fernMaxYMap = 10.2f;

			apOne.Text = "0";
			bpOne.Text = "0";
			cpOne.Text = "0";
			dpOne.Text = "0.16";
			epOne.Text = "0";
			fpOne.Text = "0";
			pOne.Text = "0.01";

			apTwo.Text = "0.85";
			bpTwo.Text = "0.04";
			cpTwo.Text = "-0.04";
			dpTwo.Text = "0.85";
			epTwo.Text = "0";
			fpTwo.Text = "1.60";
			pTwo.Text = "0.85";

			apThree.Text = "0.2";
			bpThree.Text = "-0.26";
			cpThree.Text = "0.23";
			dpThree.Text = "0.22";
			epThree.Text = "0";
			fpThree.Text = "1.60";
			pThree.Text = "0.07";

			apFour.Text = "-0.15";
			bpFour.Text = "0.28";
			cpFour.Text = "0.26";
			dpFour.Text = "0.24";
			epFour.Text = "0";
			fpFour.Text = "0.44";
			pFour.Text = "0.07";

			fernIterations.Value = 250000;
		}

		private void SetFractalTreeFern()
		{
			fernBrush = new SolidBrush(Color.LightSteelBlue);

			fernMinXMap = -0.25f;
			fernMaxXMap = 0.25f;
			fernMinYMap = 0;
			fernMaxYMap = 0.5f;

			apOne.Text = "0";
			bpOne.Text = "0";
			cpOne.Text = "0";
			dpOne.Text = "0.5";
			epOne.Text = "0";
			fpOne.Text = "0";
			pOne.Text = "0.05";

			apTwo.Text = "0.42";
			bpTwo.Text = "-0.42";
			cpTwo.Text = "0.42";
			dpTwo.Text = "0.42";
			epTwo.Text = "0";
			fpTwo.Text = "0.2";
			pTwo.Text = "0.4";

			apThree.Text = "0.42";
			bpThree.Text = "0.42";
			cpThree.Text = "-0.42";
			dpThree.Text = "0.42";
			epThree.Text = "0";
			fpThree.Text = "0.2";
			pThree.Text = "0.4";

			apFour.Text = "0.1";
			bpFour.Text = "0";
			cpFour.Text = "0";
			dpFour.Text = "0.1";
			epFour.Text = "0";
			fpFour.Text = "0.2";
			pFour.Text = "0.15";

			fernIterations.Value = 250000;
		}

		private void SetCyclosorusFern()
		{
			fernBrush = new SolidBrush(Color.ForestGreen);

			fernMinXMap = -2f;
			fernMaxXMap = 2f;
			fernMinYMap = 0;
			fernMaxYMap = 7.5f;

			apOne.Text = "0";
			bpOne.Text = "0";
			cpOne.Text = "0";
			dpOne.Text = "0.25";
			epOne.Text = "0";
			fpOne.Text = "-0.4";
			pOne.Text = "0.02";

			apTwo.Text = "0.95";
			bpTwo.Text = "0.005";
			cpTwo.Text = "-0.005";
			dpTwo.Text = "0.93";
			epTwo.Text = "-0.002";
			fpTwo.Text = "0.5";
			pTwo.Text = "0.84";

			apThree.Text = "0.035";
			bpThree.Text = "-0.2";
			cpThree.Text = "0.16";
			dpThree.Text = "0.04";
			epThree.Text = "-0.09";
			fpThree.Text = "0.02";
			pThree.Text = "0.07";

			apFour.Text = "-0.04";
			bpFour.Text = "0.2";
			cpFour.Text = "0.16";
			dpFour.Text = "0.04";
			epFour.Text = "0.083";
			fpFour.Text = "0.12";
			pFour.Text = "0.07";

			fernIterations.Value = 250000;
		}

		private void SetCulcitaFern()
		{
			fernBrush = new SolidBrush(Color.ForestGreen);

			fernMinXMap = -1.75f;
			fernMaxXMap = 2.2f;
			fernMinYMap = 0;
			fernMaxYMap = 6f;

			apOne.Text = "0";
			bpOne.Text = "0";
			cpOne.Text = "0";
			dpOne.Text = "0.25";
			epOne.Text = "0";
			fpOne.Text = "-0.14";
			pOne.Text = "0.02";

			apTwo.Text = "0.85";
			bpTwo.Text = "0.02";
			cpTwo.Text = "-0.02";
			dpTwo.Text = "0.83";
			epTwo.Text = "0";
			fpTwo.Text = "1";
			pTwo.Text = "0.84";

			apThree.Text = "0.09";
			bpThree.Text = "-0.28";
			cpThree.Text = "0.3";
			dpThree.Text = "0.11";
			epThree.Text = "0";
			fpThree.Text = "0.6";
			pThree.Text = "0.07";

			apFour.Text = "-0.09";
			bpFour.Text = "0.28";
			cpFour.Text = "0.3";
			dpFour.Text = "0.09";
			epFour.Text = "0";
			fpFour.Text = "0.7";
			pFour.Text = "0.07";

			fernIterations.Value = 250000;
		}

		private float[,] GetBarnsleyData()
		{
			int rows = dataFernPanel.RowCount - 1;
			int columns = dataFernPanel.ColumnCount;
			float[,] data = new float[columns, rows];
			float pSum = 0;

			for (int i = 0; i < data.GetLength(0); i++)
			{
				for (int j = 0; j < data.GetLength(1); j++)
				{
					Control cell = dataFernPanel.GetControlFromPosition(i, j + 1);

					if (!float.TryParse(cell.Text, out data[i, j]))
					{
						errorMessage = $"All cells must contain numbers! {i + 1}x{j + 1}";

						if (graphThread != null)
							graphThread.Abort("All cells must contain numbers!");

						return null;
					}

					if (i == data.GetLength(0) - 1)
						pSum += data[i, j];
				}
			}

			if (Math.Round(pSum, 1) != 1.0)
			{
				errorMessage = "The sum of p column (probabilities) must equal to 1";

				if (graphThread != null)
					graphThread.Abort("All cells must contain numbers!");

				return null;
			}

			return data;
		}


		public void MandelbrotSet()
		{
			for (float x = minX; x < maxX; x += 1.0f)
			{
				for (float y = minY; y < maxY; y += 1.0f)
				{
					float a = GraphicsHelper.Map(x, minX, maxX, minMapVal, maxMapVal);
					float b = GraphicsHelper.Map(y, minY, maxY, ratioMinMapVal, ratioMaxMapVal);

					realPart = a;
					imaginaryPart = b;


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

		public void JuliaSet()
		{

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
		}

		public void AnimatedJuliaSet()
		{
			double angle = 0;
			float real = 0;
			float imaginary = 0;
			float rSpeed = 1f;
			float iSpeed = 1f;

			while (true)
			{
				real = (float)Math.Cos(angle * rSpeed);
				imaginary = (float)Math.Sin(angle * iSpeed);

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

							a = aSquare - bSquare + real;
							b = twoAB + imaginary;

							if (Math.Abs(a + b) > breakpoint)
							{
								break;
							}
						}
						float brightness = GraphicsHelper.Map(n, 0, maxIterations, 0, 1);
						brightness = GraphicsHelper.Map((float)Math.Sqrt(brightness), 0, 1, 0, 255);
						if (n == maxIterations)
							brightness = 0f;

						backgroundBitmap.SetPixel((int)(x + maxX), (int)(y + maxY), Color.FromArgb(255, 0, 0, (int)brightness));
					}
				}
				angle += 0.03f;
				background.DrawImage(backgroundBitmap, new PointF(0, 0));
			}
		}
		public void Draw()
		{
			try
			{
				// Prevents graphics artifacts
				background.Clear(Color.Black);
				drawing.Clear(Color.Black);

				//drawing.DrawLine(linePen, minX, 0, maxX, 0);
				//drawing.DrawLine(linePen, 0, minY, 0, maxY);


				switch (fractalToDraw)
				{
					case RenderFractal.MandelbrotSet:
						MandelbrotSet();
						break;
					case RenderFractal.GivenJuliaSet:
						JuliaSet();
						break;
					case RenderFractal.AnimatedJuliaSet:
						AnimatedJuliaSet();
						break;
					case RenderFractal.BarnsleyFern:
						float[,] data = GetBarnsleyData();
						if (data != null)
						{
							BarnsleyFern(data);
						}
						break;
					default:
						break;
				}
				background.DrawImage(backgroundBitmap, new PointF(0, 0));
			}
			catch (ThreadAbortException abortException)
			{
				Debug.WriteLine((string)abortException.ExceptionState);
			}
		}

		private void drawButton_Click(object sender, EventArgs e)
		{
			errorMessage = string.Empty;
			if (graphThread != null)
				graphThread.Abort();

			// Set Data
			breakpoint = (float)breakpointValue.Value;
			maxIterations = (int)maxIterationsValue.Value;

			if (rbMandelbrot.Checked) fractalToDraw = RenderFractal.MandelbrotSet;
			if (rbJulia.Checked)
			{
				realPart = (float)realPartValue.Value;
				imaginaryPart = (float)imaginaryPartValue.Value;
				fractalToDraw = RenderFractal.GivenJuliaSet;
			}
			if (rbAnimatedJulia.Checked)
			{
				realPart = (float)realPartValue.Value;
				imaginaryPart = (float)imaginaryPartValue.Value;
				fractalToDraw = RenderFractal.AnimatedJuliaSet;
			}
			if (rbFern.Checked)
			{
				fractalToDraw = RenderFractal.BarnsleyFern;
			}

			// Run Draw
			graphThread = new Thread(Draw);
			graphThread.IsBackground = false;
			graphThread.Start();

			graphThread.Join();
			errorLabel.Text = errorMessage;
		}

		private void rbMandelbrot_CheckedChanged(object sender, EventArgs e)
		{
			if (rbMandelbrot.Checked)
			{
				dataPanelOne.Visible = true;
				tlpFern.Visible = false;
				dataGroupBox.Text = "Mandelbrot Data";

				rpLabel.Enabled = false;
				realPartValue.Enabled = false;

				ipLabel.Enabled = false;
				imaginaryPartValue.Enabled = false;
			}
		}

		private void rbJulia_CheckedChanged(object sender, EventArgs e)
		{
			if (rbJulia.Checked)
			{
				dataPanelOne.Visible = true;
				tlpFern.Visible = false;
				dataGroupBox.Text = "Mandelbrot Data";

				rpLabel.Enabled = true;
				realPartValue.Enabled = true;

				ipLabel.Enabled = true;
				imaginaryPartValue.Enabled = true;
			}
		}

		private void rbAnimatedJulia_CheckedChanged(object sender, EventArgs e)
		{
			if (rbAnimatedJulia.Checked)
			{
				dataPanelOne.Visible = true;
				tlpFern.Visible = false;
				dataGroupBox.Text = "Mandelbrot Data";

				rpLabel.Enabled = true;
				realPartValue.Enabled = true;

				ipLabel.Enabled = true;
				imaginaryPartValue.Enabled = true;
			}
		}

		private void rbFern_CheckedChanged(object sender, EventArgs e)
		{
			if (rbFern.Checked)
			{
				dataPanelOne.Visible = false;
				tlpFern.Visible = true;
				dataGroupBox.Text = "Barnsley Fern Data";

				rpLabel.Enabled = true;
				realPartValue.Enabled = true;

				ipLabel.Enabled = true;
				imaginaryPartValue.Enabled = true;
			}
		}

		private void rbDefaultFern_CheckedChanged(object sender, EventArgs e)
		{
			if (rbDefaultFern.Checked)
			{
				SetDefaultFern();
			}
		}

		private void rbFractalTree_CheckedChanged(object sender, EventArgs e)
		{
			if (rbFractalTree.Checked)
			{
				SetFractalTreeFern();
			}
		}

		private void rbCyclosorus_CheckedChanged(object sender, EventArgs e)
		{
			if (rbCyclosorus.Checked)
			{
				SetCyclosorusFern();
			}
		}

		private void rbCulcita_CheckedChanged(object sender, EventArgs e)
		{
			if (rbCulcita.Checked)
			{
				SetCulcitaFern();
			}
		}
	}
}
