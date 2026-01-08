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
║  ──────────────────────  Notes ───────────────────────   ║
║                                                          ║
║  note add <text>                                         ║
║      → Add a new note                                    ║
║      Example: note add I want to go to Disneyland        ║
║                                                          ║
║  note list                                               ║
║      → Show all notes                                    ║
║                                                          ║
║  note <id> done                                          ║
║      → Mark note as completed / remove it                ║
║      Example: note 1 done                                ║
║                                                          ║
║  ──────────────────────────────────────────────────────  ║
║                                                          ║
║  task help                                               ║
║      → Display this menu again                           ║
║                                                          ║
║  task exit   or   quit                                   ║
║      → Exit the application                              ║
║                                                          ║
╚══════════════════════════════════════════════════════════╝

Type a command and press Enter.";

List<string> tasks = new();
List<string> bin = new();
List<string> notes = new();

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
        Console.WriteLine($"{i + 1}. {item}");
    }
}


void HandleTaskCommands(string cmd)
{
    if (cmd.ToLower().StartsWith("task add"))
    {
        string description = cmd.Substring(9);
        tasks.Add(description);
        Console.WriteLine($"Task added: {description}");
    }

    else if (cmd.ToLower().StartsWith("task help"))
    {
        Console.WriteLine(menuMessage);
    }

    else if (cmd.ToLower().StartsWith("task list"))
    {
        Console.WriteLine("--- Tasks ---");
        ShowList(tasks);
    }

    else if (cmd.ToLower().StartsWith("task bin"))
    {
        Console.WriteLine("--- Bin ---");
        ShowList(bin);
    }

    else if (cmd.ToLower().StartsWith("task exit"))
    {
        Console.WriteLine("The program has been finished");
    }
    else
    {
        string[] parts = cmd.Split(" ");
        if (parts.Length != 3)
        {
            Console.WriteLine("invalid ubeysya");
        }

        if (parts[2] != "done")
        {
            Console.WriteLine("invalid ubeysya2");
        }
        int number = int.Parse(parts[1]);
        bin.Add(tasks[number - 1]);
        tasks.RemoveAt(number - 1);
        Console.WriteLine("deleted");
    }
}

void HandleNoteCommands(string cmd)
{
    if (cmd.ToLower().StartsWith("note add"))
    {
        string description = cmd.Substring(8);
        notes.Add(description);
        Console.WriteLine($"note added: {description}");
    }

    else if (cmd.ToLower().StartsWith("note list"))
    {
        Console.WriteLine("--- Notes ---");
        ShowList(notes);
    }
    else
    {
        string[] parts = cmd.Split(" ");
        if (parts.Length != 3)
        {
            Console.WriteLine("invalid ubeysya4");
        }

        if (parts[2] != "del")
        {
            Console.WriteLine("invalid ubeysya3");
        }
        else
        {
            int number = int.Parse(parts[1]);
            notes.RemoveAt(number - 1);
            Console.WriteLine("deleted");
        }
    }
}

while (true)
{
    string? userCmd = Console.ReadLine();

    if (string.IsNullOrEmpty(userCmd))
    {
        Console.WriteLine("Porada dnya: ubeysya");
        continue;
    }

    if (userCmd.ToLower().StartsWith("task"))
    {
        HandleTaskCommands(userCmd);
    }
    else if (userCmd.ToLower().StartsWith("note"))
    {
        HandleNoteCommands(userCmd);
    }
    else
    {
        Console.WriteLine("No such command =(");
    }

}

// OOP
// object

// object
// class User
// {
//     public string Name; // field
//     public int Age; // field
//     public bool IsAdmin; // field
//     public User(string name, int age, bool isAdmin)
//     {
//         Name = name;
//         Age = age;
//         IsAdmin = isAdmin;
//     }
// }

// OOP - Object Oriented Programming

// string name = "John";
// int age = 18;
// bool isAdmin = true;
// string[] friends = { "John", "Jack", "Max" };

// Phone
// id, brand, price, name, size, color, -> fields
// call, play games, switch off / on ->  methods (actions)




User user = new User();
