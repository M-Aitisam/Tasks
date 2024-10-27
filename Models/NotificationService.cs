namespace Project1_Lab_Simple.Models
{
   
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class NotificationService
    {
        private readonly NotificationConfig _config;

        public NotificationService(NotificationConfig config)
        {
            _config = config;
        }

        public async Task<List<string>> GetNotificationsAsync(int numberOfNotifications)
        {
            // Simulating fetching notifications
            await Task.Delay(500); // Simulate some async work
            numberOfNotifications = numberOfNotifications > 0 ? numberOfNotifications : _config.DefaultNumberOfNotifications;

            var notifications = new List<string>();
            for (int i = 1; i <= numberOfNotifications; i++)
            {
                notifications.Add($"Notification {i}");
            }
            return notifications;
        }
    }

}
