namespace MessageQueue.RabbitMQHandler
{
    public interface IMessageQueueSender
    {
        void SendMessageQueue<T>  (T message) where T: class;
        void SendNotificationMessageQueue<T>(T message) where T : class;
    }
}
