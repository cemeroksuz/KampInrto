// See https://aka.ms/new-console-template for more information

string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
string kurs2 = "Proramlamaya Başlangıç İçin Temel Kurs";
string kurs3 = "Java";
string kurs4 = "Python";
string kurs5 = "C++";

string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Proramlamaya Başlangıç İçin Temel Kurs", "Java", "Python","C++" };

for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
} 

Console.WriteLine("----------------------");
foreach(string kurs in kurslar)
{
    Console.WriteLine(kurs);
}

Console.WriteLine("----------------------");

Console.WriteLine("Sayfa Sonu");    