using System.Security.Cryptography.X509Certificates;

var todos = new List<string>();

Console.WriteLine("Hello there!");

bool exit = false;



while (!exit)
{
    Console.WriteLine();
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all todos");
    Console.WriteLine("[A]dd a todo");
    Console.WriteLine("[R]emove a todo");
    Console.WriteLine("[E]xit");

    var userChoice = Console.ReadLine();

    switch (userChoice)
    {
        case "E":
        case "e":
            exit = true;
            break;
        case "S":
        case "s":
            SeeAllTodos();
            break;
        case "A":
        case "a":
            AddTodo();
            break;

        case "R":
        case "r":
            RemoveTodo();
            break;

        default:
            Console.WriteLine("Invalid input, try again...");
            break;
    }

    Console.ReadKey();

    void SeeAllTodos()
    {

        if(todos.Count == 0)
        {
            Console.WriteLine("No Todos yet...");
        }
        for (int i = 0; i < todos.Count; i++)
        {
            
         
                Console.WriteLine((i+1) + " " + todos[i]);
            
        }
    }

    void AddTodo()
    {
        string addition;

        addition = Console.ReadLine();

        if (addition == "") {
            Console.WriteLine("You must right something to add to the list...");
        }

        todos.Add(addition);
    }

    void RemoveTodo()
    {
        int choice;

        if(todos.Count == 0)
        {
            Console.WriteLine("No todos to remove...");
        }

        SeeAllTodos();


        int.TryParse(Console.ReadLine(), out choice);

        if(choice-1 > (todos.Count - 1) || choice <= 0)
        {
            Console.WriteLine("Please enter a valid choice...");
        }


        Console.WriteLine("Removed " + todos[choice - 1]);

        todos.RemoveAt(choice-1);

        
        {

        }
    }





}