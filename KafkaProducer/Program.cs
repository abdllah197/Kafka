using Kafka;
Console.WriteLine("Hello!, This is my Kafka Producer Application");
ProduceMessage produceMessage = new ProduceMessage();
while(true)
{
    produceMessage.CreateMessage().Wait();
}

