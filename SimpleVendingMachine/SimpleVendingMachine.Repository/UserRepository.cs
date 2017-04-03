using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleVendingMachine.Models;

namespace SimpleVendingMachine.Repository
{
    public class UserRepository : IUserRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public User GetUser(int userId)
        {
            //throw new NotImplementedException();
            var users = GetUsers();

            var getUserByUserID = (from u in users
                                where u.Id == userId
                                select u).FirstOrDefault();
            return getUserByUserID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<User> GetUsers()
        {
            //throw new NotImplementedException();
            var userList = new List<User>();
            User user1 = new User
            {
                Id = 1,
                Name="Santanu",
                NumberOfCansPurchased = 0,
                CardNumber1 = "846723498093842",
                PinNumberForCard1 = 6324,
                AvailableBalanceOnCard1 = 110.80,
                CardNumber2 = "628723981239873",
                PinNumberForCard2 = 0731,
                AvailableBalanceOnCard2 = 50.50
            };
            User user2 = new User
            {
                Id = 2,
                Name = "Charolette",
                NumberOfCansPurchased = 2,
                CardNumber1 = "6389743987893333",
                PinNumberForCard1 = 3238,
                AvailableBalanceOnCard1 = 45.0,
                CardNumber2 = "628723981239873",
                PinNumberForCard2 = 4566,
                AvailableBalanceOnCard2 = 23.78
            };
            userList.Add(user1);
            userList.Add(user2);
            return userList;
        }

        /// <summary>
        /// This method update the user details like number of cans purchased and available balance on card1 and card2
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="pinNumber"></param>
        /// <param name="numberOfCansUserWantsToBuy"></param>
        /// <returns></returns>
        public User UpdateUser(int userId, int pinNumber, int numberOfCansUserWantsToBuy)
        {
            //throw new NotImplementedException();
            var users = GetUsers();

            var getUserByUserID = (from u in users
                                   where u.Id == userId
                                   select u).SingleOrDefault();

            double amountToBeTakenFromCard1 = 0.0;



            double availableAmountRemainsInCard1 = 0.0;

            double amountToBeTakenFromCard2 = 0.0;

            double availableAmountRemainsInCard2 = 0.0;

            //making sure the user is only allowed to buy cans if he/she do not exceed the already NumberOfCansPurchased limit of 25
            if (getUserByUserID.NumberOfCansPurchased<25)
            {
                //if the pin number entered by the user do not match the pin number of card1 or card2
                if (pinNumber != getUserByUserID.PinNumberForCard1 && pinNumber!= getUserByUserID.PinNumberForCard2)
                {
                    throw new Exception("Sorry the pin number entered is invalid");
                }
                //if the pin number entered by user matches the pin number for card1 
                if (pinNumber == getUserByUserID.PinNumberForCard1)
                {
                    amountToBeTakenFromCard1 = numberOfCansUserWantsToBuy * 0.50;
                    if (getUserByUserID.AvailableBalanceOnCard1 >= amountToBeTakenFromCard1)
                    {
                        //updating the amount available on card1 and the number of cans purchased after the successful transaction
                        availableAmountRemainsInCard1 = getUserByUserID.AvailableBalanceOnCard1 - amountToBeTakenFromCard1;
                        getUserByUserID.AvailableBalanceOnCard1 = availableAmountRemainsInCard1;
                        
                    }
                    getUserByUserID.NumberOfCansPurchased += numberOfCansUserWantsToBuy;

                }
                //if the pin number entered by user matches the pin number for card2 
                if (pinNumber == getUserByUserID.PinNumberForCard2)
                {
                    amountToBeTakenFromCard2 = numberOfCansUserWantsToBuy * 0.50;
                    if (getUserByUserID.AvailableBalanceOnCard2 >= amountToBeTakenFromCard2)
                    {
                        //updating the amount available on card2 and the number of cans purchased after the successful transaction
                        availableAmountRemainsInCard2 = getUserByUserID.AvailableBalanceOnCard2 - amountToBeTakenFromCard2;
                        getUserByUserID.AvailableBalanceOnCard2 = availableAmountRemainsInCard2;
                        
                    }
                    getUserByUserID.NumberOfCansPurchased += numberOfCansUserWantsToBuy;
                }
            }
            //if the user already bought 25 cans previously
            else
            {
                throw new Exception("Sorry you have reached the maximum number of cans allowed to be purchased.");
            }
            

            return getUserByUserID;
        }
    }
}
