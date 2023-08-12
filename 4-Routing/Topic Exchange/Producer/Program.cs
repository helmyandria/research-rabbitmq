using System;
using System.Text;
using RabbitMQ.Client;

var factory = new ConnectionFactory{HostName = "localhost"};

using var connection = factory.CreateConnection();

using var channel = connection.CreateModel();

channel.ExchangeDeclare(exchange: "mytopicexchange", type: ExchangeType.Topic);

var userPaymentsMessage = "A european user paid for something";

var userPaymentsBody = Encoding.UTF8.GetBytes(userPaymentsMessage);

channel.BasicPublish(exchange: "mytopicexchange", routingKey: "user.europe.payments", null, userPaymentsBody);

Console.WriteLine($"Send Message : {userPaymentsMessage}");

var businessOrderMessage = "A european business ordered goods";

var businessOrderBody = Encoding.UTF8.GetBytes(businessOrderMessage);

channel.BasicPublish(exchange: "mytopicexchange", routingKey: "business.europe.order", null, businessOrderBody);

Console.WriteLine($"Send message: {businessOrderMessage}");
