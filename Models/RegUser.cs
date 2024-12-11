using System;
using System.ComponentModel.DataAnnotations;

namespace AspHospitalMgmt.Models
{
    public class RegUser
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string UserName { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        public string Password { get; set; }
        
        [Required]
        public string DoctorName { get; set; }
        
        public DateTime BookingDate { get; set; }
    }
}
