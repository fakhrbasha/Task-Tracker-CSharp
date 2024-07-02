namespace Task_Tracker_project
{
    internal class Program
    {
        static string[] tasks = new string[100];
        static int taskIndex = 0;
        static void Main()
        {
            //welcome user

            // 1. add task
            // 2. Veiw all task
            // 3. mark task complete 

            // 4. remove task 
            // 5. exit
            Console.WriteLine("Welcome to my task tracker");
            Console.WriteLine("---------------");

            while (true) {
                Console.WriteLine("Enter Your Choice From 1 To 5");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. View Task");
                Console.WriteLine("3. Mark Complete");
                Console.WriteLine("4. Delete Task");
                Console.WriteLine("5. Exit");

                string userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ViewTask();
                        break;
                    case "3":
                        MarkComolete();
                        break;
                    case "4":
                        deleteTask();
                        break;
                    case "5":
                        
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter number from 1 to 5");
                        break;
                }

            }



        }
        private static void AddTask()
        {
            Console.WriteLine("Enter Task Title ");
            string taskTitle=Console.ReadLine();

            tasks[taskIndex] = taskTitle;

            Console.WriteLine("TAsk Added");

            taskIndex++;
        }
        private static void ViewTask()
        {
            Console.WriteLine(" Task List : ");

            for (int i = 0; i < taskIndex; i++)
            {
                Console.WriteLine($"{i+1}. Task title : {tasks[i]}");
            }
        }
        
        private static void MarkComolete()
        {
            Console.WriteLine("Enter Task Number : ");
            string taskNumber = Console.ReadLine();

            int taskId = Convert.ToInt32(taskNumber);

            tasks[taskId]=tasks[taskId] + " --Completed";
        }
        private static void deleteTask()
        {
            Console.WriteLine("Enter Task Number To Delete : ");
            string taskNumber = Console.ReadLine();

            int taskId = Convert.ToInt32(taskNumber);

            tasks[taskId] = string.Empty;
        }

    }
}
