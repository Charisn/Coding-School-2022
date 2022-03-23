using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopLib.Impl.Model
{
    internal class CustomerComment
    {
        public Guid CustomerID { get; set; }

        public Customer customer { get; set; }

        public CustomerComment()
        {

        }
    }
}
