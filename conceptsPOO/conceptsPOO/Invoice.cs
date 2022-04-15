using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conceptsPOO
{
    public class Invoice : IPay
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public float Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal GetValueToPay()
        {
            return Price * (decimal)Quantity;
        }

        public override string ToString()
        {
            return $"{Id} - {Description}" +
                $"{Environment.NewLine}\t Quantity.............: {$"{Quantity:N2}", 20}" +
                $"{Environment.NewLine}\t Price................: {$"{Price:C2}",20}" +
                $"{Environment.NewLine}\t Value To Pay.........: {$"{GetValueToPay():C2}",20}";
        }
    }
}
