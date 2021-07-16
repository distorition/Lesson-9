using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9
{
    class Program 
    {
        static void Main(string[] args)
        {


            int count = 0;
            string NamePath = "D:\\f";
            string[] AllMenu = Directory.GetFileSystemEntries(NamePath, "*", SearchOption.TopDirectoryOnly);
            for (int i = 0; i < AllMenu.Length; i++)
            {
                Console.WriteLine($"{count++} : {AllMenu[i]}");


            }

            count = FirstList( AllMenu);

        }

        private static int FirstList( string[] AllMenu)//при помощи этого метода мы зациклили первые папки  
        {
            int count = 0;
            int num = NewNum();
            string newpath = AllMenu[num];

            string[] newAllmenu = Directory.GetFileSystemEntries(newpath, "*", SearchOption.TopDirectoryOnly);
            for (int i = 0; i < newAllmenu.Length; i++)
            {
                Console.WriteLine($"{count++} : {newAllmenu[i]}");


            }
        
            SecondList(newAllmenu);
            Console.WriteLine("след число откроет папку из первго списка");
            FirstList(AllMenu);
           
            return count;
        }

        private static void SecondList(string[] newAllmenu)
        {
            int count1 = 0;
            int contin = NewNum();
            string againPath = newAllmenu[contin];
            string[] againMenu = Directory.GetFileSystemEntries(againPath, "*", SearchOption.TopDirectoryOnly);
            for (int i = 0; i < againMenu.Length; i++)
            {
                Console.WriteLine($"{count1++} : {againMenu[i]}");


            }
        }

        private static int NewNum()
        {
            Console.WriteLine("для просмотра папки ввидите число");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }
    }
}
