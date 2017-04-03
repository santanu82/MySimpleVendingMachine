
using SimpleVendingMachine.Repository;
using SimpleVendingMachineServices;

namespace SimpleVendingMachine.Services
{
    public class VendingMachineServices: IVendingMachineServices
    {
        #region Constructor Injection
        //private IUserRepository _userRepository;
        //public VendingMachineServices(IUserRepository userRepository)
        //{
        //    userRepository = _userRepository;
        //}
        #endregion

        UserRepository userRepository = new UserRepository();

        /// <summary>
        /// This method returns the number of cans purchased by the user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public int GetNumberOfCansPurchasedByTheUser(int userId,int pinNumber, int numberOfCans)
        {
            var user = userRepository.UpdateUser(userId,pinNumber,numberOfCans);
            int numberOfCansPurchased = user.NumberOfCansPurchased;
            return numberOfCansPurchased;
        }

        /// <summary>
        /// This method returns the balance available on card1 after the purchase of cans
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="numberOfCans"></param>
        /// <returns></returns>
        public double BalanceAvailableOnCard1AfterPurchaseOfCans(int userId,int pinNumber, int numberOfCans)
        {
            var user = userRepository.UpdateUser(userId, pinNumber, numberOfCans);
            double availableBalanceOnCard1 = user.AvailableBalanceOnCard1;
            return availableBalanceOnCard1;
        }

        /// <summary>
        /// This method returns the balance available on card2 after the purchase of cans
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="numberOfCans"></param>
        /// <returns></returns>
        public double BalanceAvailableOnCard2AfterPurchaseOfCans(int userId, int pinNumber, int numberOfCans)
        {
            var user = userRepository.UpdateUser(userId, pinNumber, numberOfCans);
            double availableBalanceOnCard2 = user.AvailableBalanceOnCard2;
            return availableBalanceOnCard2;
        }
    }
}
