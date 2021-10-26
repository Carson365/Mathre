using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Mathre
{
	public partial class FrmRectangle : Form
	{
		public object Placeholder;
		public static FrmMathre main;
		public static FrmRectangle RC;
		public FrmRectangle()
		{
			InitializeComponent();
			Load += FormLoad;
			btnRectangleCalculate.Click += Rectangle;
			txtRectangleDimensions.KeyPress += Rectangle;
			txtRectangleDimensions.TextChanged += Rectangle;
			KeyDown += KeyboardShortcuts;
			txtRectangleDimensions.KeyPress += RectangleKeypress;
		}
		public void FormLoad(object sender, EventArgs e) //Formload event handler
		{
			main = Application.OpenForms.OfType<FrmMathre>().Single();
			RC = Application.OpenForms.OfType<FrmRectangle>().Single();
			lblRectangleError.Visible = false;
			pnlRectangle.Visible = false;
			foreach (Control c in Controls)
			{
				main.GetAllControls(c);
			}
		}
		public void Rectangle(object sender, EventArgs e) // Event handler for the rectangle calculation functions
		{
			double Height = 0; // Add a variable to store the rectangle height
			double Width = 0; // Add a variable to store the rectangle width
			string[] words = txtRectangleDimensions.Text.Split(' '); // Split the input using the spaces as separators
			if (words.Length > 2) // If there are at least three substrings
			{
				if (double.TryParse(words[2], out double HeightValue)) // Check whether the third substring is a number
				{
					Height = HeightValue; // Assign the height value to the third substring if numeric
				}
				if (double.TryParse(words[0], out double WidthValue)) // Check whether the first substring is a number
				{
					Width = WidthValue; // Assign the width value to the first substring if numeric
				}
			}
			if (ReferenceEquals(sender, Placeholder) || ReferenceEquals(sender, txtRectangleDimensions)) // If the rectangle needs to be calculated and visualized
			{
				var ratioX = (double)pnlRectangle.MaximumSize.Width / Width; // Make the X-ratio equal to the proportional size of the maximum width of the visualization rectangle
				var ratioY = (double)pnlRectangle.MaximumSize.Height / Height; // Make the Y-ratio equal to the proportional size of the maximum height of the visualization rectangle
				var ratio = Math.Min(ratioX, ratioY); // Set the overall ratio equal to the smallest of the two ratios
				var newWidth = (int)(Width * ratio); // Create a new width for the visualizer that fits on the screen according to the ratio
				var newHeight = (int)(Height * ratio); // Create a new height for the visualizer that fits on the screen according to the ratio
				pnlRectangle.Width = newWidth; // Set the visualization width to the modified proportional width
				pnlRectangle.Height = newHeight; // Set the visualization height to the modified proportional height
				pnlRectangle.Left = (pnlRectangle.Parent.Width - pnlRectangle.Width) / 2; // Center the rectangle horizontally within its visualization space
				pnlRectangle.Top = (pnlRectangle.Parent.Height - pnlRectangle.Height) / 2; // Center the rectangle vertically within its visualization space
				pnlRectangle.Visible = true; // Make the visualization rectangle visible
				lblRectangleError.Visible = false; // Hide the error label
				if ((newHeight == 0 || newWidth == 0) && (!(Height == 0 || Width == 0))) // Check whether the adjusted sizes (using the ratio) are zero
				{
					lblRectangleError.Text = "Invalid Visualization"; // Show a visualization error message
					lblRectangleError.Visible = true; // Make the error visible
					lblRectangleArea.Text = (Width * Height).ToString(); // Show the area result
					lblRectanglePerimeter.Text = (2 * Width + 2 * Height).ToString(); // Show the perimeter result
				}
				else if ((Height == 0 || Width == 0 || newHeight == -2147483648 || newWidth == -2147483648)) // If the height or width is zero or invalid
				{
					lblRectangleError.Text = "Invalid Dimensions"; // Show an input error message
					lblRectangleError.Visible = true; // Make the error visible
					lblRectangleArea.Text = "Invalid Dimensions"; // Show an input error for the area result
					lblRectanglePerimeter.Text = "Invalid Dimensions"; // Show an input error for the perimeter result
				}
				else
				{
					lblRectangleArea.Text = (Width * Height).ToString(); // Show the area result
					lblRectanglePerimeter.Text = (2 * Width + 2 * Height).ToString(); // Show the perimeter result
				}
			}
		}
		public void KeyboardShortcuts(object sender, KeyEventArgs e) // Event handler for keypresses made within the form (which now includes keypresses from the menu items)
		{
			if (txtRectangleDimensions.ContainsFocus) // Check whether the rectangle calculator is selected
			{
				if (e.KeyCode == Keys.Enter) // Check whether the enter key is pressed
				{
					Rectangle(Placeholder, null); // Run the Rectangle Calculator
				}
				if (e.KeyCode == Keys.Delete) // Check whether the delete key is pressed
				{
					e.Handled = true; // Discard input
				}
				if (e.KeyCode == Keys.Control) // Check whether the control key is pressed
				{
					e.Handled = true; // Discard input
				}
			}
		}
		public void RectangleKeypress(object sender, KeyPressEventArgs e) // Event handler for keypresses within the rectangle calculator input field
		{
			string DecimalChar = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
			int space1 = (txtRectangleDimensions.Text.IndexOf(" ")); // Get the position of the first space in the textbox
			int x1 = (txtRectangleDimensions.Text.IndexOf("x")); // Get the position of the first x in the textbox
			int space2 = (txtRectangleDimensions.Text.IndexOf(" ", txtRectangleDimensions.Text.IndexOf(" ") + 1)); // Get the position of the second space in the textbox
			int currentpos = (txtRectangleDimensions.SelectionStart - 1); // Add a variable represesnting the character that would be deleted with a backspace keypress 
			int modifier = 0; // Introduce the modifier variable
			string[] words = txtRectangleDimensions.Text.Split(' '); // Split the input using the spaces as separators
			if (!(e.KeyChar == (char)Keys.Return)) // Check whether the pressed key is anything other than enter 
			{
				pnlRectangle.Visible = false; // Clear the rectangle
				lblRectangleArea.Text = "Area"; // Clear the area
				lblRectanglePerimeter.Text = "Perimeter"; // Clear the perimeter
			}
			if (sender is not TextBoxBase textBox) // Ensure the sender is the input form -
				return; // -or else discard it
			if (txtRectangleDimensions.SelectedText.Contains(" ") || txtRectangleDimensions.SelectedText.Contains("x")) // If there is a selection made that includes part of the multiplier field
			{
				if (e.KeyChar == '\b') // If backspace is pressed
				{
					e.Handled = true; // Discard the backspace keypress
					txtRectangleDimensions.SelectedText = ""; // Delete the selected text
					int selectionIndex = textBox.SelectionStart; // Get the current position
					txtRectangleDimensions.Text = txtRectangleDimensions.Text.Replace(" x ", ""); // (this one probably isn't needed)
					txtRectangleDimensions.Text = txtRectangleDimensions.Text.Replace(" x", ""); // Delete all variations of the multiplication separator
					txtRectangleDimensions.Text = txtRectangleDimensions.Text.Replace("x ", ""); // Delete all variations of the multiplication separator
					txtRectangleDimensions.Text = txtRectangleDimensions.Text.Replace(" ", ""); // Delete all variations of the multiplication separator
					if (currentpos == space1) modifier = 1; // If the action of deleting put the cursor at the first space, move it back 1 to reallign it
					else if (currentpos == x1) modifier = 2; // If the action of deleting put the cursor at the first x, move it back 2 to reallign it
					else if (currentpos == space2) modifier = 3; // If the action of deleting put the cursor at the second space, move it back 3 to reallign it
					else modifier = 0; // If the selection was outside of the multiplication separator, don't move it
					textBox.SelectionStart = selectionIndex - modifier; // Set the cursor to the modified position
				}
			}
			if (e.KeyChar.ToString() == DecimalChar) // If the pressed key is the user's decimal separator
			{
				if (words.Length > 2) // If there are at least 3 substrings (meaning the multiplication separator exists)
				{
					if (currentpos < space1) // If the cursor is before the first space
					{
						if (words[0].Contains(DecimalChar)) // If there is already a decimal separator
						{
							e.Handled = true; // Discard the decimal separator input
						}
					}
					else if (currentpos >= space2) // If the cursor is at or after the first space
					{
						if (words[2].Contains(DecimalChar)) // If there is already a decimal separator
						{
							e.Handled = true;// Discard the decimal separator input
						}
					}
					else
					{
						e.Handled = true; // Discard the decimal separator input
					}
				}
				else if (textBox.Text.Contains(DecimalChar)) // If there are not multiple number groups and there is already a decimal separator
				{
					e.Handled = true; // Discard the decimal separator input
				}
			}

			else if ((e.KeyChar != '\b' && (e.KeyChar < '0' || e.KeyChar > '9'))) // If a non-backspace non-number character is pressed
			{
				if (textBox.Text.Contains(" x ")) // If there is a multiplication separator
				{
					e.Handled = true; // Discard the character input
				}
				else
				{
					e.Handled = true;  // Discard the character input
					string insertText = " x "; // Set the multiplication separator
					int selectionIndex = textBox.SelectionStart; // Set the current position
					textBox.Text = textBox.Text.Insert(selectionIndex, insertText); // Append the multiplication separator
					textBox.SelectionStart = selectionIndex + 3; // Restore cursor position
				}
			}
			else if ((currentpos == space1 || currentpos == x1 || currentpos == space2) && currentpos != -1) //If the cursor is located where it would delete the multiplication operator
			{
				if (currentpos != space2) // Make sure numbers can't be entered between the spaces by the x
				{
					e.Handled = true;
				}
				if (currentpos == space1 || currentpos == x1 || currentpos == space2 && currentpos != -1) //If the cursor is located where it would delete the multiplication operator
				{
					if (e.KeyChar == '\b') // If backspace is pressed
					{
						if (txtRectangleDimensions.Text.Contains(" x ")) // If the string has a multiplication operator
						{
							e.Handled = true; // Discard the backspace
							int selectionIndex = textBox.SelectionStart; // Get the cursor position
							txtRectangleDimensions.Text = txtRectangleDimensions.Text.Replace(" x ", ""); // Remove the multiplication operator
							if (currentpos == space1) modifier = 1; // If the action of deleting put the cursor at the first space, move it back 1 to reallign it
							if (currentpos == x1) modifier = 2; // If the action of deleting put the cursor at the first x, move it back 2 to reallign it
							if (currentpos == space2) modifier = 3; // If the action of deleting put the cursor at the second space, move it back 3 to reallign it
							textBox.SelectionStart = selectionIndex - modifier; // Set the cursor to the modified position

						}
					}
				}
			}
			Rectangle(Placeholder, null);
		}
	}
}
