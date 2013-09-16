using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeterVervoegen.BL
{
	public class TestItem
	{
		public string Infinitive { get; set; }
		public string SimplePast { get; set; }
		public string PastParticiple { get; set; }
		public TestItem()
		{

		}
		public TestItem(int ItemId, string Infinitive, string SimplePast, string PastParticiple)
		{
			// TODO: Complete member initialization
			this.ItemId = ItemId;
			this.Infinitive = Infinitive;
			this.SimplePast = SimplePast;
			this.PastParticiple = PastParticiple;
		}
		public TestItem(string Infinitive, string SimplePast, string PastParticiple)
		{
			// TODO: Complete member initialization
			this.Infinitive = Infinitive;
			this.SimplePast = SimplePast;
			this.PastParticiple = PastParticiple;
		}

		public string AnswerSimplePast { get; set; }

		public string AnswerPastParticiple { get; set; }

		public void Evaluate()
		{
			correct = SimplePast.Equals(AnswerSimplePast, StringComparison.InvariantCultureIgnoreCase) && PastParticiple.Equals(AnswerPastParticiple, StringComparison.InvariantCultureIgnoreCase);
		}



		private bool correct { get; set; }

		public string Result()
		{
			return correct ? "OK" : "KO";
		}

		public int ItemId { get; set; }
	}
}
