using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class 전사
    {
        public string Name;
        public int HP;
        public int MP;
        public int ATK; // 데미지

        // 초기 세팅, 만들때 1번 실행되는 설정
        // HP 설정을 해주고 싶음

        public 전사(int h, int m)
        {
            HP = h;
            MP = m;
            ATK = 10;
        }

        public void 공격(전사 공격받은놈) // 오버로딩
        {
            공격받은놈.HP = 공격받은놈.HP - ATK;
        }

        public void 공격(마법사 공격받은놈 ) // 오버로딩
        {
            공격받은놈.HP = 공격받은놈.HP - ATK;
        }


    }
}
