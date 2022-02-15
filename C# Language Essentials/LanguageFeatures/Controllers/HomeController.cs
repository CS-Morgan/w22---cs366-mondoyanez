//using Microsoft.AspNetCore.Mvc;

//namespace LanguageFeatures.Controllers
//{
//    public class HomeController : Controller
//    {
//        public ViewResult Index()
//        {
//            return View(new string[] { "C#", "Language", "Features" });
//        }
//    }
//}

//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;
//using LanguageFeatures.Models;

//namespace LanguageFeatures.Controllers
//{
//    public class HomeController : Controller
//    {
//        public ViewResult Index()
//        {
//            List<string> results = new List<string>();

//            foreach (Product p in Product.GetProducts())
//            {
//                string name = p?.Name;
//                decimal? price = p?.Price;
//                results.Add(string.Format("Name: {0}, Price: {1}", name, price));
//            }
//            return View(results);
//        }
//    }
//}

//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;
//using LanguageFeatures.Models;

//namespace LanguageFeatures.Controllers
//{
//    public class HomeController : Controller
//    {
//        public ViewResult Index()
//        {
//            List<string> results = new List<string>();

//            foreach (Product p in Product.GetProducts())
//            {
//                string name = p?.Name;
//                decimal? price = p?.Price;
//                string relatedName = p?.Related?.Name;
//                results.Add(string.Format("Name: {0}, Price: {1}, Related: {2}", name, price, relatedName));
//            }
//            return View(results);
//        }
//    }
//}

//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;
//using LanguageFeatures.Models;

//namespace LanguageFeatures.Controllers
//{
//    public class HomeController : Controller
//    {
//        public ViewResult Index()
//        {
//            List<string> results = new List<string>();

//            foreach (Product p in Product.GetProducts())
//            {
//                string name = p?.Name ?? "<No Name>";
//                decimal? price = p?.Price ?? 0;
//                string relatedName = p?.Related?.Name ?? "<None>";
//                results.Add(string.Format("Name: {0}, Price: {1}, Related: {2}", name, price, relatedName));
//            }
//            return View(results);
//        }
//    }
//}

// using Microsoft.AspNetCore.Mvc;
// using System.Collections.Generic;
// using LanguageFeatures.Models;

// namespace LanguageFeatures.Controllers
// {
//     public class HomeController : Controller
//     {
//         public ViewResult Index()
//         {
//             List<string> results = new List<string>();

//             foreach (Product p in Product.GetProducts())
//             {
//                 string name = p?.Name ?? "<No Name>";
//                 decimal? price = p?.Price ?? 0;
//                 string relatedName = p?.Related?.Name ?? "<None>";
//                 results.Add($"Name: {name}, Price: {price}, Related: {relatedName}");
//             }
//             return View(results);
//         }
//     }
// }

// using Microsoft.AspNetCore.Mvc;
// using System.Collections.Generic;
// using LanguageFeatures.Models;

// namespace LanguageFeatures.Controllers
// {
//     public class HomeController : Controller
//     {
//         public ViewResult Index()
//         {
//             string[] names = new string[3];
//             names[0] = "Bob";
//             names[1] = "Joe";
//             names[2] = "Alice";            
//             return View("Index", names);
//         }
//     }
// }

// using Microsoft.AspNetCore.Mvc;
// using System.Collections.Generic;
// using LanguageFeatures.Models;

// namespace LanguageFeatures.Controllers
// {
//     public class HomeController : Controller
//     {
//         public ViewResult Index()
//         {
//             return View("Index", new string[] {"Bob", "Joe", "Alice"});
//         }
//     }
// }

// using Microsoft.AspNetCore.Mvc;
// using System.Collections.Generic;
// using LanguageFeatures.Models;

// namespace LanguageFeatures.Controllers
// {
//     public class HomeController : Controller
//     {
//         public ViewResult Index()
//         {
//             Dictionary<string, Product> products = new Dictionary<string, Product> {{"Kayak", new Product {Name = "Kayak", Price = 275M}}, 
//             {"Lifejacket", new Product{Name = "Lifejacket", Price = 48.95M}}};
//             return View("Index", products.Keys);
//         }
//     }
// }

// using Microsoft.AspNetCore.Mvc;
// using System.Collections.Generic;
// using LanguageFeatures.Models;

// namespace LanguageFeatures.Controllers
// {
//     public class HomeController : Controller
//     {
//         public ViewResult Index()
//         {
//             Dictionary<string, Product> products = new Dictionary<string, Product> {
//                 ["Kayak"] = new Product { Name = "Kayak", Price = 275M},
//                 ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M}
//             };

//             return View("Index", products.Keys);
//         }
//     }
// }

//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;
//using LanguageFeatures.Models;

//namespace LanguageFeatures.Controllers
//{
//    public class HomeController : Controller
//    {
//        public ViewResult Index()
//        {
//            object[] data = new object[] { 275M, 29.95M, "apple", "orange", 100, 10};
//            decimal total = 0;
//            for (int i = 0; i < data.Length; i++)
//            {
//                if (data[i] is decimal d)
//                {
//                    total += d;
//                }
//            }

//            return View("Index", new string[] { $"Total: {total:C2}" });
//        }
//    }
//}

//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;
//using LanguageFeatures.Models;

//namespace LanguageFeatures.Controllers
//{
//    public class HomeController : Controller
//    {
//        public ViewResult Index()
//        {
//            object[] data = new object[] { 275M, 29.95M, "apple", "orange", 100, 10 };
//            decimal total = 0;
//            for (int i = 0; i < data.Length; i++)
//            {
//                switch (data[i])
//                {
//                    case decimal decimalValue:
//                        total += decimalValue;
//                        break;
//                    case int intValue when intValue > 50:
//                        total += intValue;
//                        break;
//                }
//            }

//            return View("Index", new string[] { $"Total: {total:C2}" });
//        }
//    }
//}

//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;
//using LanguageFeatures.Models;

//namespace LanguageFeatures.Controllers
//{
//    public class HomeController : Controller
//    {
//        public ViewResult Index()
//        {
//            ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };
//            decimal cartTotal = cart.TotalPrices();
//            return View("Index", new string[] { $"Total: {cartTotal:C2}" });
//        }
//    }
//}

//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;
//using LanguageFeatures.Models;

//namespace LanguageFeatures.Controllers
//{
//    public class HomeController : Controller
//    {
//        public ViewResult Index()
//        {
//            ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };

//            Product[] productArray =
//            {
//                new Product {Name = "Kayak", Price= 275M},
//                new Product {Name = "Lifejacket", Price= 48.95M}
//            };

//            decimal cartTotal = cart.TotalPrices();
//            decimal arrayTotal = productArray.TotalPrices();

//            return View("Index", new string[]
//            {
//                $"Cart Total: {cartTotal:C2}",
//                $"Array Total: {arrayTotal:C2}"
//            });
//        }
//    }
//}

//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;
//using LanguageFeatures.Models;

//namespace LanguageFeatures.Controllers
//{
//    public class HomeController : Controller
//    {
//        public ViewResult Index()
//        {
//            ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };

//            Product[] productArray =
//            {
//                new Product {Name = "Kayak", Price = 275M},
//                new Product {Name = "Lifejacket", Price = 48.95M},
//                new Product {Name = "Soccer ball", Price = 19.50M},
//                new Product {Name = "Corner Flag", Price = 34.95M}
//            };

//            decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();

//            return View("Index", new string[] { $"Array Total: {arrayTotal:C2}" });
//        }
//    }
//}

//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;
//using LanguageFeatures.Models;

//namespace LanguageFeatures.Controllers
//{
//    public class HomeController : Controller
//    {
//        public ViewResult Index()
//        {
//            ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };

//            Product[] productArray =
//            {
//                new Product {Name = "Kayak", Price = 275M},
//                new Product {Name = "Lifejacket", Price = 48.95M},
//                new Product {Name = "Soccer ball", Price = 19.50M},
//                new Product {Name = "Corner Flag", Price = 34.95M}
//            };

//            decimal priceFilterTool = productArray.FilterByPrice(20).TotalPrices();
//            decimal nameFilterTool = productArray.FilterByName('S').TotalPrices();

//            return View("Index", new string[] 
//            { 
//                $"Price Total: {priceFilterTool:C2}",
//                $"Name Total: {nameFilterTool:C2}"
//            });
//        }
//    }
//}

//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;
//using LanguageFeatures.Models;
//using System;

//namespace LanguageFeatures.Controllers
//{
//    public class HomeController : Controller
//    {

//        bool FilterByPrice(Product p)
//        {
//            return (p?.Price ?? 0) >= 20;
//        }

//        public ViewResult Index()
//        {
//            ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };

//            Product[] productArray =
//            {
//                new Product {Name = "Kayak", Price = 275M},
//                new Product {Name = "Lifejacket", Price = 48.95M},
//                new Product {Name = "Soccer ball", Price = 19.50M},
//                new Product {Name = "Corner Flag", Price = 34.95M}
//            };

//            Func<Product, bool> nameFilter = delegate (Product prod) { return prod?.Name?[0] == 'S'; };

//            decimal priceFilterTool = productArray.Filter(FilterByPrice).TotalPrices();
//            decimal nameFilterTool = productArray.Filter(nameFilter).TotalPrices();

//            return View("Index", new string[]
//            {
//                $"Price Total: {priceFilterTool:C2}",
//                $"Name Total: {nameFilterTool:C2}"
//            });
//        }
//    }
//}

//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;
//using LanguageFeatures.Models;
//using System;

//namespace LanguageFeatures.Controllers
//{
//    public class HomeController : Controller
//    {
//        public ViewResult Index()
//        {
//            ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };

//            Product[] productArray =
//            {
//                new Product {Name = "Kayak", Price = 275M},
//                new Product {Name = "Lifejacket", Price = 48.95M},
//                new Product {Name = "Soccer ball", Price = 19.50M},
//                new Product {Name = "Corner Flag", Price = 34.95M}
//            };

//            decimal priceFilterTool = productArray.Filter(p => (p?.Price ?? 0) >= 20).TotalPrices();
//            decimal nameFilterTool = productArray.Filter(p => p?.Name[0] == 'S').TotalPrices();

//            return View("Index", new string[]
//            {
//                $"Price Total: {priceFilterTool:C2}",
//                $"Name Total: {nameFilterTool:C2}"
//            });
//        }
//    }
//}

//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;
//using LanguageFeatures.Models;
//using System;
//using System.Linq;

//namespace LanguageFeatures.Controllers
//{
//    public class HomeController : Controller
//    {
//        public ViewResult Index()
//        {
//            return View(Product.GetProducts().Select(p => p?.Name));
//        }
//    }
//}

//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;
//using LanguageFeatures.Models;
//using System;
//using System.Linq;

//namespace LanguageFeatures.Controllers
//{
//    public class HomeController : Controller
//    {
//        public ViewResult Index()
//        {
//            var name = new[] { "Kayak", "Lifejacket", "Soccer ball" };
//            return View(name);
//        }
//    }
//}

//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;
//using LanguageFeatures.Models;
//using System;
//using System.Linq;

//namespace LanguageFeatures.Controllers
//{
//    public class HomeController : Controller
//    {
//        public ViewResult Index()
//        {
//            var products = new[]
//            {
//                new { Name = "Kayak", Price = 275M},
//                new { Name = "Lifejacket", Price = 48.95M},
//                new { Name = "Soccer ball", Price = 19.50M},
//                new { Name = "Corner flag", Price = 34.95M}
//            };

//            return View(products.Select(p => p.Name));
//        }
//    }
//}

//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;
//using LanguageFeatures.Models;
//using System;
//using System.Linq;

//namespace LanguageFeatures.Controllers
//{
//    public class HomeController : Controller
//    {
//        public ViewResult Index()
//        {
//            var products = new[]
//            {
//                new { Name = "Kayak", Price = 275M},
//                new { Name = "Lifejacket", Price = 48.95M},
//                new { Name = "Soccer ball", Price = 19.50M},
//                new { Name = "Corner flag", Price = 34.95M}
//            };

//            return View(products.Select(p => p.GetType().Name));
//        }
//    }
//}

//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;
//using LanguageFeatures.Models;
//using System;
//using System.Linq;

//namespace LanguageFeatures.Controllers
//{
//    public class HomeController : Controller
//    {
//        public ViewResult Index()
//        {
//            IProductionSelection cart = new ShoppingCart(
//                new Product { Name = "Kayak", Price = 275M },
//                new Product { Name = "Lifejacket", Price = 48.95M },
//                new Product { Name = "Soccer ball", Price = 19.50M },
//                new Product { Name = "Corner flag", Price = 34.95M }
//            );

//            return View(cart.Products.Select(p => p.Name));
//        }  
//    }
//}

//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;
//using LanguageFeatures.Models;
//using System;
//using System.Linq;

//namespace LanguageFeatures.Controllers
//{
//    public class HomeController : Controller
//    {
//        public ViewResult Index()
//        {
//            IProductionSelection cart = new ShoppingCart(
//                new Product { Name = "Kayak", Price = 275M },
//                new Product { Name = "Lifejacket", Price = 48.95M },
//                new Product { Name = "Soccer ball", Price = 19.50M },
//                new Product { Name = "Corner flag", Price = 34.95M }
//            );

//            return View(cart.Names);
//        }
//    }
//}

//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;
//using LanguageFeatures.Models;
//using System;
//using System.Linq;
//using System.Threading.Tasks;

//namespace LanguageFeatures.Controllers
//{
//    public class HomeController : Controller
//    {
//        public async Task<ViewResult> Index()
//        {
//            long? length = await MyAsyncMethods.GetPageLength();
//            return View(new string[] { $"Length: {length}" });
//        }
//    }
//}

//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;
//using LanguageFeatures.Models;
//using System;
//using System.Linq;
//using System.Threading.Tasks;

//namespace LanguageFeatures.Controllers
//{
//    public class HomeController : Controller
//    {
//        public async Task<ViewResult> Index()
//        {
//            List<string> output = new List<string>();
//            await foreach (long? len in MyAsyncMethods.GetPageLengths(output, "apress.com", "microsoft.com", "amazon.com"))
//            {
//                output.Add($"Page length: { len}");
//            }

//            return View(output);
//        }
//    }
//}

//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;
//using LanguageFeatures.Models;
//using System;
//using System.Linq;
//using System.Threading.Tasks;

//namespace LanguageFeatures.Controllers
//{
//    public class HomeController : Controller
//    {
//        public ViewResult Index()
//        {
//            var products = new[]
//            {
//                new { Name = "Kayak", Price = 275M},
//                new { Name = "Lifejacket", Price = 48.95M},
//                new { Name = "Soccer ball", Price = 19.50M},
//                new { Name = "Corner flag", Price = 34.95M}
//            };

//            return View(products.Select(p => $"Name: {p.Name}, Price: {p.Price}"));
//        }
//    }
//}

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            var products = new[]
            {
                new { Name = "Kayak", Price = 275M},
                new { Name = "Lifejacket", Price = 48.95M},
                new { Name = "Soccer ball", Price = 19.50M},
                new { Name = "Corner flag", Price = 34.95M}
            };

            return View(products.Select(p => $"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price}"));
        }
    }
}