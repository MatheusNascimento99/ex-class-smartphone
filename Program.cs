

using Ex_Celular.Models;

Nokia celular_Nokia = new(numero: "123456789", modelo: "Tijolão", imei:"FGRSAK452268AS", memoria: 128);
celular_Nokia.Ligar();
celular_Nokia.ReceberLigacao();
celular_Nokia.InstalarAplicativo("Whatsapp");

Iphone celular_Iphone = new(numero: "025085400", modelo: "X15", imei:"99A9AAA9AA5A4A4A", memoria: 512);
celular_Iphone.Ligar();
celular_Iphone.ReceberLigacao();
celular_Iphone.InstalarAplicativo("Telegran");