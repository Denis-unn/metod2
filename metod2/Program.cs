using System;
using System.Collections.Generic;

class Metod2
{
    static void Main()
    {
        Queue<int> ocher = new Queue<int>();

        string command;
        while ((command = Console.ReadLine()) != "exit")
        {
            string[] parts = command.Split();
            string operation = parts[0];

            switch (operation)
            {
                case "push":
                    try
                    {
                        int number = int.Parse(parts[1]);
                        ocher.Enqueue(number);
                        Console.WriteLine("ok");
                        break;
                    }
                    catch (Exception e)
                    {
                        // Console.WriteLine(e.ToString());
                        Console.WriteLine("Некорректный ввод (вы ввели не число)");
                        break;
                    }

                case "pop":
                    if (ocher.Count > 0)
                    {
                        int firstElement = ocher.Dequeue();
                        Console.WriteLine(firstElement);
                    }
                    else
                    {
                        Console.WriteLine("Ошибка, невозможно удалить элемент так как очередь пуста");
                    }
                    break;

                case "front":
                    if (ocher.Count > 0)
                    {
                        int firstElement = ocher.Peek();
                        Console.WriteLine(firstElement);
                    }
                    else
                    {
                        Console.WriteLine("Ошибка, очередь пуста");
                    }
                    break;

                case "size":
                    Console.WriteLine(ocher.Count);
                    break;

                case "clear":
                    ocher.Clear();
                    Console.WriteLine("ok");
                    break;
                default:
                    Console.WriteLine("Вы написали некорректную команду для очереди");
                    break;
            }
        }

        Console.WriteLine("bye");
    }
}