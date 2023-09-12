using DesafioPOO.Models;
﻿using static System.Console;


WriteLine("Smartphone Nokia:");
var nokia = new Nokia("999999999", "NOKIA G11 PLUS", "123456789", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Dio");

WriteLine();

WriteLine("Smartphone Iphone:");
var Iphone = new Iphone("888888888", "IPHONE 14 PRO MAX ", "987654321", 228);
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Dio");
// TODO: Realizar os testes com as classes Nokia e Iphone