using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProdcutsApp.Models;

namespace ProdcutsApp.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product []{
            new Product { Id=1, Name="Tomato-Soup", Category="Grocery", Price=10},
            new Product{ Id=2, Name="ben-ten-car",Category="Toys", Price=20 },
            new Product {Id=3, Name="Hammer", Category="Hardware", Price=30}
        };

        public IEnumerable<Product> GetAllProducts() {
            return products;
        }

        public IHttpActionResult GetProduct(int Id) {
            var product = products.FirstOrDefault((p) => p.Id == Id);
            if (product == null) {
                return NotFound();
            }
            return Ok(product);
        }

    }
}
