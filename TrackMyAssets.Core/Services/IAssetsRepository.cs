using System;
using System.Collections.Generic;
using System.Text;
using TrackMyAssets.Core.Models;

namespace TrackMyAssets.Core.Services
{
    public interface IAssetsRepository
    {
        // Create
        Assets Add(Assets toAdd);
        // Read
        Assets Get(int id);
        // Update
        Assets Update(Assets toUpdate);
        // Delete
        void Remove(Assets toRemove);
        // List
        IEnumerable<Assets> GetAll();
    }
}
