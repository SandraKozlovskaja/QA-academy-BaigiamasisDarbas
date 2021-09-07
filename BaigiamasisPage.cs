using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace autotests.Page
{
    public class BaigiamasisPage : BasePage
    {
        private const string AddressUrl = "https://bivip.lt/";
        private IWebElement maistoParuosimasButton => Driver.FindElement(By.CssSelector("#product-categories > ul > li:nth-child(3) > a"));
        private IWebElement darzoviuPjausktyklesLink => Driver.FindElement(By.CssSelector("#category-inner > div:nth-child(2) > div > div > div:nth-child(2) > div:nth-child(1) > div:nth-child(2) > div > div > a"));
        private IWebElement priceMinInput => Driver.FindElement(By.Id("mfilter-opts-price-min"));
        private IWebElement priceMaxInput => Driver.FindElement(By.Id("mfilter-opts-price-max"));

        //private IWebElement acceptCookiesButton => Driver.FindElement(By.Id("accept-choices"));
        //private IWebElement firstProductPrice => Driver.FindElement(By.CssSelector("#mfilter-content-container > div.row.row-products > div:nth-child(1) > div > div.info > div.price > span"));
        //private IWebElement lastProductPrice => Driver.FindElement(By.CssSelector("#mfilter-content-container > div.row.row-products > div:nth-child(5) > div > div.info > div.price > span"));

        //private IWebElement searchField => Driver.FindElement(By.CssSelector("body > div.page_wrapper > header > div > div:nth-child(1) > div > div > div.right > div > div > input.search-input"));
        //private IWebElement searchIcon => Driver.FindElement(By.CssSelector("body > div.page_wrapper > header > div > div:nth-child(1) > div > div > div.right > div > div > input.submit-input"));
        //private IWebElement searchResultTitle => Driver.FindElement(By.CssSelector("# content > h1));
        //private IWebElement searchResultProduct => Driver.FindElement(By.CssSelector("#mfilter-content-container > div.row.row-products > div:nth-child(1) > div > div.info > h2 > a));
        public BaigiamasisPage(IWebDriver webdriver) : base(webdriver) { }

        public void NavigateToPage()
        {
            if (Driver.Url != AddressUrl)
            {
                Driver.Url = AddressUrl;
            }
        }

        public void maistoParuosimasClick()
        {
            maistoParuosimasButton.Click();
        }

        public void darzoviuPjausktyklesClick()
        {
            darzoviuPjausktyklesLink.Click();
        }


        public void InsertMinPrice(string text)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("document.getElementById('mfilter-opts-price-min').setAttribute('value', '')");
            Actions action = new Actions(Driver);
            action.DoubleClick();
            action.Build().Perform();
            priceMinInput.SendKeys(text);
            
        }

        public void InsertMaxPrice(string text)
        {
            priceMaxInput.Clear();
            priceMaxInput.SendKeys(text);
        }


        public void submitPrice()
        {
            Actions action = new Actions(Driver);
            action.SendKeys(Keys.Enter);
            
            action.Build().Perform();
        }


        //public void VerifyResult(string inputedMinPrice, string inputedMaxPrice)
        //{
        //   inputedMinPrice = Int.Parse(inputedMinPrice); 
        //   inputedMaxPrice = Int.Parse(inputedMaxPrice);
        //   Assert.IsTrue(firstProductPrice > inputedMinPrice, $"First product price < inputed min price");
        //   Assert.IsTrue(lastProductPrice < inputedMaxPrice, $"Last product price > inputed max price");
        //}

        //public void SearchByText(string text)
        //{
        //    searchField.Clear();
        //    searchField.SendKeys(text);
        //    searchIcon.Click();
        //}

        //public void ClickOnSearchIcon()
        //{
        //    searchIcon.Click();
        //}

        //public void SearchResultByTitle(string text)
        //{
        //searchResultTitle = searchResultTitle.Text;
        //Assert.IsTrue(searchResultTitle.Contains(text), "There is no word from search field");
        //}

        //public void SearchResultByFirstProduct(string text)
        //{
        //searchResultProduct = searchResultProduct.Text;
        //Assert.IsTrue(searchResultProduct.Contains(text), "There is no word from search field");
        //}
    }
}
