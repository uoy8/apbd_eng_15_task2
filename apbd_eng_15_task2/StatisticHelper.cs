namespace apbd_eng_15_task2;

public class StatisticHelper
{
    public static double CalculateAverage(int[] values)
    {
        if (values.Length == 0) return 0;
        return values.Average();
    }
}

