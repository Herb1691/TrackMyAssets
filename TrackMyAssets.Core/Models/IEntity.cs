using System;
using System.Collections.Generic;
using System.Text;

namespace TrackMyAssets.Core.Models
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }
    }
}
