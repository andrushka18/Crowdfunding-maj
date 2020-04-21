using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrowdfundingAPI
{
    public class Program
    {
        public static void Main (string [] args)
        {
            Services.DroitService s = new Services.DroitService();
            var T = s.Get();
            foreach(var m in T)
            {
                Console.WriteLine(m.IdDroit);
                Console.ReadLine();
            }
        }
    }
}