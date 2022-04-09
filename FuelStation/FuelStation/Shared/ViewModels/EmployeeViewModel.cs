using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Shared.ViewModels;

public class EmployeeViewModel
{
    public Guid ID { get; set; } = Guid.NewGuid();

    public string Name { get; set; }

    public string Surname { get; set; }

    public decimal SalaryPerMonth { get; set; }

    public EmployeeTypeENum EmployeeType { get; set; }

    public DateTime StartDate { get; set; } = DateTime.Now;

    public DateTime EndDate { get; set; } = new DateTime();
}

public class EmployeeCreateViewModel
{
    public DateTime StartDate { get; set; } = DateTime.Now;
    public string Name { get; set; }

    public string Surname { get; set; }

    public decimal SalaryPerMonth { get; set; }
    public EmployeeTypeENum EmployeeType { get; set; }

}
public class EmployeeUpdateViewModel
{
    public string Name { get; set; }

    public string Surname { get; set; }

    public decimal SalaryPerMonth { get; set; }
    public EmployeeTypeENum EmployeeType { get; set; }

}

public class EmployeeDeleteViewModel
{
    public Guid ID { get; set; } = Guid.NewGuid();

    public string Name { get; set; }

    public string Surname { get; set; }

    public decimal SalaryPerMonth { get; set; }
    public EmployeeTypeENum EmployeeType { get; set; }
    public DateTime EndDate { get; set; } = DateTime.Now;
}
