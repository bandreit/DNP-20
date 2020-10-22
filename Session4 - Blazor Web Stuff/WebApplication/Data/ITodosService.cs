using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication.Model;

namespace WebApplication.Data
{
    public interface ITodosService
    {
        Task<IList<Todo>> GetTodosAsync(int? userID, string? isCompleted);
        Task   AddTodoAsync(Todo todo);
        Task   RemoveTodoAsync(int todoId);
        Task   UpdateAsync(Todo todo);
    }
}