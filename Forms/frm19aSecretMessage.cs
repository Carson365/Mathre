using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm19aSecretMessage : Form
	{
		public static Frm00Mathre BaseForm;
		string einput = "";
		List<int> dinput = new();
		bool decodemode = false;
		public Frm19aSecretMessage()
		{
			InitializeComponent();
			btnInput.Click += Input;
			btnOutput.Click += Output;
			btnClear.Click += Clear;
			chbDecode.CheckedChanged += Decode;
		}
		public void Input(object sender, EventArgs e)
		{
			if (!decodemode) { einput = ""; while (einput == "") einput = Interaction.InputBox("What is your message?", "Secret Message Encoder", ""); SwapEnabled(); }
			else
			{
				List<int> decode = new();
				double Chars = 0;
				int RunCount = 1;
				while (Chars == 0)
				{
					string CharCount = Interaction.InputBox("How many characters to decode?", "Secret Message Decoder", "");
					if (double.TryParse(CharCount, out double CharResult)) Chars = CharResult;
				}
				while (Chars != 0)
				{
					string Place;
					int DivNum = RunCount switch { < 31 => 20, _ => 10, };
					Place = (RunCount % DivNum) switch
					{
						1 => "st",
						2 => "nd",
						3 => "rd",
						_ => "th",
					};
					int NextWord = 0;
					while (NextWord == 0)
					{
						double Numeric = 0;
						while (Numeric == 0)
						{
							string CharCount = Interaction.InputBox($"What is the {RunCount}{Place} character code?", "Secret Message Decoder", "");
							if (int.TryParse(CharCount, out int CharResult)) Numeric = Math.Abs(CharResult);
							NextWord = Math.Abs(CharResult);
						}
					}
					decode.Add((int)NextWord);
					Chars--;
					RunCount++;
				}
				dinput = decode;
				SwapEnabled();
			}
		}
		public void Output(object sender, EventArgs e)
		{
			int height = 0;
			var formb = new Frm19bSecretMessage();
			((Label)formb.Controls.Find("lblCode", true)[0]).Text = "";
			formb.Width = 500;
			formb.Height = 250;
			if (!decodemode) foreach (char c in einput) { ((Label)formb.Controls.Find("lblCode", true)[0]).Text += $"{c} = {(int)c}\n"; height += 15; }
			else foreach (int n in dinput) { ((Label)formb.Controls.Find("lblCode", true)[0]).Text += $"{n} = {(char)n}\n"; height += 15; }
			formb.MinimumSize = new System.Drawing.Size(500, height + 250);
			formb.Show();
		}
		public void Clear(object sender, EventArgs e)
		{
			dinput = null;
			einput = "";
			SwapEnabled();
		}
		public void Decode(object sender, EventArgs e)
		{
			if (!decodemode && einput != "") Clear(null, null);
			if (decodemode && dinput != null) Clear(null, null);
			decodemode ^= true;
		}
		public void SwapEnabled()
		{
			btnInput.Enabled ^= true;
			btnOutput.Enabled ^= true;
			btnClear.Enabled ^= true;
			BaseForm = Application.OpenForms.OfType<Frm00Mathre>().Single();
			((ToolStripMenuItem)BaseForm.mnuFile.DropDownItems.Find("btnInput", true)[0]).Enabled ^= true;
			((ToolStripMenuItem)BaseForm.mnuFile.DropDownItems.Find("btnOutput", true)[0]).Enabled ^= true;
			((ToolStripMenuItem)BaseForm.mnuFile.DropDownItems.Find("btnClear", true)[0]).Enabled ^= true;
		}
	}
}