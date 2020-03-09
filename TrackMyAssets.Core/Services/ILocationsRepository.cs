using System;
using System.Collections.Generic;
using System.Text;
using TrackMyAssets.Core.Models;

namespace TrackMyAssets.Core.Services
{
    public interface ILocationsRepository
    {
        // Create
        Locations Add(Locations toAdd);
        // Read
        Locations Get(int id);
        // Update
        Locations Update(Locations toUpdate);
        // Delete
        void Remove(Locations toRemove);
        // List
        IEnumerable<Locations> GetAll();
    }
}
