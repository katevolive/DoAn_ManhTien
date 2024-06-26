namespace MessageQueue.RabbitMQHandler
{
    public class RabbitMqConfiguration
    {
        public string Hostname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string QueueName { get; set; }
        public string QueueNotification { get; set; }
        public int Port { get; set; }

    }
}
