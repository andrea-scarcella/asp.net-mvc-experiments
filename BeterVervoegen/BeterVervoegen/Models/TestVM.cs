using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeterVervoegen.Models
{
	public class TestVM
	{
		public TestVM()
		{

		}
		public TestVM(IEnumerable<TestItemVM> itemList)
		{
			// TODO: Complete member initialization
			foreach (var item in itemList)
			{
				Items.Add(item);
			}

		}
		public IList<TestItemVM> Items
		{
			get
			{
				if (_items == null)
				{
					_items = new List<TestItemVM>();
				}
				return _items;
			}
			set { _items = value; }
		}

		public string Result()
		{


			return correct ? "OK" : "KO";

		}

		private bool correct { get; set; }

		private IList<TestItemVM> _items { get; set; }
	}
}