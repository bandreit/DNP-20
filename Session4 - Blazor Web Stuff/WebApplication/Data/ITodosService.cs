using System.Collections.Generic;
using WebApplication.Model;

namespace WebApplication.Data
{
    public interface ITodosService
    {
        IList<Todo> GetTodos();
        void AddTodo(Todo todo);
        void RemoveTodo(int todo);
        void Update(Todo todo);
    }
}