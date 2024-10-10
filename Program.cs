using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.Clear();

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456","Nokia Tijolão", "1111111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("777777","Iphone 16", "2222222222", 256);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");