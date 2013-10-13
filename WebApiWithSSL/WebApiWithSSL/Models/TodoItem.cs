using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiWithSSL.Models
{
	public class TodoItem
	{
		public int Id { get; set; }
		public string Text { get; set; }
		public bool Completed { get; set; }

	}
}