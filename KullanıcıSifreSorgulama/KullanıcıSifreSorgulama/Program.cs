using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanıcıSifreSorgulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kullanıcı adı giriniz :");
            string kullanıcıadi = Console.ReadLine();

            Console.Write("Şifrenizi giriniz :");
            string sifre = Console.ReadLine();

            if (kullanıcıadi == "admin" && sifre == "123")
            {
                Console.WriteLine("Merhaba, Başarılı giriş yaptınız");
            }
            else
            {
                Console.WriteLine("Girişiniz Başarısız");
            }
            Console.ReadLine();
        }
    }
}
