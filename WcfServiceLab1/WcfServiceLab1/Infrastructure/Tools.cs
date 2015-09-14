using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceLab1.Infrastructure
{
    public class Tools
    {
        public static int RandomNumber(int end)
        {
            var rand = new Random();
            return rand.Next(0, end);
        }
    }
}