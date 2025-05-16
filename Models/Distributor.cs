using System;
using System.ComponentModel.DataAnnotations;

namespace CentralizedDatabaseManagementSystem.Models
{
    public class Distributor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter Distributor Code")]
        [MaxLength(6, ErrorMessage = "Maximum 6 Character only")]
        public string DistributorCode { get; set; }

        [Required(ErrorMessage = "Please enter Distributor Name")]
        public string DistributorName { get; set; }

        [Required(ErrorMessage = "Please enter Owner Name")]
        public string OwnerName { get; set; }

        [Required(ErrorMessage = "Please enter Commissioning Date")]
        [DataType(DataType.Date)]
        public DateTime CommissioningDate { get; set; }

        [Required(ErrorMessage = "Please enter Agreement Valid From date")]
        [DataType(DataType.Date)]
        public DateTime AgreementValidFrom { get; set; }

        [Required(ErrorMessage = "Please enter Agreement Valid Upto date")]
        [DataType(DataType.Date)]
        public DateTime AgreementValidUpto { get; set; }

        [Required(ErrorMessage = "Please enter Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter State")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter Pin Code")]
        public string Pin { get; set; }

        [Required(ErrorMessage = "Please enter Phone number")]
        [Phone(ErrorMessage = "Invalid Phone number")]
        public string Phone { get; set; }

        [Phone(ErrorMessage = "Invalid Mobile number")]
        public string Mobile { get; set; }

        [Phone(ErrorMessage = "Invalid Emergency Contact number")]
        public string EmergencyContact { get; set; }

        public string GSTIN { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Please enter a valid number of vehicles")]
        public int NoOfVehicles { get; set; }

        [Required(ErrorMessage = "Please enter Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
    }
}
