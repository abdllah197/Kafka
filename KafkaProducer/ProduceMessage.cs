using Confluent.Kafka;
namespace Kafka
{
    public class ProduceMessage
    {
        public async Task CreateMessage()
        {
            var config = new ProducerConfig
            {
                BootstrapServers = "localhost:9092",
                ClientId = "my-app",
                BrokerAddressFamily = BrokerAddressFamily.Any,
            };

            using var producer = new ProducerBuilder<Null, string>(config).Build();

            Console.WriteLine("Please enter the message you want to send");
            var input = Console.ReadLine();

            var message = new Message<Null, string>
            {
                Value = input
            };

            var deliveryReport = await producer.ProduceAsync("my-topic", message);
            Console.WriteLine($"Message delivered to {deliveryReport.TopicPartitionOffset}");

        }
    }
}
