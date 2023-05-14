using MassAssignment.Models;
using LiteDB;

namespace MassAssignment.Data
{
    public class Database : IDataContext
    {
        private LiteDatabase _db = new LiteDatabase("data.db");
        private const string _USERS = "Users";

        public User GetUserById(int id)
        {
            return _db.GetCollection<User>(_USERS).FindById(id);
        }

        public void AddUser(User user)
        {
            _db.GetCollection<User>(_USERS).Insert(user);
        }

        public bool UpdateUsername(int id, User inputUser)
        {
            User user = _db.GetCollection<User>(_USERS).FindById(id);
            if (user == null) return false;

            _db.GetCollection<User>(_USERS).Update(id, inputUser);
            return true;
        }

        public bool DeleteUser(int id)
        {
            User user = _db.GetCollection<User>(_USERS).FindById(id);
            if (user == null) return false;

            _db.GetCollection<User>(_USERS).Delete(id);
            return true;
        }
    }
}

