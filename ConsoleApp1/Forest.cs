using System;
using System.Collections.Generic;
using System.Text;

namespace ForestPOC
{
	public class Forest
	{
		public List<Tree> Trees { get; set; } = new List<Tree>();

		public void PlantTree(string x, string y, string name, string color, string texture)
		{
			var type = TreeFactory.GetTreeType(name, color, texture);

			var tree = new Tree(x, y, type);

			Trees.Add(tree);
		}

		public void Draw()
		{
			foreach(var tree in Trees)
			{
				tree.Draw();
			}
		}
	}
}
