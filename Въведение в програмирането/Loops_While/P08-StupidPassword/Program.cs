namespace P08_StupidPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*             
             Генератор за тъпи пароли
Да се напише програма, която въвежда две цели числа n и l и генерира по азбучен ред всички възможни “тъпи” пароли, които се състоят от следните 5 символа:
•	Символ 1: цифра от 1 до n.
•	Символ 2: цифра от 1 до n.
•	Символ 3: малка буква измежду първите l букви на латинската азбука.
•	Символ 4: малка буква измежду първите l букви на латинската азбука.
•	Символ 5: цифра от 1 до n, по-голяма от първите 2 цифри.*/

            
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            
            for (int digit1 = 1; digit1 <= n; digit1++) 
            {
                for (int digit2 = 1; digit2 <= n; digit2++) 
                    for (char letter1 = 'a'; letter1 < 'a' + l; letter1++) 
                    {
                        for (char letter2 = 'a'; letter2 < 'a' + l; letter2++) 
                        {
                            for (int digit3 = 1; digit3 <= n; digit3++) 
                            {
                                // Проверка дали петата цифра е по-голяма от първите две
                                if (digit3 > digit1 && digit3 > digit2)
                                {
                                    
                                    Console.Write($"{digit1}{digit2}{letter1}{letter2}{digit3} ");
                                    Console.WriteLine();
                                }
                                
                            }
                        }
                    }
                }
            }
        }
    
}
