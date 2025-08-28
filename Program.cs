using System.Globalization;
using DesafioPOO.Models;

Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia("123", "abc777", "111111111", 120);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("zap");


Console.WriteLine("");

Console.WriteLine("Iphone:");
Smartphone iphone = new Iphone("777", "iphone x", "333333333", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Chess");