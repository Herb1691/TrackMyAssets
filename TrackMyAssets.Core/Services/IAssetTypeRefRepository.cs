using System;
using System.Collections.Generic;
using System.Text;
using TrackMyAssets.Core.Models;

namespace TrackMyAssets.Core.Services
{
    public interface IAssetTypeRefRepository
    {
        // Create
        AssetTypeRef Add(AssetTypeRef toAdd);
        // Read
        AssetTypeRef Get(int id);
        // Update
        AssetTypeRef Update(AssetTypeRef toUpdate);
        // Delete
        void Remove(AssetTypeRef toRemove);
        // List
        IEnumerable<AssetTypeRef> GetAll();
    }
}
