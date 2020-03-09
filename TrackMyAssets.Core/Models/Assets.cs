using System;
using System.Collections.Generic;
using System.Text;

namespace TrackMyAssets.Core.Models
{
    public class Assets : IEntity<int>
    {
        public int Id { get; set; }
        public string AssetBarcode { get; set; }
        public string AssetName { get; set; }
        public AssetTypeRef AssetType { get; set; }
        public DateTime DateAdded { get; set; }
        public int TotalUnits { get; set; }
        public double CostPerUnit { get; set; }
        public Locations HomeLocation { get; set; }
        public Locations AssignedLocation { get; set; }
        public User Custodian { get; set; }
        public DateTime ModifyDate { get; set; }
        public User ModUser { get; set; }
        public User AddedBy { get; set; }
    }
}
