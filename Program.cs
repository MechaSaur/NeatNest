using System.IO;
// Program created by MechaSaur
void main()
{
    bool run = true;
    string answer;
    // Run program while run is true
    do
    {
        Console.WriteLine(
        "1. Create File\n" +
        "2. Check Files in Directory\n" +
        "3. Delete Files\n" +
        "4. Exit\n" +
        "Input: ");
        answer = Console.ReadLine();
        // Make sure input is not empty 
        while(string.IsNullOrEmpty(answer))
        {
            Console.WriteLine("Your input can not be blank\n");
            answer = Console.ReadLine();
        }
        // Convert user string into a number
        int userNumber = Convert.ToInt32(answer);
        switch(userNumber)
        {
            case 1:
                CreateFiles();
                break;
            case 2:
                GetAllFiles();
                break;
            case 3:
                DeleteFiles();
                break;
            case 4:
                // Terminate program
                run = false;
                break;
        }

    } while (run);
}
main();

void CreateFiles()
{
    string Dir;
    string fileName;
    Console.WriteLine("Which of the following directories do you want to create your file in?\n" +
        "1. Desktop Folder\n" +
        "2. Programs Folder\n" +
        "3. My Documents\n" +
        "4. My Music\n" +
        "5. My Videos\n" +
        "6. My Computer\n" +
        "Input: ");
    // Getting and handling user input
    string userDirectory = Console.ReadLine();
    int userInt = Convert.ToInt32(userDirectory);
    // If Statements 
    while(userDirectory == null)
    {
        Console.WriteLine("Input can not be empty\n");
        userDirectory = Console.ReadLine();
    }
    switch(userInt)
    {
        // Desktop folder
        case 1:
            // Enter the desktop directory 
            Dir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Console.WriteLine("What do you want to name the file?\n");
            fileName = ($"{Console.ReadLine()}.txt");
            // Combine directory and file 
            string combinePath = Path.Combine(Dir, fileName);
            if (!File.Exists(combinePath))
            {
                File.Create(combinePath).Close();
                Console.WriteLine($"File has been created in {Dir}");
            }
            break;
        case 2:
            Dir = Environment.GetFolderPath(Environment.SpecialFolder.Programs);
            Console.WriteLine("What do you want to name the file?\n");
            fileName = ($"{Console.ReadLine()}.txt");
            combinePath = Path.Combine(Dir, fileName);
            if (!File.Exists(combinePath)) 
            {
                File.Create(combinePath).Close();
                Console.WriteLine($"File has been created in {Dir}");
            }
            break;
        case 3:
            Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Console.WriteLine("What do you want to name the file?\n");
            fileName = ($"{Console.ReadLine()}.txt");
            combinePath = Path.Combine(Dir, fileName);
            if (!File.Exists(combinePath))
            {
                File.Create(combinePath).Close();
                Console.WriteLine($"File has been created in {Dir}");
            }
            break;
        case 4:
            Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            Console.WriteLine("What do you want to name the file?\n");
            fileName = ($"{Console.ReadLine()}.txt");
            combinePath = Path.Combine(Dir, fileName);
            if (!File.Exists(combinePath))
            {
                File.Create(combinePath).Close();
                Console.WriteLine($"File has been created in {Dir}");
            }
            break;
        case 5:
            Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            Console.WriteLine("What do you want to name the file?\n");
            fileName = ($"{Console.ReadLine()}.txt");
            combinePath = Path.Combine(Dir, fileName);
            if (!File.Exists(combinePath))
            {
                File.Create(combinePath).Close();
                Console.WriteLine($"File has been created in {Dir}");
            }
            break;
        case 6:
            Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            Console.WriteLine("What do you want to name the file?\n");
            fileName = ($"{Console.ReadLine()}.txt");
            combinePath = Path.Combine(Dir, fileName);
            if (!File.Exists(combinePath))
            {
                File.Create(combinePath).Close();
                Console.WriteLine($"File has been created in {Dir}");
            }
            break;
       
    }
}

void GetAllFiles()
{
    string answer;
    string dir;
    string[] Files;
    Console.WriteLine("What directory do you want to get the list of files from?\n" +
        "1. Desktop Folder\n" +
        "2. Programs Folder\n" +
        "3. My Documents\n" +
        "4. My Music\n" +
        "5. My Videos\n" +
        "6. My Computer\n" +
        "Input: ");
    answer = Console.ReadLine();
    while(string.IsNullOrEmpty(answer))
    {
        Console.WriteLine("your input can not be blank\n");
        answer = Console.ReadLine();
    }
    // Convert answer to number for easier switch statements 
    int userNumber = Convert.ToInt32(answer);
    switch(userNumber)
    {
        case 1:
            dir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Files = Directory.GetFiles(dir);
            foreach(string file in Files)
            {
                Console.WriteLine(file);
            }
            break;
        case 2:
            dir = Environment.GetFolderPath(Environment.SpecialFolder.Programs);
            Files = Directory.GetFiles(dir);
            foreach (string file in Files)
            {
                Console.WriteLine(file);
            }
            break;
        case 3:
            dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Files = Directory.GetFiles(dir);
            foreach (string file in Files)
            {
                Console.WriteLine(file);
            }
            break;
        case 4:
            dir = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            Files = Directory.GetFiles(dir);
            foreach (string file in Files)
            {
                Console.WriteLine(file);
            }
            break;
        case 5:
            dir = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            Files = Directory.GetFiles(dir);
            foreach (string file in Files)
            {
                Console.WriteLine(file);
            }
            break;
        case 6:
            dir = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            Files = Directory.GetFiles(dir);
            foreach (string file in Files)
            {
                Console.WriteLine(file);
            }
            break;
    }
}

void DeleteFiles()
{
    string answer;
    string dir;
    string[] GetFiles;
    int numberAnswer;
    Console.WriteLine("What directory do you want to enter and delete ALL files from?\n" +
        "1. Desktop Folder\n" +
        "2. Programs Folder\n" +
        "3. My Documents\n" +
        "4. My Music\n" +
        "5. My Video\n" +
        "6. My Computer\n" +
        "Input: ");
    answer = Console.ReadLine();
    while(string.IsNullOrEmpty(answer))
    {
        Console.WriteLine("Your input can not be blank\n");
        answer = Console.ReadLine();
    }
    // Convert user input into number
    numberAnswer = Convert.ToInt32(answer);
    // Switch Statement
    switch(numberAnswer)
    {
        case 1:
            dir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            GetFiles = Directory.GetFiles(dir);
            foreach(string f in GetFiles)
            {
                File.Delete(f);
            }
            break;
        case 2:
            dir = Environment.GetFolderPath(Environment.SpecialFolder.Programs);
            GetFiles = Directory.GetFiles(dir);
            foreach (string f in GetFiles)
            {
                File.Delete(f);
            }
            break;
        case 3:
            dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            GetFiles = Directory.GetFiles(dir);
            foreach (string f in GetFiles)
            {
                File.Delete(f);
            }
            break;
        case 4:
            dir = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            GetFiles = Directory.GetFiles(dir);
            foreach (string f in GetFiles)
            {
                File.Delete(f);
            }
            break;
        case 5:
            dir = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            GetFiles = Directory.GetFiles(dir);
            foreach (string f in GetFiles)
            {
                File.Delete(f);
            }
            break;
        case 6:
            dir = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            GetFiles = Directory.GetFiles(dir);
            foreach (string f in GetFiles)
            {
                File.Delete(f);
            }
            break;
    }
}

