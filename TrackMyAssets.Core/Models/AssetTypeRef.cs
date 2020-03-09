using System;
using System.Collections.Generic;
using System.Text;

namespace TrackMyAssets.Core.Models
{
    public class AssetTypeRef : IEntity<int>
    {
        public int Id { get; set; }
        public string AssetDescription { get; set; }
        public DateTime ModifyDate { get; set; }
        public User ModUser { get; set; }
        public DateTime DateAdded { get; set; }
        public User AddedBy { get; set; }
    }
}
