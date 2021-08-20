using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VolunteerManagementSystem.Models;

namespace VolunteerManagementSystem.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IVolunteerRepository repository;
        public NavigationMenuViewComponent(IVolunteerRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedApprovalStatus = RouteData?.Values["category"];
            return View(repository.Volunteers
            .Select(x => x.Category)
            .Distinct()
            .OrderBy(x => x));
        }
    }
}
