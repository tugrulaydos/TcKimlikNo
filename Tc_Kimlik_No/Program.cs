using System;
using System.Security.Cryptography.X509Certificates;

namespace Tc_Kimlik_No
{
   
    public class Program
    {
        public static bool TCKimlikNoDogrula(string tcKimlikNo)
        {
           

            int ilk_On_Rakam = 0;  //ilk 10 rakam toplamını bu değişkene atayacağız.           

            if (tcKimlikNo[0] != '0' && tcKimlikNo.Length == 11)  //11 rakamlı ve ilk elemanı 0 değilse buraya girecek aksi taktirde 30.satır çalışacak
            {
                for(int i = 0; i < tcKimlikNo.Length-1; i++)
                {  
                    
                    ilk_On_Rakam += (int)tcKimlikNo[i] - 48; //0'ın ASCII karşılığı 48 -- char'dan int'e dönüşüm 
                }

                if (ilk_On_Rakam % 10 == (int)tcKimlikNo[10] - 48) //Birler Basamağı 11. rakama eşit ise true döner aksi halde 30.satır çalışacak
                {
                    return true;
                }                

            }
            return false;

        }
        static void Main(string[] args)
        {
            Console.Write("Tc Kimlik Numarasını Giriniz:");
            string Tc = Console.ReadLine();

            Console.Write(TCKimlikNoDogrula(Tc) ? "Tc Geçerli":"Tc Geçersiz");

            Console.ReadLine();
            
           
        }
    }
}
