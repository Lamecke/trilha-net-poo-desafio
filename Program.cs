using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("123", "n2", "1332356", 2);
Iphone iphone = new Iphone("183", "7", "2332351", 4);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("minecraft");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("minecraft");
