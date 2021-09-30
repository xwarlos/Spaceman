using System;

namespace Spaceman
{
  class Game {
    string codeWord = "";
    string currentWord = "";
    int maxGuesses = 5;
    int numGuesses = 0;
    string[] options = {"hola", "aliens", "qonda"};
    Ufo ovni = new Ufo();

    public Game() {
        Random rnd = new Random(); 
        codeWord = options[rnd.Next(3)];
        maxGuesses = 5;
        numGuesses = 0;
        currentWord = new String('_', codeWord.Length);
    }

    public void Greet() {
        Console.WriteLine("Greetings");
    }

    public bool DidWin() {
        return codeWord.Equals(currentWord) ? true : false;
    }

    public bool DidLose() {
        return numGuesses >= maxGuesses ? true : false;
    }

    public void Display() {
        Console.WriteLine(ovni.Stringify());
        Console.WriteLine(currentWord);
        Console.WriteLine(String.Concat((maxGuesses - numGuesses).ToString(), " guesses remaining"));
    }

    public void Ask() {
        Console.Write("What is your wisdom? ");
        char letra = Console.ReadLine()[0];
        
        if (codeWord.Contains(letra)) {
            // Cómo hago para hacer el buscar y reemplazar de forma eficiente?
            for (int i = 0; i < codeWord.Length; i++) {
                if (codeWord[i].Equals(letra)) {
                    currentWord = currentWord.Remove(i, 1).Insert(i, letra.ToString());
                }
            }
        } else {
            Console.WriteLine("Wrong");
            ovni.AddPart();
            numGuesses++;
        }
    }
  }
}