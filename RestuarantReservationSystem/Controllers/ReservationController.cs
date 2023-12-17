using Microsoft.AspNetCore.Mvc;
using RestuarantReservationSystem.Models;
using RestuarantReservationSystem.Repositories.Abstract;


namespace RestuarantReservationSystem.Controllers
{
    public class ReservationController: Controller
    {
        private readonly IReservationService service;
        public ReservationController(IReservationService service)
        {
            this.service = service;
        }
        public IActionResult Add()
        {
           return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
           
            var reservation = service.FindById(id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        [HttpPost]
        public IActionResult Add(Reservation model)
        {
            if (!ModelState.IsValid)
            {
                 return View(model);
            }

            var result = service.Add(model);
            if (result)
            {
                TempData["msg"] = "Created Successfully";
                return RedirectToAction(nameof(Add));
            }
            
            TempData["msg"] = "Error has occured on server side";
            return View(model);
        }

        public IActionResult Update(Reservation model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var result = service.Update(model);
            if (result)
            {
                
                return RedirectToAction("GetAll");
            }

            TempData["msg"] = "Error has occured on server side";
            return View(model);
        }


        public IActionResult Delete(int id)
        {            
            var result = service.Delete(id);
            return RedirectToAction("GetAll");
                       
        }

        public IActionResult GetAll()
        {
            var data = service.GetAll();
            return View(data);

        }
    }
}
