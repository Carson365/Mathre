// SOURCES:
// Tropical Depression Icon: https://upload.wikimedia.org/wikipedia/commons/7/7f/Tropical_Depression_icon.png
// Tropical Storm Icon: https://upload.wikimedia.org/wikipedia/commons/1/19/Tropical_storm_icon.png
// Category 1 Hurricane Icon: https://upload.wikimedia.org/wikipedia/commons/7/76/Category_1_hurricane_icon.png
// Category 2 Hurricane Icon: https://upload.wikimedia.org/wikipedia/commons/4/46/Category_2_hurricane_icon.png
// Category 3 Hurricane Icon: https://upload.wikimedia.org/wikipedia/commons/f/f6/Category_3_hurricane_icon.png
// Category 4 Hurricane Icon: https://upload.wikimedia.org/wikipedia/commons/2/24/Category_4_hurricane_icon.png
// Category 5 Hurricane Icon: https://upload.wikimedia.org/wikipedia/commons/9/91/Category_5_hurricane_icon.png
// Hurricane Damage Information:  https://www.nhc.noaa.gov/aboutsshws.php
// Hurricane Naming Information: https://www.nhc.noaa.gov/aboutnames.shtml
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Mathre
{
	public partial class Frm12Hurricane : Form, Forms.IManager
	{
		public string HurricaneInfo = "";
		public int RunCount = 0;
		public Dictionary<int, List<string>> Dictionary = new() { { 0, new List<string> { "Name", "MPH", "Knots", "Type", "Category", "Damage" } } };
		public Frm12Hurricane()
		{
			InitializeComponent();
			Load += (p, e) => { foreach (var item in Dictionary[0]) { lstHurricaneList.Columns.Add(item); } lstHurricaneList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize); };
			txtMPH.KeyPress += InputFormatter;
			txtMPH.TextChanged += ZeroRemover;
			txtMPH.KeyDown += EnterKey;
			btnCalculate.Click += Hurricane;
			btnRandom.Click += Random;
			chbDamage.CheckStateChanged += Damage;
			llbName.LinkClicked += Link;
			lstHurricaneList.ColumnWidthChanging += ListResizeManager;
		}
		public void Hurricane(object sender, EventArgs e)
		{
			if (txtMPH.Text != "")
			{
				lblKnots.Text = $"{Math.Round(Convert.ToDouble(txtMPH.Text) / 1.1507794480235)}";
				HurricaneInfo = Convert.ToDouble(txtMPH.Text) switch
				{
					< 74 => "0: Non Hurricane damage: \n\nRefer to Tropical Storm Guides.",
					< 96 => "1: Very dangerous winds will produce some damage: \n\nWell-constructed frame homes could have damage to roof, shingles, vinyl siding and gutters. Large branches of trees will snap and shallowly rooted trees may be toppled. Extensive damage to power lines and poles likely will result in power outages that could last a few to several days.",
					< 111 => "2: Extremely dangerous winds will cause extensive damage: \n\nWell-constructed frame homes could sustain major roof and siding damage. Many shallowly rooted trees will be snapped or uprooted and block numerous roads. Near-total power loss is expected with outages that could last from several days to weeks.",
					< 130 => "3: Devastating damage will occur: \n\nWell-built framed homes may incur major damage or removal of roof decking and gable ends. Many trees will be snapped or uprooted, blocking numerous roads. Electricity and water will be unavailable for several days to weeks after the storm passes.",
					< 157 => "4: Catastrophic damage will occur: \n\nWell-built framed homes can sustain severe damage with loss of most of the roof structure and/or some exterior walls. Most trees will be snapped or uprooted and power poles downed. Fallen trees and power poles will isolate residential areas. Power outages will last weeks to possibly months. Most of the area will be uninhabitable for weeks or months.",
					_ => "5: Catastrophic damage will occur: \n\nA high percentage of framed homes will be destroyed, with total roof failure and wall collapse. Fallen trees and power poles will isolate residential areas. Power outages will \nlast for weeks to possibly months. Most of the area will be uninhabitable for weeks or months.",
				};
				lblCategory.Text = HurricaneInfo.Remove(1, HurricaneInfo.Length - 1);
				if (HurricaneInfo.Remove(1, HurricaneInfo.Length - 1) != "0") picHurricaneType.Image = imgHurricanes.Images[$"Cat{HurricaneInfo.Remove(1, HurricaneInfo.Length - 1)}.png"];
				else { picHurricaneType.Image = Convert.ToDouble(txtMPH.Text) switch { < 39 => imgHurricanes.Images["TD0.png"], _ => imgHurricanes.Images["TS0.png"], }; }
				lblType.Text = Convert.ToDouble(txtMPH.Text) switch
				{
					< 39 => "Tropical Depression",
					< 74 => "Tropical Storm",
					< 111 => "Hurricane",
					< 151 => "Major Hurricane",
					_ => "Super Typhoon",
				};
				if (sender == btnRandom) { llbName.Text = "Example"; llbName.Enabled = false; }
				else
				{
					RunCount++;
					llbName.Text = RunCount switch
					{
						1 => "Alex",
						2 => "Bonnie",
						3 => "Colin",
						4 => "Danielle",
						5 => "Earl",
						6 => "Fiona",
						7 => "Gaston",
						8 => "Hermine",
						9 => "Ian",
						10 => "Julia",
						11 => "Karl",
						12 => "Lisa",
						13 => "Martin",
						14 => "Nicole",
						15 => "Owen",
						16 => "Paula",
						17 => "Richard",
						18 => "Shary",
						19 => "Tobias",
						20 => "Virginie",
						21 => "Walter",
						_ => "Special Case"
					};
					if (RunCount > 21) llbName.Enabled = true;
					Dictionary.Add(RunCount, new List<string> { $"{llbName.Text}", $"{txtMPH.Text}", $"{lblKnots.Text}", $"{lblType.Text}", $"{lblCategory.Text}", $"{HurricaneInfo.Substring(3, HurricaneInfo.LastIndexOf(':') - 3)}." });
					var item = new ListViewItem(Dictionary[RunCount][0]);
					foreach (var data in Dictionary[RunCount].Skip(1)) { item.SubItems.Add(data); }
					lstHurricaneList.Items.Add(item);
					lstHurricaneList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
				}
				Damage(chbDamage, null);
			}
		}
		public void Damage(object sender, EventArgs e) { if (chbDamage.Checked && HurricaneInfo.Length != 0 && Properties.Settings.Default.bPopups) MessageBox.Show(HurricaneInfo.Remove(0, 3).ToString(), "Damage"); }
		public void Random(object sender, EventArgs e)
		{
			Random rnd = new();
			var randomstorm = rnd.Next(0, 6) switch
			{
				0 => rnd.Next(0, 74),
				1 => rnd.Next(74, 95),
				2 => rnd.Next(95, 110),
				3 => rnd.Next(110, 129),
				4 => rnd.Next(129, 156),
				_ => rnd.Next(156, 210),
			};
			txtMPH.Text = $"{randomstorm}";
			Hurricane(btnRandom, null);
		}
		public void Link(object sender, EventArgs e)
		{
			llbName.LinkVisited = true;
			System.Diagnostics.Process.Start("https://www.nhc.noaa.gov/aboutnames_history.shtml#:~:text=In%20the%20event,Tropical%20Cyclone%20Programme.");
		}
		public void ListResizeManager(object sender, ColumnWidthChangingEventArgs e) { e.NewWidth = lstHurricaneList.Columns[e.ColumnIndex].Width; e.Cancel = true; }
		public void InputFormatter(object sender, KeyPressEventArgs e)
		{
			TextBox textBox = sender as TextBox;
			if (e.KeyChar != '\b' && (e.KeyChar < '0' || e.KeyChar > '9')) e.Handled = true;
			else if (textBox.Text.Length != 0 && Convert.ToDouble(textBox.Text) > 20 && e.KeyChar != '\b' && Convert.ToDouble($"{textBox.Text}{e.KeyChar}") > 210)
			{
				if (textBox.SelectionLength < 1) e.Handled = true;
				else if (Convert.ToDouble($"{textBox.Text.Replace(textBox.SelectedText, e.KeyChar.ToString())}") > 210) e.Handled = true;
			}
		}
		public void ZeroRemover(object sender, EventArgs e) { if (txtMPH.Text.StartsWith("0")) txtMPH.Text = txtMPH.Text.TrimStart('0'); }
		public void EnterKey(object sender, KeyEventArgs e) { if (e.KeyCode == Keys.Enter) Hurricane(txtMPH, null); }
	}
}