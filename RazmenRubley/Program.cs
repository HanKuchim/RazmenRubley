using System;
using System.Text;

public class RazmenRubley
{
    static void MakeChange(double origAmount, double remainAmount, int[] coins)

    {
        if ((origAmount % 50) < origAmount)
        {
            coins[3] = (int)(origAmount / 50);
            remainAmount = origAmount % 50;
            origAmount = remainAmount;
        }
        if ((origAmount % 10) < origAmount)
        {
            coins[2] = (int)(origAmount / 10);
            remainAmount = origAmount % 10;
            origAmount = remainAmount;
        }
        if ((origAmount % 5) < origAmount)
        {
            coins[1] = (int)(origAmount / 5);
            remainAmount = origAmount % 5;
            origAmount = remainAmount;
        }
        if ((origAmount % 1) < origAmount)
        {
            coins[0] = (int)(origAmount / 1);
            remainAmount = origAmount % 1;
        }
    }
    static void ShowChange(int[] arr)
    {
        if (arr[3] > 0)
            Console.WriteLine("Количество 50 рублевых банкнот: " +
            arr[3]);
        if (arr[2] > 0)
            Console.WriteLine("Количество 10 рублевых монет: " + arr[2]);
        if (arr[1] > 0)
            Console.WriteLine("Количество 5 рублевых монет: " + arr[1]);
        if (arr[0] > 0)
            Console.WriteLine("Количество 1 рублевых монет: " + arr[0]);
    }
    static void Main()
    {
        Console.WriteLine("Введите сумму которую хотите разменять:");
        double origAmount = Convert.ToDouble(Console.ReadLine());
        double toChange = origAmount;
        double remainAmount = 0.0;
        int[] coins = new int[4];
        MakeChange(origAmount, remainAmount, coins);

        Console.WriteLine("Лучше способ размена " +
        toChange + " в рублях: ");
        ShowChange(coins);
        Console.ReadKey();
    }
}