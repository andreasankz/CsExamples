using C13_Interfaces_2.Interfaces;
using C13_Interfaces_2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace C13_Interfaces_2.Helpers
{
    class SampleData
    {
        public static List<IShoppingItem> CartSampleItems()
        {
            var output = new List<IShoppingItem>();

            output.Add(new Product { Id = "1007573", Name = "Apple Airpods (2019)", Description = "Airpods med laddningssetup" });
            output.Add(new Product { Id = "1587100", Name = "Mac pro värsting (2020)", Description = "Bärbardator" });
            output.Add(new Product { Id = "1897407", Name = "Redbull exotics 33cl", Description = "33cl redbull burk" });

            output.Add(new License { Id = "1748974", Name = "Microsoft Windows 10 pro 64-bit", Description = "Program windows", NumberOfLicenses = 1 });
            output.Add(new License { Id = "1748974", Name = "Microsoft Windows 10 pro 64-bit", Description = "Program windows", NumberOfLicenses = 5 });

            return output;
        }
    }
}
