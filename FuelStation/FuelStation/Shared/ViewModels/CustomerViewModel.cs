using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Shared.ViewModels;

public class CustomerViewModel
{
    public Guid ID { get; set; } = Guid.NewGuid();

    public string Name { get; set; }

    public string Surname { get; set; }

    public string CardNumber { get; set; }
}
