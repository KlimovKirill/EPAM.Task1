using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task3.Employee
{
    public class User
    {
        private string firstName;
        private string surName;
        private string patronymicName;
        private DateTime bdate;

        public User(string name, string surName, DateTime bdate)
        {
            if (bdate.Year > 1900 && bdate < DateTime.Now && this.TestName(name) && this.TestName(surName))
            {
                this.firstName = name;
                this.surName = surName;
                this.patronymicName = null;
                this.bdate = bdate;
            }
            else
            {
                throw new Exception();
            }
        }

        public User(string name, string surName, string patro, DateTime bdate)
        {
            if (bdate.Year > 1900 && bdate < DateTime.Now && this.TestName(name) && this.TestName(surName) && this.TestName(patro))
            {
                this.firstName = name;
                this.surName = surName;
                this.patronymicName = patro;
                this.bdate = bdate;
            }
            else
            {
                throw new Exception();
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.firstName = value;
            }
        }

        public string SurName
        {
            get
            {
                return this.surName;
            }

            set
            {
                this.surName = value;
            }
        }

        public string Patronymic
        {
            get
            {
                return this.patronymicName;
            }

            set
            {
                this.patronymicName = value;
            }
        }

        public DateTime BirthDay
        {
            get
            {
                return this.bdate;
            }

            set
            {
                if (value.Year < 1900)
                {
                    throw new Exception("Year must be more than 1900!");
                }

                this.bdate = value;
            }
        }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - this.bdate.Year;
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
