//using System.Collections.Generic;

//namespace LanguageFeatures.Models
//{
//    public class ShoppingCart
//    {
//        public IEnumerable<Product> Products { get; set; }
//    }
//}


//using System.Collections;
//using System.Collections.Generic;

//namespace LanguageFeatures.Models
//{
//    public class ShoppingCart : IEnumerable<Product>
//    {
//        public IEnumerable<Product> Products { get; set; }
//        public IEnumerator<Product> GetEnumerator() { return Products.GetEnumerator(); }
//        IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
//    }
//}

using System.Collections;
using System.Collections.Generic;

namespace LanguageFeatures.Models
{
    public class ShoppingCart : IProductionSelection
    {
        private List<Product> products = new List<Product>();
        public ShoppingCart(params Product[] prods) { products.AddRange(prods); }
        public IEnumerable<Product> Products { get => products; }
    }
}
