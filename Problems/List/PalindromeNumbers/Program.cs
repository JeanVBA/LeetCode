public class Solution
{
    public static bool IsPalindrome(int x)
    {
        var numbers = x.ToString().Select(numb => int.Parse(numb.ToString())).ToArray();
        string resultFinal = "";

        foreach (var number in numbers)
        {
            resultFinal += number.ToString();
        }
        if (Convert.ToInt32(resultFinal).Equals(x)) return true;
        else return false;
    }
    public static void Main()
    {
        int x = 121;
        Console.WriteLine(IsPalindrome(x));
        x = -121;
        Console.WriteLine(IsPalindrome(x));
        x = 10;
        Console.WriteLine(IsPalindrome(x));
    }
}