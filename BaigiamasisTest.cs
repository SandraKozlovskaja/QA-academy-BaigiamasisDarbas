using NUnit.Framework;

namespace autotests.Test
{
    public class BaigiamasisTest : BaseTest
    {
        //1 Testcase
        [TestCase("50", "1000", TestName = "Price is between 50 and 1000")]
        public static void TestPriceBoundary(string minPrice, string maxPrice)
        {
            baigiamasisPage.NavigateToPage();
            baigiamasisPage.maistoParuosimasClick();
            baigiamasisPage.darzoviuPjausktyklesClick();
            baigiamasisPage.InsertMinPrice(minPrice);
            baigiamasisPage.InsertMaxPrice(maxPrice);
            baigiamasisPage.submitPrice();
            //baigiamasisPage.VerifyResult(minPrice, maxPrice)
        }
       
        
    }
}