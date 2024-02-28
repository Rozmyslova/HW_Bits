internal class Program
{
    static void Main(string[] args)
    {
        /*IBits ibits = new Bits(55555);
        Console.WriteLine(ibits.GetBit(0));
        Console.WriteLine(ibits.GetBit(1));
        ibits.SetBit(false, 1);
        Console.WriteLine(ibits.GetBit(1));*/

        Bits bits = new Bits(3);
        bits[1] = false;

        /*long num = (long)bits;
        Console.WriteLine(num);*/
        
        int num = (int)bits;
        Console.WriteLine(num);
                
        /*byte num = (byte)bits;
        Console.WriteLine(num);*/
    }
}