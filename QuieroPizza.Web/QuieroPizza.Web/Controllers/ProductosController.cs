using QuieroPizza.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuieroPizza.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var producto1 = new ProductoModel();
            producto1.ID = 1;
            producto1.Descripcion = "Pizza de pepperoni ";

            var producto2 = new ProductoModel();
            producto2.ID = 2;
            producto2.Descripcion = "Pizza de 4 estaciones ";

            var producto3 = new ProductoModel();
            producto3.ID = 3;
            producto3.Descripcion = "Pizza Cheese Lovers ";

            var producto4 = new ProductoModel();
            producto4.ID = 4;
            producto4.Descripcion = "Pizza Italiana ";

            var producto5 = new ProductoModel();
            producto5.ID = 5;
            producto5.Descripcion = "Pizza Suprema ";

            var listadeProductos = new List<ProductoModel>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);
            listadeProductos.Add(producto4);
            listadeProductos.Add(producto5);

            return View(listadeProductos);
        }
    }
}