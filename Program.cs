
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


    if (Ticket.choice == "1")
    {
        Console.WriteLine("Choose the ticket you want to view");
        Console.WriteLine("1) View Ticket");
        Console.WriteLine("2) View Enhancement");
        Console.WriteLine("3) View Task");

        resp = Console.ReadLine();


        if (resp == "1")
        {
            if (File.Exists(file))
            {

                StreamReader sr = new StreamReader(file);

                while (!sr.EndOfStream)
                {

                    string newPerson = sr.ReadLine();

                    Console.WriteLine(newPerson);

                }
                sr.Close();
            }
        }
        if (resp == "2")
        {
            if (File.Exists(EnhancementFile))
            {

                StreamReader sr = new StreamReader(EnhancementFile);

                while (!sr.EndOfStream)
                {

                    string newTicket = sr.ReadLine();

                    Console.WriteLine(newTicket);

                }
                sr.Close();
            }
        }
        if (resp == "3")
        {
            if (File.Exists(taskFile))
            {

                StreamReader sr = new StreamReader(taskFile);

                while (!sr.EndOfStream)
                {

                    string newTask = sr.ReadLine();

                    Console.WriteLine(newTask);

                }
                sr.Close();
            }



        }

    }
    if (Ticket.choice == "2")
    {
        StreamWriter sw = new StreamWriter(file);

        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine("Enter Ticket (Y/N)?");

             resp = Console.ReadLine();

            if (resp != "Y") { break; }

            Console.WriteLine("Enter Ticket ID:");

            Ticket.ticketID = Console.ReadLine();

            Console.WriteLine("Enter Summary:");

            Ticket.Summary = Console.ReadLine();

            Console.WriteLine("Enter Status:");

            Ticket.Status = Console.ReadLine();

            Console.WriteLine("Enter priority:");

            Ticket.priority = Console.ReadLine();

            Console.WriteLine("Enter Submitter:");

            Ticket.Submitter = Console.ReadLine();

            Console.WriteLine("Enter assigend:");

            Ticket.assigend = Console.ReadLine();


            Console.WriteLine("Enter watching:");

            Ticket.watching = Console.ReadLine();


            sw.WriteLine(Ticket.ticketID + ", " + Ticket.Summary + ", " + Ticket.Status + ", " + Ticket.priority + ", "
            + Ticket.Submitter + ", " + Ticket.assigend + ", " + Ticket.watching);

          }
        sw.Close();    
    }
   if (Ticket.choice == "3")
    {
      StreamWriter sw = new StreamWriter(EnhancementFile);
  
         for (int i = 0; i < 7; i++){
         
          Console.WriteLine("Enter Enhancement (Y/N)?");

             resp = Console.ReadLine();

            if (resp != "Y") { break; }


         }
        sw.Close();


    }



} while (Ticket.choice == "1" || Ticket.choice == "2" || Ticket.choice == "3" || Ticket.choice == "4");







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