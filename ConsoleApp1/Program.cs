namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wpisuj coś w kodzie szesnastkowym");
            string AL = Console.ReadLine();
            //Console.WriteLine(AL);
            if (AL.Length == 2)
            {
                //Console.WriteLine("działa może");
                char[] alTablica = AL.ToCharArray();
                //Console.WriteLine(alTablica[0]);
                if (alTablica[0] >= '0' && alTablica[0] <= '9' || alTablica[0] >= 'A' && alTablica[0] <= 'F')
                {
                    if (alTablica[1] >= '0' && alTablica[1] <= '9' || alTablica[1] >= 'A' && alTablica[1] <= 'F')
                    {
                        Console.WriteLine("it's working");
                        Console.WriteLine(AL);
                    }
                }
                else
                {
                    Console.WriteLine("Wpisz poprawne znaki");
                }
            }
            else
            {
                Console.WriteLine("chyba też działa");
            }
        }
    }
}