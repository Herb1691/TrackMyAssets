using System;
using System.Collections.Generic;
using System.Text;

namespace TrackMyAssets.Core.Models
{
    public class Locations : IEntity<int>
    {
        public int Id { get; set; }
        public string LocationName { get; set; }
        public string LocationDescription { get; set; }
        public DateTime ModifyDate { get; set; }
        public User ModUser { get; set; }
        public DateTime DateAdded { get; set; }
        public User AddedBy { get; set; }
    }
}
