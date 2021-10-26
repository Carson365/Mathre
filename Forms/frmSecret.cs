using System;
using System.Linq;
using System.Windows.Forms;

namespace Mathre
{
	public partial class FrmSecret : Form
	{
		public static FrmMathre main;
		public static FrmSecret SS;
		public FrmSecret()
		{
			InitializeComponent();
			Load += FormLoad;
			btnSecretDisable.Click += SecretHandler;
			btnSecretEnable.Click += SecretHandler;
			txtSecretPassword.KeyPress += NumericalKeypress;
		}
		public void FormLoad(object sender, EventArgs e) //Formload event handler
		{
			main = Application.OpenForms.OfType<FrmMathre>().Single();
			SS = Application.OpenForms.OfType<FrmSecret>().Single();
			foreach (Control c in Controls)
			{
				main.GetAllControls(c);
			}
		}
		public void SecretHandler(object sender, EventArgs e) // Event handler for the functions on the Secret Settings page
		{
			if (ReferenceEquals(sender, txtSecretPassword)) // If the event is caused by the textbox:
			{
				string hashedvalue; // Introduce the 'hashedvalue' variable
				if (String.IsNullOrEmpty(txtSecretPassword.Text)) // Check for a null value in the Secret Setting password field
					hashedvalue = String.Empty; // Set the hashedvalue to Empty if the value is null.
				using (var sha = new System.Security.Cryptography.SHA256Managed()) // Introduce the Sha256 hashing method
				{
					byte[] textData = System.Text.Encoding.UTF8.GetBytes(txtSecretPassword.Text); // Get the value of the Secret Settings password field input and convert it to a usable form (bytes)
					byte[] hash = sha.ComputeHash(textData); // Compute the Sha256 hash of the input.
					hashedvalue = BitConverter.ToString(hash).Replace("-", String.Empty); // Convert the calculated hash to a useable format and store it in the hashedvalue variable
					Console.WriteLine(hashedvalue);
				}
				if (hashedvalue == "5994471ABB01112AFCC18159F6CC74B4F511B99806DA59B3CAF5A9C173CACFC5") // If the hashed value of the text matches this predefined value (AKA the correct password):
				{
					btnSecretEnable.Enabled = true; // Enable the control buttons
					btnSecretDisable.Enabled = true; // Enable the control buttons
				}
				else
				{
					btnSecretEnable.Enabled = false; // Disable the control buttons
					btnSecretDisable.Enabled = false; // Disable the control buttons
					btnSecretDisable.Checked = true; // Check the Disabled button
				}

				if (btnSecretEnable.Enabled == false) // If the Enabled button is not pressed:
				{
					main.mnuSecret.Enabled = false; // Disable the Secret Settings menu item
				}
			}


			//txtSecretPassword.Text = ""; // Clear the text box when buttons are pressed


			if (ReferenceEquals(sender, btnSecretEnable)) // If the event is caused by the Enable button:
			{
				main.mnuSecret.Enabled = true; // Enable the Secret menu
				btnSecretEnable.Checked = true; // Check the Enabled button
			}

			if (ReferenceEquals(sender, btnSecretDisable)) // If the event is caused by the Disable button:
			{
				main.mnuSecret.Enabled = false; // Disable the Secret menu
				btnSecretDisable.Checked = true; // Check the Disabled button
			}
		}
		public void NumericalKeypress(object sender, KeyPressEventArgs e) // Event handler for keypresses within the rectangle calculator input field
		{
			if (sender is not TextBoxBase textBox) // Ensure the sender is the input form -
				return; // -or else discard it
			SecretHandler(txtSecretPassword, null);
		}
	}
}
