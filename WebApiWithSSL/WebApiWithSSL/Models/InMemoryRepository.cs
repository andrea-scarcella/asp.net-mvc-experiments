using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiWithSSL.Models
{
	public class InMemoryRepository : ITodoItemRepository
	{
		public IEnumerable<TodoItem> GetAll()
		{
			throw new NotImplementedException();
		}

		public TodoItem Get(int id)
		{
			throw new NotImplementedException();
		}

		public TodoItem Add(TodoItem item)
		{
			throw new NotImplementedException();
		}

		public void Remove(int id)
		{
			throw new NotImplementedException();
		}

		public bool Update(TodoItem item)
		{
			throw new NotImplementedException();
		}
	}
}