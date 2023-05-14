string folderpath = @"C:\Users\Auli\source\repos\textdoc\";
string filename = "shoppinglist.txt";
string filepath = Path.Combine(folderpath, filename);


List<string> myshoppinglist = new List<string>();
if(File.Exists(filepath))
{
    Myshoppinglist = getitemsfromuser();
    File.WriteAllLines(filepath, myshoppinglist);
}
else
{
    File.Create(filepath).Close();
    Console.WriteLine($"file {filename} file has been created");
    Myshoppinglist = getitemsfromuser();
    File.WriteAllLines(filepath, myshoppinglist);
}




static List<string> getitemsfromuser()
{
List<string> userlist= new List<string>();

while(true)
{
    Console.WriteLine("add an item (add)/ exit (exit):");
    string userchoice = Console.ReadLine();
    
    if(userchoice == "add")
    {
        Console.WriteLine("enter an item:");
        string useritem = Console.ReadLine();
        userlist.Add(useritem);  

    }
    else
    {
        Console.WriteLine("bye!");
        break;
    }
}
return MyShoppingList;

}

static void showitemsfromlist(List<string> somelist)
{
Console.Clear();

int ListLenght = somelist.Count;
Console.WriteLine($"you have added {ListLenght}items to your shopping list");

int i = 1;
foreach (string item in somelist)
{
    Console.WriteLine($"{i}.{item}");
    i++;    
}
}


