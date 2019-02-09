using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task7.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public DateTime DateOfBirth { get; set; }

        public string url = "http://www.p-etalon.ru/global/images/prod/nophoto.png";

        public int Age
        {
            get
            {
                return DateTime.Now.Year - this.DateOfBirth.Year;
            }
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Age}";
        }
    }
}
