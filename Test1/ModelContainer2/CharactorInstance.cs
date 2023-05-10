using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test1.Model1;

namespace Test1.ModelContainer2
{
    public class CharactorInstance
    {
        public Dictionary<string, 전사> 전사들;
        public Dictionary<string, 마법사> 마법사들;


        public CharactorInstance()
        {

            // 전사 = 클래스
            // 전사들 = 인스턴스 new 써서 생성  //  int string 변수 new를 안써도 그냥 바로 생성

            전사들 = new Dictionary<string, 전사>();
            마법사들 = new Dictionary<string, 마법사>();


            전사들.Add("융전사", new 전사(100, 50));
            전사들.Add("밍전사", new 전사(200, 10));
            전사들.Add("식전사", new 전사(150, 10));

            마법사들.Add("밍법사", new 마법사(200, 10));
            마법사들.Add("식법사", new 마법사(150, 10));
            마법사들.Add("융법사", new 마법사(200, 10));

        }


    }
}
