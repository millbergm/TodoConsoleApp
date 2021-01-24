using System;

namespace TodoApp
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            bool isRunning = true;
            ConsoleKey val;
            var db = new TodoManager("Server = 40.85.84.155; Database = Student26; User = Student26; Password = zombie-virus@2020;");

            while (isRunning)
            {
                PrintMeny();
                val = Console.ReadKey().Key;
                switch (val)
                {
                    case ConsoleKey.A:
                        Console.Clear();
                        Console.WriteLine("Din ToDo-Lista");
                        displayTodoList(db);
                        PauseProgram();
                        break;

                    case ConsoleKey.B:
                        Console.Clear();
                        var atodo = new TodoItem();
                        Console.WriteLine("Lägg till en TodoItem");
                        while (true)
                        {
                            Console.WriteLine("Titel: ");
                            atodo.Title = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(atodo.Title))
                            {
                                Console.WriteLine("Du måste ange en TITEL");
                            }
                            else { break; }
                        }
                        Console.WriteLine("Info: ");
                        atodo.Info = Console.ReadLine();
                        Console.WriteLine("Vill du ha en Deadline? Y/N: ");
                        val = Console.ReadKey().Key;
                        switch (val)
                        {
                            case ConsoleKey.Y:
                                int year, month, day;
                                Console.Write("År YYYY: ");
                                string år = Console.ReadLine();
                                while (true)
                                {
                                    try
                                    {
                                        year = Int32.Parse(år);
                                        break;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Felaktigt Input!");
                                    }
                                }
                                Console.Write("Månad MM: ");
                                string månad = Console.ReadLine();
                                while (true)
                                {
                                    try
                                    {
                                        month = Int32.Parse(månad);
                                        break;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Felaktigt Input!");
                                    }
                                }
                                Console.Write("Dag DD: ");
                                string dag = Console.ReadLine();
                                while (true)
                                {
                                    try
                                    {
                                        day = Int32.Parse(dag);
                                        break;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Felaktigt Input!");
                                    }
                                }
                                atodo.Deadline = new DateTime(year, month, day);
                                break;
                        }
                        db.AddTodoItem(atodo);
                        displayTodoList(db);
                        PauseProgram();
                        break;

                    case ConsoleKey.C:
                        Console.Clear();
                        displayTodoList(db);
                        Console.WriteLine("Vilket Todo-Item Vill Du Ta Bort");
                        string nummer = Console.ReadLine();
                        try
                        {
                            int result = Int32.Parse(nummer);
                            db.RemoveTodoItem(result);
                        }
                        catch
                        {
                            Console.WriteLine("Felaktigt Input!");
                        }
                        // displayTodoList(db);
                        PauseProgram();
                        break;

                    case ConsoleKey.Q: // Asluta programmet
                        {
                            Console.Clear();
                            Console.WriteLine("Stänger ToDo-Appen");
                            isRunning = false;
                            break;
                        }
                }
            }
        }

        private static void displayTodoList(TodoManager db)
        {
            Console.WriteLine("ID* Skapad         * Deadline * Titel");
            foreach (var todo in db.GetTodoItems())
            {
                if (todo.Deadline < todo.Created)
                {
                    Console.WriteLine($"{todo.Id} * {todo.Created.ToString("yy-MM-dd H:mm")} *          * {todo.Title}");
                }
                else if (todo.Deadline < DateTime.Now)
                {
                    Console.WriteLine($"{todo.Id} * {todo.Created.ToString("yy-MM-dd H:mm")} * {todo.Deadline.ToString("yy-MM-dd")} * {todo.Title}");
                }
                else
                {
                    Console.WriteLine($"{todo.Id} * {todo.Created.ToString("yy-MM-dd H:mm")} * {todo.Deadline.ToString("yy-MM-dd")} * {todo.Title}");
                }
            }
        }

        static void PrintMeny()
        {
            Console.Clear();
            Console.Write("\n");
            Console.WriteLine("*************************");
            Console.WriteLine("* Din ToDo-Lista        *");
            Console.WriteLine("*************************");
            Console.WriteLine("- [A] Kolla ToDo-Listan -");
            Console.WriteLine("- [B] Ny ToDo           -");
            Console.WriteLine("- [C] Ta Bort ToDo      -");
            Console.WriteLine("-------------------------");
            Console.WriteLine("- [Q] Avsluta           -");
            Console.Write("\n");
        }

        static void PauseProgram()
        {
            Console.WriteLine("\nTryck valfri tangent för att gå vidare till menyn");
            Console.ReadKey();
            Console.Clear();
        }

    }
}