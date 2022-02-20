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
        Id = 02
    };
    Employees employees2 = new CommissionEmployee()
    {
        BirthDate = new Date(1998, 1, 2),
        FirstName = "Hernando",
        LastName = "Valencia",
        HiringDate = new Date(2020, 5, 15),
        IsActive = true,
        Id = 03,
        Sales = 320000000M,
        CommissionPercentaje = 0.03F
    };
    Console.WriteLine(employees1);
    Console.WriteLine(employees2);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

