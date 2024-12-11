using System.ComponentModel.DataAnnotations;

namespace AspHospitalMgmt.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        public int Exp { get; set; }
        
        [Required]
        public string LicenceNo { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        public int DeptId { get; set; }
        
        [Phone]
        public string PhoneNo { get; set; }
    }
}

/*namespace AspHospitalMgmt.Models
{
    public class Doctors
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public int Experience { get; set; }

        [Required]
        [StringLength(50)]
        public string LicenceNo { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public int DeptId { get; set; }

        [Required]
        [Phone]
        public string PhoneNo { get; set; }
    }
}*/
