// See https://aka.ms/new-console-template for more information
class Program
    {
        static void Main(string[] args)
        {
         string[] renkler= new string [5];
         string[] hayvanlar= {"kedi","köpek","fare","maymun","papağan"};
         int[] dizi= new int[5];
         renkler[0]= "mavi";
         dizi[3]= 10;

         Console.WriteLine(renkler[0]);
         Console.WriteLine(hayvanlar[2]);
         Console.WriteLine(dizi[3]);


         Console.Write("Lütfen dizi uzunluğunu giriniz:");
         int diziUzunluğu= int.Parse(Console.ReadLine());
         int[] sayıDizisi= new int[diziUzunluğu];
         for (int i = 0; i < diziUzunluğu ; i++)
         {
            Console.Write("Lütfen {0}. sayıyı giriniz:", i+1);
            sayıDizisi [i]= int.Parse(Console.ReadLine());

         }
         int toplam=0;
           foreach (var sayi in sayıDizisi)
             toplam +=sayi;

             Console.WriteLine("Ortalama:"+toplam/diziUzunluğu);
            
           
        }
    }
