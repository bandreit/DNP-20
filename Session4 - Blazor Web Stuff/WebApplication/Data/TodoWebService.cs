using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WebApplication.Model;

namespace WebApplication.Data
{
    public class TodoWebService : ITodosService
    {
        public async Task<IList<Todo>> GetTodosAsync(int? userId, string? isCompleted)
        {
            HttpClient httpClient = new HttpClient();
            string requestURI = "https://jsonplaceholder.typicode.com/todos?";
            if (!(userId is null))
            {
                requestURI += $"&userId={userId}";
            }
            if (!(isCompleted is null) && isCompleted != "Both")
            {
                requestURI += $"&completed={isCompleted.ToLower()}";
            }

            Console.Out.WriteLine(requestURI);
            string message = await httpClient.GetStringAsync(requestURI);
            List<Todo> result = JsonSerializer.Deserialize<List<Todo>>(message);
            return result;
        }

        public async Task AddTodoAsync(Todo todo)
        {
            HttpClient httpClient = new HttpClient();

            string todoSerialized = JsonSerializer.Serialize(todo);
            
            StringContent content = new StringContent(
                todoSerialized,
                Encoding.UTF8,
                "application/json");
            HttpResponseMessage response = await httpClient.PostAsync("https://jsonplaceholder.typicode.com/todos", content);
            Console.Out.WriteLine(response.ToString());
        }

        public async Task RemoveTodoAsync(int todoId)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.DeleteAsync($"https://jsonplaceholder.typicode.com/todos/{todoId}");
            Console.Out.WriteLine(response.ToString());
        }

        public async Task UpdateAsync(Todo todo)
        {
            HttpClient httpClient = new HttpClient();

            string todoSerialized = JsonSerializer.Serialize(todo);
            
            StringContent content = new StringContent(
                todoSerialized,
                Encoding.UTF8,
                "application/json");
            HttpResponseMessage response = await httpClient.PutAsync($"https://jsonplaceholder.typicode.com/todos/{todo.TodoId}", content);
            Console.Out.WriteLine(response.ToString());
        }
    }
}