

namespace Answer
{

    public static class Utilities
    {
        public static async Task ShowConsoleAnimation()
        {
            for (int i = 0; i < 20; i++)
                //{
                //    Console.Write("| -");
                //    await Task.Delay(50);
                //    Console.Write("\b\b\b");
                //    Console.Write("/ \\");
                //    await Task.Delay(50);
                //    Console.Write("\b\b\b");
                //    Console.Write("- |");
                //    await Task.Delay(50);
                //    Console.Write("\b\b\b");
                //    Console.Write("\\ /");
                //    await Task.Delay(50);
                //    Console.Write("\b\b\b");
                //}

            foreach (string s in new[] { "| -", "/ \\", "- |", "\\ /", })
            {
                Console.Write(s);
                await Task.Delay(50);
                Console.Write("\b\b\b");
            }
            Console.WriteLine();
        }
    }

}
