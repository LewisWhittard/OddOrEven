using Xunit;
using OddOrEvenInfranstucture.Logic.Checker;

public class CheckerTests
{
    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    public void Test_CheckValue_True(int value)
    {
        //Arrange
        Checker checker = new Checker();
        string expected = "Even";

        //Act
        string actual = checker.CheckValue(value);

        //Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData (3)]
    [InlineData(5)]
    [InlineData(7)]
    public void Test_CheckValue_False(int value)
    {
        //Arrange
        Checker checker = new Checker();
        string expected = "Odd";

        //Act
        string actual = checker.CheckValue(value);

        //Assert
        Assert.Equal(expected, actual);
    }

    //TestHook
    [Fact]
    public void Test_GetValues_TestHook()
    {
        //Arrange
        Checker checker = new Checker(true);
        List<string> expected = new List<string> { "Even", "Odd" };

        //Act
        List<string> actual = checker.GetValues();

        //Assert
        Assert.Equal(expected, actual);
    }

    //TestHook default
    [Fact]
    public void Test_GetValues_TestHook_Default()
    {
        //Arrange
        Checker checker = new Checker();
        List<string> expected = new List<string> { "Even", "Odd" };

        try
        {
            //Act
            List<string> actual = checker.GetValues();
            //assert fail
            Assert.Equal(true, false);
        }
        catch (Exception x)
        {
            //assert pass
            Assert.Equal("Test Hook is not enabled", x.Message);

        }
    }

    //TestHook False
    [Fact]
    public void Test_GetValues_TestHook_False()
    {
        //Arrange
        Checker checker = new Checker(false);
        List<string> expected = new List<string> { "Even", "Odd" };

        try
        {
            //Act
            List<string> actual = checker.GetValues();
            //assert fail
            Assert.Equal(true, false);
        }
        catch (Exception x)
        {
            //assert pass
            Assert.Equal("Test Hook is not enabled", x.Message);

        }
    }
}



