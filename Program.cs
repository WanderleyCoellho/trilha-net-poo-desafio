using DesafioPOO.Models;
// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone Iphone = new Iphone(numero: "92985057697",
                               modelo: "Iphone 13",
                               imei: "123456789012345",
                               memoria: "128GB");

Console.WriteLine($"Iphone: {Iphone.Numero}, {Iphone.Modelo}, {Iphone.IMEI}, {Iphone.Memoria}");
Iphone.Ligar();
Iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Smartphone Nokia = new Nokia(numero: "92985057698",
                             modelo: "Nokia 1100",
                             imei: "987654321098765",
                             memoria: "16GB");
Console.WriteLine($"Nokia: {Nokia.Numero}, {Nokia.Modelo}, {Nokia.IMEI}, {Nokia.Memoria}");
Nokia.ReceberLigacao();
Nokia.InstalarAplicativo("WhatsApp");