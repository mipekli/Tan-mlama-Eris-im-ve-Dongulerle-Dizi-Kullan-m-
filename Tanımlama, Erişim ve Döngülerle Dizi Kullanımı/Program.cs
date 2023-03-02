//Dizi Tanımlama
string[] renkler = new string [6];
string[] hayvanlar = {"kedi","köpek","kuş","maymun"};
int[] dizi;
dizi = new int[5];

//dizilere değer atama ve erişim
renkler[0] ="mavi";
Console.WriteLine(renkler[1]);

dizi[3] = 10;


Console.WriteLine(hayvanlar[1]);
Console.WriteLine(dizi[3]);
Console.WriteLine(renkler[0]);

//Dongülerle dizi kullanımı
// Klavyeden girilen n tane sayının ortalamısnı hesaplayan program.
Console.WriteLine("Lütfen Dizinin Eleman Sayısını giriniz:");
int diziUzunulugu = int.Parse(Console.ReadLine());
int[] sayiDizisi = new int[diziUzunulugu];

for (int i = 0; i < diziUzunulugu; i++)
{
    Console.WriteLine("Lütfen {0}. sayısı giriniz:",i+1);
    sayiDizisi[i] = Int32.Parse(Console.ReadLine());
}

int toplam = 0;
foreach (var sayi in sayiDizisi)
{
    toplam += sayi;
    Console.WriteLine("Ortalama:" + toplam / diziUzunulugu);
}
