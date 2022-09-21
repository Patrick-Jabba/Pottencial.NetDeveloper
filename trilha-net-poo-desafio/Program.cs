using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("(21)9276843");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("What's App");


Iphone iphone = new Iphone("(21)9276843");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");