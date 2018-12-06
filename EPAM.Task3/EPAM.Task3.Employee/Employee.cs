using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task3.Employee
{
    public class Employee : User
    {
        private DateTime emplDate;
        private string position;

        public Employee(string name, string sname, DateTime bdate, DateTime edate) : base(name, sname, bdate)
        {
            if (bdate.Year > 1900 && edate.Year > 1900 && edate < DateTime.Now)
            {
                this.emplDate = edate;
            }
            else
            {
                throw new Exception();
            }
        }

        public Employee(string name, string sname, string patro, DateTime bdate, string position, DateTime edate) : base(name, sname, patro, bdate)
        {
            if (bdate.Year > 1900 && edate.Year > 1914 && edate < DateTime.Now && this.TestName(position))
            {
                this.position = position;
                this.emplDate = edate;
            }
            else
            {
                throw new Exception();
            }
        }

        public string Position
        {
            get
            {
                return this.position;
            }

            set
            {
                this.position = value;
            }
        }

        public DateTime EmployedDate
        {
            get
            {
                return this.emplDate;
            }

            set
            {
                if (value.Year < 1914)
                {
                    throw new Exception("Year must be more than 1914!");
                }

                this.emplDate = value;
            }
        }

        public int WorkExperience
        {
            get
            {
                return DateTime.Now.Year - this.emplDate.Year;
            }
        }

        private bool TestName(string name)
        {
            if (name.Length < 1)
            {
                return false;
            }

            int separatorTest = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (char.IsSeparator(name[i]))
                {
                    separatorTest++;
                }
            }

            if (separatorTest == name.Length)
            {
                return false;
            }

            return true;
        }
    }
}
