using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{

    // 

    public class 마법사
    {
        public int HP;
        public int MP;
        public int ATK;

        public 마법사(int hP, int mP)
        {
            HP = hP;
            MP = mP;
            ATK = 10;
        }

        public void 공격(전사 공격받은놈)
        {
            공격받은놈.HP = 공격받은놈.HP - ATK;
        }

        public void 공격(마법사 공격받은놈)
        {
            공격받은놈.HP = 공격받은놈.HP - ATK;
        }


    }
}
