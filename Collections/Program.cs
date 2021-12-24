// See https://aka.ms/new-console-template for more information

//string[] isimler = new string[] { "Cem", "Engin", "Murat", "Kerem", "Halil" };

//Console.WriteLine(isimler[0]);
//Console.WriteLine(isimler[1]);
//Console.WriteLine(isimler[2]);
//Console.WriteLine(isimler[3]);
//Console.WriteLine(isimler[4]);
//isimler = new string[6];
//isimler[5] = "İlker";
//Console.WriteLine(isimler[5]);
//Console.WriteLine(isimler[0]);

//Generic yapılar esnek oldukları için sonradan değer aldığında genişler. Arrayler genişlemez.
List<string> isimler2 = new List<string> { "Cem", "Engin", "Murat", "Kerem", "Halil" };

foreach (var isim in isimler2)
{
    Console.WriteLine(isim);
}

isimler2.Add("İlker");
Console.WriteLine(isimler2[5]);
Console.WriteLine(isimler2[0]);
