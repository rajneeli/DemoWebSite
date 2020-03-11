using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteDemo
{
    class ObjectRepository
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath,Using= "//a[@class='ico-login']")]
        public IWebElement loginButton
        {
            get;
            set;
        }

        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Welcome, Please Sign In!')]")]
        public IWebElement loginScreenMessage
        {
            get;
            set;
        }

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement loginEmail
        {
            get;
            set;
        }
        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement loginPassword
        {
            get;
            set;
        }

        [FindsBy(How = How.XPath, Using = "//input[@value='Log in']")]
        public IWebElement loginSubmitButton
        {
            get;
            set;
        }

        [FindsBy(How = How.ClassName, Using = "account")]
        public IWebElement userAccountId
        {
            get;
            set;
        }

        [FindsBy(How = How.XPath, Using = "//a[@class='ico-cart']/span[@class='cart-label']")]
        public IWebElement shoppingCartLink
        {
            get;
            set;
        }

        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'itemquantity')]")]
        public IWebElement itemQuatityField
        {
            get;
            set;
        }

        [FindsBy(How = How.Name, Using = "updatecart")]
        public IWebElement updateCartLink
        {
            get;
            set;
        }

        [FindsBy(How = How.XPath, Using = "//a[@href='/books']")]
        public IWebElement booksMenuLink
        {
            get;
            set;
        }

       
        [FindsBy(How = How.XPath, Using = " //div[@class='order-summary-content']")]
        public IWebElement shoppingCartEmpty
        {
            get;
            set;
        }

        [FindsBy(How = How.XPath, Using = "//div[@class='item-box'][1]")]
        public IWebElement bookProductSelect
        {
            get;
            set;
        }

        [FindsBy(How = How.XPath, Using = "//span[@itemprop='price']")]
        public IWebElement priceDetails
        {
            get;
            set;
        }

        [FindsBy(How = How.XPath, Using = "//input[@value='Add to cart'][1]]")]
        public IWebElement addToCartLink
        {
            get;
            set;
        }

        [FindsBy(How = How.XPath, Using = "//p[@class='content']")]
        public IWebElement shoppingCartMessage
        {
            get;
            set;
        }

        [FindsBy(How = How.XPath, Using = "//span[@class='product-price']")]
        public IWebElement productPrice
        {
            get;
            set;
        }

        [FindsBy(How = How.Id, Using = "termsofservice")]
        public IWebElement termsCheckbox
        {
            get;
            set;
        }

        [FindsBy(How = How.Id, Using = "checkout")]
        public IWebElement checkoutButton
        {
            get;
            set;
        }

        [FindsBy(How = How.XPath, Using = "//select[@class='address-select valid']")]
        public IWebElement addressSelect
        {
            get;
            set;
        }

        [FindsBy(How = How.Id, Using = "BillingNewAddress_CountryId")]
        public IWebElement billingNewAddressCountryField
        {
            get;
            set;
        }

        [FindsBy(How = How.Id, Using = "BillingNewAddress.City")]
        public IWebElement billingNewAddressCityField
        {
            get;
            set;
        }

        [FindsBy(How = How.Id, Using = "BillingNewAddress_Address1")]
        public IWebElement billingNewAddressField
        {
            get;
            set;
        }

        [FindsBy(How = How.Id, Using = "BillingNewAddress_ZipPostalCode")]
        public IWebElement billingNewAddressZipCodeField
        {
            get;
            set;
        }

        [FindsBy(How = How.Id, Using = "BillingNewAddress_PhoneNumber")]
        public IWebElement billingNewAddressPhoneNumberField
        {
            get;
            set;
        }

        [FindsBy(How = How.XPath, Using = "//div[@id='billing-buttons-container']/input")]
        public IWebElement billingButton
        {
            get;
            set;
        }


        [FindsBy(How = How.Id, Using = "shipping-address-select")]
        public IWebElement shippingAddressSelect
        {
            get;
            set;
        }

        [FindsBy(How = How.XPath, Using = "//div[@id='shipping-buttons-container']//input")]
        public IWebElement shippingButton
        {
            get;
            set;
        }

        [FindsBy(How = How.Id, Using = "shippingoption_1")]
        public IWebElement nextAirDayRadioButton
        {
            get;
            set;
        }

        [FindsBy(How = How.XPath, Using = "//div[@id='shipping-method-buttons-container']//input")]
        public IWebElement shippingMethodButton
        {
            get;
            set;
        }

        [FindsBy(How = How.Id, Using = "paymentmethod_0")]
        public IWebElement cOdPaymentMethod
        {
            get;
            set;
        }

        [FindsBy(How = How.XPath, Using = "//div[@id='payment-method-buttons-container']//input")]
        public IWebElement paymentMethodButton
        {
            get;
            set;
        }

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'You will pay by COD')]")]
        public IWebElement youWillPayCodText
        {
            get;
            set;
        }

        [FindsBy(How = How.XPath, Using = "//div[@id='payment-info-buttons-container']//input")]
        public IWebElement paymentInfoButton
        {
            get;
            set;
        }

        [FindsBy(How = How.XPath, Using = "//div[@id='confirm-order-buttons-container']//input")]
        public IWebElement confirmOrderButton
        {
            get;
            set;
        }

        [FindsBy(How = How.XPath, Using = "//div[@class='title']/strong")]
        public IWebElement orderSuccessMessage
        {
            get;
            set;
        }

        [FindsBy(How = How.XPath, Using = "//ul[@class='details']/li[1]")]
        public IWebElement orderDetails
        {
            get;
            set;
        }

        [FindsBy(How = How.XPath, Using = "//input[@value='Continue']")]
        public IWebElement continueButton
        {
            get;
            set;
        }

        [FindsBy(How = How.ClassName, Using = "ico-logout")]
        public IWebElement logoutButton
        {
            get;
            set;
        }


    }
}
