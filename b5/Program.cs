using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b5
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu()
        {
            QuanLyCD quanLyCD = new QuanLyCD();

            int chon = 0;
            do
            {
                Console.Write("--------------moi ban an so--------------");
              
                chon = int.Parse(Console.ReadLine());
                Console.WriteLine(" 2 : them cd");
                Console.WriteLine(" 3 : tinh gtb");
                Console.WriteLine(" 4 : sxgd theo gia thanh");
                Console.WriteLine(" 5 : sxtd theo tua CD");
                Console.WriteLine(" 6 : xuat danh sach");
                Console.WriteLine(" 0 : thoat");
                switch(chon)
                {
                    case 2:
                        CD cd = new CD();
                        Console.WriteLine("mơi ban nhap ma cd: ");
                        cd.Macd = int.Parse(Console.ReadLine());
                        Console.WriteLine("mơi ban nhap tua cd: ");
                        cd.Tuacd = Console.ReadLine();
                        Console.WriteLine("mơi ban nhap ca sy: ");
                        cd.Casy =Console.ReadLine();
                        Console.WriteLine("mơi ban nhap so bai hat: ");
                        cd.Sobaihat = int.Parse(Console.ReadLine());
                        Console.WriteLine("mơi ban nhap don gia: ");
                        cd.dongia= int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        double kq = quanLyCD.tinhgiatritrungbinh();
                        Console.WriteLine("gia tri trung binh la");

                        break;
                    case 4:
                        quanLyCD.sxgtheogiathanh();
                        Console.WriteLine("đa sap sep");
                        break;
                    case 5:
                        quanLyCD.sxttheotuacd();
                        Console.WriteLine("đa sap sep");
                        break;
                    case 6:
                        quanLyCD.xuat();
                        break;
                    case 0:
                        
                        break;


                }    
            }
            while (chon <= 6);
        }
    }
}
