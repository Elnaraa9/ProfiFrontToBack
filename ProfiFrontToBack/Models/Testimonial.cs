using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfiFrontToBack.Models
{
    public class Testimonial 
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public int Star { get; set; }
    }
}
