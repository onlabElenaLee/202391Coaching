namespace OneBackComboTrainingWeb;

public class HolidayForTest : Holiday
{
    private DateTime _today;

    public DateTime Today
    {
        set => _today = value;
    }
    protected override DateTime GetToday()
    {
        return _today;
    }

}