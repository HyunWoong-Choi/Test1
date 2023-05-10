using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test1.Model1;

namespace Test1.ModelContainer2
{
    public class AttackManager
    {
        public void 공격계산(전사 때린놈, 전사 맞은놈)
        {
            맞은놈.HP = 맞은놈.HP - 때린놈.ATK;
        }

        public void 공격계산(전사 때린놈, 마법사 맞은놈)
        {
            맞은놈.HP = 맞은놈.HP - 때린놈.ATK;
        }

        public void 공격계산(마법사 때린놈, 전사 맞은놈)
        {
            맞은놈.HP = 맞은놈.HP - 때린놈.ATK;
        }

        public void 공격계산(마법사 때린놈, 마법사 맞은놈)
        {
            맞은놈.HP = 맞은놈.HP - 때린놈.ATK;
        }
    }
}
