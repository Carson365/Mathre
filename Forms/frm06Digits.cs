using System;
using System.Linq;
using System.Windows.Forms;

namespace Mathre
{
	public partial class Frm06Digits : Form, Forms.IManager
	{
		public static Frm00Mathre BaseForm;
		public Frm06Digits()
		{
			InitializeComponent();
			Load += FormLoad;
			txtNumber.KeyPress += InputFormatter;
		}
		public void FormLoad(object sender, EventArgs e)
		{
			lblDigitsListOdds.Text = "";
			lblDigitsListEvens.Text = "";
			BaseForm = Application.OpenForms.OfType<Frm00Mathre>().Single();
			foreach (Control c in Controls) { BaseForm.GetAllControls(c); }
		}
		public void MenuControl(object sender, EventArgs e)
		{
			if (sender.GetType().Name == "ToolStripTextBox")
			{
				var senderName = ((ToolStripTextBox)sender).Name;
				((TextBox)Controls.Find(senderName, true)[0]).Text = ((ToolStripTextBox)sender).Text;
			}
			else
			{
				var senderName = ((ToolStripMenuItem)sender).Name;
				Action a = senderName.Substring(0, 3) switch
				{
					"Button" => () => ((Button)Controls.Find(senderName, true)[0]).PerformClick(),
					"RadioButton" => () => ((RadioButton)Controls.Find(senderName, true)[0]).PerformClick(),
					"CheckBox" => () => ((CheckBox)Controls.Find(senderName, true)[0]).Checked ^= true,
					_ => null,
				};
				a?.Invoke();
			}
		}
		public void Digits(object sender, EventArgs e)
		{
			int.TryParse(lblDigitsCount.Text, out int a);
			if (txtNumber.Text.Length > a)
			{
				var label = (txtNumber.SelectionStart % 2) switch { 0 => lblDigitsListEvens, _ => lblDigitsListOdds };
				if (label.Text.Contains($"Digit {txtNumber.SelectionStart}:")) { DigitsRedo(null, null); }
				else { label.Text += $"Digit {txtNumber.SelectionStart}: {txtNumber.Text[txtNumber.SelectionStart - 1]}\r\n"; }
			}
			else
			{
				if (txtNumber.SelectionStart == txtNumber.Text.Length + 1)
				{
					var label = (txtNumber.SelectionStart % 2) switch { 1 => lblDigitsListEvens, _ => lblDigitsListOdds };
					label.Text = label.Text.Remove(label.Text.Length - 13);
				}
				else { DigitsRedo(null, null); }
			}
			lblDigitsCount.Text = $"{txtNumber.Text.Length}";
		}
		public void DigitsRedo(object sender, KeyEventArgs e)
		{
			lblDigitsListEvens.Text = "";
			lblDigitsListOdds.Text = "";
			for (int i = 0; i < txtNumber.Text.Length; i++)
			{
				char c = txtNumber.Text[i];
				var label = ((txtNumber.Text.IndexOf(c, i) + 1) % 2) switch { 0 => lblDigitsListEvens, _ => lblDigitsListOdds };
				label.Text += $"Digit {i + 1}: {c}\r\n";
			}
		}
		public void InputFormatter(object sender, KeyPressEventArgs e)
		{
			if (sender is not TextBoxBase) return;
			if ((e.KeyChar != '\b' && (e.KeyChar < '0' || e.KeyChar > '9'))) { e.Handled = true; }
			Digits(null, null);
		}
	}
}
