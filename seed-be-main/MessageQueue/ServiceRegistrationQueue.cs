using MessageQueue.RabbitMQHandler;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MessageQueue
{
    public static class ServiceRegistrationQueue
    {
        public static void AddServicesQueue(this IServiceCollection services, IConfiguration _config)
        {
            services.Configure<RabbitMqConfiguration>(_config.GetSection("RabbitMqConfiguration"));
            services.AddTransient<IMessageQueueSender, MessageQueueSender>();
        }
    }
}
