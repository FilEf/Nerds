using Nerds.Data.Interfaces;
using Nerds.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nerds.Data.Mocks
{
    public class MockCategory : IPhonesCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryName = "Телефон", Description = "Кнопочные телефоны"},
                    new Category{CategoryName = "Смартфон", Description = "Полноценные мобильные компьютеры"}
                };
            }
        }
    }
}
