using NUnit.Framework;

namespace autotests.Test
{
    public class BaigiamasisTest : BaseTest
    {
        //1 Testcase
        [TestCase("50", "1300", TestName = "Price is between 50 and 1000")]
        public static void TestPriceBoundary(string minPrice, string maxPrice)
        {
            baigiamasisPage.NavigateToPage();
            baigiamasisPage.maistoParuosimasClick();
            baigiamasisPage.darzoviuPjausktyklesClick();
            //baigiamasisPage.InsertMinPrice(minPrice);
            //baigiamasisPage.InsertMaxPrice(maxPrice);
            //baigiamasisPage.submitPrice();
            //baigiamasisPage.VerifyResult(minPrice, maxPrice)
        }

        //2 Testcase
        [TestCase("puodas", TestName = "Search for PUODAS in search field")]
        [TestCase("keptuvė", TestName = "Search for KEPTUVĖ in search field")]
        public static void TestSearchField(string text)
        {
            baigiamasisPage.NavigateToPage();
            baigiamasisPage.SearchByText(text);
            baigiamasisPage.ClickOnSearchIcon();
            baigiamasisPage.SearchResultByFirstProduct(text);
        }

        //3 Testcase
        [TestCase("Vardenis", "Labai geras ir naudingas daiktas", "Dėkojame už Jūsų įvertinimą. Jis buvo išsiųstas patvirtinimui", TestName = "Leave a review Vardenis")]
        [TestCase("Pavardenis", "Nepaigailėjome, kad įsigijome", "Dėkojame už Jūsų įvertinimą. Jis buvo išsiųstas patvirtinimui", TestName = "Leave a review Pavardenis")]
        public static void TestReviewLeaving(string name, string review, string successMessage)
        {
            baigiamasisPage.NavigateToPage();
            baigiamasisPage.maistoParuosimasClick();
            baigiamasisPage.darzoviuPjausktyklesClick();
            baigiamasisPage.goToProductInsideClick();
            baigiamasisPage.atsiliepimaiButtonClick();
            baigiamasisPage.leaveReview(name, review, successMessage);
        }

        //4 Testcase
        [Test]
        public static void TestAddingToCart()
        {
            baigiamasisPage.NavigateToPage();
            baigiamasisPage.maistoParuosimasClick();
            baigiamasisPage.darzoviuPjausktyklesClick();
            baigiamasisPage.addProductToCart();
            
            baigiamasisPage.checkIfProductAddedToCart("pjaustykl");
            baigiamasisPage.checkProductPrice("1", "43");
            baigiamasisPage.increaseAmountOfProduct();
            baigiamasisPage.checkProductPrice("2","86");
        }

    }
}