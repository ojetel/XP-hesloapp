using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    internal class Hesloapp
    {
        public static string heslo = "";

        public static bool ObsahujeRPR(string heslo)
        {
            return heslo.Contains("RPR");
        }
        public static bool JeDlouhe(string heslo)
        {
            if (heslo.Length >= 8 && heslo.Length <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool JeNeprazdne(string heslo)
        {
            if(heslo.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
