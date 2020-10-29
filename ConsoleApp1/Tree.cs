using System;
using System.Collections.Generic;
using System.Text;

namespace ForestPOC
{
	public class Tree
	{
		public string X { get; set; }
		public string Y { get; set; }
		public TreeType TreeType { get; set; }

		public Tree(string x, string y, TreeType type)
		{
			X = x;
			Y = y;
			TreeType = type;
		}

		public void Draw()
		{
			TreeType.Draw(X, Y);
		}
		
	}
}


