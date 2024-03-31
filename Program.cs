using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("11 99999-9999","Nokia 12", "111111111111111/11",128);
Iphone iphone = new Iphone("11 22222-2222", "Iphone 14", "222222222222222/22",256);

nokia.InstalarAplicativo("Play Store");
nokia.ReceberLigacao();
nokia.Ligar();

iphone.InstalarAplicativo("App Store");
iphone.ReceberLigacao();
nokia.Ligar();