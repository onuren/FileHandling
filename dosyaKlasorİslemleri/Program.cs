using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace dosyaKlasorİslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //using system.IO içerisinde bulunurlar
            #region directory

            //DirectoryInfo klasor = new DirectoryInfo("C:\\Program Files");
            //klasor.Create();
            ////klasor.Delete();

            //DateTime olusturma = klasor.CreationTime;
            //Console.WriteLine(olusturma);
            //Console.WriteLine(klasor.CreationTimeUtc);
            //Console.WriteLine(klasor.FullName);//dosya yolu
            //Console.WriteLine(klasor.Exists);
            //Console.WriteLine(klasor.LastAccessTime);
            //Console.WriteLine(klasor.Name);
            //Console.WriteLine(klasor.Parent);//bir üst klasörü verir
            //Console.WriteLine(klasor.Root);//C yi verir

            //DirectoryInfo[] klasorler = klasor.GetDirectories();
            //for (int i = 0; i < klasorler.Length; i++)
            //{
            //    Console.WriteLine(klasorler[i].Name);
            //}

            //FileInfo[] dosyalar = klasor.GetFiles();
            //for (int i = 0; i < dosyalar.Length; i++)
            //{
            //    Console.WriteLine(dosyalar[i].Name);
            //}

            #endregion

            #region driveinfo

            //DriveInfo di = new DriveInfo("C:\\");
            //Console.WriteLine(di.TotalSize);
            //Console.WriteLine(di.TotalFreeSpace);
            //Console.WriteLine(di.AvailableFreeSpace);
            //Console.WriteLine(di.DriveType);
            //Console.WriteLine(di.DriveFormat);



            #endregion

            #region fileinfo

            //FileInfo fi_docx = new FileInfo("C:\\Ben Oluştum/Nikola.docx");
            //FileInfo fi_txt = new FileInfo("C:\\Ben Oluştum/Nikola.txt");

            //Console.WriteLine(fi_docx.Name);
            //Console.WriteLine(fi_txt.Name);

            //Console.WriteLine(fi_txt.Extension);
            //Console.WriteLine(fi_docx.Extension);

            //Console.WriteLine(fi_docx.IsReadOnly);
            //Console.WriteLine(fi_txt.IsReadOnly);

            //Console.WriteLine(fi_txt.DirectoryName);
            //Console.WriteLine(fi_docx.DirectoryName);

            #endregion

            #region filestream

            //FileStream fs = new FileStream("C:\\Ben Olustum/FileStream.txt", FileMode.Create);

            ////byte olarak yazar ve okur.

            #endregion

            #region streamwriter

            //StreamWriter writer = new StreamWriter("C:\\Ben Olustum / FileStream.txt",true);
            ////sonuna true eklenirse temizlemeden altına ekleyerek yazdırır.
            //writer.WriteLine("Onur Engün");
            //writer.Flush(); //kapatmadan önce yazdırır
            //writer.WriteLine("asd");
            //writer.Close();//dosyayı kapatır


            #endregion

            #region stream reader

            //StreamReader reader = new StreamReader("C:\\Ben Olustudum/nikola.txt");
            //Console.WriteLine(reader.Read());//sadece satır okur
            //Console.WriteLine(reader.Read());

            //Console.WriteLine(reader.ReadToEnd());//hepsini okur

            #endregion

            #region encoding info
            ////kodlamaların listesini gösterir
            //EncodingInfo[] kodlamalar = Encoding.GetEncodings();
            //for (int i = 0; i < kodlamalar.Length; i++)
            //{
            //    Console.WriteLine(kodlamalar[i].CodePage + " "+kodlamalar[i].Name+" "+kodlamalar[i].DisplayName);
            //}

            #endregion

            #region encoding

            //Encoding kod = Encoding.GetEncoding("windows-1254");

            //StreamReader reader = new StreamReader("C:\\Ben Olustudum/nikola.txt",kod);
            //Console.WriteLine(reader.ReadToEnd());

            #endregion
        }
    }
}
