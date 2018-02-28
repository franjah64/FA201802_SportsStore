using System.Collections.Generic;
using SportsStore.Models;

namespace SportsStore.Models.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
<<<<<<< HEAD
        public string CurrentCategory { get; set; }
=======
>>>>>>> 5c457cbf8a04481d495ffbef9d79c3ba9b6ad65c
    }
}