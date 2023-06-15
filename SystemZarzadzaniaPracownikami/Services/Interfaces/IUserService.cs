using SystemZarzadzaniaPracownikami.Models;

namespace SystemZarzadzaniaPracownikami.Services.Interfaces
{
    public interface IUserService
    {
        int Save(User user);
        List<User>GetAll();
        User Get(int id);
        int Delete(int id);

        int Edit(int id, User user);
    }
}
