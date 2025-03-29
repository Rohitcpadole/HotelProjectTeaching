using System;

namespace HotelProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Do While Loop
            ///It execute do block first and then check the condition in while loop
            ///Syntax:
            ///do{
            ///  Statement1;
            ///  Statement2;
            ///  Statement3;
            ///  }while(condition);
            char choice;
            do
            {
                int category, order, quanity, amount = 0;
                Console.WriteLine("------------MY HOTEL------------");
                Console.WriteLine("-----------Order Menu-----------");
                Console.WriteLine("1. Tea");
                Console.WriteLine("2. Coffee");
                Console.WriteLine("3. Samosa");
                Console.WriteLine("4. Dosa");
                Console.WriteLine("5. Maggie");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Please Select Your Category");
                category = Convert.ToInt32(Console.ReadLine());
                switch (category)
                {
                    case 1:
                        Console.WriteLine("101---->Simple Tea = 10Rs - Full");
                        Console.WriteLine("102---->Masala Tea = 15Rs - Full");
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Please Select Your Order");
                        order = Convert.ToInt32(Console.ReadLine());
                        switch (order)
                        {
                            case 101:
                                Console.WriteLine("Please Enter Quanity");
                                Console.WriteLine("--------------------------------");
                                quanity = Convert.ToInt32(Console.ReadLine());
                                amount = quanity * 10;
                                break;
                            case 102:
                                Console.WriteLine("Please Enter Quanity");
                                Console.WriteLine("--------------------------------");
                                quanity = Convert.ToInt32(Console.ReadLine());
                                amount = quanity * 15;
                                break;
                            default:
                                Console.WriteLine("Please Enter Correct Order");
                                Console.WriteLine("--------------------------------");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("201---->Cappachino = 20Rs - Full");
                        Console.WriteLine("202---->Lato = 25Rs - Full");
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Please Select Your Order");
                        order = Convert.ToInt32(Console.ReadLine());
                        switch (order)
                        {
                            case 201:
                                Console.WriteLine("Please Enter Quanity");
                                Console.WriteLine("--------------------------------");
                                quanity = Convert.ToInt32(Console.ReadLine());
                                amount = quanity * 20;
                                break;
                            case 202:
                                Console.WriteLine("Please Enter Quanity");
                                Console.WriteLine("--------------------------------");
                                quanity = Convert.ToInt32(Console.ReadLine());
                                amount = quanity * 25;
                                break;
                            default:
                                Console.WriteLine("Please Enter Correct Order");
                                Console.WriteLine("--------------------------------");
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("301---->Sambhar Samosa = 50Rs - Full");
                        Console.WriteLine("302---->Dahi Samosa = 70Rs - Full");
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Please Select Your Order");
                        order = Convert.ToInt32(Console.ReadLine());
                        switch (order)
                        {
                            case 301:
                                Console.WriteLine("Please Enter Quanity");
                                Console.WriteLine("--------------------------------");
                                quanity = Convert.ToInt32(Console.ReadLine());
                                amount = quanity * 50;
                                break;
                            case 302:
                                Console.WriteLine("Please Enter Quanity");
                                Console.WriteLine("--------------------------------");
                                quanity = Convert.ToInt32(Console.ReadLine());
                                amount = quanity * 70;
                                break;
                            default:
                                Console.WriteLine("Please Enter Correct Order");
                                Console.WriteLine("--------------------------------");
                                break;
                        }
                        break;
                }
                Console.WriteLine("Your Bill:" + amount);
                Console.WriteLine("Do you want to continue");
                Console.WriteLine("Yes : Y Or No : N");
                choice = Convert.ToChar(Console.ReadLine());
            } while (choice == 'Y');
        }
    }
}
