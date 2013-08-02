using Microsoft.VisualStudio.TestTools.UnitTesting;
using ForTests;

[TestClass]
public class UnitTesting
{
    [TestMethod]
    public void StandardTest()
    {
        int[] numArray = { 1, 3, 5, 1, 4, 3, 5, 6, 7, 8, 10, 9, 5, 5, 6, 3, 2 };
        int result = CountGivenNumberInArray.CountGivenNumber(5, numArray);
        Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void MaxValueTest()
    {
        int[] numArray = { 1, 3, 5, 1, 4, 3, 5, 6, 7, 8, 10, 9, 5, 5, 6, 3, 2 };
        int result = CountGivenNumberInArray.CountGivenNumber(int.MaxValue, numArray);
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void MinValueTest() // This test will fail
    {
        int[] numArray = { 1, 3, 5, 1, 4, 3, 5, 6, 7, 8, 10, 9, 5, 5, 6, 3, 2, int.MinValue };
        int result = CountGivenNumberInArray.CountGivenNumber(int.MinValue, numArray);
        Assert.AreEqual(0, result);
    }
}