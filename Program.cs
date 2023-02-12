namespace classFraction
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Fraction F1 = new(1, 1);
                Fraction F2 = new(2, 2);
                Fraction F3;
                Fraction F4 = new Fraction();
                Fraction F5 = new Fraction();
                Fraction F6;
                F3 = F1 / F2;
                Console.WriteLine(F3.FractionToString());
                F6 = F4 * F5;
                F6.Shorten();
                Console.WriteLine(F6.FractionToString());

            }
            catch(Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }

        }       
        
     

    }
}