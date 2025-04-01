namespace st10301625_ICE_Task_2.Models
{
    // EmailNotificationService class implements INotificationService interface
    public class EmailNotificationService : INotificationService
    {
        // Method to send an email notification with a message
        public void SendNotification(string message)
        {
            // Simulate sending an email by printing a message to the console
            Console.WriteLine($"Email sent: {message}");
        }
    }
}
