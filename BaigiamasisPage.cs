﻿using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace autotests.Page
{
    public class BaigiamasisPage : BasePage
    {
        private const string AddressUrl = "https://bivip.lt/";

        //1 Testcase
        private IWebElement maistoParuosimasButton => Driver.FindElement(By.CssSelector("#product-categories > ul > li:nth-child(3) > a"));
        private IWebElement darzoviuPjausktyklesLink => Driver.FindElement(By.CssSelector("#category-inner > div:nth-child(2) > div > div > div:nth-child(2) > div:nth-child(1) > div:nth-child(2) > div > div > a"));
        private IWebElement priceMinInput => Driver.FindElement(By.Id("mfilter-opts-price-min"));
        private IWebElement priceMaxInput => Driver.FindElement(By.Id("mfilter-opts-price-max"));

        //private IWebElement acceptCookiesButton => Driver.FindElement(By.Id("accept-choices"));
        //private IWebElement firstProductPrice => Driver.FindElement(By.CssSelector("#mfilter-content-container > div.row.row-products > div:nth-child(1) > div > div.info > div.price > span"));
        //private IWebElement lastProductPrice => Driver.FindElement(By.CssSelector("#mfilter-content-container > div.row.row-products > div:nth-child(5) > div > div.info > div.price > span"));


        //2 Testcase
        private IWebElement searchField => Driver.FindElement(By.CssSelector("body > div.page_wrapper > header > div > div:nth-child(1) > div > div > div.right > div > div > input.search-input"));
        private IWebElement searchIcon => Driver.FindElement(By.CssSelector("body > div.page_wrapper > header > div > div:nth-child(1) > div > div > div.right > div > div > input.submit-input"));
        //private IWebElement searchResultTitle => Driver.FindElement(By.CssSelector("# content > h1"));
        private IWebElement searchResultProduct => Driver.FindElement(By.CssSelector("#mfilter-content-container > div.row.row-products > div:nth-child(1) > div > div.info > h2 > a"));


        // 3 Testcase
        private IWebElement goToProductInside => Driver.FindElement(By.CssSelector("#mfilter-content-container > div.row.row-products > div:nth-child(1) > div > div.info > h2 > a"));
        private IWebElement atsiliepimaiButton => Driver.FindElement(By.CssSelector("#tabs-nav > li:nth-child(3) > span"));

        private IWebElement inputName => Driver.FindElement(By.Id("input-name"));
        private IWebElement inputReview => Driver.FindElement(By.Id("input-review"));
        //private IWebElement evaluateProduct => Driver.FindElement(By.CssSelector("# form-review > div:nth-child(5)"));
        private IWebElement evaluateProduct => Driver.FindElement(By.CssSelector("#form-review > div:nth-child(5) > fieldset > label:nth-child(2)"));
        private IWebElement continueButton => Driver.FindElement(By.Id("button-review"));
        private IWebElement reviewSuccessMessage => Driver.FindElement(By.CssSelector("#form-review > div.alert.alert-success"));


        // 4 Testcase
        private IWebElement addToCartButton => Driver.FindElement(By.CssSelector("#mfilter-content-container > div.row.row-products > div:nth-child(1) > div > div.info > button"));
        //private IWebElement goToCartButton => Driver.FindElement(By.Id("cart"));
        private IWebElement goToCartButton => Driver.FindElement(By.CssSelector("#cart"));
        private IWebElement productIsInCart => Driver.FindElement(By.CssSelector("#cart_view > div > div.qc-checkout-product.panel-body > table > tbody > tr > td.qc-name > a"));
        private IWebElement productPriceInCartIncreased => Driver.FindElement(By.CssSelector("#cart_view > div > div.qc-checkout-product.panel-body > table > tbody > tr > td.qc-total"));
        private IWebElement increaseProductAmountInCartButton => Driver.FindElement(By.CssSelector("#cart_view > div > div.qc-checkout-product.panel-body > table > tbody > tr > td.qc-quantity > div > span:nth-child(3) > button.btn.btn-primary.increase.hidden-xs"));

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


        //public void InsertMinPrice(string text)
        //{
        //    //IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
        //    //js.ExecuteScript("document.getElementById('mfilter-opts-price-min').setAttribute('value', '')");
        //    //Actions action = new Actions(Driver);
        //    //action.DoubleClick();
        //    //action.Build().Perform();
        //    //priceMinInput.SendKeys(text);

        //    priceMinInput.Clear();
        //    priceMinInput.SendKeys(text);

        //}

        //public void InsertMaxPrice(string text)
        //{
        //    priceMaxInput.Clear();
        //    priceMaxInput.SendKeys(text);
        //    Actions builder = new Actions(Driver);
        //    builder.SendKeys(Keys.Enter);
        //}


        //public void submitPrice()
        //{
        //    Actions action = new Actions(Driver);
        //    action.SendKeys(Keys.Enter);
        //    action.Build().Perform();
        //}


        //public void VerifyResult(string inputedMinPrice, string inputedMaxPrice)
        //{
        //   inputedMinPrice = Int.Parse(inputedMinPrice); 
        //   inputedMaxPrice = Int.Parse(inputedMaxPrice);
        //   Assert.IsTrue(firstProductPrice > inputedMinPrice, $"First product price < inputed min price");
        //   Assert.IsTrue(lastProductPrice < inputedMaxPrice, $"Last product price > inputed max price");
        //}

        public void SearchByText(string text)
        {
            searchField.Clear();
            searchField.SendKeys(text);
            searchIcon.Click();
        }

        public void ClickOnSearchIcon()
        {
            searchIcon.Click();
        }

        //public void SearchResultByTitle(string text)
        //{
        //    //searchResultTitle = searchResultTitle.Text;
        //    Assert.IsTrue(searchResultTitle.Text.Contains(text), "There is no word from search field");
        //}

        public void SearchResultByFirstProduct(string text)
        {
            Assert.IsTrue(searchResultProduct.Text.Contains(text), "There is no word from search field");
        }

        public void goToProductInsideClick()
        {
            goToProductInside.Click();
        }

        public void atsiliepimaiButtonClick()
        {
            atsiliepimaiButton.Click();
        }
        public void leaveReview(string name, string review, string successMessage)
        {
            inputName.SendKeys(name);
            inputReview.SendKeys(review);
            evaluateProduct.Click();
            continueButton.Click();
            Assert.IsTrue(reviewSuccessMessage.Text.Contains(successMessage), "Message was wrong");
        }

        public void addProductToCart()
        {
            addToCartButton.Click();
        }
        public void checkIfProductAddedToCart(string productTitle)
        {
            goToCartButton.Click();
            Assert.IsTrue(productIsInCart.Text.Contains(productTitle), "Product wasn't added to Cart");

        }
        public void increaseAmountOfProduct()
        {
            increaseProductAmountInCartButton.Click();
        }

        //public void checkProductPrice(string productPrice)
        //{

        //    Assert.IsTrue(productPriceInCartIncreased.Text.Contains(productPrice), $"Price isn't correct, {productPriceInCartIncreased.Text}");
        //}

        public void checkProductPrice(string kiekis, string productPrice)
        {
            GetWait().Until(ExpectedConditions.TextToBePresentInElementValue(By.CssSelector("#cart_view > div > div.qc-checkout-product.panel-body > table > tbody > tr > td.qc-quantity > div > input"), kiekis));
            Assert.IsTrue(productPriceInCartIncreased.Text.Contains(productPrice), $"Price isn't correct, {productPriceInCartIncreased.Text}");
        }
    }
}
