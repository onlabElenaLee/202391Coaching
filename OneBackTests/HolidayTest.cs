using FluentAssertions;
using NSubstitute;
using OneBackComboTrainingWeb;

namespace OneBackTests;

[TestFixture]
public class HolidayTest
{
    private HolidayForTest _holidayForTest;

    [SetUp]
    public void Setup()
    {
        _holidayForTest = new HolidayForTest();
    }

    [Test]
    public void today_is_xmas()
    {
        GivenToday(12, 25);

        ThemeShouldBe("Merry Xmas");
    }

    [Test]
    public void today_is_not_xmas()
    {
        GivenToday(11, 25);

        ThemeShouldBe("Today is not Xmas");
    }

    private void ThemeShouldBe(string expected)
    {
        string result = _holidayForTest.GetTheme();
        _holidayForTest.GetTheme().Should().Be(expected);

        result.Should().Be(expected);
    }


    private void GivenToday(int month, int day)
    {
        _holidayForTest.Today = new DateTime(2000, month, day);
    }
}