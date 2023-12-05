using System.Diagnostics.CodeAnalysis;

namespace OneBackComboTrainingWeb;

public class Holiday
{
    public Holiday()
    {
    }

    public string GetTheme()
    {
        DateTime today = GetToday();
        if (today.Month == 12 && today.Day == 25)
        {
            return "Merry Xmas";
        }
        else
        {
            return "Today is not Xmas";
        }
    }

    protected virtual DateTime GetToday()
    {
        return DateTime.UtcNow;
    }
}