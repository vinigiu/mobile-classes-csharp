using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokiaMobile = new Nokia("976560220", "nokia phone", "87984654632168", 512);
Iphone iphoneMobile = new Iphone("977460118", "iphone 13", "65465132183213", 128);

Console.WriteLine($"Teste de instalação de app no Nokia:");
nokiaMobile.InstalarAplicativo("Candy Crush");

Console.WriteLine($"Teste de instalação de app no iPhone:");
iphoneMobile.InstalarAplicativo("Candy Crush");

Console.WriteLine($"Teste de efetuar ligação no Nokia:");
nokiaMobile.Ligar();

Console.WriteLine($"Teste de efetuar ligação no iPhone:");
iphoneMobile.Ligar();

Console.WriteLine($"Teste de receber ligação no Nokia:");
nokiaMobile.ReceberLigacao();

Console.WriteLine($"Teste de receber ligação no iPhone:");
iphoneMobile.ReceberLigacao();


