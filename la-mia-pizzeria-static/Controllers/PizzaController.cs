﻿using la_mia_pizzeria_static.Data;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            PizzeriaContext db = new PizzeriaContext();
            List<Pizza> listaPizza = db.Pizzas.ToList();
            return View(listaPizza);
        }

        public IActionResult Dettagli(int id)
        {
            PizzeriaContext db = new PizzeriaContext();
            Pizza pizza = db.Pizzas.Where(p => p.Id == id).FirstOrDefault();
            return View(pizza);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pizza pizza)
        {
            return View();
        }

    }
}
