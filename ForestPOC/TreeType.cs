using System;

namespace ForestPOC
{
	public class TreeType
	{
		public string Color { get; set; }
		public string Name { get; set; }
		public string Texture { get; set; }

		public TreeType(string name, string color, string texture)
		{
			Name = name;
			Color = color;
			Texture = texture;
		}

		public void Draw(string x, string y)
		{
			Console.WriteLine(string.Format("een {0}(e) {1}(e) {2} getekend op x locatie {3} en y locatie {4}", Texture,Color, Name, x, y));
		}
	}
}
