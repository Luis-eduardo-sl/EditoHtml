using System.Text;

namespace EditorHtml
{
  public static class Editor
  {
    public static void Show()
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.White;
      Console.Clear();
      Console.WriteLine("MODO EDITOR");
      Console.WriteLine("----------------");
      Start();

    }


    public static void Start()
    {
      var file = new StringBuilder();

      do
      {
        file.Append(Console.ReadLine());
        file.Append(Environment.NewLine);
      } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

      Console.WriteLine("----------------");
      Console.WriteLine("Deseja salvar o arquivo? ");
      Viewer.Show(file.ToString());

    }

  }
}