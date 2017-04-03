using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleVendingMachine.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int NumberOfCansPurchased { get; set; }

        public string CardNumber1 { get; set; }

        public int PinNumberForCard1 { get; set; }

        public double AvailableBalanceOnCard1 { get; set; }

        public string CardNumber2 { get; set; }

        public int PinNumberForCard2 { get; set; }

        public double AvailableBalanceOnCard2 { get; set; }

    }
}
