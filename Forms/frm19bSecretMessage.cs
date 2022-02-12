using Mathre.Forms;
using System;
using System.Linq;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm19bSecretMessage : Form, IManager
	{
		public static Frm00Mathre BaseForm;
		public Frm19bSecretMessage()
		{
			InitializeComponent();
			Load += FormLoad;
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<Frm00Mathre>().Single();
			foreach (Control c in Controls) { BaseForm.GetAllControls(c); }
		}
		public void MenuControl(object sender, EventArgs e)
		{
			var senderName = ((ToolStripMenuItem)sender).Name;
			Action a = senderName.Substring(0, 3) switch
			{
				"btn" => () => ((Button)Controls.Find(senderName, true)[0]).PerformClick(),
				"rad" => () => ((RadioButton)Controls.Find(senderName, true)[0]).PerformClick(),
				"chb" => () => ((CheckBox)Controls.Find(senderName, true)[0]).Checked ^= true,
				_ => null,
			};
			a?.Invoke();
		}
		public void Default(object sender, EventArgs e)
		{
		}
	}
}