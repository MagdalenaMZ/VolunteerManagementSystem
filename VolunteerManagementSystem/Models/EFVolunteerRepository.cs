using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerManagementSystem.Models
{
    public class EFVolunteerRepository : IVolunteerRepository
    {
        private ApplicationDbContext context;
        public EFVolunteerRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<Volunteer> Volunteers => context.Volunteers;

        public void SaveVolunteer(Volunteer volunteer)
        {
            if (volunteer.VolunteerID == 0)
            {
                context.Volunteers.Add(volunteer);
            }
            else
            {
                Volunteer dbEntry = context.Volunteers
                .FirstOrDefault(p => p.VolunteerID == volunteer.VolunteerID);
                if (dbEntry != null)
                {
                    dbEntry.FirstName = volunteer.FirstName;
                    dbEntry.LastName = volunteer.LastName;
                    dbEntry.Skills_Interests = volunteer.Skills_Interests;
                    dbEntry.Category = volunteer.Category;
                }
            }
            context.SaveChanges();
        }
        public Volunteer DeleteVolunteer(int volunteerID)
        {
            Volunteer dbEntry = context.Volunteers
            .FirstOrDefault(p => p.VolunteerID == volunteerID);
            if (dbEntry != null)
            {
                context.Volunteers.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
