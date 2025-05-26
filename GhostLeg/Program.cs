namespace GhostLeg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deze methode NIET AANPASSEN. Start in 'CreateAnswer(int W, int H, string[] lines)'
            Inputs inputs = new Inputs();
            for (int i = 0; i < inputs.GetNumberOfPuzzles(); i++)
            {
                Console.Error.WriteLine("TEST");
                bool check = inputs.CheckAnswer(i,CreateAnswer(inputs.GetWidth(i), inputs.GetHeight(i), inputs.GetLines(i)));
                if (check) Console.ForegroundColor = ConsoleColor.Green; else Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(check?"Correct!":"Fout..");
                Console.ResetColor();
            }
        }

        static string CreateAnswer(int W, int H, string[] lines)
        {
            string answer = "";
            //SCHRIJF HIER JE CODE

            return answer.Trim();
        }
    }
}
