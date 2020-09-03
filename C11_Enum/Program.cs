using System;
using System.Net.WebSockets;

namespace C11_Enum
{


    public enum Level
    {
        Low,
        Normal,
        High

    }


    class Program
    {

        enum Status
        {
            Pending,
            Production,
            Transporting,
            Delivered

        }



        static void Main(string[] args)
        {
            var temperature = 32;
            var _tempLevel = Level.Normal;

            switch (temperature)
            {
                case var t when t < 10:
                    _tempLevel = Level.Low;
                    
                    break;


                case var t when t > 30:
                    _tempLevel = Level.High;
                    
                    break;

                default:
                    _tempLevel = Level.Normal;
                    
                    break;
            }

            switch (_tempLevel)
            {
                case Level.Low:
                    Console.WriteLine("Temperature is to low");
                    break;

                case Level.Normal:
                    Console.WriteLine("Temperature is normal");
                    break;

                case Level.High:
                    Console.WriteLine("Temperature is to high");
                    break;

            }


            var status = Status.Transporting;

            switch (status)
            {
                case Status.Pending:
                    Console.WriteLine("Electronic information has been received");
                    break;
                case Status.Production:
                    Console.WriteLine("Your product(s) are being prepared for shipping!");
                    break;
                case Status.Transporting:
                    Console.WriteLine("Your product(s) are in transit.");
                    break;
                case Status.Delivered:
                    Console.WriteLine("Your product(s) has been delivered.");
                    break;
                default:
                    break;
            }

        }
    }
}
