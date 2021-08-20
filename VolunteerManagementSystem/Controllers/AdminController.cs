using Microsoft.AspNetCore.Mvc;
using VolunteerManagementSystem.Models;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace VolunteerManagementSystem.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IVolunteerRepository repository;
        public AdminController(IVolunteerRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index() => View(repository.Volunteers);

        public ViewResult Edit(int volunteerId) =>
            View(repository.Volunteers
                .FirstOrDefault(p => p.VolunteerID == volunteerId));

        [HttpPost]
        public IActionResult Edit(Volunteer volunteer)
        {
            if (ModelState.IsValid)
            {
                repository.SaveVolunteer(volunteer);
                TempData["message"] = $"{volunteer.FirstName} has been saved";
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(volunteer);
            }
        }
        public ViewResult Create() => View("Edit", new Volunteer());

        [HttpPost]
        public IActionResult Delete(int volunteerId)
        {
            Volunteer deletedVolunteer = repository.DeleteVolunteer(volunteerId);
            if (deletedVolunteer != null)
            {
                TempData["message"] = $"{deletedVolunteer.FirstName} was deleted";
            }
            return RedirectToAction("Index");
        }
    }
}
