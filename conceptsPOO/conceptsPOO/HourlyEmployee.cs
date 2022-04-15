namespace conceptsPOO
{
    public class HourlyEmployee : Employees
    {
        public float Hours { get; set; }
        public decimal HourValue { get; set; }

        public override decimal GetValueToPay()
        {
            return (decimal)Hours * HourValue;
        }


        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"{Environment.NewLine}\t Hours................: {$"{Hours:N2}",20}" +
                $"{Environment.NewLine}\t Hourd Value..........: {$"{HourValue:N2}",20}" +
                $"{Environment.NewLine}\t Value to pay.........: {$"{GetValueToPay():C2}",20}";
        }
    }
}
