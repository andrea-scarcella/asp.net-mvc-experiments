using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeterVervoegen.Specflow
{
	class Test
	{


		public Test(IEnumerable<TestItem> itemList)
		{
			// TODO: Complete member initialization
			Items = itemList;

		}
		public IEnumerable<TestItem> Items { get; private set; }


		public TestItem Item(int p1)
		{
			return Items.Where(x => x.ItemId == p1).FirstOrDefault();
		}

		internal void Evaluate()
		{
			foreach (TestItem item in Items)
			{
				item.Evaluate();
			}
			//int okCount=Items.Where(x => x.Result().Equals("OK")).Count();
			int okCount = Items.Where(x => x.Result().Equals("OK")).Count();
			int count = Items.Count();
			correct = okCount == count;
		}

		internal string Result()
		{

			return correct ? "OK" : "KO";

		}

		private bool correct { get; set; }
	}
}
