using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace VolunteerManagementSystem.Models
{
    public class Volunteer
    {
        public int VolunteerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string CentersPreferences { get; set; }
        public string Skills_Interests { get; set; }
        public string Availability { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string EducationalBackground { get; set; }
        public string CurrentLicenses { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactPhone { get; set; }
        public string EmergencyContactEmail { get; set; }
        public string EmergencyContactAddress { get; set; }
        public string DriversLicense { get; set; }
        public string SocialSecurityCard { get; set; }
        public string ApprovalStatus { get; set; }
    }
}