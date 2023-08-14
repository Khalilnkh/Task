using System;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            PhotoBook album1=new PhotoBook();
            Console.WriteLine(album1.GetNumberPages());
            PhotoBook album2=new PhotoBook(24);
            Console.WriteLine(album2.GetNumberPages());
            BigPhotoBook album3=new BigPhotoBook();
            Console.WriteLine(album3.GetNumberPages());
        }
    }
    public class PhotoBook
    {
        private int numPages { get; set; }

        public PhotoBook()
        {
            numPages =16;

        }
        public PhotoBook(int nump)
        {
            numPages=nump;
        }

        public int GetNumberPages()
        {
            return numPages;
        }
    }

    public class BigPhotoBook
    {
        private int numPages { get; set; }

        public BigPhotoBook()
        {
            numPages = 64;
        }
        public int GetNumberPages()
        {
            return numPages;
        }

    }




}
