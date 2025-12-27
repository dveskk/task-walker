string menuMessage = @"
╔══════════════════════════════════════════════════════════╗
║                     Task Walker - Menu                   ║
╠══════════════════════════════════════════════════════════╣
║                                                          ║
║  Available commands:                                     ║
║                                                          ║
║  task add <description>                                  ║
║      → Add a new task                                    ║
║      Example: task add Finish course section             ║
║                                                          ║
║  task list                                               ║
║      → Show all active tasks with details                ║
║                                                          ║
║  task <id> done                                          ║
║      → Mark task with specified ID as completed          ║
║      Example: task 3 done                                ║
║                                                          ║
║  task <id> ext <note>                                    ║
║      → Add extra information/note to a task              ║
║      Example: task 2 ext Need to review topics first     ║
║                                                          ║
║  task bin                                                ║
║      → Show all completed tasks                          ║
║                                                          ║
║  task help                                               ║
║      → Display this menu again                           ║
║                                                          ║
║  task exit   or   quit                                   ║
║      → Exit the application                              ║
║                                                          ║
╚══════════════════════════════════════════════════════════╝

Type a command and press Enter.";

// void -> return None
// int  -> return 5
// double -> return 5.5;
// string -> return "test";

// METHOD
void ShowList(List<string> elements)
{
    if (elements.Count == 0)
    {
        Console.WriteLine("nema");
        return;
    }
    for (int i = 0; i < elements.Count; i++)
    {
        string item = elements[i];
        Console.WriteLine($"{i+1}. {item}");
    }
}




List<string> tasks = new();
List<string> bin = new();

while (true)
{
    string? userCmd = Console.ReadLine();

    if (string.IsNullOrEmpty(userCmd))
    {
        Console.WriteLine("Porada dnya: ubeysya");
        continue;
    }

    if (userCmd.ToLower().StartsWith("task add"))
    {
        string description = userCmd.Substring(9);
        tasks.Add(description);
        Console.WriteLine($"Task added: {description}");
    }

    else if (userCmd.ToLower().StartsWith("task help"))
    {
        Console.WriteLine(menuMessage);
    }

    else if (userCmd.ToLower().StartsWith("task list"))
    {
        Console.WriteLine("--- Tasks ---");
        ShowList(tasks);
    }

    else if (userCmd.ToLower().StartsWith("task bin"))
    {
        Console.WriteLine("--- Bin ---");
        ShowList(bin);
    }

    else if (userCmd.ToLower().StartsWith("task exit"))
    {
        Console.WriteLine("The program has been finished");
        break;
    }

    else
    {
        string[] parts = userCmd.Split(" ");
        if (parts.Length != 3)
        {
            Console.WriteLine("invalid ubeysya");
            continue;
        }

        if (parts[2] != "done")
        {
            Console.WriteLine("invalid ubeysya2");
            continue;
        }
        int number = int.Parse(parts[1]);
        bin.Add(tasks[number - 1]);
        tasks.RemoveAt(number - 1);
        Console.WriteLine("deleted");
    }
}
