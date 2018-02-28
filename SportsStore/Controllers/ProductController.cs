using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System.Linq;
using SportsStore.Models.ViewModels;

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public int PageSize = 4;

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        //public ViewResult List() => View(repository.Products);
<<<<<<< HEAD
        public ViewResult List(string category, int productPage = 1)
         => View(new ProductsListViewModel
         {
             Products = repository.Products
             .Where(p=> p.Category == null || p.Category == category)
             .OrderBy(p => p.ProductID)
             .Skip((productPage - 1) * PageSize)
             .Take(PageSize),
=======
        public ViewResult List(int productPage = 1)
         => View(new ProductsListViewModel
         {
             Products = repository.Products
         .OrderBy(p => p.ProductID)
         .Skip((productPage - 1) * PageSize)
         .Take(PageSize),
>>>>>>> 5c457cbf8a04481d495ffbef9d79c3ba9b6ad65c
             PagingInfo = new PagingInfo
             {
                 CurrentPage = productPage,
                 ItemsPerPage = PageSize,
<<<<<<< HEAD
                 TotalItems = category == null ? repository.Products.Count() : repository.Products.Where(e =>  e.Category == category).Count()
             },
             CurrentCategory=category
=======
                 TotalItems = repository.Products.Count()
             }
>>>>>>> 5c457cbf8a04481d495ffbef9d79c3ba9b6ad65c
         });
    }
}