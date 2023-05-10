using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test1.Model1;
using Test1.ModelContainer2;

namespace Test1.Control3
{
    public class Control_Combat
    {

        public CharactorInstance ci;
        public AttackManager am;

        public Control_Combat()
        {
            ci = new CharactorInstance(); // 캐릭터가 잇음.      ci.전사들[이름], ci.마법사들[이름]
            am = new AttackManager();      // 공격 모션 처리 함수 am.공격계산
        }



        public void Perform(string 때리는놈) // 평가
        {
            try
            {

                if (ci.전사들.ContainsKey(때리는놈))
                {
                    am.공격계산(ci.전사들[때리는놈], ci.마법사들["밍법사"]);
                }
                else if (ci.마법사들.ContainsKey(때리는놈))
                {
                    am.공격계산(ci.마법사들[때리는놈], ci.마법사들["밍법사"]);
                }
                else
                {
                    throw new Exception();
                    // 아직 정의가 안된 동작
                }
            } 
            catch (Exception e)
            {
                // 로그 남김. 파일을 열어서 거기다가 메시지 적는거
            }



        }



        

    }
}
