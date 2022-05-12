using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
// icons from icons8.com
{
	public partial class Frm22CardGame : Form
	{
		readonly MyNUD numW = new();
		readonly Random rnd = new();
		Panel[] pnl = new Panel[7];
		readonly int[] cardnums = new int[7];
		readonly int[] cards = new int[7];
		readonly bool[] cardused = new bool[7]; // bool[] defaults to false for all items
		bool stopgame;
		int Hsum;
		int Psum;
		decimal score = 1000;
		public Frm22CardGame()
		{
			InitializeComponent();
			Shown += NumSet;
			Load += Setup;
			pnlCard2.Click += Hit;
			pnlCard3.Click += Hit;
			btnDeal.Click += Setup;
			btnStand.Click += Hit;
			btnRules.Click += Rules;
		}
		// Custom NumericUpDown for Fib Sequence
		class MyNUD : NumericUpDown
		{
			public override void UpButton() { int n = (int)Math.Round((double)Value * ((1 + Math.Sqrt(5)) / 2.0)); if (n < Maximum) Value = n; else Value = Maximum; if (Value == 0) Value = 1; }
			public override void DownButton() { int n = (int)Math.Round((double)Value / ((1 + Math.Sqrt(5)) / 2.0)); if (n >= Minimum) Value = n; if (Value == 0) Value = 1; }
		}
		// Set up the overriden NumericUpDown
		public void NumSet(object sender, EventArgs e)
		{
			numW.Size = numWager.Size;
			numW.Location = numWager.Location;
			numW.Value = 1;
			numW.Minimum = 0;
			numW.Maximum = 1000;
			numW.KeyPress += ValidEntry;
			TextBox txt = (TextBox)numW.Controls[1];
			numW.KeyUp += (p, e) => { if (txt.Text == "" && 1! < numW.Maximum) numW.Value = 1; else txt.Text = $"{numW.Value}"; };
			numW.TextChanged += (s, e) => { if (numW.Text.StartsWith("0")) numW.Text = numW.Text.TrimStart('0'); };
			pnlWager.Controls.Add(numW);
			numWager.Hide();
			numW.Show();
		}
		public void ValidEntry(object sender, KeyPressEventArgs e)
		{
			NumericUpDown box = sender as NumericUpDown;
			TextBox txt = (TextBox)numW.Controls[1];
			if (e.KeyChar != '\b' && (e.KeyChar < '0' | e.KeyChar > '9')) e.Handled = true;
			else if (e.KeyChar != '\b' && Convert.ToInt32(box.Text.Remove(txt.SelectionStart, txt.SelectionLength).Insert(((TextBox)numW.Controls[1]).SelectionStart, $"{e.KeyChar}")) > numW.Maximum) e.Handled = true;
			box.Validate(true);
		}
		public IEnumerable<Control> GetAll(Control.ControlCollection items)
		{
			List<Control> allItems = new();
			foreach (Control item in items.OfType<Control>()) { allItems.Add(item); allItems.AddRange(GetAll(item.Controls)); }
			return allItems;
		}
		public void Setup(object sender, EventArgs e)
		{
			lblRTotal.Text = "";
			for (int i = 0; i < cardnums.Length; i++) { cardnums[i] = Rand(2, 14); } // an ace is an 11 so the count starts at 2
			for (int i = 0; i < cardnums.Length; i++) { cards[i] = (cardnums[i] - 2) * 4 + Rand(0, 3); } // subtract 2 from above (start at 0)
			pnl = GetAll(Controls).OfType<Panel>().Where(a => a.Name.StartsWith("pnlCard")).OrderBy(x => x.Name).ToArray();
			for (int i = 0; i < pnl.Length; i++) { if (i != 2 && i != 3 && i != 6) SetCard(i); else { pnl[i].BackgroundImage = Resources.Cards; cardused[i] = false; } }
			Game();
		}
		public int Rand(int low, int high) { return rnd.Next(low, high + 1); } // Better random than Random.Next
		public void SetCard(int i) { cardused[i] = true; pnl[i].BackgroundImage = lstCards.Images[cards[i]]; }
		public int GetCardVal(int slot) { return slot switch { < 12 => slot, _ => 10 }; }
		public void Hit(object sender, EventArgs e)
		{
			if (numW.Value == 0 && sender is not Frm21Dice) MessageBox.Show("Sorry, You have no points to wager.", "INVALID");
			else
			{
				if (Hsum < 21 && Psum > Hsum) { if (!cardused[6]) SetCard(6); }
				lblRTotal.Text = "";
				if (!stopgame)
				{
					if (sender is Panel pan)
					{
						if (!cardused[2] && pan.Name.Last() == '2') SetCard(2);
						else if (cardused[2] && !cardused[3] && pan.Name.Last() == '3') { SetCard(3); stopgame = true; }
					}
					else { stopgame = true; }
				}
				Game();
			}
		}
		public void Game()
		{
			int[] PScore = new int[7];
			for (int i = 0; i <= 3; i++) PScore[i] = (cardused[i] ? 1 : 0) * GetCardVal(cardnums[i]);
			Psum = PScore.Sum();
			int[] HScore = new int[7];
			for (int i = 4; i <= 6; i++) HScore[i] = (cardused[i] ? 1 : 0) * GetCardVal(cardnums[i]);
			Hsum = HScore.Sum();
			int UpTo = cardnums.Take(4).Where(a => a == 11).Count();
			while (Psum > 21 && UpTo > 0) { Psum -= 10; UpTo--; }
			lblPTotal.Text = $"{Psum}";
			lblHTotal.Text = $"{Hsum}";
			if (Psum >= 21 || Hsum > 21) stopgame = true;
			if (cardused[6] && Hsum < 21 && Psum < 21 && Psum > Hsum) stopgame = true;
			if (stopgame)
			{
				if (Psum > 21 && Hsum > 21) { lblRTotal.Text = "Draw"; }
				else if (Psum > 21) { lblRTotal.Text = "You Lose"; score -= numW.Value; }
				else if (Hsum > 21) { lblRTotal.Text = "You Win"; score += numW.Value; }
				else if (Psum > Hsum) { lblRTotal.Text = "You Win"; score += numW.Value; }
				else if (Psum < Hsum) { lblRTotal.Text = "You Lose"; score -= numW.Value; }
				else { lblRTotal.Text = "Draw"; }
				lblScore.Text = $"{score}";
				numW.Maximum = score;
				stopgame = false;
				MessageBox.Show(lblRTotal.Text);
				Setup(null, null);
			}
		}
		public void Rules(object sender, EventArgs e)
		{
			string rules =
				"Try to be closer to 21 that the house!\n" +
				"Click on the hidden cards to be dealt them.\n" +
				"Click on \"stand\" when you believe you can win.\n" +
				"Click \"Deal\" to be dealt a new hand to play with.\n" +
				"Win against the house to earn what you have wagered!";
			MessageBox.Show(rules, "RULES");
		}
	}
}