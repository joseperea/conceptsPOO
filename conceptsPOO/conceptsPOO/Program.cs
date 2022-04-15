using conceptsPOO;

try
{
    Console.WriteLine("Poo Concepts");
    Console.WriteLine("============");
    Employees employees1 = new SalaryEmployee()
    {
        BirthDate = new Date(1992, 1, 2),
        FirstName = "Jose",
        LastName = "Perea",
        HiringDate = new Date(2018, 5, 15),
        IsActive = true,
        Salary = 2100000.10M,
        Id = 2020
    };
    Employees employees2 = new CommissionEmployee()
    {
        BirthDate = new Date(1998, 1, 2),
        FirstName = "Hernando",
        LastName = "Valencia",
        HiringDate = new Date(2020, 5, 15),
        IsActive = true,
        Id = 3030,
        Sales = 320000000M,
        CommissionPercentaje = 0.03F
    };
    Employees employees3 = new HourlyEmployee()
    {
        BirthDate = new Date(1998, 1, 2),
        FirstName = "Camilo",
        LastName = "Gonzales",
        HiringDate = new Date(2020, 5, 15),
        IsActive = true,
        Id = 4040,
        HourValue = 12345.56M,
        Hours = 123.03F
    };

    Employees employees4 = new BaseCommissionEmployee()
    {
        BirthDate = new Date(1998, 1, 2),
        FirstName = "Liza",
        LastName = "Delgado",
        HiringDate = new Date(2020, 5, 15),
        IsActive = true,
        Id = 5050,
        Sales = 120000000M,
        CommissionPercentaje = 0.01F,
        Base = 900000M
    };

    ICollection<Employees> employees = new List<Employees>()
    {
       employees1,employees2, employees3, employees4
    };

    decimal PayRoll = 0;

    foreach (Employees itemEmployees in employees)
    {
        Console.WriteLine(itemEmployees);
        PayRoll += itemEmployees.GetValueToPay();
    }
    Console.WriteLine("                                ====================");
    Console.WriteLine($"TOTAL                           {$"{PayRoll:C2}",20}");

    Invoice invoice1 = new Invoice()
    {
        Description = "Realme",
        Id = 1,
        Price = 2000000M,
        Quantity = 4
    };
    Invoice invoice2 = new Invoice()
    {
        Description = "Queso Campesino",
        Id = 2,
        Price = 10000M,
        Quantity = 50
    };

    Console.WriteLine("=======================================================================");
    Console.WriteLine(invoice1);
    Console.WriteLine(invoice2);

    //Console.WriteLine(employees1);
    //Console.WriteLine(employees2);
    //Console.WriteLine(employees3);
    //Console.WriteLine(employees4);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

