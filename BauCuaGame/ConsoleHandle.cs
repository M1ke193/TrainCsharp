public class ConsoleHandle
{
    public static void WriteAndClearAll(string text, int delay = 1000)
    {
        Console.WriteLine(text);
        Thread.Sleep(delay);
        Console.Clear();
    }

    public static void WriteAndClear(string text, int delay = 0) 
    {
        Console.WriteLine(text);
        Thread.Sleep(delay);
        int currentCursor = Console.CursorTop;
        int textHeight = text.Split('\n').Length;
        while (textHeight > 0)
        {
            Console.SetCursorPosition(0, currentCursor);
            Console.Write(new string(' ', Console.WindowWidth));
            currentCursor--;
            textHeight--;
        }
        Console.SetCursorPosition(0, currentCursor);
    }
    public static void ClearChoosenLine(int starLine, int endLine)
    {
        var tempStartLine = starLine;
        if (starLine > endLine) return;
        while (starLine <= endLine - 1)
        {
            Console.SetCursorPosition(0, starLine);
            Console.Write(new string(' ', Console.WindowWidth));
            starLine++;
        }
        Console.SetCursorPosition(0, tempStartLine);
    }
    public static void loopInputKey(ConsoleKey KeyToEnd)
    {
        ConsoleKeyInfo userInput;
        do
        {
            userInput = Console.ReadKey();
        } while (userInput.Key != KeyToEnd);
    }
}
