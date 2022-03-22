using PetShopLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PetShopLib.Impl
{
    public class Customer : ICustomer
    {
        [Required]
        public long Phone { get ; set; }
        public int TIN { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public Guid ID { get; set; }
        public string FullName { get { return $"{Name} {SurName} "; } }
        public Customer()
        {
            ID = Guid.NewGuid();
        }
    }

}
