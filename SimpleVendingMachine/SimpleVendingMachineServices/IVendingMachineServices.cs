using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleVendingMachineServices
{
    public interface IVendingMachineServices
    {
        int GetNumberOfCansPurchasedByTheUser(int userId, int pinNumber, int numberOfCans);

        double BalanceAvailableOnCard1AfterPurchaseOfCans(int userId, int pinNumber, int numberOfCans);
        double BalanceAvailableOnCard2AfterPurchaseOfCans(int userId, int pinNumber, int numberOfCans);
    }
}
