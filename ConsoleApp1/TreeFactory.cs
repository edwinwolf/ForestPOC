using System;
using System.Collections.Generic;
using System.Text;

namespace ForestPOC
{
	public static class TreeFactory
	{
		public static List<TreeType> TreeTypes { get; set; } = new List<TreeType>();

		public static TreeType GetTreeType(string name, string color, string texture)
		{

			var type = TreeTypes.Find(x => x.Color == color && x.Name == name && x.Texture == texture);

			if(type == null)
			{
				type = new TreeType(name, color, texture);
				TreeTypes.Add(type);
			}

			return type;

		}

		
	}
}
