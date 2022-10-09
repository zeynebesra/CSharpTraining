using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumCSharpLearning
{
    class Program

    {

        static void Main(string[] args)
        {
            /*
             * 10 .) Değer Tipleri ( Value Types ) :
             * Değer tiplerinin tamamı Object denilen bir nesneden türemiştir. 
             * C#’da her nesne ya da veri tipi aslında Object tipidir.
             * 
             */

            //bool boolVariable = new bool();
            //byte byteVariable = new byte();
            //char charVariable = new char();
            //decimal decimalVariable = new decimal();
            //double doubleVariable = new double();
            //float floatVariable = new float();

            //Console.WriteLine(boolVariable);
            //Console.WriteLine(byteVariable);
            //Console.WriteLine(charVariable);
            //Console.WriteLine(decimalVariable);
            //Console.WriteLine(doubleVariable);
            //Console.WriteLine(floatVariable);

            //Console.ReadLine();

            /*
             * 11. Referans Tipleri ( Reference Types ) :
             * C#'ta önceden tanımlı iki referans tipi vardır Object ve String.
             * Object türü C#’ta bütün türlerin türediği sınıftır. 
             * Diğer bir deyişle Object türünden bir nesneye herhangi bir veri türünden nesneyi atayabiliriz.
             * Object’e eşleştirme (Boxing) işlemi ve tersi, Object’i dönüştürme (Unboxing).
             * 
             */

            /*
             * 12. String  :
             */

            //String path = "C:\\Windows\\assembly"; // Özel anlamlar içeren karakterleri ifade etmek için \ ifadesini kullanırız.
            //Console.WriteLine(path);

            //String path2 = @"C:\Windows\assembly"; // String içinde görülen ifadenin aynısımı belirtmek için string ifadesinin önüne @ işereti konulur.
            //Console.WriteLine(path2);

            //Console.ReadLine();


            /*
             * 13. Object ve String Veri Türü :
             * Object ve string değişkenler stack te oluşturulur değerleri heap te bulunur. 
             * Stack te ise heap adresleri saklanır.
             * 
             */

            // -- 1
            //char[] x = { 'K', 'a', 'm', 'i', 'l', };
            //string s = new string(x);
            //Console.WriteLine(s);
            //object o = 5;
            //Console.WriteLine(o);

            //Console.ReadLine();

            //-- 2

            //object x;
            //x = 10;
            //Console.WriteLine(x.GetType());
            //x = "B";
            //Console.WriteLine(x.GetType());
            //x = 8.78F;
            //Console.WriteLine(x.GetType());
            //x = false;
            //Console.WriteLine(x.GetType());
            //x = 5.489M;
            //Console.WriteLine(x.GetType());

            //Console.ReadLine();


            /*
             * 14. var Değişken Yapısı :
             * var, anahtar sözcüğünü kullanarak bir veri tanımladığımızda, atadığımız ilk değerin tipini derleyici tarafından kendine değer tipi olarak belirlemektedir.
             * 
             */

            //var vrDegisken = "string değer";
            //vrDegisken = 64; //var tipindeki değişkenimize ilk atadığımız değerin tipini kendine tip olarak belirleyecek, sonraki atamalarda da aynı tipte değer isteyecektir.
            //Console.WriteLine(vrDegisken);

            //Console.ReadLine();

            /*
             * 15. dynamic Değişken Yapısı:
             * dynamic , derleme zamanında ( compile time ) gerçekleştirilen tip kontrollerinin pas geçilerek, bu kontrollerin tamamen çalışma zamanında ( runtime ) gerçekleştirilmesidir.
             * 
             */

            //dynamic str = "Sentez Yazılım";
            //dynamic i = 2;
            //Console.WriteLine(str.GetType()); // System.String
            //Console.WriteLine(i.GetType());   // System.Int32

            //dynamic strValue = "Zeyneb ";
            //string s = strValue + "Esra";
            //Console.WriteLine(s);             // 
            //strValue = 12;
            //strValue = 4 + strValue;
            //Console.WriteLine(strValue);      // 16

            //Console.ReadLine();

            //dynamic , kullanılarak oluşturulan değişkenler,
            //çalışma zamanında kendilerine atanan değişkenleri dinamik bir şekilde çözümleyerek değişkenin tipi o an ne ise,
            //o tip için işlemleri yapmasını sağlar.

            /*
             * 
             * 16. object ve dynamic Arasındaki Farklar :
             * dynamic object gibi davranır ancak aralarındaki en büyük fark,
             * object tipine var olan tüm sınıf örnekleri atanabilse de, static tip yine System.Object’dir.
             * Uygulamada gerçek tipi kullanabilmeniz için “object” tipi cast etmeniz gerekmektedir. “dynamic”’de ise buna gerek yoktur.
             * .NET zaten runtimeda tipi otomatik olarak belirleyerek gerekli casting işlemini yapar.
             * 
             */

            //object oValue = "Zeyneb";
            //int t = ((string)oValue).Length; // unBoxing yapılıyor.

            //dynamic dValue = "Sabahattin Zaim Üniversitesi";
            //int k = dValue.Length;

            //object rakam = 10;
            ////rakam = rakam + 10; 
            ////Derleme zamanı hatası. Çünkü derleme anında Rakam değişkeni "System.Object" tipinde

            //rakam = (int)rakam + 10; //Hatasız atama için, "unboxing" yapmamız gerekiyor.

            //dynamic sayi = 5;
            //sayi = sayi + 5;

            //Console.ReadLine();


            /*
             * 17. Tür Dönüşümleri : 
             * Farklı türden değişkenlerin aynı ifade içinde işlem görmeleri için tür dönüşümü kullanılır. 
             * Tür dönüşümlerini “Bilinçli” ve “Bilinçsiz” tür dönüşümü olarak ayırmak mümkündür.
             * --- Bilniçsiz Tür Dönüşümü : Derleyici tarafından bir değişkeni tanımladığımız türün dışında geçici olarak başka bir türe çevirmeye bilinçsiz tür dönüşümü denir
             */

            // -- 1
            //int intVlaue = 5;
            //float floatValue;
            //floatValue = intVlaue;
            //Console.WriteLine(floatValue);

            //Console.ReadLine();

            /*
             * ---> Bilinçsiz yapılan tür dönüşümlerinde bir nesnenin türü asla kalıcı olarak değiştirilmez. 
             * Bilinçsiz yapılan tür dönüşümleri 2 şekilde gerçekleştirilebilir. Küçük türün büyük türe dönüştürülmesi ve Büyük türün küçük türe dönüştürlmesi.
             * -> Küçük türün büyük türe dönüştürülmesi ( Otomotik tip dönüşümü 
             * Küçük tür büyük türe dönüştürülürken fazla bitler sıfır ile doldurulur. Küçük türün yüksek anlamlı bitlerinin sıfırla beslenmesi değişkendeki değeri
             * değiştirmediği için tür dönüşümünde herhangi bir veri kaybı olmaz.
             */

            // -- 2

            //byte byteValue = 128;
            //int intValue;
            //intValue = byteValue;
            //Console.WriteLine("byteValue : {0}", byteValue); // 12
            //Console.WriteLine("intValue : {0}", intValue);   // 12

            //byte a = 20;
            //int b;
            //b = a;
            //Console.WriteLine(a); // 20
            //Console.WriteLine(b); // 20

            //float f = 20f;
            //double d = f;
            //Console.WriteLine(f); // 20
            //Console.WriteLine(d); // 20

            //char c = 'a';
            //decimal m;
            //m = c;
            //Console.WriteLine(c); // a
            //Console.WriteLine(m); // 97

            //float floatDeger = 32.32f;
            //double doubleDeger;
            //doubleDeger = floatDeger;
            //Console.WriteLine("Float'ın değeri : " + floatDeger + "\ndouble'ın değeri : " + doubleDeger);
            ///*
            // * Float'ın değeri : 32,32
            // * double'ın değeri : 32,3199996948242
            // */

            //Console.ReadLine();

            /*
             * ---> Bazı değer türleri arasında tür dönüşümü yapmak mümkün değildir. Bunlar
             *  -> Bool, decimal ve double türünden herhangi bir türe
             * -> Herhangi bir türden char türüne
             * -> Float ve decimal türünden herhangi bir türe float türünden double türüne ( dönüşüm hariç )
             * -> Büyük türün küçük türe dönüştürülmesi
             * Büyük türlerin küçük türlere otomatik dönüştürülmesi C#’da yasaklanmıştır. Eğer bu tür bir dönüştürme (bilinçsiz olarak) mümkün olsaydı birtakım veri
             * kayıpları yaşanacaktır. Ancak “()” cast operatörü ile yapılır.
             * --- Bilniçli Tür Dönüşümü : genellikle derleyicinin izin vermediği dönüşümlerde kullanılır. Bu tür dönüşümlerde de yine küçük türler büyük türe ya da tersi dönüşümler yapılabilir.
             * -> Küçük türlerin büyük türlere çevrilmesi aynı bilinçsiz dönüşümde olduğu gibidir.
             * -> Bilinçli tür dönüşümü yapılırken “tür dönüştürme operatörleri” kullanılır.
             * Tür dönüştürme operatörü parantez içinde değişken ya da sabitten önce yazılır.

             *!!Bilinçsiz yapılan tür dönüşümlerinde büyük türler, küçük türlere dönüştürülemiyordu. Eğer tür dönüştürme operatörü kullanılırsa bu işlem mümkün olur.
             *
             * (dönüştürülecekTür) degişken yada sabit
             */


            // --3
            //int a = 400;
            //byte b = (byte)a;
            //Console.WriteLine(b); // 144

            //Console.ReadLine();

            /*
             * 18. Checked ve Unchecked :
             * Tür dönüşümlerinde veri kayıplarında programa hata uyarısı verdirebilmek için checked deyimi kullanılır. 
             * Checked anahtar sözcüğü ile çalışma zamanında oluşabilecek veri kayıplarının olabileceği durumlarda hata vermesini sağlayabiliriz.
             */

            // -- 1

            //int intValue = 256;
            //byte byteValue;
            //checked
            //{
            //    byteValue = (byte)intValue; // Taşma olduğundan program hata verir.
            //}
            //Console.WriteLine(byteValue);

            //Console.ReadLine();

            // -- 2 yukarıdaki hata veriyor

            //int intValue1 = 255;
            //int intValue2 = 500;
            //byte byteValue1, byteValue2;

            //checked
            //{
            //    byteValue1 = (byte)intValue1;
            //    Console.WriteLine(byteValue1);

            //    unchecked //  çok fazla blok oluşturmamak için “unchecked” ifadesi kullanılabilir.
            //    {
            //        byteValue2 = (byte)intValue2;
            //        Console.WriteLine(byteValue2);
            //    }
            //    Console.WriteLine(byteValue2);
            //}

            //Console.ReadLine();

            /*
             * 19. Referans ve Değer Türleri Arasındaki Dönüşüm :
             * Object Türü ve ToString() Metodu : Temel veri türleri de dahil olmak üzere bütün veri tipleri object denilen bir referans türünden türemiştir.
             * Türeme, kalıtım yolu ile olduğu için var olan özellikler her zaman korunur.
             * 
             * C# herşey nesne(object) referans türünden türetilmiştir. Temelde bir sınıf vardır. 
             * Örneğin object sınıfının ToString() metodu bütün temel veri ve referans türlerinde kullanılır.
             * 
             * .ToString() metodu bütün temel türlerde ya da referans türlerde kullanılabilir. Amacı ise string’e dönüşüm işlemi yapmaktır.
             * 
             */

            //string str = 345.58f.ToString();
            //Console.WriteLine(str + " - " + str.GetType());
            //str = 56.ToString();
            //Console.WriteLine(str + " - " + str.GetType());

            //int intValue1 = 5;
            //int intValue2 = 7;
            //string strValue1 = intValue1.ToString();
            //string strValue2 = intValue2.ToString();

            //Console.WriteLine(intValue1.GetType() + " - " + strValue1.GetType());
            //Console.WriteLine(intValue2.GetType() + " - " + strValue2.GetType());

            //Console.ReadLine();

            /*
             * --- Boxing ( Değer - Referans Dönüşümü ) İşlemi : değer ve referans tipleri arasında bir dönüşüme ihtiyaç duyulduğunda “Boxing” yapılır. 
             * Bu yöntem değer tipindeki verileri “ object ” nesnesine çevirir.
             * Bir değer tipini referans tipe atadığımızda stack’teki bilgi bit olarak heap ’e kopyalanır ve stack ’teki object türünden olan değişken heap’i gösterecek şekilde ayarlanır.
             * 
             * -> Bilinçsiz “boxing” işlemi
             * int intValue = 50; // değer tipi
             * object onjValue = i; // boxing
             * 
             * -> Bilinçli “boxing” işlemi
             * int intValue = 50; // değer tipi
             * object onjValue = (object)i; // boxing
             * 
             * --- Unboxing ( Referans -Değer Dönüşümü ) İşlemi : Heap alanındaki nesnelerin değerlerinin bit olarak stack bölgesine kopyalanması işlemine “ unboxing ” adı verilir.
             * Bu işlem sonucunda “referans türler değer türüne” dönüştürülmüş olur.
             * Unboxing işlemine tabi tutulacak nesnenin daha önceden boxing işlemine tabi tutulmuş olması gerekir.
             * Unboxing işlemi bilinçsiz bir biçimde yapılmaz, mutlaka tür dönüşüm operatörü kullanılmalıdır.
             * 
             * Boxing işlemi normal bir atama işleminden 20 kat daha uzun sürmektedir. Unboxing işlemi ise yine normal bir atama işleminden 4 kat daha uzun sürmektedir. 
             * Bu yüzden gerekli olmayan aşırı boxing ve unboxing kullanımı uygulamanızı gözle görülür bir biçimde yavaşlatacaktır.
             * 
             * int i= 123;      // değer tipi
             * object o = i;    // boxing
             * int j = (int)o;  // unboxing
             * 
             */

            /*
             * 22. System.Convert İle Tür Dönüşümü :
             * .NET sınıf kütüphanesinde yer alan “Convert” sınıfı string değerleri ve temel veri türlerini birbirine çevirmek için kullanılır.
             * Her bir veri türü için ayrı bir çevrim fonksiyonuna sahiptir.
             * 
             */

            int i = 50;
            string s = "50";
            int b = Convert.ToInt32(i);
            double c = Convert.ToDouble(s);
            Console.WriteLine("b : " + b + " c: " + c); // b : 50 c: 50

            string str1, str2;
            int i1, i2, t;

            Console.Write("1. Sayıyı Giriniz : ");
            i1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. Sayıyı Giriniz : ");
            str2 = Console.ReadLine();
            i2 = Convert.ToInt32(str2);

            t = i1 + i2;

            Console.WriteLine("Toplam : " + t.ToString());

            Console.ReadLine();

        }
    }
}
