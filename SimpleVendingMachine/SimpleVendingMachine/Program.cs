using SimpleVendingMachine.Repository;
using SimpleVendingMachine.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleVendingMachine
{
    class Program
    {
        
        static void Main(string[] args)
        {
            VendingMachineServices myVendingServices = new VendingMachineServices();
            UserRepository myUserRepository = new UserRepository();
            Console.Beep();
            Console.WriteLine("Welcomes user to Vending Machine, please buy cans by providing following details...");
            Console.WriteLine("Please type your ID: ");
            try
            {
                int userId = Convert.ToInt32(Console.ReadLine());
                var user = myUserRepository.GetUser(userId);
                Console.Beep();
                Console.WriteLine("Welcome " + user.Name + "!");
                Console.WriteLine("Please provide the pin number for your card: ");
                int pinNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please provide the number of cans you want to buy: ");
                int numberOfCans = Convert.ToInt32(Console.ReadLine());
                user = myUserRepository.UpdateUser(userId, pinNumber, numberOfCans);
                Console.Beep();
                Console.WriteLine("You have now purchased: " 
                    + myVendingServices.GetNumberOfCansPurchasedByTheUser(userId,pinNumber,numberOfCans).ToString()+ " cans");
                Console.WriteLine("Your balance available on card1: " 
                    + myVendingServices.BalanceAvailableOnCard1AfterPurchaseOfCans(userId, pinNumber, numberOfCans).ToString());
                Console.WriteLine("Your balance available on card2: "
                    + myVendingServices.BalanceAvailableOnCard2AfterPurchaseOfCans(userId, pinNumber, numberOfCans).ToString());
            }
            catch (Exception ex)
            {

                Console.WriteLine("You have entered Invalid Data " + ex.Message.ToString());
            }

            Console.ReadLine();


        }
    }
}
