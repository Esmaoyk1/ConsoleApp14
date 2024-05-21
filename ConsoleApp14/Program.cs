using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta5_bilgisayarlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Lenova[] lenovalist = new Lenova[2];
            for (int i = 0; i < lenovalist.Length; i++)
            {
                lenovalist[i] = new Lenova();
            }

            Sony[] sonylist = new Sony[2];
            for (int i = 0; i < lenovalist.Length; i++)
            {
                sonylist[i] = new Sony();
            }
            Del[] dellist = new Del[2];
            for (int i = 0; i < dellist.Length; i++)
            {
                dellist[i] = new Del();
            }
            Asus[] asuslist = new Asus[2];
            for (int i = 0; i < asuslist.Length; i++)
            {
                asuslist[i] = new Asus();
            }

            lenovalist[0].Lenova_ayrıntı(1333, 3.2, 110, 85, "asus", "ssd", 9, "i5", 8, 1000);
            lenovalist[1].Lenova_ayrıntı(1400, 3.6, 120, 90, "nvidia", "ssd", 11, "i7", 12, 1500);

            sonylist[0].Sony_ayrıntı(1400, 3.8, 100, 95, "asus", "yok", 10, "i5", 8, 6.5, 950);
            sonylist[1].Sony_ayrıntı(1500, 3.6, 130, 80, "msı", "ssd", 11, "i9", 12, 8.1, 850);

            dellist[0].Del_ayrıntı(1333, 3.5, 110, 85, "nvidia", 9, "i5", 8, 7.5, 750);
            dellist[1].Del_ayrıntı(1400, 3.9, 130, 90, "asus", 9, "i3", 4, 7.8, 700);

            asuslist[0].Asus_ayrıntı(1400, 3.6, 120, 95, "asus", "ssd", 7, 8, 7.6, 550);
            asuslist[1].Asus_ayrıntı(1500, 3.2, 130, 85, "zotac", "yok", 8, 4, 8.1, 600);

            Console.WriteLine("hangi marka laptop alacaksınız");
            string marka1 = Console.ReadLine();

            if (marka1 == "lenova")
            {
                for (int i = 0; i < lenovalist.Length; i++)
                {
                    Console.WriteLine((i + 1) + "-  {0}GB ram, {1} işlemmci, {2}. nesil , {3} , {4} ekran kartı, yazma hızı {5}MB/s, okuma hızı {6}MB/s, işlemci hızı{7}GHz , veri yolu hızı {8}MHz, ekran{9} inc"
                                    , lenovalist[i].ram, lenovalist[i].islemci, lenovalist[i].nesil, lenovalist[i].disk, lenovalist[i].ekrankartı_marrkası, lenovalist[i].diskyazmahızı, lenovalist[i].diskokumahızı, lenovalist[i].islemcihızı, lenovalist[i].veriyolu_hızı, lenovalist[i].Ekran);
                }

                Console.WriteLine("kaç numaralı laptop`u seçeceksiniz");
                int seçim = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("fiyatı:" + lenovalist[seçim - 1].fiyat + " dolar");
                Console.WriteLine("ram kapasitesini artırmak istrmisiniz");
                string cevap = Console.ReadLine();
                if (cevap == "evet")
                {
                    Console.WriteLine("kaç GB artırmak istersiniz");
                    int ilaveram = Convert.ToInt32(Console.ReadLine());
                    if (ilaveram == 4)
                    {
                        int sonrakifiyat = lenovalist[seçim - 1].fiyat * 10 / 100 + (lenovalist[seçim - 1].fiyat);//4gb için lenova
                        Console.WriteLine("yeni fiyat:" + sonrakifiyat);
                    }
                    else if (ilaveram == 8)
                    {
                        int sonrakifiyat = lenovalist[seçim - 1].fiyat * 20 / 100 + (lenovalist[seçim - 1].fiyat);//8gb ram için lenova

                        Console.WriteLine("yeni fiyat:" + sonrakifiyat);

                    }
                }
                else if (cevap == "hayır")
                {
                    Console.WriteLine("alışveriş için teşekkürler");
                }
            }
            if (marka1 == "sony")
            {
                for (int i = 0; i < sonylist.Length; i++)
                {
                    Console.WriteLine((i + 1) + "-  {0}GB ram, {1} işlemmci, {2}. nesil , {3} , {4} ekran kartı, yazma hızı {5}MB/s, okuma hızı {6}MB/s, işlemci hızı{7}GHz , veri yolu hızı {8}MHz, ekran{9} inc"
                                    , sonylist[i].ram, sonylist[i].islemci, sonylist[i].nesil, sonylist[i].disk, sonylist[i].ekrankartı_marrkası, sonylist[i].diskyazmahızı, sonylist[i].diskokumahızı, sonylist[i].islemcihızı, sonylist[i].veriyolu_hızı, sonylist[i].Ekran);
                }

                Console.WriteLine("kaç numaralı laptop`u seçeceksiniz");
                int seçim = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("fiyatı:" + sonylist[seçim - 1].fiyat + " dolar");
                Console.WriteLine("ram kapasitesini artırmak istrmisiniz");
                string cevap = Console.ReadLine();
                if (cevap == "evet")
                {
                    Console.WriteLine("kaç GB artırmak istersiniz");
                    int ilaveram = Convert.ToInt32(Console.ReadLine());
                    if (ilaveram == 4)
                    {
                        int sonrakifiyat = sonylist[seçim - 1].fiyat * 8 / 100 + (sonylist[seçim - 1].fiyat);//4gb için sony
                        Console.WriteLine("yeni fiyat:" + sonrakifiyat);
                    }
                    else if (ilaveram == 8)
                    {
                        int sonrakifiyat = sonylist[seçim - 1].fiyat * 12 / 100 + (sonylist[seçim - 1].fiyat);//8gb ram için sony

                        Console.WriteLine("yeni fiyat:" + sonrakifiyat);

                    }
                }
                else if (cevap == "hayır")
                {
                    Console.WriteLine("alışveriş için teşekkürler");
                }
            }

            if (marka1 == "del")
            {
                for (int i = 0; i < dellist.Length; i++)
                {
                    Console.WriteLine((i + 1) + "-  {0}GB ram, {1} işlemmci, {2}. nesil , {3} , {4} ekran kartı, yazma hızı {5}MB/s, okuma hızı {6}MB/s, işlemci hızı{7}GHz , veri yolu hızı {8}MHz, ekran{9} inc"
                                    , dellist[i].ram, dellist[i].islemci, dellist[i].nesil, dellist[i].disk, dellist[i].ekrankartı_marrkası, dellist[i].diskyazmahızı, dellist[i].diskokumahızı, dellist[i].islemcihızı, lenovalist[i].veriyolu_hızı, dellist[i].Ekran);
                }

                Console.WriteLine("kaç numaralı laptop`u seçeceksiniz");
                int seçim = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("fiyatı:" + lenovalist[seçim - 1].fiyat + " dolar");
                Console.WriteLine("ram kapasitesini artırmak istrmisiniz");
                string cevap = Console.ReadLine();
                if (cevap == "evet")
                {
                    Console.WriteLine("kaç GB artırmak istersiniz");
                    int ilaveram = Convert.ToInt32(Console.ReadLine());
                    if (ilaveram == 4)
                    {
                        int sonrakifiyat = dellist[seçim - 1].fiyat * 5 / 100 + (dellist[seçim - 1].fiyat);//4gb için del
                        Console.WriteLine("yeni fiyat:" + sonrakifiyat);
                    }
                    else if (ilaveram == 8)
                    {
                        int sonrakifiyat = dellist[seçim - 1].fiyat * 6 / 100 + (dellist[seçim - 1].fiyat);//8gb ram için del

                        Console.WriteLine("yeni fiyat:" + sonrakifiyat);

                    }
                }
                else if (cevap == "hayır")
                {
                    Console.WriteLine("alışveriş için teşekkürler");
                }
            }
            if (marka1 == "asus")
            {
                for (int i = 0; i < asuslist.Length; i++)
                {
                    Console.WriteLine((i + 1) + "-  {0}GB ram, {1} işlemmci, {2}. nesil , {3} , {4} ekran kartı, yazma hızı {5}MB/s, okuma hızı {6}MB/s, işlemci hızı{7}GHz , veri yolu hızı {8}MHz, ekran{9} inc"
                                    , asuslist[i].ram, asuslist[i].islemci, asuslist[i].nesil, asuslist[i].disk, asuslist[i].ekrankartı_marrkası, asuslist[i].diskyazmahızı, asuslist[i].diskokumahızı, asuslist[i].islemcihızı, asuslist[i].veriyolu_hızı, asuslist[i].Ekran);
                }

                Console.WriteLine("kaç numaralı laptop`u seçeceksiniz");
                int seçim = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("fiyatı:" + asuslist[seçim - 1].fiyat + " dolar");
                Console.WriteLine("ram kapasitesini artırmak istrmisiniz");
                string cevap = Console.ReadLine();
                if (cevap == "evet")
                {
                    Console.WriteLine("kaç GB artırmak istersiniz");
                    int ilaveram = Convert.ToInt32(Console.ReadLine());
                    if (ilaveram == 4)
                    {
                        int sonrakifiyat = asuslist[seçim - 1].fiyat * 6 / 100 + (asuslist[seçim - 1].fiyat);//4gb için asus
                        Console.WriteLine("yeni fiyat:" + sonrakifiyat);
                    }
                    else if (ilaveram == 8)
                    {
                        int sonrakifiyat = asuslist[seçim - 1].fiyat * 5 / 100 + (asuslist[seçim - 1].fiyat);//8gb ram için asus

                        Console.WriteLine("yeni fiyat:" + sonrakifiyat);

                    }
                }
                else if (cevap == "hayır")
                {
                    Console.WriteLine("alışveriş için teşekkürler");
                }
            }









            Console.ReadKey();
        }
    }
    class Markalar
    {
        public int ram;
        public string islemci;
        public int nesil;
        public string disk;
        public double Ekran;
        public string name;



    }
    class Lenova : Markalar
    {
        public int veriyolu_hızı;
        public double islemcihızı;
        public int diskokumahızı;
        public int diskyazmahızı;
        public string ekrankartı_marrkası;
        public int fiyat;
        public Lenova()
        {
            name = "lenova";
            Ekran = 17.3;
        }


        public void Lenova_ayrıntı(int veriyolu_hızı, double islemcihızı, int diskokumahızı, int diskyazmahızı, string ekrankartı_marrkası, string disk, int nesil, string islemci, int ram, int fiyat)
        {
            this.veriyolu_hızı = veriyolu_hızı;
            this.islemcihızı = islemcihızı;
            this.diskokumahızı = diskokumahızı;
            this.diskyazmahızı = diskyazmahızı;
            this.ekrankartı_marrkası = ekrankartı_marrkası;
            this.disk = disk;
            this.nesil = nesil;
            this.islemci = islemci;
            this.ram = ram;
            this.fiyat = fiyat;
        }

    }
    class Sony : Markalar
    {
        public int veriyolu_hızı;
        public double islemcihızı;
        public int diskokumahızı;
        public int diskyazmahızı;
        public string ekrankartı_marrkası;
        public int fiyat;
        public double Ekran;
        public Sony()
        {
            name = "sony";

        }


        public void Sony_ayrıntı(int veriyolu_hızı, double islemcihızı, int diskokumahızı, int diskyazmahızı, string ekrankartı_marrkası, string disk, int nesil, string islemci, int ram, double Ekran, int fiyat)
        {
            this.veriyolu_hızı = veriyolu_hızı;
            this.islemcihızı = islemcihızı;
            this.diskokumahızı = diskokumahızı;
            this.diskyazmahızı = diskyazmahızı;
            this.ekrankartı_marrkası = ekrankartı_marrkası;
            this.disk = disk;
            this.nesil = nesil;
            this.islemci = islemci;
            this.ram = ram;
            this.fiyat = fiyat;
            this.Ekran = Ekran;
        }
    }
    class Del : Markalar
    {
        public int veriyolu_hızı;
        public double islemcihızı;
        public int diskokumahızı;
        public int diskyazmahızı;
        public string ekrankartı_marrkası;
        public int fiyat;
        public Del()
        {
            name = "del";
            disk = "SSD";
        }


        public void Del_ayrıntı(int veriyolu_hızı, double islemcihızı, int diskokumahızı, int diskyazmahızı, string ekrankartı_marrkası, int nesil, string islemci, int ram, double Ekran, int fiyat)
        {
            this.veriyolu_hızı = veriyolu_hızı;
            this.islemcihızı = islemcihızı;
            this.diskokumahızı = diskokumahızı;
            this.diskyazmahızı = diskyazmahızı;
            this.ekrankartı_marrkası = ekrankartı_marrkası;
            this.nesil = nesil;
            this.islemci = islemci;
            this.ram = ram;
            this.fiyat = fiyat;
            this.Ekran = Ekran;
        }

    }
    class Asus : Markalar
    {
        public int veriyolu_hızı;
        public double islemcihızı;
        public int diskokumahızı;
        public int diskyazmahızı;
        public string ekrankartı_marrkası;
        public int fiyat;
        public Asus()
        {
            name = "asus";
            islemci = "i7";
        }


        public void Asus_ayrıntı(int veriyolu_hızı, double islemcihızı, int diskokumahızı, int diskyazmahızı, string ekrankartı_marrkası, string disk, int nesil, int ram, double Ekran, int fiyat)
        {
            this.veriyolu_hızı = veriyolu_hızı;
            this.islemcihızı = islemcihızı;
            this.diskokumahızı = diskokumahızı;
            this.diskyazmahızı = diskyazmahızı;
            this.ekrankartı_marrkası = ekrankartı_marrkası;
            this.disk = disk;
            this.nesil = nesil;

            this.ram = ram;
            this.fiyat = fiyat;
            this.Ekran = Ekran;
        }

    }
}
