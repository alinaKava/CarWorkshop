using System;

namespace CarWorkshop.Models
{
    public class Appointment
    {
        private string _userName;
        private string _carTrademark;
        private string _companyName;
        private DateTime _dateTime;

        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
            }
        }

        public string CarTrademark
        {
            get
            {
                return _carTrademark;
            }
            set
            {
                _carTrademark = value;
            }
        }

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

        public DateTime DateTime
        {
            get
            {
                return _dateTime;
            }
            set
            {
                _dateTime = value;
            }
        }
    }
}
