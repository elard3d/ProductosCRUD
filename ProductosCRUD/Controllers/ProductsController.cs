using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductosCRUD.Models;

namespace ProductosCRUD.Controllers
{
    public class ProductsController : Controller {

        private ProductosContext _context;

        public ProductsController(ProductosContext context) {
        
            this._context = context;
        }
    
        public ViewResult Index()
        {
            ViewBag.Products = _context.Products.ToList();

            return View("Index");

        }
        
        public ViewResult Create()
        {
            return View("Create");
        }




    }
}
