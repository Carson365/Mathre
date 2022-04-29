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
			btnSortUp.Click += Default;
			btnSortDown.Click += Default;
			btnSearch.Click += Default;
		}
		public void Default(object sender, EventArgs e)
		{
			if (ReferenceEquals(btnInput, sender))
			{
				lblFriendsList.Text = "";
				for (int i = 0; i < friends.Length; i++)
				{
					friends[i] = Microsoft.VisualBasic.Interaction.InputBox($"Input Name of Contact {i+1}");
					lblFriendsList.Text += $"Friend {i+1}: {friends[i]}\n";
				}
				btnSearch.Enabled = true;
				btnSortUp.Enabled = true;
				btnSortDown.Enabled = true;
			}
			// sort the array alphabetically when the search button is pressed
			if (ReferenceEquals(btnSortUp, sender))
			{
				Array.Sort(friends);
				lblFriendsList.Text = "";
				for (int i = 0; i < friends.Length; i++)
				{
					lblFriendsList.Text += $"Friend {i + 1}: {friends[i]}\n";
				}
			}
			// same for sortdown
			if (ReferenceEquals(btnSortDown, sender))
			{
				Array.Sort(friends);
				Array.Reverse(friends);
				lblFriendsList.Text = "";
				for (int i = 0; i < friends.Length; i++)
				{
					lblFriendsList.Text += $"Friend {i + 1}: {friends[i]}\n";
				}
			}
			if (ReferenceEquals(btnSearch, sender))
			{
				string search = Microsoft.VisualBasic.Interaction.InputBox("Search for a name");
				//make a copy of the friends array but all items uppercase
				string[] searchFriends = new string[friends.Length];
				for (int i = 0; i < friends.Length; i++)
				{
					searchFriends[i] = friends[i].ToUpper();
				}
				int index = Array.IndexOf(searchFriends, search.ToUpper());
				if (index == -1)
				{
					MessageBox.Show($"{search} is not in the list");
				}
				else
				{
					MessageBox.Show($"{search} is in the list as Friend {index + 1}");
				}
			}
		}

		public void InputFormatter(object sender, KeyPressEventArgs e)
		{
			throw new NotImplementedException();
		}
	}
}