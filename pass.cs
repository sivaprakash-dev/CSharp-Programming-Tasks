using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class
    {
        public static void UserId(string id)
        {
            Console.WriteLine("User Id :" + id);
        }
        public void UserPass(int pass)
        {
            Console.WriteLine("User Password :" + pass);

            second.UserEmail("samyd1709@gmail.com");

            second e = new second();
            e.UserPhone(9786216760);
        }

        class second
        {
            public static void UserEmail(string email)
            {
                Console.WriteLine("User Email :" + email);
            }

            public void UserPhone(long phone)
            {
                Console.WriteLine("User Phone :" + phone);

                third p = new third();
                p.UserPinCode(606201);
            }

            class third
            {
                public static void UserAddress(string address)
                {
                    Console.WriteLine("User Address :" + address);

                    Class.UserId("C22UG132");

                    Class p = new Class();
                    p.UserPass(2005);
                }

                public void UserPinCode(int pin)
                {
                    Console.WriteLine("User PinCode :" + pin);
                }
            }

            static void Main()
            {
                third.UserAddress("Chennai");

            }

        }

    }
}
