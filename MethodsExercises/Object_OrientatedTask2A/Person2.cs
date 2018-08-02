using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_OrientatedTask2A
{
    public class Person2
    {
        string fName;
        string lName;
        int payRate;
        int tax;
        int accountNumber;
        string occupation;
        string workHours;
        string relationshipStatus;
        string noOfChildren;
        string country;
        public string Fname
        {
            get
            {
                return fName;
            }
            set
            {
                fName = value;
            }
        }
        public string Lname
        {
            get
            {
                return lName;
            }
            set
            {
                lName = value;
            }
        }
        public int PayRate
        {
            get
            {
                return payRate;
            }
            set
            {
                payRate = value;
            }
        }
        public int Tax
        {
            get
            {
                return tax;
            }
            set
            {
                tax = value;
            }
        }
        public int AccountNumber
        {
            get
            {
                return accountNumber;
            }
            set
            {
                accountNumber = value;
            }
        }
        public string Occupation
        {
            get
            {
                return occupation;
            }
            set
            {
                occupation = value;
            }
        }
        public string WorkHours
        {
            get
            {
                return workHours;
            }
            set
            {
                workHours = value;
            }
        }
        public string RelationshipStatus
        {
            get
            {
                return relationshipStatus;
            }
            set
            {
                relationshipStatus = value;
            }
        }
        public string NoOfChildren
        {
            get
            {
                return noOfChildren;
            }
            set
            {
                noOfChildren = value;
            }
        }
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        
        public Person2(string _Fname, string _Lname, int _PayRate, int _Tax, int _AccountNumber, string _Occupation, string _WorkHours, string _RelationshipStatus, string _NoOfChildren, string _Country)
        {
            fName = _Fname;
            lName = _Lname;
            payRate = _PayRate;
            tax = _Tax;
            accountNumber = AccountNumber;
            occupation = _Occupation;
            workHours = _WorkHours;
            relationshipStatus = _RelationshipStatus;
            noOfChildren = _NoOfChildren;
            country = _Country;
        }
    }
}
