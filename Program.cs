using DesafioPOO.Models;


  Console.WriteLine($"Dispositivo Nokia");
  Smartphone nokia = new Nokia(numero: "01234567890", modelo:"Lumia 1520", imei:"9985745632111", memoria:32);
  nokia.Ligar();
  nokia.InstalarAplicativo("Skype");
  nokia.ReceberLigacao();

  Console.WriteLine("\n");


  Console.WriteLine($"Dispositivo Iphone");
  Smartphone iphone = new Iphone(numero: "55369852147", modelo:"Iphone 13 Pro", imei:"5645414477888", memoria:256);
  iphone.Ligar();
  iphone.InstalarAplicativo("Whatsapp");
  iphone.ReceberLigacao();

        