using WebApplicationWithLogic.Models;

namespace WebApplicationWithLogic.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string Password);
    }
}