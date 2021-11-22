using System;
using System.Threading.Tasks;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class FrmSlots : Form
	{
		public static FrmMathre BaseForm;
		public static FrmSlots ThisForm;
		public int tokens = 100;
		public int animate = 0;
		public int counter = 3;
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
				Random rnd = new(); // Generate random numbers 1-3
				int random1 = rnd.Next(1, 4);
				lbl1.Text = $"{random1}";
				int random2 = rnd.Next(1, 4);
				lbl2.Text = $"{random2}";
				int random3 = rnd.Next(1, 4);
				lbl3.Text = $"{random3}";
				while (animate < 7)
				{
					lbl1.Location = new System.Drawing.Point(lbl1.Location.X, lbl1.Location.Y + animate -1);
					await Task.Delay(20);
					animate++;
					if (animate == 5 && counter < 7)
					{
						animate = -counter;
						counter++;
					}
				}
				if (random1 == 1 && random2 == 1 && random3 == 1) // Increase the token count and display the jackpot message for each jackpot
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
		public void MenuHandler(object sender, EventArgs e)
		{
			Action A = sender.ToString() switch
			{
				"Spin" => () => ((Button)ThisForm.pnlWager.Controls[$"btn{sender}"]).PerformClick(),
				"Double Or Nothing" => () => ThisForm.chbDouble.Checked = !ThisForm.chbDouble.Checked,
				_ => () => ThisForm.chbMessage.Checked = !ThisForm.chbMessage.Checked,
			};
			A.Invoke();
		}
		public void Message(object sender, EventArgs e)
		{
			lblScore.Text = $"{tokens}"; // Update score before displaying the message box
			lblWinIndicator.Text = $"{sender}";
			if (chbMessage.Checked) // Ensure the user wants to see the message box
			{
				MessageBox.Show($"{sender}", "                                        Result                                        ");
			}
		}
	}
}
