using Nerds.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nerds.Data.Interfaces
{
    interface IPhonesCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
