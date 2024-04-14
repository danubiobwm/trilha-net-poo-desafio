using DesafioPOO.Models;

var nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 64);
var iphone = new iPhone("987654321", "iPhone 13", "012345678901234", 128);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");