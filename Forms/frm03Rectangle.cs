// Enter icon sourced from https://icons8.com/icon/62334/enter-mac-key
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class FrmRectangle : Form
	{
		public object Placeholder;
		private static FrmMathre BaseForm;
		public FrmRectangle()
		{
			InitializeComponent();
			Load += FormLoad;
			txtRectangleDimensions.KeyPress += Rectangle;
			txtRectangleDimensions.TextChanged += Rectangle;
			KeyDown += KeyboardShortcuts;
			txtRectangleDimensions.KeyPress += RectangleKeypress;
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<FrmMathre>().Single();
			lblRectangleError.Visible = false;
			pnlRectangle.Visible = false;
			foreach (Control c in Controls)
			{
				BaseForm.GetAllControls(c);
			}
		}
		public void Rectangle(object sender, EventArgs e)
		{
			double Height = 0;
			double Width = 0;
			string[] words = txtRectangleDimensions.Text.Split(' ');
			if (words.Length > 2)
			{
				if (double.TryParse(words[2], out double HeightValue))
				{
					Height = HeightValue;
				}
				if (double.TryParse(words[0], out double WidthValue))
				{
					Width = WidthValue;
				}
			}
			if (ReferenceEquals(sender, Placeholder) || ReferenceEquals(sender, txtRectangleDimensions))
			{
				var ratioX = (double)pnlRectangle.MaximumSize.Width / Width;
				var ratioY = (double)pnlRectangle.MaximumSize.Height / Height;
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
		public void KeyboardShortcuts(object sender, KeyEventArgs e)
		{
			if (txtRectangleDimensions.ContainsFocus)
			{
				if (e.KeyCode == Keys.Enter)
				{
					Rectangle(Placeholder, null);
				}
				if (e.KeyCode == Keys.Delete)
				{
					e.Handled = true;
				}
				if (e.KeyCode == Keys.Control)
				{
					e.Handled = true;
				}
			}
		}
		public void RectangleKeypress(object sender, KeyPressEventArgs e)
		{
			string DecimalChar = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
			int space1 = (txtRectangleDimensions.Text.IndexOf(" "));
			int x1 = (txtRectangleDimensions.Text.IndexOf("x"));
			int space2 = (txtRectangleDimensions.Text.IndexOf(" ", txtRectangleDimensions.Text.IndexOf(" ") + 1));
			int currentpos = (txtRectangleDimensions.SelectionStart - 1);
			int modifier = 0;
			string[] words = txtRectangleDimensions.Text.Split(' ');
			if (!(e.KeyChar == (char)Keys.Return))
			{
				pnlRectangle.Visible = false;
				lblRectangleArea.Text = "Area";
				lblRectanglePerimeter.Text = "Perimeter";
			}
			if (sender is not TextBoxBase textBox)
				return;
			if (txtRectangleDimensions.SelectedText.Contains(' ') || txtRectangleDimensions.SelectedText.Contains('x'))
			{
				if (e.KeyChar == '\b')
				{
					e.Handled = true;
					txtRectangleDimensions.SelectedText = "";
					int selectionIndex = textBox.SelectionStart;
					txtRectangleDimensions.Text = txtRectangleDimensions.Text.Replace(" x ", "");
					txtRectangleDimensions.Text = txtRectangleDimensions.Text.Replace(" x", "");
					txtRectangleDimensions.Text = txtRectangleDimensions.Text.Replace("x ", "");
					txtRectangleDimensions.Text = txtRectangleDimensions.Text.Replace(" ", "");
					if (currentpos == space1) modifier = 1;
					else if (currentpos == x1) modifier = 2;
					else if (currentpos == space2) modifier = 3;
					else modifier = 0;
					textBox.SelectionStart = selectionIndex - modifier;
				}
			}
			if (e.KeyChar.ToString() == DecimalChar)
			{
				if (words.Length > 2)
				{
					if (currentpos < space1)
					{
						if (words[0].Contains(DecimalChar))
						{
							e.Handled = true;
						}
					}
					else if (currentpos >= space2)
					{
						if (words[2].Contains(DecimalChar))
						{
							e.Handled = true;
						}
					}
					else
					{
						e.Handled = true;
					}
				}
				else if (textBox.Text.Contains(DecimalChar))
				{
					e.Handled = true;
				}
			}
			else if ((e.KeyChar != '\b' && (e.KeyChar < '0' || e.KeyChar > '9')))
			{
				if (textBox.Text.Contains(" x "))
				{
					e.Handled = true;
				}
				else
				{
					e.Handled = true;
					string insertText = " x ";
					int selectionIndex = textBox.SelectionStart;
					textBox.Text = textBox.Text.Insert(selectionIndex, insertText);
					textBox.SelectionStart = selectionIndex + 3;
				}
			}
			else if ((currentpos == space1 || currentpos == x1 || currentpos == space2) && currentpos != -1)
			{
				if (currentpos != space2)
				{
					e.Handled = true;
				}
				if (currentpos == space1 || currentpos == x1 || currentpos == space2 && currentpos != -1)
				{
					if (e.KeyChar == '\b')
					{
						if (txtRectangleDimensions.Text.Contains(" x "))
						{
							e.Handled = true;
							int selectionIndex = textBox.SelectionStart;
							txtRectangleDimensions.Text = txtRectangleDimensions.Text.Replace(" x ", "");
							if (currentpos == space1) modifier = 1;
							if (currentpos == x1) modifier = 2;
							if (currentpos == space2) modifier = 3;
							textBox.SelectionStart = selectionIndex - modifier;

						}
					}
				}
			}
			Rectangle(Placeholder, null);
		}
	}
}
