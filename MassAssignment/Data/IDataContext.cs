﻿using MassAssignment.Models;

namespace MassAssignment.Data
{
    public interface IDataContext
    {
        public User GetUserById(int id);
        public void AddUser(User user);
        public bool UpdateUsername(int id, User inputUser);
        public bool DeleteUser(int id);

    }
}
