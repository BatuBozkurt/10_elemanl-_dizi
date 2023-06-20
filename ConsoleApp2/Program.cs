//10 elamanlı bir tamsayı diziyi klavyeden
 // doldurup eleman toplamı
 // ve ortalamasını yazdırın

int toplam= 0;
int[] dizi = new int[10];
for (int i = 0; i < dizi.Length; i++)
{
    //Console.Write(i + 1 + ". sayıyı gir: ");
    Console.Write("{0}. sayıyı gir:", i + 1);

    dizi[i] = int.Parse(Console.ReadLine());
    toplam += dizi[i];
}
Console.WriteLine("Eleman Toplamı=" + toplam);
Console.WriteLine("Dizi Ortalaması=" + (double)toplam / dizi.Length);

Console.ReadKey();
