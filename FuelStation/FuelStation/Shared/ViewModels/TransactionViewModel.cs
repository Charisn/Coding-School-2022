using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Shared.ViewModels;

public class TransactionViewModel
{
    public Guid ID { get; set; } = Guid.NewGuid();

    public Guid EmployeeID { get; set; }

    public Guid CustomerID { get; set; }

    public List<TransactionLineViewModel> TransactionLines { get; set; } = new();    
}
