using System.Threading.Tasks;
using A1_DNP1Y.Models;

namespace A1_DNP1Y.Data
{
    public interface IUserService
    {
        Task<User> ValidateUser(string userName, string Password);
    }
}