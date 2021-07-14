using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BELayer
{
    public class BEL
    {
        public string _emp_code;
       

        public string emp_code
        {
            get
            {
                return _emp_code;
            }
            set
            {
                _emp_code = value;
            }
        }
        public string _Recovery_Duration;
        public string Recovery_Duration
        {
            get
            {
                return _Recovery_Duration;
            }
            set
            {
                _Recovery_Duration = value;
            }
        }
        public string _Family_Members_Affected;
        public string Family_Members_Affected
        {
            get
            {
                return _Family_Members_Affected;
            }
            set
            {
                _Family_Members_Affected = value;
            }
        }
        public string _Family_Members_Relation;
        public string Family_Members_Relation
        {
            get
            {
                return _Family_Members_Relation;
            }
            set
            {
                _Family_Members_Relation = value;
            }
        }
        public string _Family_Members_Name;
        public string Family_Members_Name
        {
            get
            {
                return _Family_Members_Name;
            }
            set
            {
                _Family_Members_Name = value;
            }
        }
       
    }

    public class EmployeeData
    {
        public string _emp_code;

        public string emp_code
        {
            get { return _emp_code; }
            set { _emp_code = value; }
        }

        public string _emp_name;

        public string emp_name
        {
            get { return _emp_name; }
            set { _emp_name = value; }
        }

        public string _emp_email;

        public string emp_email
        {
            get { return _emp_email; }
            set { _emp_email = value; }
        }

        public string _emp_contact;

        public string emp_contact
        {
            get { return _emp_contact; }
            set { _emp_contact = value; }
        }

        public string _joining_date;

        public string joining_date
        {
            get { return _joining_date; }
            set { _joining_date = value; }
        }


    }

    public class Vaccinated
    {
        public string _emp_code;
        public string emp_code
        {
            get { return _emp_code; }
            set { _emp_code = value; }
        }

       

        public string _Vaccine_Type;

        public string Vaccine_Type
        {
            get { return _Vaccine_Type; }
            set { _Vaccine_Type = value; }
        }

        public int _Dose_No;

        public int Dose_No
        {
            get { return _Dose_No ; }
            set { _Dose_No = value; }
        }

        public DateTime _Vaccine_Date;

        public  DateTime Vaccine_Date
        {
            get { return _Vaccine_Date; }
            set { _Vaccine_Date = value; }
        }

        public string _Vaccine_Location;

        public string Vaccine_Location
        {
            get { return _Vaccine_Location; }
            set { _Vaccine_Location = value; }
        }

        public string _Vaccine_Certificate;

        public string Vaccine_Certificate
        {
            get { return _Vaccine_Certificate; }
            set { _Vaccine_Certificate = value; }
        }


    }
}

 
    