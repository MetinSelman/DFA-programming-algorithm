using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algostateprogramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // dfa çözümleri için bir iki boyutlu dizi tanımlıyoruz. bu iki boyutlu dizinin satır indisi bulunduğumuz durumu
            // sütun indisi ise gelen durumu veriyor.
            // dizinin bu i,j indisli durumunun değeri ise gideceğimiz state'in satır indisini veriyor.
            //bu şekilde diziyi tanımladıktan sonra string'i döndürerek işlemleri yapıyoruz.
           
                // DFA'nın durumları ve geçiş fonksiyonları
                // 0: q0, 1: q1, 2: q2, 3: q3, 4: q4 (kabul durumu)
                int[,] q2 = new int[5, 3];

                // Geçiş fonksiyonu tanımlanıyor
                q2[0, 0] = 1; // q0 ile a -> q1
                q2[0, 1] = 1; // q0 ile b -> q1
                q2[0, 2] = 0; // q0 ile c -> q0

                q2[1, 0] = 2; // q1 ile a -> q2
                q2[1, 1] = 2; // q1 ile b -> q2
                q2[1, 2] = 1; // q1 ile c -> q1

                q2[2, 0] = 2; // q2 ile a -> q2
                q2[2, 1] = 2; // q2 ile b -> q2
                q2[2, 2] = 3; // q2 ile c -> q3

                q2[3, 0] = 2; // q3 ile a -> q2
                q2[3, 1] = 2; // q3 ile b -> q2
                q2[3, 2] = 4; // q3 ile c -> q4

                q2[4, 0] = 4; // q4 ile a -> q4 (kabul durumu)
                q2[4, 1] = 4; // q4 ile b -> q4 (kabul durumu)
                q2[4, 2] = 4; // q4 ile c -> q4 (kabul durumu)

                // Başlangıç durumu
                int state2 = 0;

                // Test edilecek giriş dizisi
                string st2 = "xyzabccxy"; // Bu dizi giriş olarak kabul ediliyor, sizin test dizinizle değiştirin.

                // Giriş dizisini işle
                for (int i = 0; i < st2.Length; i++)
                {
                    int symbolIndex;
                    if (st2[i] == 'a')
                        symbolIndex = 0;
                    else if (st2[i] == 'b')
                        symbolIndex = 1;
                    else if (st2[i] == 'c')
                        symbolIndex = 2;
                    else
                        continue; // Diğer karakterleri göz ardı et

                    state2 = q2[state2, symbolIndex];
                }

                // Son durumda kabul durumu olup olmadığını kontrol et
                if (state2 == 4)
                    Console.WriteLine("Kabul");
                else
                    Console.WriteLine("Red");
            }
        }

    }


