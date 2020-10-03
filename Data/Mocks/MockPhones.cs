using Nerds.Data.Interfaces;
using Nerds.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Nerds.Data.Mocks
{
    public class MockPhones : IAllPhones
    {
        private readonly IPhonesCategory _CategoryPhones = new MockCategory();
        public IEnumerable<Phone> Phones {
            get
            {
                return new List<Phone>
                {
                    new Phone
                    {
                        Name = "Телефон 1",
                        Description = "zzz",
                        Display = "zzz",
                        Price = 5000.99M,
                        IsFavorite = true,
                        Available = true,
                        Category =_CategoryPhones.AllCategories.First()
                    },

                    new Phone
                    {
                        Name = "Телефон 2",
                        Description = "qqq",
                        Display = "qqq",
                        Price = 25000.99M,
                        IsFavorite = true,
                        Available = true,
                        Category =_CategoryPhones.AllCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Phone> GetFavCars { get; set; }

        public Phone getObjectPhone(DebugInfoGenerator phoneId)
        {
            throw new NotImplementedException();
        }
    }
}
