namespace CustomerServiceWorkflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> tickets = new Queue<string>();
            Stack<string> actions = new Stack<string>();
            string currentTicket = null;

            tickets.Enqueue("Ticket #1");
            tickets.Enqueue("Ticket #2");
            tickets.Enqueue("Ticket #3");

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Process next request");
                Console.WriteLine("2. Undo last action");
                Console.WriteLine("3. Exit");

                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        if (tickets.Count == 0)
                        {
                            Console.WriteLine("No pending requests.");
                            break;
                        }

                        currentTicket = tickets.Dequeue();
                        actions.Clear(); 

                        Console.WriteLine($"Processing {currentTicket}");

                        actions.Push("Checked issue");
                        actions.Push("Contacted customer");
                        actions.Push("Resolved issue");

                        Console.WriteLine("Actions performed on this request.");
                        break;

                    case 2:
                        if (actions.Count == 0)
                            Console.WriteLine("Nothing to undo.");
                        else
                            Console.WriteLine("Undo action: " + actions.Pop());
                        break;

                    case 3:
                        Console.WriteLine("\nExiting system.");
                        if (tickets.Count == 0)
                        {
                            Console.WriteLine("No pending requests.");
                        }
                        else
                        {
                            Console.WriteLine("Remaining requests in queue:");
                            foreach (var t in tickets)
                                Console.WriteLine(t);
                        }
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
         }
    }
}
