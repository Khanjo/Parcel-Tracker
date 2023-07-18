using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{
    public class ParcelsController : Controller
    {
        [HttpGet("/parcels")]
        public ActionResult Index()
        {
            List<Parcel> parcels = Parcel.GetAll();
            return View(parcels);
        }

        [HttpGet("/parcels/new")]
        public ActionResult ParcelForm()
        {
            return View();
        }

        [HttpPost("/parcels")]
        public ActionResult Create(int length, int width, int height, int weight)
        {
            Parcel parcel = new Parcel(length, width, height, weight);
            return RedirectToAction("Index");
        }
    }
}