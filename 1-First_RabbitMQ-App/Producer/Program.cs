using System;
using System.Text;
using RabbitMQ.Client;
using System.Text.Json;
using System.Text.Json.Serialization;

var factory = new ConnectionFactory{HostName = "localhost"};

using var connection = factory.CreateConnection();

using var channel = connection.CreateModel();

channel.QueueDeclare(
    queue: "letterbox",
    durable: false,
    exclusive: false,
    autoDelete: false,
    arguments: null
);

var message = "This is my first message";

var encodeMessage = Encoding.UTF8.GetBytes(message);

channel.BasicPublish("","letterbox", null, encodeMessage);

Console.WriteLine($"Published Message : {message}");

Console.ReadKey();
