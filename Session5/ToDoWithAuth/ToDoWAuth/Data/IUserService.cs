using ToDoWAuth.Model;

namespace ToDoWAuth.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string Password);
    }
}