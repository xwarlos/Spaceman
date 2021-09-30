using System;

namespace Spaceman
{
  class Program
  {
    static void Main(string[] args)
    {
        Game juego = new Game();
        juego.Greet();

        while(true) {
          juego.Display();
          juego.Ask();

          if (juego.DidWin()) {
            juego.Display();
            Console.WriteLine("Congrats");
            break;
          } else if (juego.DidLose()) {
            Console.WriteLine(":(");
            break;
          }
        }
    }
  }
}
