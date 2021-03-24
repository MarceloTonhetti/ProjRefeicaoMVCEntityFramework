using ProjRefeicaoMVCEntityFramework.Dal;
using ProjRefeicaoMVCEntityFramework.Models;
using System.Linq;
using System.Web.Mvc;

namespace ProjRefeicaoMVCEntityFramework.Controllers
{
    public class PizzaController : Controller
    {
        private SnackBarContext db = new SnackBarContext();

        // GET: Pizza
        public ActionResult Index()
        {
            return View(db.Pizzas.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pizza pizza)
        {
            if (ModelState.IsValid)
            {
                db.Pizzas.Add(pizza);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pizza);
        }

        public ActionResult Edit(int id)
        {
            return View(db.Pizzas.First(p => p.Id == id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Pizza pizza)
        {
            if (ModelState.IsValid)
            {
                Pizza pizzaUpdate = db.Pizzas.First(p => p.Id == pizza.Id);
                pizzaUpdate.Description = pizza.Description;
                pizzaUpdate.Value = pizza.Value;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Details(int id)
        {
            return View(db.Pizzas.First( predicate => predicate.Id == id));
        }

        public ActionResult Delete(int id)
        {
            return View(db.Pizzas.First(predicate => predicate.Id == id));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            var pizza = db.Pizzas.First(p => p.Id == id);
            db.Pizzas.Remove(pizza);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}