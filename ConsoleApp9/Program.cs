using System;
using System.Collections.Generic;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Bilgi_yarismasi());
            Console.WriteLine(Yarismaci_bilgileri());
            Console.WriteLine("***********************************************************************");
            Console.WriteLine(Soru_cevap()); 
            Console.WriteLine(Para_hesaplama());
            Console.Read();    
            
        }
        public static List<string> Soru_cevap()
        {
  
            List <string> cevaplar = new List<string>();
            Console.WriteLine("1)Sherlock Holmes'un birçok macerasında yanında olan yakın dostu ve yardımcısı kimdir?" + "\n" + "a- Hercule Poirot" + "\n" + "b- Dr. Watson" + "\n" + "c- Müfettiş Clouseau" + "\n" + "d- Miss Marple");
            
            string Soru1_cevap = Convert.ToString(Console.ReadLine());
            cevaplar.Add(Soru1_cevap);
            if (Soru1_cevap == "B" || Soru1_cevap == "Dr.Watson" || Soru1_cevap == "b")
            {
                Console.WriteLine("Tebrikler.Doğru şıkkı bildiniz.Bunun karşılığında 1000 TL kazandınız");
                Console.WriteLine("**********************************************************************************************************");    

            }
            else
            {
                Console.WriteLine("1.) Soruyu Yanlış Bildiniz");
                Console.WriteLine("**********************************************************************************************************");
            }
            Console.WriteLine("2)Gabardin nedir?" + "\n" + "a- Bir enstrüman çeşidi" + "\n" + "b- Bir köpek cinsi" + "\n" + "c- Bir kumaş türü" + "\n" + "d- Bir saç modeli");
            string Soru2_cevap =Convert.ToString(Console.ReadLine());
            cevaplar.Add(Soru2_cevap);
             
            if (Soru2_cevap == "C" || Soru2_cevap == "Bir kumaş türü" || Soru2_cevap == "c")
            {
                Console.WriteLine("Tebrikler.Doğru şıkkı bildiniz.Bunun karşılığında 1000 TL kazandınız");
                Console.WriteLine("**********************************************************************************************************");
            }
            else
            {
                Console.WriteLine("2.) Soruyu Yanlış Bildiniz");
                Console.WriteLine("**********************************************************************************************************");
            }

            Console.WriteLine("3)İlkyaz ne demektir?"+"\n"+ "a- Sonbahar"+"\n"+"b- Kış"+"\n"+"c- İlkbahar"+"\n"+ "d- Yaz");
            string Soru3_cevap= Convert.ToString(Console.ReadLine());
            cevaplar.Add(Soru3_cevap);
            if (Soru3_cevap=="C" || Soru3_cevap == "İlkbahar" || Soru3_cevap == "c")
            {
                Console.WriteLine("Tebrikler.Doğru şıkkı bildiniz.Bunun karşılığında 1000 TL kazandınız");
                Console.WriteLine("**********************************************************************************************************");

            }
            else
            {
                Console.WriteLine("3.) Soruyu Yanlış Bildiniz");
                Console.WriteLine("**********************************************************************************************************");
            }
            Console.WriteLine("4)Aya yolculuk kitabının yazarı kimdir?"+"\n"+"a-Jules Verne"+"\n"+"b-Stefan Zweig"+"\n"+"c-Carson McCullers"+"\n"+"d-Jack London");
            string Soru4_cevap=Convert.ToString(Console.ReadLine());
            cevaplar.Add(Soru4_cevap);
            if (Soru4_cevap == "A" || Soru4_cevap == "Jules Verne" || Soru4_cevap == "a")
            {
                Console.WriteLine("Tebrikler.Doğru şıkkı bildiniz.Bunun karşılığında 1000 TL kazandınız");
                Console.WriteLine("**********************************************************************************************************");
            }
            else
            {
                Console.WriteLine("4.) Soruyu Yanlış Bildiniz");
                Console.WriteLine("**********************************************************************************************************");

            }

            return cevaplar;   
        }
        static List<string> Yarismaci_bilgileri ()
        { 
            List<string> Yarismaci = new List<string>();
            Console.Write("Adınızı giriniz:");
            string ad=Console.ReadLine();
            Yarismaci.Add(ad);  
            Console.Write("Soyadınızı giriniz:");
            string soyad=Console.ReadLine();
            Yarismaci.Add(soyad);
            Console.Write("Şehrinizi giriniz:");
            string sehir = Console.ReadLine();
            Yarismaci.Add(sehir);
            Console.Write("Yaşınızı  giriniz:");
            string Yas = Console.ReadLine();
            Yarismaci.Add(Yas);
            string bakiye = "0";
            Yarismaci.Add(bakiye);
           
            return Yarismaci;
            


        }
        public static int Para_hesaplama()
        {
            
            Console.WriteLine("Kaç doğru soru bildiniz?");
            int Dogru_cevap = Convert.ToInt32 (Console.ReadLine());
            int Para = 1000;
            int Kazanilan_para=Dogru_cevap*Para;
            Console.WriteLine("{0}TL KAZANDINIZ TEBRİKLER",Kazanilan_para);
            return Kazanilan_para;
        }
        public static string Bilgi_yarismasi()
        {
            Console.WriteLine("                                                  Bilgi Yarışmasına hoş geldiniz                                                   ");
            Console.WriteLine("                                                  ******************************                                                   ");
            Console.WriteLine("YARIŞMACI BİLGİLERİ");
            return Console.ReadLine();


        }     
    }
}
