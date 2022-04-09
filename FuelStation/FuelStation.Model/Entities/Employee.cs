using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model.Entities;

public class Employee : Person
{
    public DateTime StartDate { get; set; } = DateTime.Now;

    public DateTime EndDate { get; set; } = new DateTime();

    public decimal SalaryPerMonth { get; set; } 

    public EmployeeTypeENum EmployeeType { get; set; }

}
