using NotificationSystem.Services;
using NotificationSystem.Interfaces;

namespace NotificationSystem
{
    internal class Program
    {
        INotificationInteract notificationInteract;
        public Program()
        {
            notificationInteract = new NotificationService();

        }

        internal void DoCrudOperations()
        {

        }

        internal void SendNotification()
        {
            UserService userService = new UserService();

            while (true)
            {
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. Send Notification");
                Console.WriteLine("3. Do CRUD Operations");
                Console.WriteLine("4. Exit");
                int.TryParse(Console.ReadLine(), out int choice);
                switch (choice)
                {
                    case 1:
                        userService.AddUser();
                        break;
                    case 2:
                        notificationInteract.SendNotification();
                        break;
                    case 3:
                        DoCrudOperations();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            new Program().SendNotification();
        }
    }
}
