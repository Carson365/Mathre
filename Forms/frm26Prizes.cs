using System;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm26Prizes : Form
	{
		Button[,] ButtonsL;
		bool[,] Buttons;
		int ButtonsX = 5;
		int ButtonsY = 5;
		int guesses = 0;
		readonly Random rnd = new();
		public Frm26Prizes()
		{
			InitializeComponent();
			HandleCreated += (p, e) => { Setup(); foreach (Button b in ButtonsL) b.Enabled = false; ButtonsX = -1; };
			btnPlay.Click += Play;
		}
		private void Setup()
		{
			Buttons = new bool[ButtonsX, ButtonsY];
			ButtonsL = new Button[ButtonsX, ButtonsY];
			//
			for (int y = 0; y < Buttons.GetLength(1); y++)
			{
				for (int x = 0; x < Buttons.GetLength(0); x++)
				{
					Button b = new()
					{
						Size = new System.Drawing.Size(50, 50),
						Location = new System.Drawing.Point(20 + 60 * x, 20 + 60 * y),
					};
					b.Click += (p, e) => b.Text = "X";
					b.Enabled = true;
					pnlFrame.Controls.Add(b);
					ButtonsL[x,y] = b;
				}
			}
				Generate();
		}
		private void Generate()
		{
			// Two different random X values
			int rndX1 = rnd.Next(ButtonsX);
			int rndX2 = rnd.Next(ButtonsX);
			while (rndX2 == rndX1) rndX2 = rnd.Next(ButtonsX);
			// Two different random Y values
			int rndY1 = rnd.Next(ButtonsY);
			int rndY2 = rnd.Next(ButtonsY);
			while (rndY2 == rndY1) rndY2 = rnd.Next(ButtonsY);
			// Set the correct indices
			Buttons[rndX1, rndY1] = true;
			Buttons[rndX2, rndY2] = true;
			// Set the button click event
			ButtonsL[rndX1, rndY1].Click += (p, e) => ButtonsL[rndX1, rndY1].Text = "Comp";
			ButtonsL[rndX2, rndY2].Click += (p, e) => ButtonsL[rndX2, rndY2].Text = "uter";
		}
		private void Play(object sender, EventArgs e)
		{
			// Regenerate Grid if different amounts are desired
			Action A = () => { foreach (Button b in ButtonsL) pnlFrame.Controls.Remove(b); };
			if (ButtonsX != nudX.Value || ButtonsY != nudY.Value) { ButtonsX = Convert.ToInt16(nudX.Value); ButtonsY = Convert.ToInt16(nudY.Value); A.Invoke(); Setup(); }
		}
		private void Guess(object sender, EventArgs e)
		{
			guesses++;
			if (guesses > 0)
			{

			}
			else
			{
				//foreach (bool b in ButtonsL) { if (b) Buttons[ButtonsL.]}
				//foreach ( bool A in ButtonsL ) 
				//int emptyBox = Array.FindIndex(Buttons.GetLength(1), true);
				foreach (Button b in ButtonsL) b.Enabled = false;
			}
		}
	}
}
