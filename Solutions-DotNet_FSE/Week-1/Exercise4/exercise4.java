import java.util.*;

public class exercise4 {

    // Calculate AVG Monthly Growth Rate
    public static double calculateAvgGrowthRate(List<Double> monthlyRevenue) {
        double totalGrowth = 0.0;
       
        for (int i = 1; i < monthlyRevenue.size(); i++) {
            double growth = (monthlyRevenue.get(i) - monthlyRevenue.get(i - 1)) / monthlyRevenue.get(i - 1);
            totalGrowth += growth;
        }

        return totalGrowth / (monthlyRevenue.size() - 1);
    }

    // Forecast Revenue
    public static List<Double> forecast(List<Double> hist, int n) {
        List<Double> forecast = new ArrayList<>(hist);
        double avg = calculateAvgGrowthRate(hist);
        double last = hist.get(hist.size() - 1);

        for (int i = 0; i < n; i++) {
            double next = last * (1 + avg);
            forecast.add(next);
            last = next;
        }
        return forecast;
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        List<Double> past = new ArrayList<>();

        System.out.println("Enter number of past months data: ");
        int n = scanner.nextInt();

        for (int i = 1; i <= n; i++) {
            System.out.printf("Enter revenue for month %d: ", i);
            past.add(scanner.nextDouble());
        }
        
        System.out.println("Enter number of months to forecast: ");
        int m = scanner.nextInt();

        List<Double> forecast = forecast(past, m);
        System.out.println("\nHistorical Revenue Data");
        for (int i = 0; i < past.size(); i++) {
            System.out.printf("\tMonth %d: Rs.%.2f%n", i + 1, past.get(i));
        }

        System.out.println("\nForecasted Revenue");
        for (int i = past.size(); i < forecast.size(); i++) {
            System.out.printf("\tMonth %d: Rs.%.2f%n", i + 1, forecast.get(i));
        }

        scanner.close();
    }
}