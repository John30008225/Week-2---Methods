using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Person1
    {
        string fname;
        string lname;
        float payrate;
        float tax;
        string acc;

        public string Fname
        {
            get
            {
                return fname;
            }
    set
            {   
                fname = value;
            }
        }
     
        public string Lname
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value;
            }
        }

        public float Payrate
        {
            get
            {
                return payrate;
            }
            set
            {
                payrate = value;
            }
        }

        public float Tax
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

        public string Acc
        {
            get
            {
                return acc;
            }
            set
            {
                acc = value;
            }
        }
        
        //Constructor  
        public Person1(string _fname, string _lname, float _payrate, float _tax, string _acc)
        {
            Fname = _fname;
            Lname = _lname;
            Payrate = _payrate;
            Tax = _tax;
            Acc = _acc;
        }
    }
}
