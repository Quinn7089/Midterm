
string file = "ticketData.txt";
string EnhancementFile = "EnhancementData.txt";
string taskFile = "taskData.txt";
ticket Ticket = new ticket();
Enhancement enhancement = new Enhancement();
Task task = new Task();
string resp;

do
{
    Console.WriteLine("1) Read Data from file.");
    Console.WriteLine("2) Create Ticket.csv");
    Console.WriteLine("3) Create Enhancement.csv");
    Console.WriteLine("4) Create Task.csv");
    Console.WriteLine("Enter any other key to exit");


    Ticket.choice = Console.ReadLine();

    
}while (Ticket.choice == "1" || Ticket.choice == "2" || Ticket.choice == "3" || Ticket.choice == "4");







public class ticket
{

    public string ticketID { get; set; }

    public string Summary { get; set; }

    public string Status { get; set; }

    public string priority { get; set; }

    public string Submitter { get; set; }

    public string assigend { get; set; }

    public string watching { get; set; }

    public string choice { get; set; }

}

public class Enhancement
{
    public string TicketID { get; set; }

    public string Summary { get; set; }

    public string Status { get; set; }

    public string Priority { get; set; }

    public string Submitter { get; set; }

    public string Assigned { get; set; }

    public string Watching { get; set; }

    public string Software { get; set; }

    public string Cost { get; set; }

    public string Reason { get; set; }

    public string Estimate { get; set; }

}

public class Task
{
    public string TicketID { get; set; }

    public string Summary { get; set; }

    public string Status { get; set; }

    public string Priority { get; set; }

    public string Submitter { get; set; }

    public string Assigned { get; set; }

    public string Watching { get; set; }

    public string Name { get; set; }

    public string DueDate { get; set; }

}