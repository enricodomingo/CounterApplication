using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CounterApplication
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        //public HomeController(IRepository iRepository)
        //{
        //    _iRepository = iRepository;
        //}

        public ActionResult Index()
        {
            var data = db.CounterModels.FirstOrDefault();
            if(data == null)
            {
                data = new CounterModel()
                {
                    Id = 1,
                    Counter = 0
                };
            }
            return View(data);
        }

        [HttpPost]
        public ActionResult Index(int id)
        {
            var counter = db.CounterModels.Find(id);

            if(counter == null)
            {
                CounterModel count = new CounterModel()
                {
                    Counter = 1
                };
                db.CounterModels.Add(count);
                db.SaveChanges();
                counter = db.CounterModels.FirstOrDefault();
            }
            else if(counter.Counter < 10)
            {
                counter.Counter += 1;
                db.SaveChanges();
            }
            return View(counter);
        }
    }
}