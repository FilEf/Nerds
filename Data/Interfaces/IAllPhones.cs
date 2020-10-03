using Nerds.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Nerds.Data.Interfaces
{
    interface IAllPhones
    {
        IEnumerable<Phone> Phones { get; }
        IEnumerable<Phone> GetFavCars { get; set; }
        Phone getObjectPhone(DebugInfoGenerator phoneId);
    }
}
