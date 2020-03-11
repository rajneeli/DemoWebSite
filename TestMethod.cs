using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace SiteDemo
{
    class TestMethod : ReusableFunctions
    {

        IWebDriver driver;
        string browserName = ConfigurationManager.AppSettings["Browser"];
        string URL = ConfigurationManager.AppSettings["BaseUrl"];
        string userName = ConfigurationManager.AppSettings["Username"];
        string password = ConfigurationManager.AppSettings["Password"];



        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver(@"C:\Users\Raj\Desktop\csharp.webdriver-master\SiteDemo\lib");
            test();
            closeBrowser();
        }


        [Test]
        public void test()
        {
            var objectsRepository = new ObjectRepository();
            PageFactory.InitElements(driver, objectsRepository);

            //Launching the url
            driver.Url = URL;
            driver.Manage().Window.Maximize();

            //click on Loginbutton
            objectsRepository.loginButton.Click();

            //Validate message in login screen
            verify("Welcome, Please Sign In!", objectsRepository.loginScreenMessage, "Welcome, Please Sign In!");

            //Enter username and password and click
            objectsRepository.loginEmail.SendKeys(userName);
            objectsRepository.loginPassword.SendKeys(password);
            objectsRepository.loginSubmitButton.Click();

            //verify the user account id
            verify("atest@gmail.com", objectsRepository.userAccountId, "User Account Id");

            //clear the shopping cart
            objectsRepository.shoppingCartLink.Click();
            if (!objectsRepository.shoppingCartEmpty.Displayed)
            {
                objectsRepository.itemQuatityField.Clear();
                objectsRepository.itemQuatityField.SendKeys("0");
                objectsRepository.updateCartLink.Click();
            }

            //click on books category
            objectsRepository.booksMenuLink.Click();

            //Select book from list displayed 
            objectsRepository.bookProductSelect.Click();

            //Get the price details and enter the quantity(more than one)
            string priceDetails = objectsRepository.priceDetails.GetAttribute("value");
            Console.WriteLine("Price Details are " + priceDetails);
            objectsRepository.priceDetails.Clear();
            objectsRepository.priceDetails.SendKeys("3");

            //Click on “Add to cart”
            objectsRepository.addToCartLink.Click();

            //Validate “The product has been added to shopping cart” message 
            verify("The product has been added to shopping cart", objectsRepository.shoppingCartMessage, "The product has been added to shopping cart");

            //.   Click on “shopping cart” on top right and validate the “Sub-Total” Price for selected book
            objectsRepository.shoppingCartLink.Click();

            verify("30", objectsRepository.productPrice, "Sub total Validate");


            //.   Click on “Check-out”
            objectsRepository.termsCheckbox.Click();
            objectsRepository.checkoutButton.Click();

            //.   Select “New Address” From “Billing Address” drop down
            defaultWait(objectsRepository.addressSelect);
            selectDropDownByText(objectsRepository.addressSelect, "New Address");

            //Fill all mandatory fields in “Billing Address” and click “Continue”
            selectDropDownByValue(objectsRepository.billingNewAddressCountryField, "0");
            objectsRepository.billingNewAddressCityField.SendKeys("TestCity");
            objectsRepository.billingNewAddressField.SendKeys("TestAddress");
            objectsRepository.billingNewAddressZipCodeField.SendKeys("500331");
            objectsRepository.billingNewAddressPhoneNumberField.SendKeys("9986245878");
            objectsRepository.billingButton.Click();

            //Select the “Shipping Address” as same as “Billing Address” from “Shipping Address” drop down and click on “Continue”.
            selectDropDownByValue(objectsRepository.shippingAddressSelect, "697181");
            objectsRepository.shippingButton.Click();

            //.   Select the shipping method as “Next Day Air” and click on “Continue”
            objectsRepository.nextAirDayRadioButton.Click();
            objectsRepository.shippingMethodButton.Click();

            //Choose the payment method as COD (Cash on delivery) and click on “Continue”
            Boolean cod = objectsRepository.checkoutButton.Selected;
            if (!cod)
            {
                objectsRepository.checkoutButton.Click();

            }

            objectsRepository.paymentMethodButton.Click();

            //Validate the message “You will pay by COD” and click on “Continue”
            verify("You will pay by COD", objectsRepository.youWillPayCodText, "You will pay by COD text");
            objectsRepository.paymentInfoButton.Click();

            //Click on “Confirm Order”
            objectsRepository.confirmOrderButton.Click();

            //Validate the message “Your order has been successfully processed!” and print the Order number 
            verify("Your order has been successfully processed!", objectsRepository.orderSuccessMessage, "Your order has been successfully processed!");
            Console.WriteLine(objectsRepository.orderDetails);

            //Click on “Continue” and log out from the application 
            objectsRepository.continueButton.Click();
            objectsRepository.logoutButton.Click();

        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
