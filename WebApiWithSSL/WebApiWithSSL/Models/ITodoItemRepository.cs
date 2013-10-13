using System.Collections.Generic;

namespace WebApiWithSSL.Models
{
	interface ITodoItemRepository
	{
		IEnumerable<TodoItem> GetAll();
		TodoItem Get(int id);
		TodoItem Add(TodoItem item);
		void Remove(int id);
		bool Update(TodoItem item);
	}
}
