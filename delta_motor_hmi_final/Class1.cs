using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EtherCat
{
    class Motor
    {
        public static ushort[] Cardnum = new ushort[1] { 0 };

        public static ushort[] Driver = new ushort[4] { 0, 1, 2, 3 }; //0 
        public static ushort[] motor = new ushort[4] { 0, 0, 0, 0 }; //0-2 三軸 3 中間軸
        //====
        public static string[] Monitor = new string[4];
    }

    class parameter 
    {
        public static  int ratio = 13889;//學長ratio是13889
    
    }

}
