using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone iphone = new Iphone("15276152", "17", "67125", 64);
iphone.Ligar(); 
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");

Smartphone tijolao = new Nokia("172653232", "tijolao", "16725712", 32);
tijolao.Ligar();
tijolao.ReceberLigacao();
tijolao.InstalarAplicativo("Jogo da cobrinha");