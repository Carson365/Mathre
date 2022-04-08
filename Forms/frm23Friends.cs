using System;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm23Friends : Form, Forms.IManager
	{
		string[] friends = new string[5];
		public Frm23Friends()
		{
			InitializeComponent();
			btnInput.Click += Default;
			txtSearch.TextChanged += Default;
		}
		public void Default(object sender, EventArgs e)
		{
			if (ReferenceEquals(btnInput, sender))
			{
				for (int i = 0; i < friends.Length; i++)
				{
					friends[i] = Microsoft.VisualBasic.Interaction.InputBox($"Input Name of Contact {i+1}");
				}
			}
			//else if (ReferenceEquals(btnSort, sender))
			//{

			//}
			else if (ReferenceEquals(txtSearch, sender))
			{
				foreach (string name in friends)
				{
					if (!name.Contains(txtSearch.Text))
					{
						friends.GetValue(1);
					}
				}
			}

		}

		public void InputFormatter(object sender, KeyPressEventArgs e)
		{
			throw new NotImplementedException();
		}
	}
}