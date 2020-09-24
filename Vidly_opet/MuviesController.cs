using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly_opet
{
    public class MuviesController : Controller
        {
            // GET: Muvies
            /* public ActionResult Random()
            {
                return Random();
            }
            */
            [Route("muvies/released/{year}/{month:regex(\\d {4}):range(1, 12)}")]
            public ActionResult ByReleaseYear(int year, int month)
            {
                return Content(year + "/" + month);
            }

            public ActionResult Edit(int id)
            {
                return Content("id=" + id);
            }

            // muvies
            public ActionResult index(int? pageIndex, string sortBy)
            {
                if (!pageIndex.HasValue)
                    pageIndex = 1;


                if (string.IsNullOrWhiteSpace(sortBy))
                    sortBy = "Name";

                return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
            }

            // GET Muvies/Random
            public ActionResult Random()
            {
                var muvie = new Muvie() { name = "Sreck!" };
                var customers = new List<Customer>
                {
                    new Customer {Name = "Customer 1"},
                    new Customer {Name = "Customer 2"}
                };

                var ViewModel = new RandomMuvieViewModel
                {
                    Muvie = muvie,
                    Customers = customers
                };
                ViewData["Muvie"] = muvie;
                return View(ViewModel);
            }



        }
    
}