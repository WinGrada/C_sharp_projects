using System;

namespace heads_or_tails
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Это игра проверяет твою удачу!\n");
            Console.WriteLine("Компьютер подбросил монетку и ты должен угадать 'орел' это или 'решка'\n");
            Console.WriteLine("Нажми '1' если это Орел.");
            Console.WriteLine("Нажми '2' если это Решка.\n");
            Console.WriteLine("Для выхода из программы нажмите 's'");

            while (true)
            {
                string user_coin_side = Enter_user_coin_side();
                if (user_coin_side.Equals( "s" ))
                {
                    Environment.Exit(0);
                }

                if (Is_string_valid(user_coin_side))
                {
                    if (Did_user_win(user_coin_side))
                    {
                        Console.WriteLine("Ты угадал! Поздравляю!");
                    }
                    else
                    {
                        Console.WriteLine("Хех, не повезло. Может в следующий раз?");
                    }
                }
            }
        }

 
        static int Toss_coin()
        {
            Random random = new Random();
            int random_coin_side = random.Next(1, 3);

            return random_coin_side;
        }

        static bool Do_sides_match( int random_coin_side, int user_coin_side )
        {
            if (random_coin_side == user_coin_side) return true;

            return false;
        }

        static string Enter_user_coin_side()
        {
            string user_coin_side = Console.ReadLine();

            return user_coin_side;
        }

        static bool Is_numbers( string user_string_entered )
        {
            bool result_convert = int.TryParse(user_string_entered, out int convert_string);

            if (result_convert) return true;

            Console.WriteLine("Error: Вы ввели не числа!");
            return false;
        }

        static bool Is_string_valid( string user_string_entered)
        {
            int valid_size = 1;

            if (user_string_entered.Length == valid_size)
            {
                if (Is_numbers( user_string_entered )) 
                {
                    if ( (user_string_entered.Equals("1")) || (user_string_entered.Equals("2")) )
                    {
                        return true;
                    }
                }
            }

            Console.WriteLine("Erorr: Такого варианта не существует ");
            return false;
        }

        static bool Did_user_win( string user_coin_side )
        {
            int bot_coin_side = Toss_coin();
            int converted_user_coin_side = int.Parse(user_coin_side);

            if (Do_sides_match(bot_coin_side, converted_user_coin_side)) return true;

            return false;
        }
    }
}
