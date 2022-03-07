/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 01
**				ÖĞRENCİ ADI............: Mustafa Melih TÜFEKCİOĞLU
**				ÖĞRENCİ NUMARASI.......: B191210004
**                         DERSİN ALINDIĞI GRUP...: B Grubu 
****************************************************************************/
using System;
using System.IO;
namespace B191210004
{
    class Program
    {
        static void Main(string[] args)
        {
            int AA = 0, BA = 0, BB = 0, CB = 0, CC = 0, DC = 0, DD = 0, FD = 0, FF = 0;
        
            string dosya = @"ogrenciler.txt";
            FileStream i = new FileStream(dosya, FileMode.Open, FileAccess.Read);
            StreamReader j = new StreamReader(i);

            while (!j.EndOfStream) /* Dosyanın sonuna kadar okumaya yarıyo  */
            {
                string isim;
                int odev, vize, final;

                isim = j.ReadLine();
                odev = Convert.ToInt32(j.ReadLine().Split("=")[1]); /* "=" işaretinden sonraki ilk elamanı ödev değişkenine atamaya yarıyo */
                vize = Convert.ToInt32(j.ReadLine().Split("=")[1]); /* "=" işaretinden sonraki ilk elamanı vize değişkenine atamaya yarıyo */
                final = Convert.ToInt32(j.ReadLine().Split("=")[1]); /* "=" işaretinden sonraki ilk elamanı final değişkenine atamaya yarıyo */

                float ortalama = 0f;
                ortalama = (odev * 0.2f) + (vize * 0.3f) + (final * 0.5f);

                if (ortalama >= 90)
                    AA = AA + 1;

                else if (ortalama >= 85)
                    BA = BA + 1;

                else if (ortalama >= 80)
                    BB = BB + 1;

                else if (ortalama >= 75)
                    CB = CB + 1;

                else if (ortalama >= 65)
                    CC = CC + 1;

                else if (ortalama >= 58)
                    DC = DC + 1;

                else if (ortalama >= 50)
                    DD = DD + 1;

                else if (ortalama >= 40)
                    FD = FD + 1;

                else
                    FF = FF + 1;
            }
        
            string dosyaYaz = @"sonuclar.txt";
            FileStream fs = new FileStream(dosyaYaz, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            int kisiSayisi = AA + BA + BB + CB + CC + DC + DD + FF + FD;

            sw.WriteLine("Siniftaki Kisi Sayisi:" + kisiSayisi);
            sw.WriteLine("AA notu alan kisiler:" + AA + " " + "%" + (double)AA / kisiSayisi * 100);
            sw.WriteLine("BA notu alan kisiler:" + BA + " " + "%" + (double)BA / kisiSayisi * 100);
            sw.WriteLine("BB notu alan kisiler:" + BB + " " + "%" + (double)BB / kisiSayisi * 100);
            sw.WriteLine("CB notu alan kisiler:" + CB + " " + "%" + (double)CB / kisiSayisi * 100);
            sw.WriteLine("CC notu alan kisiler:" + CC + " " + "%" + (double)CC / kisiSayisi * 100);
            sw.WriteLine("DC notu alan kisiler:" + DC + " " + "%" + (double)DC / kisiSayisi * 100);
            sw.WriteLine("DD notu alan kisiler:" + DD + " " + "%" + (double)DD / kisiSayisi * 100);
            sw.WriteLine("FD notu alan kisiler:" + FD + " " + "%" + (double)FD / kisiSayisi * 100);
            sw.WriteLine("FF notu alan kisiler:" + FF + " " + "%" + (double)FF / kisiSayisi * 100);
            sw.Close();
            fs.Close();
        }
    }
}
