using MyLibrary;
namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MessageWriter MyWriter = new MessageWriter();
            MyWriter.Write("Hello, Writer!");

            FiggleWriter FyWriter = new FiggleWriter();
            FyWriter.Write("Hello, Figgle!");
        }

    }
}
