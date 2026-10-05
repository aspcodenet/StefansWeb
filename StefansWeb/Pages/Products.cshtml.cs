using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StefansWeb.Data;

namespace StefansWeb.Pages
{
    public class ProductsModel : PageModel
    {
        public List<Product> Products { get; set; }
        
        // OnGet anropas när sidan skapas
        // vi kan göra avancerade saker -  hämta från databas
        public void OnGet()
        {
            Products = new List<Product>();
            Products.Add(new Product { ProductID=1,ProductName="Test", UnitPrice=12});
            Products.Add(new Product { ProductID = 2, ProductName = "Test2", UnitPrice = 121 });
            Products.Add(new Product { ProductID = 3, ProductName = "Test3", UnitPrice = 122 });
        }
    }
}
