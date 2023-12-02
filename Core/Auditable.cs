using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Project.Core
{
    public class Auditable
    {
        public string Id = Guid.NewGuid().ToString();
        public bool IsDeleted { get; set; }
        public string DeletedBy { get; set; } = default!;
        public DateTime DateCreated { get; set; } 
    }
}