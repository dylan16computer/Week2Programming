﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_OrientatedTask1A
{
    public class Person1
    {
        string fName;
        string lName;
        int payRate;
        int tax;
        int accountNumber;
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
    }
}
