using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class Warehouse
    {
        private readonly List<ApieceProduct> _apieceList = new List<ApieceProduct>();
        private readonly List<ByWeightProduct> _byWeightList = new List<ByWeightProduct>();
        public List<Product> Products = new List<Product>();
        public Warehouse()
        {
            CreateProductsList();

            _apieceList.ForEach(x => Products.Add(x));
            _byWeightList.ForEach(x => Products.Add(x));
        }

        private void CreateProductsList()
        {
            _apieceList.Add(new ApieceProduct("Black tea", 25, "general"));
            _apieceList.Add(new ApieceProduct("Bread", 6, "general"));
            _apieceList.Add(new ApieceProduct("Chocolate", 33, "general"));
            _apieceList.Add(new ApieceProduct("Chips", 12, "general"));
            _apieceList.Add(new ApieceProduct("Ketchup", 16, "general"));
            _apieceList.Add(new ApieceProduct("Beer", 10, "alchohol"));
            _byWeightList.Add(new ByWeightProduct("Cookies", 45, "general"));
            _byWeightList.Add(new ByWeightProduct("Apple", 15, "general"));
            _byWeightList.Add(new ByWeightProduct("Meat", 70, "general"));
            _byWeightList.Add(new ByWeightProduct("Sausage", 58, "general"));
            _byWeightList.Add(new ByWeightProduct("Fish", 64, "general"));
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
