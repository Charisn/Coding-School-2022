using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Shared.ViewModels;

public class ItemViewModel
{
    public Guid ID { get; set; } = Guid.NewGuid();

    public string Code { get; set; }

    public string Description { get; set; }

    public decimal Price { get; set; }

    public decimal Cost { get; set; }


}
