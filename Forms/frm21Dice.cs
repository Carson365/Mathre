using System;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm21Dice : Form
	{
		decimal wagerstep = 0;
		decimal lastvalue = 0;
		decimal wagersave = 0;
		public Frm21Dice()
		{
			InitializeComponent();
			//numWager.Click += Wage;
			numWager.ValueChanged += Wage;
		}
		public void Default(object sender, EventArgs e)
		{

		}
		public void Wage(object sender, EventArgs e)
		{
			if (numWager.Value < lastvalue)
			{
				numWager.Value += wagersave ;
				//numWager.Increment -= wagerstep;

			}
			if (numWager.Value > lastvalue)
			{
				wagersave = wagerstep;
				wagerstep = numWager.Increment;
				numWager.Increment += wagersave;
				Console.WriteLine($"wagersave: {wagersave}");
				Console.WriteLine($"wagerstep: {wagerstep}");
				Console.WriteLine($"numWager.Increment: {numWager.Increment}");
				Console.WriteLine($"numWager.Value: {numWager.Value}");
			}
			lastvalue = numWager.Value;
		}
	}
}