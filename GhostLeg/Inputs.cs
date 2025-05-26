using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GhostLeg
{
    internal class Inputs
    {
        private const int NUMBER = 4;
        private int[,] size = new int[NUMBER, 2];
        private string[][] lines = new string[NUMBER][];
        private string[] answers = new string[NUMBER];

        public Inputs()
        {
            //TEST 1
            size[0, 0] = 7; size[0, 1] = 7;
            lines[0] = new string[] {
                            "A  B  C",
                            "|  |  |",
                            "|--|  |",
                            "|  |--|",
                            "|  |--|",
                            "|  |  |",
                            "1  2  3"
                        };

            //TEST 2
            size[1, 0] = 13; size[1, 1] = 8;
            lines[1] = new string[] {
                        "A  B  C  D  E",
                        "|  |  |  |  |",
                        "|  |--|  |  |",
                         "|--|  |  |  |",
                         "|  |  |--|  |",
                         "|  |--|  |--|",
                         "|  |  |  |  |",
                         "1  2  3  4  5",
                        };
            answers[1] = "A3 B5 C1 D2 E4";

            //TEST 3
            size[2, 0] = 22; size[2, 1] = 18;
            lines[2] = new string[] {
                         "P  Q  R  S  T  U  V  W",
                         "|  |  |  |  |--|  |  |",
                         "|  |  |--|  |  |  |--|",
                         "|  |--|  |--|  |  |  |",
                         "|--|  |--|  |  |  |--|",
                         "|--|  |  |  |  |--|  |",
                         "|  |--|  |  |--|  |--|",
                         "|  |  |  |--|  |--|  |",
                         "|--|  |  |  |--|  |  |",
                         "|  |  |--|  |  |  |  |",
                         "|  |  |  |--|  |  |--|",
                         "|  |  |  |  |--|  |  |",
                         "|--|  |  |  |  |  |  |",
                         "|--|  |--|  |  |  |--|",
                         "|  |--|  |  |--|  |  |",
                         "|  |  |--|  |  |  |--|",
                         "|--|  |--|  |  |--|  |",
                         "1  2  3  4  5  6  7  8"
                        };
            answers[2] = "P3 Q7 R8 S5 T6 U2 V4 W1";

            //TEST 4
            size[3, 0] = 76; size[3, 1] = 23;
            lines[3] = new string[] {
                    "~  !  @  #  $  %  ^  &  *  (  )  +  `  1  2  3  4  5  6  7  8  9  0  =  \\  /",
                    "|  |--|  |  |--|  |  |--|  |--|  |  |--|  |  |  |--|  |--|  |  |--|  |  |--|",
                    "|--|  |--|  |  |  |--|  |--|  |--|  |  |  |--|  |  |--|  |--|  |  |  |--|  |",
                    "|  |--|  |--|  |  |  |  |  |--|  |--|  |  |  |  |--|  |--|  |--|  |--|  |--|",
                    "|--|  |--|  |  |  |--|  |--|  |--|  |  |  |--|  |--|  |--|  |  |  |--|  |--|",
                    "|--|  |  |  |  |--|  |  |--|  |  |  |  |--|  |--|  |--|  |--|  |--|  |--|  |",
                    "|  |--|  |  |--|  |--|  |  |--|  |  |--|  |--|  |  |  |--|  |  |--|  |--|  |",
                    "|  |  |  |--|  |--|  |--|  |  |  |--|  |--|  |  |--|  |--|  |--|  |--|  |--|",
                    "|--|  |  |  |--|  |--|  |--|  |  |  |--|  |--|  |--|  |  |--|  |  |--|  |--|",
                    "|  |  |--|  |  |  |  |--|  |  |--|  |  |  |  |  |  |--|  |  |  |--|  |--|  |",
                    "|  |  |  |--|  |  |--|  |  |  |  |--|  |  |--|  |--|  |--|  |--|  |--|  |--|",
                    "|  |--|  |--|  |  |  |  |  |--|  |--|  |  |  |  |--|  |--|  |--|  |--|  |--|",
                    "|--|  |--|  |  |  |--|  |--|  |--|  |  |  |--|  |--|  |--|  |  |  |--|  |--|",
                    "|--|  |  |  |  |--|  |  |--|  |  |  |  |--|  |--|  |--|  |--|  |--|  |--|  |",
                    "|--|  |--|  |  |  |--|  |--|  |--|  |  |  |--|  |  |--|  |  |  |--|  |  |--|",
                    "|  |--|  |  |--|  |--|  |  |--|  |  |--|  |--|  |  |  |--|  |  |--|  |--|  |",
                    "|  |--|  |  |--|  |  |  |  |--|  |  |--|  |  |--|  |--|  |--|  |--|  |--|  |",
                    "|--|  |  |--|  |  |  |  |--|  |  |--|  |--|  |  |--|  |--|  |--|  |--|  |--|",
                    "|--|  |--|  |  |  |--|  |--|  |--|  |  |  |--|  |  |--|  |  |  |--|  |  |--|",
                    "|  |--|  |  |--|  |  |--|  |--|  |  |  |--|  |--|  |  |--|  |--|  |--|  |--|",
                    "|  |  |  |--|  |  |--|  |  |  |  |--|  |  |--|  |  |--|  |--|  |--|  |--|  |",
                    "|--|  |--|  |--|  |--|  |--|  |--|  |--|  |--|  |--|  |--|  |  |  |  |  |--|",
                    "a  A  b  B  c  C  d  D  e  E  f  F  g  G  h  H  i  I  j  J  k  K  l  L  m  M"
                    };
            answers[3] = "~E !F @C #c $G %B ^A &h *a (g )b +f `I 1d 2D 3i 4J 5e 6M 7k 8L 9l 0H =K \\j /m";
        }

        public int GetWidth(int puzzle)
        {
            return size[puzzle,0];
        }
        public int GetHeight(int puzzle) {
            return size[puzzle,1]; 
        }
        public string[] GetLines(int puzzle) {
            return lines[puzzle];
        }
        public bool CheckAnswer(int puzzle, string answer)
        {
            Console.WriteLine("Jouw antwoord is: "+answer);
            return answer == answers[puzzle];
        }
        public int GetNumberOfPuzzles()
        {
            return NUMBER;
        }
    }
}
