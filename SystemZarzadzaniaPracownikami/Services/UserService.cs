using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SystemZarzadzaniaPracownikami.Models;
using SystemZarzadzaniaPracownikami.Services.Interfaces;

namespace SystemZarzadzaniaPracownikami.Services
{
    public class UserService : IUserService
    {
        private readonly DbUserContext _context;

        public UserService(DbUserContext context)
        {
            _context = context; 
        }

        public int Save(User user)
        {
            _context.Add(user);
            if(_context.SaveChanges() > 0)
            {
                System.Console.WriteLine("SUKCES");
            }
            return user.Id;

        }
        public List<User> GetAll()
        {
            var usersList = _context.Users.ToList();
            return usersList;
        }

		public User Get(int id)
		{
            var user = _context.Users.Find(id);
            return user;
		}

		public int Delete(int id)
		{
            var user = _context.Users.Find(id);
            _context.Users.Remove(user);
            _context.SaveChanges();
            return id;

		}

        public int Edit(int id, User user)
        {
            var userEdit = _context.Users.Find(id);
            if (userEdit != null)
            {
                userEdit.Name = user.Name;
                userEdit.Sname = user.Sname;
                userEdit.Wiek = user.Wiek;
                userEdit.Rola = user.Rola;
                 _context.SaveChanges();

            }
            return user.Id;
        }
    }
}
