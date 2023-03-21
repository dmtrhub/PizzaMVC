using MVCPizza.Models;
using static PizzaLibrary.BusinessLogic.PizzaProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVCPizza.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize]         
        public ActionResult AddPizza()
        {
            ViewBag.Message = "New Pizza";
            return View();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddPizza(PizzaModel model)
        {
            if(ModelState.IsValid)
            {
                int pizzas = CreatePizza(model.PizzaID, model.PizzaName,
                            model.PizzaSize, model.PizzaPrice);
                return RedirectToAction("PizzaCatalogue");
            }

            return View();
        }

        public ActionResult PizzaCatalogue()
        {
            ViewBag.Message = "List of Pizzas";
            var data = LoadPizza();
            List<PizzaModel> pizzas = new List<PizzaModel>();

            foreach(var row in data)
            {
                pizzas.Add(new PizzaModel
                {
                    PizzaID = row.PizzaID,
                    PizzaName = row.PizzaName,
                    PizzaSize = row.PizzaSize,
                    PizzaPrice = row.PizzaPrice
                });
            }

            return View(pizzas);
        }
    }
}