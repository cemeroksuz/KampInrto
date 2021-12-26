// See https://aka.ms/new-console-template for more information

using Oop3;

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();
IKrediManager esnafKrediManager = new EsnafKredisiManager();


ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();
ILoggerService smsLoggerService = new SmsLoggerService();

List<ILoggerService> loggers = new List<ILoggerService>() { new DatabaseLoggerService() , new FileLoggerService()};

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(esnafKrediManager, loggers);

List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };


//basvuruManager.KrediOnBilgilendirmesiYap(krediler);
