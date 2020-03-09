using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace TrackMyAssets.Core.Models
{
    public class User : IdentityUser, IEntity<string>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // TODO: add a FullName property that returns FirstName + LastName
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
