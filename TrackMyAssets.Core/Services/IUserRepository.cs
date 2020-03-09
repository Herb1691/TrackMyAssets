using System;
using System.Collections.Generic;
using System.Text;
using TrackMyAssets.Core.Models;

namespace TrackMyAssets.Core.Services
{
    public interface IUserRepository
    {
        // Create
        User Add(User toAdd);
        // Read
        User Get(int id);
        // Update
        User Update(User toUpdate);
        // Delete
        void Remove(User toRemove);
        // List
        IEnumerable<User> GetAll();
    }
}
