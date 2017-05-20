using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContext
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Phone> Phones { get; set; }

        public Company()
        {
            Phones = new List<Phone>();
        }
    }
}
