class exercise4
{
    // Calculate Average Monthly Growth Rate
    static double CalculateAvgGrowthRate(double[] monthlyRevenue, int size)
    {
        double totalGrowth = 0.0;

        for (int i = 1; i < size; i++)
        {
            double growth = (monthlyRevenue[i] - monthlyRevenue[i - 1]) / monthlyRevenue[i - 1];
            totalGrowth += growth;
        }

        return totalGrowth / (size - 1);
    }

    // Forecast future revenue
    static double[] Forecast(double[] hist, int histSize, int n)
    {
        double[] forecast = new double[histSize + n];
        Array.Copy(hist, forecast, histSize);

        double avg = CalculateAvgGrowthRate(hist, histSize);
        double last = hist[histSize - 1];

        for (int i = histSize; i < histSize + n; i++)
        {
            last *= (1 + avg);
            forecast[i] = last;
        }

        return forecast;
    }

    static void Main()
    {
        Console.Write("Enter number of past months data: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        double[] past = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter revenue for month {i + 1}: ");
            past[i] = double.Parse(Console.ReadLine() ?? "0");
        }

        Console.Write("Enter number of months to forecast: ");
        int m = int.Parse(Console.ReadLine() ?? "0");

        double[] result = Forecast(past, n, m);

        Console.WriteLine("\nHistorical Revenue Data");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\tMonth {i + 1}: Rs.{result[i]:F2}");
        }

        Console.WriteLine("\nForecasted Revenue");
        for (int i = n; i < result.Length; i++)
        {
            Console.WriteLine($"\tMonth {i + 1}: Rs.{result[i]:F2}");
        }
    }
}