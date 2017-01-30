using System;

public class PriceChangeAlert
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double granica = double.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double nextPrice = double.Parse(Console.ReadLine());
            double differecne = Proc(price, nextPrice);
            bool isSignificantDifference = IsDiff(differecne, granica);
            string message = Get(nextPrice, price, differecne, isSignificantDifference);
            Console.WriteLine(message);

            price = nextPrice;
        }
    }

    private static bool IsDiff(double differecne, double granica)
    {
        throw new NotImplementedException();
    }

    private static string Get(double c, double last, double difference, bool etherTrueOrFalse)
    {
        string to = string.Empty;
        if (difference == 0)
        {
            to = string.Format("NO CHANGE: {0}", c);
        }
        else if (!etherTrueOrFalse)
        {
            to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, c, difference);
        }
        else if (etherTrueOrFalse && (difference > 0))
        {
            to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, c, difference);
        }
        else if (etherTrueOrFalse && (difference < 0))
        {
            to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, c, difference);
        }    

        return to;
    }

    private static bool ImaliDif(double granica, double isDiff)
    {
        if (Math.Abs(granica) >= isDiff)
        {
            return true;
        }

        return false;
    }

    private static double Proc(double l, double c)
    {
        double r = (c - l) / l;
        return r;
    }
}
