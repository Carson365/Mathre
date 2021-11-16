using System;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class FrmSlots : Form
	{
		public static FrmMathre BaseForm;
		public static FrmSlots ThisForm;
		public int tokens = 100;
		public FrmSlots()
		{
			InitializeComponent();
			Load += FormLoad;
			btnSpin.Click += Gamble;
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<FrmMathre>().Single();
			ThisForm = Application.OpenForms.OfType<FrmSlots>().Single();
			foreach (Control c in Controls)
			{
				BaseForm.GetAllControls(c);
			}
		}
		public void Gamble(object sender, EventArgs e)
		{
			lblWinIndicator.Text = "";
			if (tokens <= 0)
			{
				Message("No Tokens", null);
			}
			else
			{
				if (tokens == 1 && chbDouble.Checked)
				{
					chbDouble.Checked = false;
				}
				tokens -= (1 + Convert.ToInt32(chbDouble.Checked));
				Random rnd = new();
				int random1 = rnd.Next(1, 4);
				lbl1.Text = $"{random1}";
				int random2 = rnd.Next(1, 4);
				lbl2.Text = $"{random2}";
				int random3 = rnd.Next(1, 4);
				lbl3.Text = $"{random3}";
				if (random1 == 1 && random2 == 1 && random3 == 1)
				{
					tokens += (5 + (Convert.ToInt32(chbDouble.Checked) * 5));
					Message("Jackpot!!", null);
				}
				else if (random1 == 2 && random2 == 2 && random3 == 2)
				{
					tokens += (10 + (Convert.ToInt32(chbDouble.Checked) * 10));
					Message("Jackpot!!", null);
				}
				else if (random1 == 3 && random2 == 3 && random3 == 3)
				{
					tokens += (15 + (Convert.ToInt32(chbDouble.Checked) * 15));
					Message("Jackpot!!", null);
				}
			}
			lblScore.Text = $"{tokens}";
		}
		public void Message(object sender, EventArgs e)
		{
			lblScore.Text = $"{tokens}";
			lblWinIndicator.Text = $"{sender}";
			if (chbDisableMessagebox.Checked)
			{
				MessageBox.Show($"{sender}", "                                        Result                                        ");
			}
		}
	}
}
