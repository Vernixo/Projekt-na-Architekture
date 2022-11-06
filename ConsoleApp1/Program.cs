namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wartość dla rejestru \"AL\"");
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
                        Console.WriteLine("Podaj wartość dla rejestru \"AH\"");
                        string AH = Console.ReadLine();
                        if (AH.Length == 2)
                        {
                            char[] ahTablica = AH.ToCharArray();
                            if (ahTablica[0] >= '0' && ahTablica[0] <= '9' || ahTablica[0] >= 'A' && ahTablica[0] <= 'F')
                            {
                                if (ahTablica[1] >= '0' && ahTablica[1] <= '9' || ahTablica[1] >= 'A' && ahTablica[1] <= 'F')
                                {
                                    Console.WriteLine("Podaj wartość dla rejestru \"BL\"");
                                    string BL = Console.ReadLine();
                                    if (BL.Length == 2)
                                    {

                                    }
                                }
                            }
                        }
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