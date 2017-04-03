using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleVendingMachine.Repository;

namespace SimpleVendingMachine.Tests
{
    [TestClass]
    public class VendingMachineServicesTests
    {
        [TestMethod]
        public void Update_Cans_Purchased_By_The_User1_Correctly()
        {
            //Act
            int numberOfCansUserWantToBuy = 10;
            int userId = 1;
            int pinNumber = 6324;
            //as the user has already purchased 0 cans before, hence total cans purchased by the user now is 10
            int expectedCansPurchasedByUser = 10;
            //Assert
            UserRepository myUserRepository = new UserRepository();
            var user = myUserRepository.UpdateUser(userId, pinNumber, numberOfCansUserWantToBuy);
            int actualNumberOfCansPurchasedByUser = user.NumberOfCansPurchased;
            //Arrange
            Assert.AreEqual(expectedCansPurchasedByUser, actualNumberOfCansPurchasedByUser);

        }
        [TestMethod]
        public void Update_Balance_On_Card1_Correctly_When_Card1_Used_By_User1()
        {
            //Act
            int numberOfCansUserWantToBuy = 10;
            int userId = 1;
            int pinNumber = 6324;
            //as the user has already purchased 0 cans before, hence he/she have to pay for 10 cans which is (10*0.5 = 5.0)
            double expectedAvailableBalanceOnCard1 = 105.8;
            //Assert
            UserRepository myUserRepository = new UserRepository();
            var user = myUserRepository.UpdateUser(userId, pinNumber, numberOfCansUserWantToBuy);
            double actualAvailableBalanceOnCard1 = user.AvailableBalanceOnCard1;
            //Arrange
            Assert.AreEqual(expectedAvailableBalanceOnCard1, actualAvailableBalanceOnCard1);
        }
        [TestMethod]
        public void Update_Balance_On_Card2_Correctly_When_Card2_Used_By_User1()
        {
            //Act
            int numberOfCansUserWantToBuy = 10;
            int userId = 1;
            int pinNumber = 0731;
            //as the user has already purchased 0 cans before, hence he/she have to pay for 10 cans which is (10*0.5 = 5.0)
            double expectedAvailableBalanceOnCard2 = 45.5;
            //Assert
            UserRepository myUserRepository = new UserRepository();
            var user = myUserRepository.UpdateUser(userId, pinNumber, numberOfCansUserWantToBuy);
            double actualAvailableBalanceOnCard2 = user.AvailableBalanceOnCard2;
            //Arrange
            Assert.AreEqual(expectedAvailableBalanceOnCard2, actualAvailableBalanceOnCard2);
        }


        [TestMethod]
        public void Update_Cans_Purchased_By_The_User2_Correctly()
        {
            //Act
            int numberOfCansUserWantToBuy = 7;
            int userId = 2;
            int pinNumber = 3238;
            //as the user has already purchased 2 cans before, hence total cans purchased by the user now is 9
            int expectedCansPurchasedByUser = 9;
            //Assert
            UserRepository myUserRepository = new UserRepository();
            var user = myUserRepository.UpdateUser(userId, pinNumber, numberOfCansUserWantToBuy);
            int actualNumberOfCansPurchasedByUser = user.NumberOfCansPurchased;
            //Arrange
            Assert.AreEqual(expectedCansPurchasedByUser, actualNumberOfCansPurchasedByUser);

        }
        [TestMethod]
        public void Update_Balance_On_Card1_Correctly_When_Card1_Used_By_User2()
        {
            //Act
            int numberOfCansUserWantToBuy = 7;
            int userId = 2;
            int pinNumber = 3238;
            //as the user has already purchased 2 cans before, hence he/she have to pay for 7 cans which is (7*0.5 = 3.5)
            double expectedAvailableBalanceOnCard1 = 41.5;
            //Assert
            UserRepository myUserRepository = new UserRepository();
            var user = myUserRepository.UpdateUser(userId, pinNumber, numberOfCansUserWantToBuy);
            double actualAvailableBalanceOnCard1 = user.AvailableBalanceOnCard1;
            //Arrange
            Assert.AreEqual(expectedAvailableBalanceOnCard1, actualAvailableBalanceOnCard1);
        }
        [TestMethod]
        public void Update_Balance_On_Card2_Correctly_When_Card2_Used_By_User2()
        {
            //Act
            int numberOfCansUserWantToBuy = 7;
            int userId = 2;
            int pinNumber = 4566;
            //as the user has already purchased 2 cans before, hence he/she have to pay for 7 cans which is (7*0.5 = 3.5)
            double expectedAvailableBalanceOnCard2 = 20.28;
            //Assert
            UserRepository myUserRepository = new UserRepository();
            var user = myUserRepository.UpdateUser(userId, pinNumber, numberOfCansUserWantToBuy);
            double actualAvailableBalanceOnCard2 = user.AvailableBalanceOnCard2;
            //Arrange
            Assert.AreEqual(expectedAvailableBalanceOnCard2, actualAvailableBalanceOnCard2);
        }
       
    }
}
