using DesafioPOO.Models;

// Implementado

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123789", modelo: "Nokia M10", imei: "115151515", memoria: 64);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatzaperson");

Console.WriteLine("Smartphone Nokia:");
Smartphone iPhone = new Iphone(numero: "1584689", modelo: "Iphone 10", imei: "2120589325", memoria: 32);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatzaperson");