using System.Collections.Generic;

namespace CarWorkshop.Models
{
    public class CarWorkshop
    {
        private string _companyName;
        private List<string> _carTrademarks = new List<string>();
        private string _city;
        private string _postalCode;
        private string _country;

        public string CompanyName
        {
            get
            {
                return _companyName;
            }
            set
            {
                _companyName = value;
            }
        }

        public List<string> CarTrademarks
        {
            get
            {
                return _carTrademarks;
            }
            set
            {
                _carTrademarks = value;
            }
        }

        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }

        public string PostalCode
        {
            get
            {
                return _postalCode;
            }
            set
            {
                _postalCode = value;
            }
        }

        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
            }
        }
    }
}
