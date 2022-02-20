namespace conceptsPOO
{
    public class SalaryEmployee : Employees
    {

        public decimal Salary { get; set; }

        public override decimal GetValueToPay()
        {
            //Agregar Logica para calcular otras cosas.
            return Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"{Environment.NewLine}\t Value to pay.........: {$"{GetValueToPay():C2}", 20}";
        }
    }
}
