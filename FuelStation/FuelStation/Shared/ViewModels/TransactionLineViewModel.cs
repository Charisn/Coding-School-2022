using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Shared.ViewModels;

public class TransactionLineViewModel
{
    public Guid TransactionID { get; set; }

    public Guid ItemID { get; set; }

    public int Quantity { get; set; }

    public decimal ItemPrice { get; set; }

    public decimal NetValue { get; set; }

    public decimal DiscountPercentage { get; set; }

    public decimal DiscountValue { get; set; }

    public decimal TotalValue { get; set; }
}
