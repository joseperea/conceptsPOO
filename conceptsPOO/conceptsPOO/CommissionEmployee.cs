using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conceptsPOO
{
    public class CommissionEmployee : Employees
    {
        public float CommissionPercentaje { get; set; }
        public decimal Sales { get; set; }

        public override decimal GetValueToPay()
        {
           return Sales * (decimal)CommissionPercentaje;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"{Environment.NewLine}\t Commission Percentaje: {$"{CommissionPercentaje:P2}",20}" +
                $"{Environment.NewLine}\t Sale.................: {$"{Sales:C2}",20}" +
                $"{Environment.NewLine}\t Value to pay.........: {$"{GetValueToPay():C2}",20}";
        }
    }
}
