using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.Model1
{
    public class 전사
    {
        public int HP;
        public int MP;
        public int ATK; // 데미지


        public 전사(int h, int m)
        {
            HP = h;
            MP = m;
            ATK = 10;
        }

    }
}
