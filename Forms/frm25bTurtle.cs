using System;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm25bTurtle : Form
	{
		public readonly System.Timers.Timer tmrMain = new(15);
		int Speed = 1;
		int Up = 0;
		int Down = 0;
		int ticks = 0;
		readonly PictureBox Turtle = new();
		readonly TextBox SpeedTag = new();
		readonly Random rnd = new();
		public Frm25bTurtle()
		{
			InitializeComponent();
			KeyDown += KeyProcessor;
			Shown += (p, e) => { tmrMain.Enabled = true; Focus(); };
			VisibleChanged += (p, e) => { tmrMain.Enabled = Visible; if (Visible) Focus(); };
			// Create the turtle element
			Turtle.Left = -200;
			Turtle.Top = (ClientRectangle.Height / 2) - (Turtle.Height);
			Turtle.Visible = true;
			Turtle.Size = new System.Drawing.Size(187, 144);
			Turtle.Image = Resources.Turtle1;
			Controls.Add(Turtle);
			// Create the moving speed tag element
			SpeedTag.Left = -20;
			SpeedTag.Top = 20;
			SpeedTag.Visible = true;
			SpeedTag.Size = new System.Drawing.Size(80, 20);
			SpeedTag.Text = "Slow";
			SpeedTag.TextAlign = HorizontalAlignment.Center;
			SpeedTag.BorderStyle = BorderStyle.None;
			SpeedTag.Font = new System.Drawing.Font(SpeedTag.Font.FontFamily, 16, System.Drawing.FontStyle.Bold);
			SpeedTag.TabStop = false;
			Controls.Add(SpeedTag);
			// Start the timer once the form is loaded
			HandleCreated += (p, e) => tmrMain.Elapsed += Default;
		}
		public void Default(object sender, EventArgs e)
		{
			if (IsHandleCreated) Invoke(new MethodInvoker(delegate // Required since this is multithreaded
			{
				ticks++;
				Turtle.Left += Speed; // Move the turtle
				SpeedTag.Left += Speed * rnd.Next(5, 7); // Move the speed tag randomly
				if (Turtle.Left > ClientRectangle.Width) Turtle.Left = -20;
				if (SpeedTag.Left > ClientRectangle.Width) SpeedTag.Left = -200;
				// Set the Turtle's image in a cycle. Faster when moving faster.
				if (ticks % (90 / Speed) == 0) Turtle.Image = Resources.Turtle1;
				if (ticks % (90 / Speed) == 30 / Speed) Turtle.Image = Resources.Turtle2;
				if (ticks % (90 / Speed) == 60 / Speed) Turtle.Image = Resources.Turtle3;
				SpeedTag.Text = Speed switch { 1 => "Slow", 2 => "Medium", _ => "Fast" };
			}));
		}
		public void KeyProcessor(object sender, KeyEventArgs e)
		{
			// Speed
			if (e.KeyCode == Keys.D) Up = 1;
			if (e.KeyCode == Keys.A) Down = 1;
			Go();
			// Pause
			if (e.KeyCode == Keys.Escape) tmrMain.Enabled ^= true;
		}
		public void Go()
		{
			// Movement
			Speed = Speed + Up - Down;
			if (Speed < 1) Speed = 1;
			else if (Speed > 3) Speed = 3;
			Up = 0;
			Down = 0;
		}
	}
}