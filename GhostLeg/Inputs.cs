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
            lines[0] = new string[7];
            lines[0][0] = "A  B  C";
            lines[0][1] = "|  |  |";
            lines[0][2] = "|--|  |";
            lines[0][3] = "|  |--|";
            lines[0][4] = "|  |--|";
            lines[0][5] = "|  |  |";
            lines[0][6] = "1  2  3";
            answers[0] = "A2 B1 C3";

            //TEST 2
            size[1, 0] = 13; size[1, 1] = 8;
            lines[1] = new string[8];
            lines[1][0] = "A  B  C  D  E";
            lines[1][1] = "|  |  |  |  |";
            lines[1][2] = "|  |--|  |  |";
            lines[1][3] = "|--|  |  |  |";
            lines[1][4] = "|  |  |--|  |";
            lines[1][5] = "|  |--|  |--|";
            lines[1][6] = "|  |  |  |  |";
            lines[1][7] = "1  2  3  4  5";
            answers[1] = "A3 B5 C1 D2 E4";

            //TEST 3
            size[2, 0] = 22; size[2, 1] = 18;
            lines[2] = new string[18];
            lines[2][0] = "P  Q  R  S  T  U  V  W";
            lines[2][1] = "|  |  |  |  |--|  |  |";
            lines[2][2] = "|  |  |--|  |  |  |--|";
            lines[2][3] = "|  |--|  |--|  |  |  |";
            lines[2][4] = "|--|  |--|  |  |  |--|";
            lines[2][5] = "|--|  |  |  |  |--|  |";
            lines[2][6] = "|  |--|  |  |--|  |--|";
            lines[2][7] = "|  |  |  |--|  |--|  |";
            lines[2][8] = "|--|  |  |  |--|  |  |";
            lines[2][9] = "|  |  |--|  |  |  |  |";
            lines[2][10] = "|  |  |  |--|  |  |--|";
            lines[2][11] = "|  |  |  |  |--|  |  |";
            lines[2][12] = "|--|  |  |  |  |  |  |";
            lines[2][13] = "|--|  |--|  |  |  |--|";
            lines[2][14] = "|  |--|  |  |--|  |  |";
            lines[2][15] = "|  |  |--|  |  |  |--|";
            lines[2][16] = "|--|  |--|  |  |--|  |";
            lines[2][17] = "1  2  3  4  5  6  7  8";
            answers[2] = "P3 Q7 R8 S5 T6 U2 V4 W1";

            //TEST 4
            size[3, 0] = 76; size[3, 1] = 23;
            lines[3]  = new string[23];
            lines[3][0] = "~  !  @  #  $  %  ^  &  *  (  )  +  `  1  2  3  4  5  6  7  8  9  0  =  \\  /";
            lines[3][1] = "|  |--|  |  |--|  |  |--|  |--|  |  |--|  |  |  |--|  |--|  |  |--|  |  |--|";
            lines[3][2] = "|--|  |--|  |  |  |--|  |--|  |--|  |  |  |--|  |  |--|  |--|  |  |  |--|  |";
            lines[3][3] = "|  |--|  |--|  |  |  |  |  |--|  |--|  |  |  |  |--|  |--|  |--|  |--|  |--|";
            lines[3][4] = "|--|  |--|  |  |  |--|  |--|  |--|  |  |  |--|  |--|  |--|  |  |  |--|  |--|";
            lines[3][5] = "|--|  |  |  |  |--|  |  |--|  |  |  |  |--|  |--|  |--|  |--|  |--|  |--|  |";
            lines[3][6] = "|  |--|  |  |--|  |--|  |  |--|  |  |--|  |--|  |  |  |--|  |  |--|  |--|  |";
            lines[3][7] = "|  |  |  |--|  |--|  |--|  |  |  |--|  |--|  |  |--|  |--|  |--|  |--|  |--|";
            lines[3][8] = "|--|  |  |  |--|  |--|  |--|  |  |  |--|  |--|  |--|  |  |--|  |  |--|  |--|";
            lines[3][9] = "|  |  |--|  |  |  |  |--|  |  |--|  |  |  |  |  |  |--|  |  |  |--|  |--|  |";
            lines[3][10] ="|  |  |  |--|  |  |--|  |  |  |  |--|  |  |--|  |--|  |--|  |--|  |--|  |--|";
            lines[3][11] ="|  |--|  |--|  |  |  |  |  |--|  |--|  |  |  |  |--|  |--|  |--|  |--|  |--|";
            lines[3][12] ="|--|  |--|  |  |  |--|  |--|  |--|  |  |  |--|  |--|  |--|  |  |  |--|  |--|";
            lines[3][13] ="|--|  |  |  |  |--|  |  |--|  |  |  |  |--|  |--|  |--|  |--|  |--|  |--|  |";
            lines[3][14] ="|--|  |--|  |  |  |--|  |--|  |--|  |  |  |--|  |  |--|  |  |  |--|  |  |--|";
            lines[3][15] ="|  |--|  |  |--|  |--|  |  |--|  |  |--|  |--|  |  |  |--|  |  |--|  |--|  |";
            lines[3][16] ="|  |--|  |  |--|  |  |  |  |--|  |  |--|  |  |--|  |--|  |--|  |--|  |--|  |";
            lines[3][17] ="|--|  |  |--|  |  |  |  |--|  |  |--|  |--|  |  |--|  |--|  |--|  |--|  |--|";
            lines[3][18] ="|--|  |--|  |  |  |--|  |--|  |--|  |  |  |--|  |  |--|  |  |  |--|  |  |--|";
            lines[3][19] ="|  |--|  |  |--|  |  |--|  |--|  |  |  |--|  |--|  |  |--|  |--|  |--|  |--|";
            lines[3][20] ="|  |  |  |--|  |  |--|  |  |  |  |--|  |  |--|  |  |--|  |--|  |--|  |--|  |";
            lines[3][21] ="|--|  |--|  |--|  |--|  |--|  |--|  |--|  |--|  |--|  |--|  |  |  |  |  |--|";
            lines[3][22] ="a  A  b  B  c  C  d  D  e  E  f  F  g  G  h  H  i  I  j  J  k  K  l  L  m  M";
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
