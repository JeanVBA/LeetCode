public class Solution
{
    public static bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        var numbers = x.ToString().Select(numb => Convert.ToInt64(numb.ToString())).ToArray();
        string resultFinal = "";

        for (int i = numbers.Length; i > 0; i--)
        {
            resultFinal += numbers[i-1].ToString();
        }
        if(Convert.ToInt64(resultFinal).Equals(x)) return true;
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
        x = 1234567899;
        Console.WriteLine(IsPalindrome(x));
    }
}