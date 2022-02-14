// SOURCES:
// Enter Icon: https://icons8.com/icon/62334/enter-mac-key
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm03Rectangle : Form
	{
		public static object Placeholder;
		public static Frm00Mathre BaseForm;
		public int lastvalue = 0;
		public Frm03Rectangle()
		{
			InitializeComponent();
			Load += FormLoad;
			txtRectangleDimensions.KeyPress += Rectangle;
			txtRectangleDimensions.TextChanged += Rectangle;
			txtRectangleDimensions.KeyDown += RectangleKeypress;
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<Frm00Mathre>().Single();
			lblRectangleError.Visible = false;
			pnlRectangle.Visible = false;
			foreach (Control c in Controls) { BaseForm.GetAllControls(c); }
			KeyPreview = true;
		}
		public void Rectangle(object sender, EventArgs e)
		{
			double Height = 0;
			double Width = 0;
			string[] words = txtRectangleDimensions.Text.Split('*');
			if (words.Length > 1)
			{
				if (double.TryParse(words[1], out double HeightValue)) { Height = HeightValue; }
				if (double.TryParse(words[0], out double WidthValue)) { Width = WidthValue; }
			}
			if (ReferenceEquals(sender, Placeholder) || ReferenceEquals(sender, txtRectangleDimensions))
			{
				var ratioX = pnlRectangle.MaximumSize.Width / Width;
				var ratioY = pnlRectangle.MaximumSize.Height / Height;
				var ratio = Math.Min(ratioX, ratioY);
				var newWidth = (int)(Width * ratio);
				var newHeight = (int)(Height * ratio);
				pnlRectangle.Width = newWidth;
				pnlRectangle.Height = newHeight;
				pnlRectangle.Left = (pnlRectangle.Parent.Width - pnlRectangle.Width) / 2;
				pnlRectangle.Top = (pnlRectangle.Parent.Height - pnlRectangle.Height) / 2;
				pnlRectangle.Visible = true;
				lblRectangleError.Visible = false;
				if ((newHeight == 0 || newWidth == 0) && (!(Height == 0 || Width == 0)))
				{
					lblRectangleError.Text = "Invalid Visualization";
					lblRectangleError.Visible = true;
					lblRectangleArea.Text = (Width * Height).ToString();
					lblRectanglePerimeter.Text = (2 * Width + 2 * Height).ToString();
				}
				else if ((Height == 0 || Width == 0 || newHeight == -2147483648 || newWidth == -2147483648))
				{
					lblRectangleError.Text = "Invalid Dimensions";
					lblRectangleError.Visible = true;
					lblRectangleArea.Text = "Invalid Dimensions";
					lblRectanglePerimeter.Text = "Invalid Dimensions";
				}
				else
				{
					lblRectangleArea.Text = (Width * Height).ToString();
					lblRectanglePerimeter.Text = (2 * Width + 2 * Height).ToString();
				}
			}
		}
		public void RectangleKeypress(object sender, KeyEventArgs e)
		{
			TextBox textBox = sender as TextBox;
			string DecimalChar = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
			string[] words = textBox.Text.Split('*');
			if (!(e.KeyCode == Keys.Left || e.KeyCode == Keys.Right))
			{
				pnlRectangle.Visible = false;
				lblRectangleArea.Text = "Area";
				lblRectanglePerimeter.Text = "Perimeter";

				if (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Decimal)
				{
					if (textBox.SelectionStart > words[0].Length && words[1].Contains(DecimalChar)) { e.SuppressKeyPress = true; }
					else if (textBox.SelectionStart < words[0].Length && words[0].Contains(DecimalChar)) { e.SuppressKeyPress = true; }
				}
				else if (e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete)
				{
					if (e.Shift)
					{
						if (e.KeyCode == Keys.D8) { if (textBox.Text.Contains("*")) { e.SuppressKeyPress = true; } }
						else { e.SuppressKeyPress = true; }
					}
					else if (((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)))
					{
						if (textBox.Text.Contains("*"))
						{
							e.SuppressKeyPress = true;
							if (textBox.SelectedText.Contains('*')) { textBox.SelectedText = ""; textBox.AppendText("*"); }
						}
						else
						{
							e.SuppressKeyPress = true;
							int selectionIndex = textBox.SelectionStart;
							textBox.Text = textBox.Text.Insert(selectionIndex, "*");
							textBox.SelectionStart = selectionIndex + 1;
						}
					}
				}
				Rectangle(Placeholder, null);
			}
		}
		public void RectangleKeypress2(object sender, KeyEventArgs e)
		{
			ToolStripTextBox textBox = sender as ToolStripTextBox;
			string DecimalChar = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
			string[] words = textBox.Text.Split('*');
			if (!(e.KeyCode == Keys.Left || e.KeyCode == Keys.Right))
			{
				pnlRectangle.Visible = false;
				lblRectangleArea.Text = "Area";
				lblRectanglePerimeter.Text = "Perimeter";
				
				if (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Decimal)
				{
					if (textBox.SelectionStart > words[0].Length && words[1].Contains(DecimalChar)) { e.SuppressKeyPress = true; }
					else if (textBox.SelectionStart < words[0].Length && words[0].Contains(DecimalChar)) { e.SuppressKeyPress = true; }
				}
				else if (e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete)
				{
					if (e.Shift)
					{
						if (e.KeyCode == Keys.D8) { if (textBox.Text.Contains("*")) { e.SuppressKeyPress = true; } }
						else { e.SuppressKeyPress = true; }
					}
					else if (((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)))
					{
						if (textBox.Text.Contains("*"))
						{
							e.SuppressKeyPress = true;
							if (textBox.SelectedText.Contains('*')) { textBox.SelectedText = ""; textBox.AppendText("*"); }
						}
						else
						{
							e.SuppressKeyPress = true;
							int selectionIndex = textBox.SelectionStart;
							textBox.Text = textBox.Text.Insert(selectionIndex, "*");
							textBox.SelectionStart = selectionIndex + 1;
						}
					}
				}
				Rectangle(Placeholder, null);
			}
		}
	}
}
