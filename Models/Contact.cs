using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnet_Adresse
{
    class Contact
    {

        private string _lastName;
        private string _firstName;
        private string _middleName;
        private string _phone;
        private string  _email;
        private string _address1;
        private string _address2;
        private string _city;
        private string _state;
        private string _zip;
        private string _country;

        #region Properties
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        public string Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }


        public string State
        {
            get { return _state; }
            set { _state = value; }
        }


        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string Address2
        {
            get { return _address2; }
            set { _address2 = value; }
        }

        public string Address1
        {
            get { return _address1; }
            set { _address1 = value; }
        }


        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }


        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }



        public string MiddleName
        {
            get { return _middleName; }
            set { _middleName = value; }
        }


        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        #endregion

        #region ctor
        public Contact(string lastName, string firstName, string middleName, string phone, string email, string address1, string address2, string city, string state, string zip, string country)
        {
            _lastName = lastName;
            _firstName = firstName;
            _middleName = middleName;
            _phone = phone;
            _email = email;
            _address1 = address1;
            _address2 = address2;
            _city = city;
            _state = state;
            _zip = zip;
            _country = country;
        }


        #endregion


        public override string ToString()
        {
            return $"{LastName}, {FirstName}";
        }

        public override bool Equals(object obj)
        {
            return obj is Contact contact &&
                   Country == contact.Country &&
                   Zip == contact.Zip &&
                   State == contact.State &&
                   City == contact.City &&
                   Address2 == contact.Address2 &&
                   Address1 == contact.Address1 &&
                   Email == contact.Email &&
                   Phone == contact.Phone &&
                   MiddleName == contact.MiddleName &&
                   FirstName == contact.FirstName &&
                   LastName == contact.LastName;
        }

        public override int GetHashCode()
        {
            int hashCode = -1911988389;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Country);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Zip);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(State);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(City);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Address2);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Address1);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Phone);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MiddleName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FirstName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LastName);
            return hashCode;
        }
    }
}
