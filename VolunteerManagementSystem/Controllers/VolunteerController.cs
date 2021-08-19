using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VolunteerManagementSystem.Models;
using VolunteerManagementSystem.Models.ViewModels;

namespace VolunteerManagementSystem.Controllers
{
    public class VolunteerController : Controller
    {
        private IVolunteerRepository repository;
        public int PageSize = 4;
        public VolunteerController(IVolunteerRepository repo)
        {
            repository = repo;
        }
        public ViewResult List(string ApprovalStatus, int page = 1)
            => View(new VolunteersListViewModel
            {
                Volunteers = repository.Volunteers
                .Where(p => ApprovalStatus == null || p.ApprovalStatus == ApprovalStatus)
                .OrderBy(p => p.VolunteerID)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = ApprovalStatus == null ?
                    repository.Volunteers.Count() :
                    repository.Volunteers.Where(e =>
                    e.ApprovalStatus == ApprovalStatus).Count()
                },
                CurrentCategory = ApprovalStatus
            });
    }
}