
namespace Fractals
{
	partial class FractalForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.canvas = new System.Windows.Forms.PictureBox();
			this.Title = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.rbFractals = new System.Windows.Forms.TableLayoutPanel();
			this.rbMandelbrot = new System.Windows.Forms.RadioButton();
			this.rbJulia = new System.Windows.Forms.RadioButton();
			this.rbAnimatedJulia = new System.Windows.Forms.RadioButton();
			this.rbDragon = new System.Windows.Forms.RadioButton();
			this.rbSierpinski = new System.Windows.Forms.RadioButton();
			this.rbFern = new System.Windows.Forms.RadioButton();
			this.dataGroupBox = new System.Windows.Forms.GroupBox();
			this.tlpFern = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.rbDefaultFern = new System.Windows.Forms.RadioButton();
			this.rbFractalTree = new System.Windows.Forms.RadioButton();
			this.dataFernPanel = new System.Windows.Forms.TableLayoutPanel();
			this.label11 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.apOne = new System.Windows.Forms.TextBox();
			this.bpOne = new System.Windows.Forms.TextBox();
			this.cpOne = new System.Windows.Forms.TextBox();
			this.dpOne = new System.Windows.Forms.TextBox();
			this.epOne = new System.Windows.Forms.TextBox();
			this.fpOne = new System.Windows.Forms.TextBox();
			this.pOne = new System.Windows.Forms.TextBox();
			this.bpTwo = new System.Windows.Forms.TextBox();
			this.fpTwo = new System.Windows.Forms.TextBox();
			this.pTwo = new System.Windows.Forms.TextBox();
			this.apFour = new System.Windows.Forms.TextBox();
			this.epFour = new System.Windows.Forms.TextBox();
			this.pFour = new System.Windows.Forms.TextBox();
			this.apTwo = new System.Windows.Forms.TextBox();
			this.cpTwo = new System.Windows.Forms.TextBox();
			this.epTwo = new System.Windows.Forms.TextBox();
			this.dpTwo = new System.Windows.Forms.TextBox();
			this.apThree = new System.Windows.Forms.TextBox();
			this.bpThree = new System.Windows.Forms.TextBox();
			this.dpThree = new System.Windows.Forms.TextBox();
			this.cpThree = new System.Windows.Forms.TextBox();
			this.epThree = new System.Windows.Forms.TextBox();
			this.pThree = new System.Windows.Forms.TextBox();
			this.fpThree = new System.Windows.Forms.TextBox();
			this.bpFour = new System.Windows.Forms.TextBox();
			this.cpFour = new System.Windows.Forms.TextBox();
			this.fpFour = new System.Windows.Forms.TextBox();
			this.dpFour = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label13 = new System.Windows.Forms.Label();
			this.fernIterations = new System.Windows.Forms.NumericUpDown();
			this.label12 = new System.Windows.Forms.Label();
			this.errorLabel = new System.Windows.Forms.Label();
			this.drawButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.renderBar = new System.Windows.Forms.ProgressBar();
			this.dataPanelOne = new System.Windows.Forms.TableLayoutPanel();
			this.imaginaryPartValue = new System.Windows.Forms.NumericUpDown();
			this.realPartValue = new System.Windows.Forms.NumericUpDown();
			this.maxIterationsValue = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.rpLabel = new System.Windows.Forms.Label();
			this.ipLabel = new System.Windows.Forms.Label();
			this.breakpointValue = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.rbCyclosorus = new System.Windows.Forms.RadioButton();
			this.rbCulcita = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
			this.rbFractals.SuspendLayout();
			this.dataGroupBox.SuspendLayout();
			this.tlpFern.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.dataFernPanel.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fernIterations)).BeginInit();
			this.dataPanelOne.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imaginaryPartValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.realPartValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.maxIterationsValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.breakpointValue)).BeginInit();
			this.SuspendLayout();
			// 
			// canvas
			// 
			this.canvas.BackColor = System.Drawing.SystemColors.Desktop;
			this.canvas.Dock = System.Windows.Forms.DockStyle.Left;
			this.canvas.Location = new System.Drawing.Point(0, 0);
			this.canvas.Name = "canvas";
			this.canvas.Size = new System.Drawing.Size(708, 708);
			this.canvas.TabIndex = 0;
			this.canvas.TabStop = false;
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Title.Location = new System.Drawing.Point(747, 9);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(400, 61);
			this.Title.TabIndex = 1;
			this.Title.Text = "Fractals Viewer";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(722, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(245, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Choose fractal to render";
			// 
			// rbFractals
			// 
			this.rbFractals.ColumnCount = 3;
			this.rbFractals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.45946F));
			this.rbFractals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.82883F));
			this.rbFractals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.43216F));
			this.rbFractals.Controls.Add(this.rbMandelbrot, 0, 0);
			this.rbFractals.Controls.Add(this.rbJulia, 1, 0);
			this.rbFractals.Controls.Add(this.rbAnimatedJulia, 2, 0);
			this.rbFractals.Controls.Add(this.rbDragon, 2, 1);
			this.rbFractals.Controls.Add(this.rbSierpinski, 0, 1);
			this.rbFractals.Controls.Add(this.rbFern, 1, 1);
			this.rbFractals.Location = new System.Drawing.Point(727, 116);
			this.rbFractals.Name = "rbFractals";
			this.rbFractals.RowCount = 2;
			this.rbFractals.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.rbFractals.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
			this.rbFractals.Size = new System.Drawing.Size(444, 70);
			this.rbFractals.TabIndex = 3;
			// 
			// rbMandelbrot
			// 
			this.rbMandelbrot.AutoSize = true;
			this.rbMandelbrot.Checked = true;
			this.rbMandelbrot.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.rbMandelbrot.Location = new System.Drawing.Point(3, 3);
			this.rbMandelbrot.Name = "rbMandelbrot";
			this.rbMandelbrot.Size = new System.Drawing.Size(120, 20);
			this.rbMandelbrot.TabIndex = 0;
			this.rbMandelbrot.TabStop = true;
			this.rbMandelbrot.Text = "Mandelbrot set";
			this.rbMandelbrot.UseVisualStyleBackColor = true;
			this.rbMandelbrot.CheckedChanged += new System.EventHandler(this.rbMandelbrot_CheckedChanged);
			// 
			// rbJulia
			// 
			this.rbJulia.AutoSize = true;
			this.rbJulia.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.rbJulia.Location = new System.Drawing.Point(156, 3);
			this.rbJulia.Name = "rbJulia";
			this.rbJulia.Size = new System.Drawing.Size(77, 20);
			this.rbJulia.TabIndex = 1;
			this.rbJulia.TabStop = true;
			this.rbJulia.Text = "Julia set";
			this.rbJulia.UseVisualStyleBackColor = true;
			this.rbJulia.CheckedChanged += new System.EventHandler(this.rbJulia_CheckedChanged);
			// 
			// rbAnimatedJulia
			// 
			this.rbAnimatedJulia.AutoSize = true;
			this.rbAnimatedJulia.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.rbAnimatedJulia.Location = new System.Drawing.Point(284, 3);
			this.rbAnimatedJulia.Name = "rbAnimatedJulia";
			this.rbAnimatedJulia.Size = new System.Drawing.Size(140, 20);
			this.rbAnimatedJulia.TabIndex = 2;
			this.rbAnimatedJulia.TabStop = true;
			this.rbAnimatedJulia.Text = "Animated Julia set";
			this.rbAnimatedJulia.UseVisualStyleBackColor = true;
			this.rbAnimatedJulia.CheckedChanged += new System.EventHandler(this.rbAnimatedJulia_CheckedChanged);
			// 
			// rbDragon
			// 
			this.rbDragon.AutoSize = true;
			this.rbDragon.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.rbDragon.Location = new System.Drawing.Point(284, 37);
			this.rbDragon.Name = "rbDragon";
			this.rbDragon.Size = new System.Drawing.Size(135, 20);
			this.rbDragon.TabIndex = 3;
			this.rbDragon.TabStop = true;
			this.rbDragon.Text = "Heighway dragon";
			this.rbDragon.UseVisualStyleBackColor = true;
			// 
			// rbSierpinski
			// 
			this.rbSierpinski.AutoSize = true;
			this.rbSierpinski.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.rbSierpinski.Location = new System.Drawing.Point(3, 37);
			this.rbSierpinski.Name = "rbSierpinski";
			this.rbSierpinski.Size = new System.Drawing.Size(142, 20);
			this.rbSierpinski.TabIndex = 5;
			this.rbSierpinski.TabStop = true;
			this.rbSierpinski.Text = "Sierpinski Triangle";
			this.rbSierpinski.UseVisualStyleBackColor = true;
			// 
			// rbFern
			// 
			this.rbFern.AutoSize = true;
			this.rbFern.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.rbFern.Location = new System.Drawing.Point(156, 37);
			this.rbFern.Name = "rbFern";
			this.rbFern.Size = new System.Drawing.Size(115, 20);
			this.rbFern.TabIndex = 4;
			this.rbFern.TabStop = true;
			this.rbFern.Text = "Barnsley Fern";
			this.rbFern.UseVisualStyleBackColor = true;
			this.rbFern.CheckedChanged += new System.EventHandler(this.rbFern_CheckedChanged);
			// 
			// dataGroupBox
			// 
			this.dataGroupBox.Controls.Add(this.tlpFern);
			this.dataGroupBox.Controls.Add(this.errorLabel);
			this.dataGroupBox.Controls.Add(this.drawButton);
			this.dataGroupBox.Controls.Add(this.label2);
			this.dataGroupBox.Controls.Add(this.renderBar);
			this.dataGroupBox.Controls.Add(this.dataPanelOne);
			this.dataGroupBox.Font = new System.Drawing.Font("Arial", 15F);
			this.dataGroupBox.Location = new System.Drawing.Point(727, 192);
			this.dataGroupBox.Name = "dataGroupBox";
			this.dataGroupBox.Size = new System.Drawing.Size(444, 504);
			this.dataGroupBox.TabIndex = 4;
			this.dataGroupBox.TabStop = false;
			this.dataGroupBox.Text = "Data";
			// 
			// tlpFern
			// 
			this.tlpFern.ColumnCount = 1;
			this.tlpFern.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpFern.Controls.Add(this.tableLayoutPanel1, 0, 3);
			this.tlpFern.Controls.Add(this.dataFernPanel, 0, 0);
			this.tlpFern.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.tlpFern.Controls.Add(this.label12, 0, 2);
			this.tlpFern.Location = new System.Drawing.Point(9, 29);
			this.tlpFern.Name = "tlpFern";
			this.tlpFern.RowCount = 4;
			this.tlpFern.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.45317F));
			this.tlpFern.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
			this.tlpFern.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tlpFern.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tlpFern.Size = new System.Drawing.Size(429, 352);
			this.tlpFern.TabIndex = 5;
			this.tlpFern.Visible = false;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.96927F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.64302F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.1513F));
			this.tableLayoutPanel1.Controls.Add(this.rbDefaultFern, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.rbFractalTree, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.rbCyclosorus, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.rbCulcita, 2, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 215);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(423, 74);
			this.tableLayoutPanel1.TabIndex = 11;
			// 
			// rbDefaultFern
			// 
			this.rbDefaultFern.AutoSize = true;
			this.rbDefaultFern.Checked = true;
			this.rbDefaultFern.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.rbDefaultFern.Location = new System.Drawing.Point(3, 3);
			this.rbDefaultFern.Name = "rbDefaultFern";
			this.rbDefaultFern.Size = new System.Drawing.Size(100, 20);
			this.rbDefaultFern.TabIndex = 0;
			this.rbDefaultFern.TabStop = true;
			this.rbDefaultFern.Text = "Default fern";
			this.rbDefaultFern.UseVisualStyleBackColor = true;
			this.rbDefaultFern.CheckedChanged += new System.EventHandler(this.rbDefaultFern_CheckedChanged);
			// 
			// rbFractalTree
			// 
			this.rbFractalTree.AutoSize = true;
			this.rbFractalTree.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.rbFractalTree.Location = new System.Drawing.Point(134, 35);
			this.rbFractalTree.Name = "rbFractalTree";
			this.rbFractalTree.Size = new System.Drawing.Size(103, 20);
			this.rbFractalTree.TabIndex = 1;
			this.rbFractalTree.Text = "Fractal Tree";
			this.rbFractalTree.UseVisualStyleBackColor = true;
			this.rbFractalTree.CheckedChanged += new System.EventHandler(this.rbFractalTree_CheckedChanged);
			// 
			// dataFernPanel
			// 
			this.dataFernPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dataFernPanel.ColumnCount = 7;
			this.dataFernPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
			this.dataFernPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
			this.dataFernPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
			this.dataFernPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
			this.dataFernPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
			this.dataFernPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
			this.dataFernPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
			this.dataFernPanel.Controls.Add(this.label11, 5, 0);
			this.dataFernPanel.Controls.Add(this.label9, 4, 0);
			this.dataFernPanel.Controls.Add(this.label8, 3, 0);
			this.dataFernPanel.Controls.Add(this.label7, 2, 0);
			this.dataFernPanel.Controls.Add(this.label6, 1, 0);
			this.dataFernPanel.Controls.Add(this.label5, 0, 0);
			this.dataFernPanel.Controls.Add(this.label10, 6, 0);
			this.dataFernPanel.Controls.Add(this.apOne, 0, 1);
			this.dataFernPanel.Controls.Add(this.bpOne, 1, 1);
			this.dataFernPanel.Controls.Add(this.cpOne, 2, 1);
			this.dataFernPanel.Controls.Add(this.dpOne, 3, 1);
			this.dataFernPanel.Controls.Add(this.epOne, 4, 1);
			this.dataFernPanel.Controls.Add(this.fpOne, 5, 1);
			this.dataFernPanel.Controls.Add(this.pOne, 6, 1);
			this.dataFernPanel.Controls.Add(this.bpTwo, 1, 2);
			this.dataFernPanel.Controls.Add(this.fpTwo, 5, 2);
			this.dataFernPanel.Controls.Add(this.pTwo, 6, 2);
			this.dataFernPanel.Controls.Add(this.apFour, 0, 4);
			this.dataFernPanel.Controls.Add(this.epFour, 4, 4);
			this.dataFernPanel.Controls.Add(this.pFour, 6, 4);
			this.dataFernPanel.Controls.Add(this.apTwo, 0, 2);
			this.dataFernPanel.Controls.Add(this.cpTwo, 2, 2);
			this.dataFernPanel.Controls.Add(this.epTwo, 4, 2);
			this.dataFernPanel.Controls.Add(this.dpTwo, 3, 2);
			this.dataFernPanel.Controls.Add(this.apThree, 0, 3);
			this.dataFernPanel.Controls.Add(this.bpThree, 1, 3);
			this.dataFernPanel.Controls.Add(this.dpThree, 3, 3);
			this.dataFernPanel.Controls.Add(this.cpThree, 2, 3);
			this.dataFernPanel.Controls.Add(this.epThree, 4, 3);
			this.dataFernPanel.Controls.Add(this.pThree, 6, 3);
			this.dataFernPanel.Controls.Add(this.fpThree, 5, 3);
			this.dataFernPanel.Controls.Add(this.bpFour, 1, 4);
			this.dataFernPanel.Controls.Add(this.cpFour, 2, 4);
			this.dataFernPanel.Controls.Add(this.fpFour, 5, 4);
			this.dataFernPanel.Controls.Add(this.dpFour, 3, 4);
			this.dataFernPanel.Location = new System.Drawing.Point(3, 3);
			this.dataFernPanel.Name = "dataFernPanel";
			this.dataFernPanel.RowCount = 5;
			this.dataFernPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.dataFernPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.dataFernPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.dataFernPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.dataFernPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.dataFernPanel.Size = new System.Drawing.Size(423, 142);
			this.dataFernPanel.TabIndex = 10;
			// 
			// label11
			// 
			this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(316, 2);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(16, 23);
			this.label11.TabIndex = 6;
			this.label11.Text = "f";
			// 
			// label9
			// 
			this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(255, 2);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(21, 23);
			this.label9.TabIndex = 4;
			this.label9.Text = "e";
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(196, 2);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(21, 23);
			this.label8.TabIndex = 3;
			this.label8.Text = "d";
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(137, 2);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(20, 23);
			this.label7.TabIndex = 2;
			this.label7.Text = "c";
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(78, 2);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(21, 23);
			this.label6.TabIndex = 1;
			this.label6.Text = "b";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(19, 2);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(21, 23);
			this.label5.TabIndex = 0;
			this.label5.Text = "a";
			// 
			// label10
			// 
			this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(378, 2);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(21, 23);
			this.label10.TabIndex = 5;
			this.label10.Text = "p";
			// 
			// apOne
			// 
			this.apOne.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.apOne.Font = new System.Drawing.Font("Arial", 10F);
			this.apOne.Location = new System.Drawing.Point(3, 31);
			this.apOne.MaxLength = 6;
			this.apOne.Name = "apOne";
			this.apOne.Size = new System.Drawing.Size(53, 23);
			this.apOne.TabIndex = 7;
			this.apOne.Text = "0";
			this.apOne.WordWrap = false;
			// 
			// bpOne
			// 
			this.bpOne.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.bpOne.Font = new System.Drawing.Font("Arial", 10F);
			this.bpOne.Location = new System.Drawing.Point(62, 31);
			this.bpOne.MaxLength = 6;
			this.bpOne.Name = "bpOne";
			this.bpOne.Size = new System.Drawing.Size(53, 23);
			this.bpOne.TabIndex = 8;
			this.bpOne.Text = "0";
			this.bpOne.WordWrap = false;
			// 
			// cpOne
			// 
			this.cpOne.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cpOne.Font = new System.Drawing.Font("Arial", 10F);
			this.cpOne.Location = new System.Drawing.Point(121, 31);
			this.cpOne.MaxLength = 6;
			this.cpOne.Name = "cpOne";
			this.cpOne.Size = new System.Drawing.Size(53, 23);
			this.cpOne.TabIndex = 9;
			this.cpOne.Text = "0";
			this.cpOne.WordWrap = false;
			// 
			// dpOne
			// 
			this.dpOne.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dpOne.Font = new System.Drawing.Font("Arial", 10F);
			this.dpOne.Location = new System.Drawing.Point(180, 31);
			this.dpOne.MaxLength = 6;
			this.dpOne.Name = "dpOne";
			this.dpOne.Size = new System.Drawing.Size(53, 23);
			this.dpOne.TabIndex = 10;
			this.dpOne.Text = "0.16";
			this.dpOne.WordWrap = false;
			// 
			// epOne
			// 
			this.epOne.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.epOne.Font = new System.Drawing.Font("Arial", 10F);
			this.epOne.Location = new System.Drawing.Point(239, 31);
			this.epOne.MaxLength = 6;
			this.epOne.Name = "epOne";
			this.epOne.Size = new System.Drawing.Size(53, 23);
			this.epOne.TabIndex = 11;
			this.epOne.Text = "0";
			this.epOne.WordWrap = false;
			// 
			// fpOne
			// 
			this.fpOne.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.fpOne.Font = new System.Drawing.Font("Arial", 10F);
			this.fpOne.Location = new System.Drawing.Point(298, 31);
			this.fpOne.MaxLength = 6;
			this.fpOne.Name = "fpOne";
			this.fpOne.Size = new System.Drawing.Size(53, 23);
			this.fpOne.TabIndex = 12;
			this.fpOne.Text = "0";
			this.fpOne.WordWrap = false;
			// 
			// pOne
			// 
			this.pOne.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pOne.Font = new System.Drawing.Font("Arial", 10F);
			this.pOne.Location = new System.Drawing.Point(361, 31);
			this.pOne.MaxLength = 6;
			this.pOne.Name = "pOne";
			this.pOne.Size = new System.Drawing.Size(54, 23);
			this.pOne.TabIndex = 13;
			this.pOne.Text = "0.01";
			this.pOne.WordWrap = false;
			// 
			// bpTwo
			// 
			this.bpTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.bpTwo.Font = new System.Drawing.Font("Arial", 10F);
			this.bpTwo.Location = new System.Drawing.Point(62, 59);
			this.bpTwo.MaxLength = 6;
			this.bpTwo.Name = "bpTwo";
			this.bpTwo.Size = new System.Drawing.Size(53, 23);
			this.bpTwo.TabIndex = 15;
			this.bpTwo.Text = "0.04";
			this.bpTwo.WordWrap = false;
			// 
			// fpTwo
			// 
			this.fpTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.fpTwo.Font = new System.Drawing.Font("Arial", 10F);
			this.fpTwo.Location = new System.Drawing.Point(298, 59);
			this.fpTwo.MaxLength = 6;
			this.fpTwo.Name = "fpTwo";
			this.fpTwo.Size = new System.Drawing.Size(53, 23);
			this.fpTwo.TabIndex = 19;
			this.fpTwo.Text = "1.6";
			this.fpTwo.WordWrap = false;
			// 
			// pTwo
			// 
			this.pTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pTwo.Font = new System.Drawing.Font("Arial", 10F);
			this.pTwo.Location = new System.Drawing.Point(361, 59);
			this.pTwo.MaxLength = 6;
			this.pTwo.Name = "pTwo";
			this.pTwo.Size = new System.Drawing.Size(54, 23);
			this.pTwo.TabIndex = 20;
			this.pTwo.Text = "0.85";
			this.pTwo.WordWrap = false;
			// 
			// apFour
			// 
			this.apFour.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.apFour.Font = new System.Drawing.Font("Arial", 10F);
			this.apFour.Location = new System.Drawing.Point(3, 115);
			this.apFour.MaxLength = 6;
			this.apFour.Name = "apFour";
			this.apFour.Size = new System.Drawing.Size(53, 23);
			this.apFour.TabIndex = 29;
			this.apFour.Text = "-0.15";
			this.apFour.WordWrap = false;
			// 
			// epFour
			// 
			this.epFour.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.epFour.Font = new System.Drawing.Font("Arial", 10F);
			this.epFour.Location = new System.Drawing.Point(239, 115);
			this.epFour.MaxLength = 6;
			this.epFour.Name = "epFour";
			this.epFour.Size = new System.Drawing.Size(53, 23);
			this.epFour.TabIndex = 33;
			this.epFour.Text = "0";
			this.epFour.WordWrap = false;
			// 
			// pFour
			// 
			this.pFour.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pFour.Font = new System.Drawing.Font("Arial", 10F);
			this.pFour.Location = new System.Drawing.Point(361, 115);
			this.pFour.MaxLength = 6;
			this.pFour.Name = "pFour";
			this.pFour.Size = new System.Drawing.Size(54, 23);
			this.pFour.TabIndex = 35;
			this.pFour.Text = "0.07";
			this.pFour.WordWrap = false;
			// 
			// apTwo
			// 
			this.apTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.apTwo.Font = new System.Drawing.Font("Arial", 10F);
			this.apTwo.Location = new System.Drawing.Point(3, 59);
			this.apTwo.MaxLength = 6;
			this.apTwo.Name = "apTwo";
			this.apTwo.Size = new System.Drawing.Size(53, 23);
			this.apTwo.TabIndex = 14;
			this.apTwo.Text = "0.85";
			this.apTwo.WordWrap = false;
			// 
			// cpTwo
			// 
			this.cpTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cpTwo.Font = new System.Drawing.Font("Arial", 10F);
			this.cpTwo.Location = new System.Drawing.Point(121, 59);
			this.cpTwo.MaxLength = 6;
			this.cpTwo.Name = "cpTwo";
			this.cpTwo.Size = new System.Drawing.Size(53, 23);
			this.cpTwo.TabIndex = 16;
			this.cpTwo.Text = "-0.04";
			this.cpTwo.WordWrap = false;
			// 
			// epTwo
			// 
			this.epTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.epTwo.Font = new System.Drawing.Font("Arial", 10F);
			this.epTwo.Location = new System.Drawing.Point(239, 59);
			this.epTwo.MaxLength = 6;
			this.epTwo.Name = "epTwo";
			this.epTwo.Size = new System.Drawing.Size(53, 23);
			this.epTwo.TabIndex = 18;
			this.epTwo.Text = "0";
			this.epTwo.WordWrap = false;
			// 
			// dpTwo
			// 
			this.dpTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dpTwo.Font = new System.Drawing.Font("Arial", 10F);
			this.dpTwo.Location = new System.Drawing.Point(180, 59);
			this.dpTwo.MaxLength = 6;
			this.dpTwo.Name = "dpTwo";
			this.dpTwo.Size = new System.Drawing.Size(53, 23);
			this.dpTwo.TabIndex = 17;
			this.dpTwo.Text = "0.85";
			this.dpTwo.WordWrap = false;
			// 
			// apThree
			// 
			this.apThree.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.apThree.Font = new System.Drawing.Font("Arial", 10F);
			this.apThree.Location = new System.Drawing.Point(3, 87);
			this.apThree.MaxLength = 6;
			this.apThree.Name = "apThree";
			this.apThree.Size = new System.Drawing.Size(53, 23);
			this.apThree.TabIndex = 21;
			this.apThree.Text = "0.2";
			this.apThree.WordWrap = false;
			// 
			// bpThree
			// 
			this.bpThree.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.bpThree.Font = new System.Drawing.Font("Arial", 10F);
			this.bpThree.Location = new System.Drawing.Point(62, 87);
			this.bpThree.MaxLength = 6;
			this.bpThree.Name = "bpThree";
			this.bpThree.Size = new System.Drawing.Size(53, 23);
			this.bpThree.TabIndex = 22;
			this.bpThree.Text = "-0.26";
			this.bpThree.WordWrap = false;
			// 
			// dpThree
			// 
			this.dpThree.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dpThree.Font = new System.Drawing.Font("Arial", 10F);
			this.dpThree.Location = new System.Drawing.Point(180, 87);
			this.dpThree.MaxLength = 6;
			this.dpThree.Name = "dpThree";
			this.dpThree.Size = new System.Drawing.Size(53, 23);
			this.dpThree.TabIndex = 24;
			this.dpThree.Text = "0.22";
			this.dpThree.WordWrap = false;
			// 
			// cpThree
			// 
			this.cpThree.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cpThree.Font = new System.Drawing.Font("Arial", 10F);
			this.cpThree.Location = new System.Drawing.Point(121, 87);
			this.cpThree.MaxLength = 6;
			this.cpThree.Name = "cpThree";
			this.cpThree.Size = new System.Drawing.Size(53, 23);
			this.cpThree.TabIndex = 23;
			this.cpThree.Text = "0.23";
			this.cpThree.WordWrap = false;
			// 
			// epThree
			// 
			this.epThree.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.epThree.Font = new System.Drawing.Font("Arial", 10F);
			this.epThree.Location = new System.Drawing.Point(239, 87);
			this.epThree.MaxLength = 6;
			this.epThree.Name = "epThree";
			this.epThree.Size = new System.Drawing.Size(53, 23);
			this.epThree.TabIndex = 26;
			this.epThree.Text = "0";
			this.epThree.WordWrap = false;
			// 
			// pThree
			// 
			this.pThree.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pThree.Font = new System.Drawing.Font("Arial", 10F);
			this.pThree.Location = new System.Drawing.Point(361, 87);
			this.pThree.MaxLength = 6;
			this.pThree.Name = "pThree";
			this.pThree.Size = new System.Drawing.Size(54, 23);
			this.pThree.TabIndex = 28;
			this.pThree.Text = "0.07";
			this.pThree.WordWrap = false;
			// 
			// fpThree
			// 
			this.fpThree.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.fpThree.Font = new System.Drawing.Font("Arial", 10F);
			this.fpThree.Location = new System.Drawing.Point(298, 87);
			this.fpThree.MaxLength = 6;
			this.fpThree.Name = "fpThree";
			this.fpThree.Size = new System.Drawing.Size(53, 23);
			this.fpThree.TabIndex = 27;
			this.fpThree.Text = "1.6";
			this.fpThree.WordWrap = false;
			// 
			// bpFour
			// 
			this.bpFour.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.bpFour.Font = new System.Drawing.Font("Arial", 10F);
			this.bpFour.Location = new System.Drawing.Point(62, 115);
			this.bpFour.MaxLength = 6;
			this.bpFour.Name = "bpFour";
			this.bpFour.Size = new System.Drawing.Size(53, 23);
			this.bpFour.TabIndex = 30;
			this.bpFour.Text = "0.28";
			this.bpFour.WordWrap = false;
			// 
			// cpFour
			// 
			this.cpFour.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cpFour.Font = new System.Drawing.Font("Arial", 10F);
			this.cpFour.Location = new System.Drawing.Point(121, 115);
			this.cpFour.MaxLength = 6;
			this.cpFour.Name = "cpFour";
			this.cpFour.Size = new System.Drawing.Size(53, 23);
			this.cpFour.TabIndex = 31;
			this.cpFour.Text = "0.26";
			this.cpFour.WordWrap = false;
			// 
			// fpFour
			// 
			this.fpFour.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.fpFour.Font = new System.Drawing.Font("Arial", 10F);
			this.fpFour.Location = new System.Drawing.Point(298, 115);
			this.fpFour.MaxLength = 6;
			this.fpFour.Name = "fpFour";
			this.fpFour.Size = new System.Drawing.Size(53, 23);
			this.fpFour.TabIndex = 34;
			this.fpFour.Text = "0.44";
			this.fpFour.WordWrap = false;
			// 
			// dpFour
			// 
			this.dpFour.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dpFour.Font = new System.Drawing.Font("Arial", 10F);
			this.dpFour.Location = new System.Drawing.Point(180, 115);
			this.dpFour.MaxLength = 6;
			this.dpFour.Name = "dpFour";
			this.dpFour.Size = new System.Drawing.Size(53, 23);
			this.dpFour.TabIndex = 32;
			this.dpFour.Text = "0.24";
			this.dpFour.WordWrap = false;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
			this.tableLayoutPanel2.Controls.Add(this.label13, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.fernIterations, 1, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 151);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(423, 28);
			this.tableLayoutPanel2.TabIndex = 12;
			// 
			// label13
			// 
			this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Arial", 13F);
			this.label13.Location = new System.Drawing.Point(3, 3);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(171, 21);
			this.label13.TabIndex = 6;
			this.label13.Text = "Number of iterations";
			// 
			// fernIterations
			// 
			this.fernIterations.Font = new System.Drawing.Font("Arial", 10F);
			this.fernIterations.Location = new System.Drawing.Point(238, 3);
			this.fernIterations.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.fernIterations.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.fernIterations.Name = "fernIterations";
			this.fernIterations.Size = new System.Drawing.Size(176, 23);
			this.fernIterations.TabIndex = 7;
			this.fernIterations.Value = new decimal(new int[] {
            500000,
            0,
            0,
            0});
			// 
			// label12
			// 
			this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Arial", 13F);
			this.label12.Location = new System.Drawing.Point(3, 186);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(200, 21);
			this.label12.TabIndex = 5;
			this.label12.Text = "Predefined fern settings";
			// 
			// errorLabel
			// 
			this.errorLabel.AutoSize = true;
			this.errorLabel.BackColor = System.Drawing.Color.Transparent;
			this.errorLabel.Font = new System.Drawing.Font("Arial", 10F);
			this.errorLabel.ForeColor = System.Drawing.Color.Red;
			this.errorLabel.Location = new System.Drawing.Point(8, 384);
			this.errorLabel.Name = "errorLabel";
			this.errorLabel.Size = new System.Drawing.Size(54, 16);
			this.errorLabel.TabIndex = 11;
			this.errorLabel.Text = "label12";
			// 
			// drawButton
			// 
			this.drawButton.Location = new System.Drawing.Point(9, 421);
			this.drawButton.Name = "drawButton";
			this.drawButton.Size = new System.Drawing.Size(383, 37);
			this.drawButton.TabIndex = 6;
			this.drawButton.Text = "Draw";
			this.drawButton.UseVisualStyleBackColor = true;
			this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial", 10F);
			this.label2.Location = new System.Drawing.Point(166, 473);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "Rendering";
			// 
			// renderBar
			// 
			this.renderBar.Location = new System.Drawing.Point(9, 464);
			this.renderBar.Name = "renderBar";
			this.renderBar.Size = new System.Drawing.Size(383, 34);
			this.renderBar.TabIndex = 0;
			// 
			// dataPanelOne
			// 
			this.dataPanelOne.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dataPanelOne.ColumnCount = 2;
			this.dataPanelOne.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.27415F));
			this.dataPanelOne.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.72585F));
			this.dataPanelOne.Controls.Add(this.imaginaryPartValue, 1, 3);
			this.dataPanelOne.Controls.Add(this.realPartValue, 1, 2);
			this.dataPanelOne.Controls.Add(this.maxIterationsValue, 1, 1);
			this.dataPanelOne.Controls.Add(this.label4, 0, 1);
			this.dataPanelOne.Controls.Add(this.rpLabel, 0, 2);
			this.dataPanelOne.Controls.Add(this.ipLabel, 0, 3);
			this.dataPanelOne.Controls.Add(this.breakpointValue, 1, 0);
			this.dataPanelOne.Controls.Add(this.label3, 0, 0);
			this.dataPanelOne.Location = new System.Drawing.Point(9, 29);
			this.dataPanelOne.Name = "dataPanelOne";
			this.dataPanelOne.RowCount = 5;
			this.dataPanelOne.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.dataPanelOne.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.dataPanelOne.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.dataPanelOne.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.dataPanelOne.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 229F));
			this.dataPanelOne.Size = new System.Drawing.Size(429, 352);
			this.dataPanelOne.TabIndex = 4;
			// 
			// imaginaryPartValue
			// 
			this.imaginaryPartValue.DecimalPlaces = 5;
			this.imaginaryPartValue.Enabled = false;
			this.imaginaryPartValue.Font = new System.Drawing.Font("Arial", 10F);
			this.imaginaryPartValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
			this.imaginaryPartValue.Location = new System.Drawing.Point(283, 108);
			this.imaginaryPartValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.imaginaryPartValue.Name = "imaginaryPartValue";
			this.imaginaryPartValue.Size = new System.Drawing.Size(127, 23);
			this.imaginaryPartValue.TabIndex = 9;
			// 
			// realPartValue
			// 
			this.realPartValue.DecimalPlaces = 5;
			this.realPartValue.Enabled = false;
			this.realPartValue.Font = new System.Drawing.Font("Arial", 10F);
			this.realPartValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
			this.realPartValue.Location = new System.Drawing.Point(283, 73);
			this.realPartValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.realPartValue.Name = "realPartValue";
			this.realPartValue.Size = new System.Drawing.Size(127, 23);
			this.realPartValue.TabIndex = 8;
			// 
			// maxIterationsValue
			// 
			this.maxIterationsValue.Font = new System.Drawing.Font("Arial", 10F);
			this.maxIterationsValue.Location = new System.Drawing.Point(283, 38);
			this.maxIterationsValue.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.maxIterationsValue.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.maxIterationsValue.Name = "maxIterationsValue";
			this.maxIterationsValue.Size = new System.Drawing.Size(127, 23);
			this.maxIterationsValue.TabIndex = 7;
			this.maxIterationsValue.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 14.5F);
			this.label4.Location = new System.Drawing.Point(3, 35);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(133, 23);
			this.label4.TabIndex = 1;
			this.label4.Text = "Max iterations";
			// 
			// rpLabel
			// 
			this.rpLabel.AutoSize = true;
			this.rpLabel.Enabled = false;
			this.rpLabel.Font = new System.Drawing.Font("Arial", 14.5F);
			this.rpLabel.Location = new System.Drawing.Point(3, 70);
			this.rpLabel.Name = "rpLabel";
			this.rpLabel.Size = new System.Drawing.Size(91, 23);
			this.rpLabel.TabIndex = 2;
			this.rpLabel.Text = "Real part";
			// 
			// ipLabel
			// 
			this.ipLabel.AutoSize = true;
			this.ipLabel.Enabled = false;
			this.ipLabel.Font = new System.Drawing.Font("Arial", 14.5F);
			this.ipLabel.Location = new System.Drawing.Point(3, 105);
			this.ipLabel.Name = "ipLabel";
			this.ipLabel.Size = new System.Drawing.Size(137, 23);
			this.ipLabel.TabIndex = 3;
			this.ipLabel.Text = "Imaginary part";
			// 
			// breakpointValue
			// 
			this.breakpointValue.DecimalPlaces = 2;
			this.breakpointValue.Font = new System.Drawing.Font("Arial", 10F);
			this.breakpointValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.breakpointValue.Location = new System.Drawing.Point(283, 3);
			this.breakpointValue.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
			this.breakpointValue.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.breakpointValue.Name = "breakpointValue";
			this.breakpointValue.Size = new System.Drawing.Size(127, 23);
			this.breakpointValue.TabIndex = 6;
			this.breakpointValue.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 14.5F);
			this.label3.Location = new System.Drawing.Point(3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(155, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "Breakpoint value";
			// 
			// rbCyclosorus
			// 
			this.rbCyclosorus.AutoSize = true;
			this.rbCyclosorus.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.rbCyclosorus.Location = new System.Drawing.Point(134, 3);
			this.rbCyclosorus.Name = "rbCyclosorus";
			this.rbCyclosorus.Size = new System.Drawing.Size(130, 20);
			this.rbCyclosorus.TabIndex = 2;
			this.rbCyclosorus.Text = "Cyclosorus Fern";
			this.rbCyclosorus.UseVisualStyleBackColor = true;
			this.rbCyclosorus.CheckedChanged += new System.EventHandler(this.rbCyclosorus_CheckedChanged);
			// 
			// rbCulcita
			// 
			this.rbCulcita.AutoSize = true;
			this.rbCulcita.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.rbCulcita.Location = new System.Drawing.Point(289, 3);
			this.rbCulcita.Name = "rbCulcita";
			this.rbCulcita.Size = new System.Drawing.Size(103, 20);
			this.rbCulcita.TabIndex = 3;
			this.rbCulcita.Text = "Culcita Fern";
			this.rbCulcita.UseVisualStyleBackColor = true;
			this.rbCulcita.CheckedChanged += new System.EventHandler(this.rbCulcita_CheckedChanged);
			// 
			// FractalForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1183, 708);
			this.Controls.Add(this.dataGroupBox);
			this.Controls.Add(this.rbFractals);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Title);
			this.Controls.Add(this.canvas);
			this.Name = "FractalForm";
			this.Text = "FractalForm";
			this.Load += new System.EventHandler(this.ControlForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
			this.rbFractals.ResumeLayout(false);
			this.rbFractals.PerformLayout();
			this.dataGroupBox.ResumeLayout(false);
			this.dataGroupBox.PerformLayout();
			this.tlpFern.ResumeLayout(false);
			this.tlpFern.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.dataFernPanel.ResumeLayout(false);
			this.dataFernPanel.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.fernIterations)).EndInit();
			this.dataPanelOne.ResumeLayout(false);
			this.dataPanelOne.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.imaginaryPartValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.realPartValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.maxIterationsValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.breakpointValue)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox canvas;
		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel rbFractals;
		private System.Windows.Forms.RadioButton rbMandelbrot;
		private System.Windows.Forms.RadioButton rbJulia;
		private System.Windows.Forms.RadioButton rbAnimatedJulia;
		private System.Windows.Forms.GroupBox dataGroupBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ProgressBar renderBar;
		private System.Windows.Forms.TableLayoutPanel dataPanelOne;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label rpLabel;
		private System.Windows.Forms.Label ipLabel;
		private System.Windows.Forms.Button drawButton;
		private System.Windows.Forms.NumericUpDown breakpointValue;
		private System.Windows.Forms.NumericUpDown imaginaryPartValue;
		private System.Windows.Forms.NumericUpDown realPartValue;
		private System.Windows.Forms.NumericUpDown maxIterationsValue;
		private System.Windows.Forms.RadioButton rbDragon;
		private System.Windows.Forms.RadioButton rbSierpinski;
		private System.Windows.Forms.RadioButton rbFern;
		private System.Windows.Forms.TableLayoutPanel dataFernPanel;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox apOne;
		private System.Windows.Forms.TextBox bpOne;
		private System.Windows.Forms.TextBox cpOne;
		private System.Windows.Forms.TextBox dpOne;
		private System.Windows.Forms.TextBox epOne;
		private System.Windows.Forms.TextBox fpOne;
		private System.Windows.Forms.TextBox pOne;
		private System.Windows.Forms.TextBox cpTwo;
		private System.Windows.Forms.TextBox bpTwo;
		private System.Windows.Forms.TextBox dpTwo;
		private System.Windows.Forms.TextBox epTwo;
		private System.Windows.Forms.TextBox apTwo;
		private System.Windows.Forms.TextBox fpTwo;
		private System.Windows.Forms.TextBox pTwo;
		private System.Windows.Forms.TextBox cpThree;
		private System.Windows.Forms.TextBox dpThree;
		private System.Windows.Forms.TextBox bpThree;
		private System.Windows.Forms.TextBox apThree;
		private System.Windows.Forms.TextBox pThree;
		private System.Windows.Forms.TextBox epThree;
		private System.Windows.Forms.TextBox fpThree;
		private System.Windows.Forms.TextBox apFour;
		private System.Windows.Forms.TextBox cpFour;
		private System.Windows.Forms.TextBox dpFour;
		private System.Windows.Forms.TextBox fpFour;
		private System.Windows.Forms.TextBox epFour;
		private System.Windows.Forms.TextBox bpFour;
		private System.Windows.Forms.TextBox pFour;
		private System.Windows.Forms.Label errorLabel;
		private System.Windows.Forms.TableLayoutPanel tlpFern;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.RadioButton rbDefaultFern;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.RadioButton rbFractalTree;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.NumericUpDown fernIterations;
		private System.Windows.Forms.RadioButton rbCyclosorus;
		private System.Windows.Forms.RadioButton rbCulcita;
	}
}