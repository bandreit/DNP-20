using System.Collections.Generic;
using ToDoWAuth.Model;

namespace ToDoWAuth.Data
{
    public interface ITodosService
    {
        IList<Todo> GetTodos();
        void AddTodo(Todo todo);
        void RemoveTodo(int todo);
        void Update(Todo todo);
    }
}