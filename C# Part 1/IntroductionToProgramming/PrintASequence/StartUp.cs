namespace PrintASequence
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
               {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(-i);
                }
            }
        }
    }
}
