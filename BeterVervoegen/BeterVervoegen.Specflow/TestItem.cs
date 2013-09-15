﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeterVervoegen.Specflow
{
	public class TestItem
	{
		private string infinitive;
		private string simplePast;
		private string pastParticiple;

		public TestItem(string infinitive, string simplePast, string pastParticiple)
		{
			// TODO: Complete member initialization
			this.infinitive = infinitive;
			this.simplePast = simplePast;
			this.pastParticiple = pastParticiple;
		}

		public string AnswerSimplePast { get; set; }

		public string AnswerPastParticiple { get; set; }

		internal void evaluate()
		{
			correct = simplePast.Equals(AnswerSimplePast, StringComparison.InvariantCultureIgnoreCase) && pastParticiple.Equals(AnswerPastParticiple, StringComparison.InvariantCultureIgnoreCase);
		}



		private bool correct { get; set; }

		public string Result()
		{
			return correct ? "OK" : "KO";
		}
	}
}
