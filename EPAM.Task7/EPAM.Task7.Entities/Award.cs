using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task7.Entities
{
    public class Award
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string url = "https://banner2.kisspng.com/20171128/64a/gold-cup-trophy-png-clipart-picture-5a1d430290d849.5285016215118671385933.jpg";

        public override string ToString()
        {
            return $"{Id} {Title}";
        }
    }
}
