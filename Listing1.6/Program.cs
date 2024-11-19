using System;
class Dialog
{
    static void Main ()
    {
        Console.Title = "Давайте познакомимся";
        Console.Write("Как вас зовут? ");
        string name = Console.ReadLine();
        string txt = "Очень приятно, " + name + "!!!!";
        Console.WriteLine(txt);
    }
}