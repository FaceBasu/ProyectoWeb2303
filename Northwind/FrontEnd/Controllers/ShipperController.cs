using FrontEnd.Helpers.Implementations;
using FrontEnd.Helpers.Interfaces;
using FrontEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class ShipperController : Controller
    {

        IShipperHelper ShipperHelper;


        public ShipperController(IShipperHelper _ShipperHelper)

        {
            ShipperHelper = _ShipperHelper;
        }



        // GET: ShipperController
        public ActionResult Index()
        {
           

            List<ShipperViewModel> categories = ShipperHelper.GetAll();

            return View(categories);
        }

        // GET: ShipperController/Details/5
        public ActionResult Details(int id)
        {
            ShipperViewModel Shipper = ShipperHelper.GetById(id);
            return View(Shipper);
        }

        // GET: ShipperController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShipperController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ShipperViewModel Shipper)
        {
            try
            {
                ShipperHelper.AddShipper(Shipper);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ShipperController/Edit/5
        public ActionResult Edit(int id)
        {
            ShipperViewModel Shipper = ShipperHelper.GetById(id);
            return View(Shipper);
        }

        // POST: ShipperController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ShipperViewModel Shipper)
        {
            try
            {
                ShipperViewModel ShipperViewModel = ShipperHelper.EditShipper(Shipper);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ShipperController/Delete/5
        public ActionResult Delete(int id)
        {
            ShipperViewModel Shipper = ShipperHelper.GetById(id);
            return View(Shipper);
        }

        // POST: ShipperController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ShipperViewModel Shipper)
        {
            try
            {
                ShipperHelper.DeleteShipper(Shipper.ShipperId);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
