class Program
{
    static void Main()
    {
        string[] pixelRows = new string[] {
"..............",
"..............",
"....RRRRR.....",
".KKKKKKKKKKKK.",
"..KSKSSSKSSS..",
"..KSKKSSSKSSS.",
"..KKSSSSKKKK..",
"....SSSSSSS...",
"...BBRBBB.....",
"..BBBRBBRBBB..",
".BBBBRBBRBBBB.",
".SSBBRRRRBBSS.",
".SSSRYRRYRSSS.",
".SSRRRRRRRRSS.",
"...RRR..RRR...",
"..OOO...OOO...",
".OOOO...OOOO..",
".............."
        };

        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.Clear();

        for (int row = 0; row < pixelRows.Length; row++)
        {
            string line = pixelRows[row];
            Console.SetCursorPosition(0, row);

            int c = 0;
            while (c < line.Length)
            {
                char ch = line[c];
                int run = 1;
                while (c + run < line.Length && line[c + run] == ch) run++;

                Console.BackgroundColor = ColorFor(ch);
                Console.Write(new string(' ', run * 3));

                c += run;
            }
        }

        Console.ReadKey();
    }

    static ConsoleColor ColorFor(char ch)
    {
        if (ch == 'R') return ConsoleColor.Red;
        if (ch == 'B') return ConsoleColor.Blue;
        if (ch == 'S') return ConsoleColor.DarkYellow;
        if (ch == 'K') return ConsoleColor.Black;
        if (ch == 'Y') return ConsoleColor.Yellow;
        if (ch == 'O') return ConsoleColor.DarkYellow;
        return ConsoleColor.Cyan;
    }
}

