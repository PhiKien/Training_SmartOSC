using Practice_1.Controller;
using Practice_1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1.View
{
    class Menu
    {
        MenuController menuController = new MenuController();
        public void menu()
        {
            bool isChoose = true;

            List<User> listUser = new List<User>();
            do
            {
                Console.WriteLine("---------------------QUAN LY SINH VIEN---------------------------");
                Console.WriteLine("1: Nhap thong tin hoc sinh!");
                Console.WriteLine("2: Hien tat ca danh sach hoc sinh!");
                Console.WriteLine("3: Hien thi nhung hoc sinh co diem trung binh tren 6!");
                Console.WriteLine("4: Lay ra danh sach cac mon hoc cua hoc sinh!");
                Console.WriteLine("5: Thoat!");
                Console.WriteLine("---------------------QUAN LY SINH VIEN---------------------------");
                Console.WriteLine("Moi ban chon so: ");
                int chonSo = menuController.nhapChonSo();
                Console.WriteLine("-----------------------------------------------------------------");
                switch (chonSo)
                {
                    case 1:
                        menuController.nhapDsHocSinh(listUser);
                        break;
                    case 2:
                        Console.Clear();
                        menuController.hienDsHocSinh(listUser);
                        break;
                    case 3:
                        Console.Clear();
                        menuController.locDsHocSinh(listUser);
                        break;
                    case 4:
                        Console.Clear();
                        menuController.layRaCacMonHoc(listUser);
                        break;
                    case 5:
                        menuController.toExit(chonSo);
                        break;
                    default:
                        break;
                }
            } while (isChoose);
        }
    }
}
