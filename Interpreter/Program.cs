namespace Interpreter
{
    internal class Program
    {
        private static string[] tests = { "1sp 1/ 1bS 1_ 1/ 1bS nl 1( 1sp 1o 1. 1o 1sp 1) nl 1sp 1> 1sp 1^ 1sp 1< nl 2sp 3|" ,
                                "18sp 1: nl 18sp 1: nl 7sp 2, 9sp 1: 9sp 2, nl 7sp 2: 9sp 1: 9sp 2: nl 2, 5sp 2: 9sp 1: 9sp 2: 5sp 2, nl 2: 5sp 2: 9sp 1: 9sp 2: 5sp 2: nl 1sp 1sQ 2: 1. 3sp 1sQ 2: 1. 6sp 1: 6sp 1. 2: 1sQ 3sp 1. 2: 1sQ nl 4sp 1sQ 2: 1. 2sp 1sQ 2: 1. 2sp 1_ 1/ 1~ 1bS 1_ 2sp 1. 2: 1sQ 2sp 1. 2: 1sQ nl 6sp 1sQ 2: 1. 2sp 3: 1/ 5sp 1bS 3: 2sp 1. 2: 1sQ nl 8sp 1sQ 5: 1( 7sp 1) 5: 1sQ nl 15sp 1bS 1sp 3_ 1sp 1/ nl 9sp 1. 5: 1/ 1` 3sp 1` 1bS 5: 1. nl 7sp 1. 2: 1sQ 3sp 1. 1: 1bS 1o 1sp 1o 1/ 1: 1. 3sp 1sQ 2: 1. nl 5sp 1. 2: 1sQ 3sp 1. 2: 2sp 1: 1sQ 1: 2sp 2: 1. 3sp 1sQ 2: 1. nl 3sp 1. 2: 1sQ 4sp 2: 1sQ 3sp 1sQ 1sp 1sQ 3sp 1sQ 2: 4sp 1sQ 2: 1. nl 2sp 2: 6sp 2: 13sp 2: 6sp 2: nl 2sp 2^ 6sp 2: 13sp 2: 6sp 2^ nl 10sp 2: 13sp 2: nl 10sp 2^ 13sp 2^",
                                "13sp 2x nl 12sp 1/ 1sp 1. 1| 1_ nl 11sp 1/ 1( 1_ 1) 1_ 1< nl 10sp 1/ 2sp 1( nl 1sp 2( 4_ 1. 1- 1sQ 4sp 1) nl 2sp 2bS 9sp 1/ nl 3sp 1bS 1sQ 1- 1. 1- 1. 1- 1sQ 1` 1/ nl 1sp 1_ 2sp 1bS 6_ 1/ nl 1( 1_ 1) 3sp 1_ 1| 1_ 1bS 1_ nl 16sQ",
                                "6sp 1_ 7sp 1_ nl 5sp 1( 1_ 1bS 5sp 1/ 1_ 1) nl 7sp 2) 3sp 2( nl 5sp 1. 1- 7sQ 1- 1. 2sp nl 1sp 1/ 1^ 1bS 1/ 2sp 1_ 1. 3sp 1_ 1. 2sp 1bS 1/ 1^ 1bS nl 1sp 1bS 1( 3sp 1/ 2_ 1bS 1sp 1/ 2_ 1bS 3sp 1) 1/ nl 2sp 1bS 1, 2sp 1bS 1o 1_ 1/ 1_ 1bS 1o 1_ 1/ 2sp 1, 1/ nl 4sp 1bS 4sp 1( 1_ 1) 4sp 1/ nl 5sp 1` 1- 1. 1sQ 3= 1sQ 1. 1- 1sQ nl 6sp 2_ 1) 1sp 1- 1sp 1( 2_ 3sp nl 5sp 1/ 2sp 1` 3~ 1` 2sp 1bS nl 4sp 1/ 2sp 1/ 5sp 1bS 2sp 1bS nl 4sp 1bS 1sp 1: 7sp 1; 1sp 1/ nl 5sp 1bS 1| 2= 1( 1* 1) 2= 1| 1/ nl 6sp 1: 7sp 1: nl 7sp 1bS 2sp 1| 2sp 1/ nl 5sp 3_ 1) 1= 1| 1= 1( 3_ nl 4sp 1{ 4_ 1/ 1sp 1bS 4_ 1}",
                                "4sp 2_ nl 2sp 1. 1^ 1o 1sp 1~ 1bS nl 1sp 1Y 1sp 1/ 1sQ 1~ 1) 1sp 1} 6sp 5_ nl 1sp 1l 1/ 2sp 1/ 1sp 1/ 4sp 1, 1- 1~ 5sp 2~ 2- 1. 1, 1_ nl 4sp 1( 1sp 1( 4sp 1/ 2sp 1~ 1- 1. 1_ 9sp 1^ 1. nl 5sp 1bS 1sp 1sQ 2- 1sQ 2- 1. 4sp 1sQ 1- 1. 1_ 7sp 1bS nl 6sp 1sQ 1- 1. 8_ 5sp 1~ 2- 1. 1, 2_ 1sp 1^ 1. nl 16sp 1sQ 1~ 1r 1- 1. 1, 3_ 1. 1- 1sQ 1- 1. 1sp 1^ 1. nl 17sp 1Y 1I 4sp 1bS 6sp 1~ 1- 1. 1bS nl 17sp 2| 5sp 1bS 8sp 1` 1bS nl 17sp 2| 5sp 2/ nl 17sp 2| 4sp 2/ nl 17sp 1( 1) 3sp 2/ nl 17sp 2| 2sp 2/ 4sp 1~ 1F 1r 1a 1n nl 17sp 2| 1sp 1( 1sp 1c nl 4sp 3_ 1. 1_ 1sp 2_ 2sp 3_ 1I 1| 2_ 1` 2- 2_ 1. 1_ 1sp 2_ 2sp 1_ nl 2sp 1sQ 1~ 5sp 1~ 2sp 1sQ 1~ 3sp 2: 2sp 2~ 2sQ 4sp 1~ 2sp 2~ nl 17sp 2: nl 17sp 1. 1: nl 18sp 1. nl 2sp 32~"};
        private static string[] answers = { " /\\_/\\\r\n( o.o )\r\n > ^ <\r\n  |||",
                                            "                  :\r\n                  :\r\n       ,,         :         ,,\r\n       ::         :         ::\r\n,,     ::         :         ::     ,,\r\n::     ::         :         ::     ::\r\n '::.   '::.      :      .::'   .::'\r\n    '::.  '::.  _/~\\_  .::'  .::'\r\n      '::.  :::/     \\:::  .::'\r\n        ':::::(       ):::::'\r\n               \\ ___ /\r\n         .:::::/`   `\\:::::.\r\n       .::'   .:\\o o/:.   '::.\r\n     .::'   .::  :':  ::.   '::.\r\n   .::'    ::'   ' '   '::    '::.\r\n  ::      ::             ::      ::\r\n  ^^      ::             ::      ^^\r\n          ::             ::\r\n          ^^             ^^",
                                            "             xx\r\n            / .|_\r\n           /(_)_<\r\n          /  (\r\n ((____.-'    )\r\n  \\\\         /\r\n   \\'-.-.-'`/\r\n _  \\______/\r\n(_)   _|_\\_\r\n''''''''''''''''",
                                            "      _       _\r\n     (_\\     /_)\r\n       ))   ((\r\n     .-'''''''-.  \r\n /^\\/  _.   _.  \\/^\\\r\n \\(   /__\\ /__\\   )/\r\n  \\,  \\o_/_\\o_/  ,/\r\n    \\    (_)    /\r\n     `-.'==='.-'\r\n      __) - (__   \r\n     /  `~~~`  \\\r\n    /  /     \\  \\\r\n    \\ :       ; /\r\n     \\|==(*)==|/\r\n      :       :\r\n       \\  |  /\r\n     ___)=|=(___\r\n    {____/ \\____}",
                                            "    __\r\n  .^o ~\\\r\n Y /'~) }      _____\r\n l/  / /    ,-~     ~~--.,_\r\n    ( (    /  ~-._         ^.\r\n     \\ '--'--.    '-._       \\\r\n      '-.________     ~--.,__ ^.\r\n                '~r-.,___.-'-. ^.\r\n                 YI    \\      ~-.\\\r\n                 ||     \\        `\\\r\n                 ||     //\r\n                 ||    //\r\n                 ()   //\r\n                 ||  //    ~Fran\r\n                 || ( c\r\n    ___._ __  ___I|__`--__._ __  _\r\n  '~     ~  '~   ::  ~~''    ~  ~~\r\n                 ::\r\n                 .:\r\n                  .\r\n  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~"};

        static void Main(string[] args)
        {
            //Deze methode NIET AANPASSEN. Start in 'DoConvert(string inp)'
            for (int i = 0; i < tests.Length; i++)
            {
                string a = DoConvert(tests[i]);
                Console.WriteLine(a);
                bool success = a == answers[i];
                if (success) { Console.ForegroundColor = ConsoleColor.Green; }
                else { Console.ForegroundColor = ConsoleColor.Red; }
                Console.WriteLine(success);
                Console.ResetColor();
            }
        }
        
        private static string DoConvert(string inp)
        {
            string antwoord = "";
            // Schrijf hier jouw code:


            // Geef het correcte antwoord terug.
            return antwoord;
        }
    }
}
