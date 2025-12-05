using System;
using System.Linq;
using Xunit;
public class Program
{
    static void Main()
    {
        int[] m = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        number j = new number();
        Console.WriteLine(number.Mini(m));

      
    }
    [Fact]
    public void test()
    {
        int[] m = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        number j = new number();
        Assert.Equal(number.Mini(m),1);
    }
}
class number
{
    public static int Mini(int[] n) => n.Min();
 
}
       