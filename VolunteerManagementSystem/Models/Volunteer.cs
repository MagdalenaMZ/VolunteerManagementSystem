using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace VolunteerManagementSystem.Models
{
    public class Volunteer
    {
        public int VolunteerID { get; set; }

        [Required(ErrorMessage = "Please enter a volunteer first name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a volunteer last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter a volunteer username ")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter a volunteer password ")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter a volunteer center preferences")]
        public string CentersPreferences { get; set; }

        [Required(ErrorMessage = "Please enter a volunteer skills/interests")]
        public string Skills_Interests { get; set; }

        [Required(ErrorMessage = "Please enter a volunteer availability")]
        public string Availability { get; set; }

        [Required(ErrorMessage = "Please enter a volunteer address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter a volunteer phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter a volunteer email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a volunteer educational background information")]
        public string EducationalBackground { get; set; }

        [Required(ErrorMessage = "Please enter a volunteer current licences")]
        public string CurrentLicenses { get; set; }

        [Required(ErrorMessage = "Please enter a volunteer emergency contact name")]
        public string EmergencyContactName { get; set; }

        [Required(ErrorMessage = "Please enter a volunteer emergency contact phone number")]
        public string EmergencyContactPhone { get; set; }

        [Required(ErrorMessage = "Please enter a volunteer emergency contact email")]
        public string EmergencyContactEmail { get; set; }

        [Required(ErrorMessage = "Please enter a volunteer emergency contact address")]
        public string EmergencyContactAddress { get; set; }

        [Required(ErrorMessage = "Please enter whether there is a copy of volunteer’s drivers license on file")]
        public string DriversLicense { get; set; }

        [Required(ErrorMessage = " Please enter whether there is a copy of volunteer’s social security card on file")]
        public string SocialSecurityCard { get; set; }

        [Required(ErrorMessage = " Please enter volunteer's approval status")]
        public string Category { get; set; }
    }
}