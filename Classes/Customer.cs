using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareII.Classes
{
    public class Customer
    {
        
        //private fields
        private int customerId;
        private string customerName;
        private int addressId;
        private int active;
        private DateTime createDate;
        private string createdBy;
        private DateTime lastUpdate;
        private string lastUpdateBy;
        private string address;
        private string address2;
        private int cityId;
        private string postalCode;
        private string phone;
        private string city;
        private int countryId;
        private string country;
        

        //public accessors and mutators
        public int CustomerId { get; set;}
        public string CustomerName { get; set; }
        public int AddressId { get; set; }
        public int Active { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public int CityId { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public int CountryId { get; set; }
        public string Country { get; set; }

    }
}
