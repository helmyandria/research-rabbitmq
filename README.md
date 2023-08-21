## Mechanism 1-First_RabbitMQ-App

![Alt text](https://github.com/helmyandria/Assets/blob/main/research-rabbitmq/1-First_RabbitMQ-App.jpg)

```
Consumer : create queue
Producer : send message
```

## Mechanism 2-Competing-Consumers

![Alt text](https://github.com/helmyandria/Assets/blob/main/research-rabbitmq/2-Competing_Consumers.jpg)

```
channel.BasicQos : round robin dispatching
```

## Mechanism 3-Pub-Sub
![Alt text](https://github.com/helmyandria/Assets/blob/main/research-rabbitmq/3-Pub-Sub.jpg)

```
message :
business.europe.purchases
user.europe.purchases
user.europe.payments
```

## Mechanism 4-Routing
### Direct Exchange
![Alt text](https://github.com/helmyandria/Assets/blob/main/research-rabbitmq/4-Routing-Direct_Exchange.jpg)
### Topic Exchange
![Alt text](https://github.com/helmyandria/Assets/blob/main/research-rabbitmq/4-Routing-Topic_Exchange.jpg)

## Mechanism 5-Request-Reply
![Alt text](https://github.com/helmyandria/Assets/blob/main/research-rabbitmq/5-Request-Reply.jpg)

## Mechanism 6-Other-Exchanges
### Exchange to Exhange
![Alt text](https://github.com/helmyandria/Assets/blob/main/research-rabbitmq/6-Other-Exchanges-Exhange_to_Exchange.jpg)
### Headers Exchange
![Alt text](https://github.com/helmyandria/Assets/blob/main/research-rabbitmq/6-Other-Exchanges-Headers_Exchange.jpg)
### Consistant Hashing Exchange
![Alt text](https://github.com/helmyandria/Assets/blob/main/research-rabbitmq/6-Other-Exchanges-Consistant_Hashing_Exchange.jpg)

## Mechanism 7-Exchange-Options
### Alternate Exchange
![Alt text](https://github.com/helmyandria/Assets/blob/main/research-rabbitmq/7-Exchange-Options-Alternate_Exchanges.jpg)
### DeadLetter Exchange
![Alt text](https://github.com/helmyandria/Assets/blob/main/research-rabbitmq/7-Exchange-Options-Dead_Letter_Exchange.jpg)
