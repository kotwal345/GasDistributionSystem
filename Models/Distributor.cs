namespace CentralizedDatabaseManagementSystem.Models
{
    public class Distributor
    {
        public int Id { get; set; }
        public string DistributorCode { get; set; }
        public string DistributorName { get; set; }
        public string OwnerName { get; set; }
        public DateTime CommissioningDate { get; set; }
        public string KYCUpdated { get; set; } // "Yes"/"No"
        public DateTime AgreementValidFrom { get; set; }
        public DateTime AgreementValidUpto { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Pin { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string EmergencyContact { get; set; }
        public DateTime? InsuranceExpiryDate { get; set; }
        public string GSTIN { get; set; }
        public string PNGOperatorsAvailable { get; set; } // "Yes"/"No"
        public string PNGFirmName { get; set; }
        public string Transporter { get; set; } // "Yes"/"No"
        public int NoOfVehicles { get; set; }
        public string Email { get; set; }
    }
}
