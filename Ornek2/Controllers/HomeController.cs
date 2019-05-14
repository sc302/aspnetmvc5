using Ornek2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ornek2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int? kategoriId)
        {
            //1 kategori listesi
            //dropdowna bas
            //HTML.BeginForm()
            //selected item id yi aldin
            //return View() kategori
            //return View(o id ile ilgili products)
            //-------
            //bir model ol
            List<KategoriProductViewModel> liste = new List<KategoriProductViewModel>();
            liste.Add(new KategoriProductViewModel()
            {
                KategoriId = 0,
                KategoriAdi="beyaz esya",
                Products = new List<Product>() {
                    new Product() { ProductId = 0, ProductName = "buzdolabi" },
                    new Product() { ProductId = 1, ProductName = "camasir makinesi" }
                },     
            });
            liste.Add(new KategoriProductViewModel()
            {
                KategoriId = 1,
                KategoriAdi="elektronik",
                Products = new List<Product>() {
                    new Product() { ProductId = 2, ProductName = "pc" },
                    new Product() { ProductId = 3, ProductName = "tv" }
                },
            });


           // ViewBag.ProductList = liste;

            return View(liste);
        }
    }


}