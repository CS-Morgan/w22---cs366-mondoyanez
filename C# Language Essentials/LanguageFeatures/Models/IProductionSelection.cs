//using System.Collections.Generic;

//namespace LanguageFeatures.Models
//{
//    public interface IProductionSelection
//    {
//        IEnumerable<Product> Products { get; }
//    }
//}

using System.Collections.Generic;
using System.Linq;

namespace LanguageFeatures.Models
{
    public interface IProductionSelection
    {
        IEnumerable<Product> Products { get; }
        IEnumerable<string> Names => Products.Select(p => p.Name);
    }
}