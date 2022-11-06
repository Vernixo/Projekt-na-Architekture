namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wartość dla rejestru \"AL\"");
            string AL = Console.ReadLine();
            if (AL.Length == 2)
            {
                char[] alTablica = AL.ToCharArray();
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
                                        char[] blTablica = BL.ToCharArray();
                                        if (blTablica[0] >= '0' && blTablica[0] <= '9' || blTablica[0] >= 'A' && blTablica[0] <= 'F')
                                        {
                                            if (blTablica[1] >= '0' && blTablica[1] <= '9' || blTablica[1] >= 'A' && blTablica[1] <= 'F')
                                            {
                                                Console.WriteLine("Podaj wartość dla rejestru \"BH\"");
                                                string BH = Console.ReadLine();
                                                if (BH.Length == 2)
                                                {
                                                    char[] bhTablica = BH.ToCharArray();
                                                    if (bhTablica[0] >= '0' && bhTablica[0] <= '9' || bhTablica[0] >= 'A' && bhTablica[0] <= 'F')
                                                    {
                                                        if (bhTablica[1] >= '0' && bhTablica[1] <= '9' || bhTablica[1] >= 'A' && bhTablica[1] <= 'F')
                                                        {
                                                            Console.WriteLine("Podaj wartość dla rejestru \"CL\"");
                                                            string CL = Console.ReadLine();
                                                            if (CL.Length == 2)
                                                            {
                                                                char[] clTablica = CL.ToCharArray();
                                                                if (clTablica[0] >= '0' && clTablica[0] <= '9' || clTablica[0] >= 'A' && clTablica[0] <= 'F')
                                                                {
                                                                    if (clTablica[1] >= '0' && clTablica[1] <= '9' || clTablica[1] >= 'A' && clTablica[1] <= 'F')
                                                                    {
                                                                        Console.WriteLine("Podaj wartość dla rejestru \"CH\"");
                                                                        string CH = Console.ReadLine();
                                                                        if (CH.Length == 2)
                                                                        {
                                                                            char[] chTablica = CH.ToCharArray();
                                                                            if (chTablica[0] >= '0' && chTablica[0] <= '9' || chTablica[0] >= 'A' && chTablica[0] <= 'F')
                                                                            {
                                                                                if (chTablica[1] >= '0' && chTablica[1] <= '9' || chTablica[1] >= 'A' && chTablica[1] <= 'F')
                                                                                {
                                                                                    Console.WriteLine("Podaj wartość dla rejestru \"DL\"");
                                                                                    string DL = Console.ReadLine();
                                                                                    if (DL.Length == 2)
                                                                                    {
                                                                                        char[] dlTablica = DL.ToCharArray();
                                                                                        if (dlTablica[0] >= '0' && dlTablica[0] <= '9' || dlTablica[0] >= 'A' && dlTablica[0] <= 'F')
                                                                                        {
                                                                                            if (dlTablica[1] >= '0' && dlTablica[1] <= '9' || dlTablica[1] >= 'A' && dlTablica[1] <= 'F')
                                                                                            {
                                                                                                Console.WriteLine("Podaj wartość dla rejestru \"DH\"");
                                                                                                string DH = Console.ReadLine();
                                                                                                if (DH.Length == 2)
                                                                                                {
                                                                                                    char[] dhTablica = DH.ToCharArray();
                                                                                                    if (dhTablica[0] >= '0' && dhTablica[0] <= '9' || dhTablica[0] >= 'A' && dhTablica[0] <= 'F')
                                                                                                    {
                                                                                                        if (dhTablica[1] >= '0' && dhTablica[1] <= '9' || dhTablica[1] >= 'A' && dhTablica[1] <= 'F')
                                                                                                        {

                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
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