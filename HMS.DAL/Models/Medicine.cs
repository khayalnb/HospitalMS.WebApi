using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DAL.Models
{
    public class Medicine:BaseEntity
    {
        public string Name { get; set; }
        public string ProduceCompanyName { get; set; }
        public string CompositionDescription { get; set; }
        public decimal PriceCost { get; set; }
        public string Dose { get; set; }
        public string Description { get; set; }
    }
}
