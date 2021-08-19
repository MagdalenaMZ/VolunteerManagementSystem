using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VolunteerManagementSystem.Models;

namespace VolunteerManagementSystem.Models.ViewModels
{
    public class VolunteersListViewModel
    {
        public IEnumerable<Volunteer> Volunteers { get; set; }
        public PagingInfo PagingInfo { get; set; }

        public string CurrentCategory { get; set; }
    }
}
