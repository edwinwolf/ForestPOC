using System;
using System.Text;

namespace ForestPOC
{
	class Program
	{
		static void Main(string[] args)
		{
			var forest = new Forest();

			Console.WriteLine("WE GAAN BOMEN TEKENEN YES!!!! #GROEENNNNNNN");
			Start(forest);
		}

		private static void Start(Forest forest)
		{
			Console.WriteLine("Voer de x waarde in: ");
			var x = Console.ReadLine();

			if (x == "check")
			{
				Console.WriteLine(Environment.NewLine);
				Console.WriteLine(TreeFactory.TreeTypes.Count);
				Console.WriteLine(Environment.NewLine);
				Start(forest);
			}

			Console.WriteLine("Voer de y waarde in: ");
			var y = Console.ReadLine();

			Console.WriteLine("Voer de naam in: ");
			var name = Console.ReadLine();

			Console.WriteLine("Voer de kleur van de boom in: ");
			var color = Console.ReadLine();

			Console.WriteLine("Voer de textuur in: ");
			var texture = Console.ReadLine();

			forest.PlantTree(x, y, name, color, texture);

			forest.Draw();
			Console.WriteLine(Environment.NewLine);

			Start(forest);
		}
	}
}
