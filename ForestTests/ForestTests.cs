using ForestPOC;
using NUnit.Framework;

namespace ForestTests
{
	public class Tests
	{
		[Test]
		public void CheckIfOnlyOneIsAdded()
		{
			var forest = new Forest();

			forest.PlantTree("1", "2", "eik", "bruin", "hard");
			forest.PlantTree("4", "3", "eik", "bruin", "hard");
			forest.PlantTree("3", "4", "eik", "bruin", "hard");
			forest.PlantTree("2", "5", "eik", "bruin", "hard");

			Assert.AreEqual(forest.Trees.Count, 4);

			Assert.AreEqual(TreeFactory.TreeTypes.Count, 1);
		}

		[Test]
		public void CheckIfMultipleHaveBeenAdded()
		{
			var forest = new Forest();

			forest.PlantTree("1", "2", "eik1", "bruin", "hard");
			forest.PlantTree("4", "3", "eik", "bruin", "hard");
			forest.PlantTree("3", "4", "eik", "bruin", "hard");
			forest.PlantTree("2", "5", "eik", "bruin", "hard");

			Assert.AreEqual(forest.Trees.Count, 4);

			Assert.AreEqual(TreeFactory.TreeTypes.Count, 2);
		}
	}
}