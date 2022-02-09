using Mathre.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
namespace Mathre
{
	public partial class Frm18Humane : Form, IManager
	{
		public static Frm00Mathre BaseForm;
		public Frm18Humane()
		{
			InitializeComponent();
			Load += FormLoad;
			btnView.Click += API;
		}
		public void FormLoad(object sender, EventArgs e)
		{
			BaseForm = Application.OpenForms.OfType<Frm00Mathre>().Single();
			foreach (Control c in Controls) { BaseForm.GetAllControls(c); }
		}
		public void MenuControl(object sender, EventArgs e) { var ThisForm = Application.OpenForms.OfType<Frm18Humane>().Single(); ThisForm.Default(sender, e); }
		public void Default(object sender, EventArgs e)
		{

		}
		public async void API(object sender, EventArgs e)
		{
			//https://stackoverflow.com/questions/32716174/call-and-consume-web-api-in-winform-using-c-net/32716351
			var client = new HttpClient();
			client.BaseAddress = new Uri("https://api.rescuegroups.org/v5");
			var request = new HttpRequestMessage(HttpMethod.Post, "/public/animals/search/available/dogs/");

			var keyValues = new List<KeyValuePair<string, string>>();
			keyValues.Add(new KeyValuePair<string, string>("results", "http://www.google.com"));
			keyValues.Add(new KeyValuePair<string, string>("content", "This is some content"));

			request.Content = new FormUrlEncodedContent(keyValues);
			var response = await client.SendAsync(request);
			Console.WriteLine(response.ToString()); ;
		}
		public void RandomAnimal(object sender, EventArgs e)
		{

			Random rnd = new();
			Action ranimal = rnd.Next(0, 6) switch
			{
				0 => () => { Cats(rnd.Next(0, 74), null); }
				,
				1 => () => { rnd.Next(74, 95); }
				,
				2 => () => { rnd.Next(95, 110); }
				,
				3 => () => { rnd.Next(110, 129); }
				,
				4 => () => { rnd.Next(129, 156); }
				,
				_ => () => { rnd.Next(156, 210); }
				,
			};
			ranimal.Invoke();
		}
		public void Cats(object sender, EventArgs e)
		{
		}
		public void Dogs(object sender, EventArgs e)
		{
		}
		public void Birds(object sender, EventArgs e)
		{
		}
		public void Snakes(object sender, EventArgs e)
		{
		}
	}
}