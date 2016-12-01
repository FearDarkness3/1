using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class Warehouse
    {
        private readonly List<Apiece> _apieceList = new List<Apiece>();
        private readonly List<ByWeight> _byWeightList = new List<ByWeight>();
        public List<Product> Products = new List<Product>();
        public Warehouse()
        {
            CreateProductsList();

            _apieceList.ForEach(x => Products.Add(x));
            _byWeightList.ForEach(x => Products.Add(x));
        }

        private void CreateProductsList()
        {
            _apieceList.Add(new Apiece("Black tea", 25, "general"));
            _apieceList.Add(new Apiece("Bread", 6, "general"));
            _apieceList.Add(new Apiece("Chocolate", 33, "general"));
            _apieceList.Add(new Apiece("Chips", 12, "general"));
            _apieceList.Add(new Apiece("Ketchup", 16, "general"));
            _apieceList.Add(new Apiece("Beer", 10, "alchohol"));
            _byWeightList.Add(new ByWeight("Cookies", 45, "general"));
            _byWeightList.Add(new ByWeight("Apple", 15, "general"));
            _byWeightList.Add(new ByWeight("Meat", 70, "general"));
            _byWeightList.Add(new ByWeight("Sausage", 58, "general"));
            _byWeightList.Add(new ByWeight("Fish", 64, "general"));
        }
        private void AddToList(Product prod)
        {
            if (!Products.Contains(prod))
            {
                Products.Add(prod);
            }
        }
        private void RemoveFromList(Product prod)
        {
            if (Products.Contains(prod))
            {
                Products.Remove(prod);
            }
        }
    }
}
