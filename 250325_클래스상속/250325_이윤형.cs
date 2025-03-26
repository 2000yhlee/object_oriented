using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250325_클래스상속
{
    class Trainer
    {
        private Poketmon[] poketmons = new Poketmon[6];
        private Poketmon currentPoketmon;

        public Trainer()
        {
            poketmons[0] = new Pikachu();
            poketmons[1] = new Charmander();
            poketmons[2] = new Squirtle();
            poketmons[3] = new Bulbasaur();
            poketmons[4] = new Piplup();
            poketmons[5] = new Chimchar();
        }

        public void Peak(int index)
        {
            if (index < 0 || index >= poketmons.Length)
            {
                Console.WriteLine("잘못된 숫자를 입력하셨습니다. 0~5번 사이의 숫자를 선택해 포캣몬을 소환하세요.");
            }
            else
            {
                currentPoketmon = poketmons[index];
                Console.WriteLine("{0} 을/를 선택하셨습니다.", currentPoketmon.name);
            }
        }
        public void Print()
        {
            Console.WriteLine("트레이너가 보유한 포캣몬");
            foreach (var poketmon in poketmons)
            {
                Console.WriteLine(poketmon.name);
            }
            
        }
    }

    abstract class Poketmon
    {
        public string name;
        public string skillName;
        public abstract void Skill();
    }

    class Pikachu : Poketmon
    {
        public Pikachu()
        {
            name = "피카츄";
            skillName = "백만볼트";
        }

        public override void Skill()
        {
            Console.WriteLine("{0}! {1}!!", name, skillName);
        }

    }

    class Charmander : Poketmon
    {
        public Charmander()
        {
            name = "파이리";
            skillName = "화염방사";
        }

        public override void Skill()
        {
            Console.WriteLine("{0}! {1}!!", name, skillName);
        }

    }
    class Squirtle : Poketmon
    {
        public Squirtle()
        {
            name = "꼬부기";
            skillName = "물대포";
        }

        public override void Skill()
        {
            Console.WriteLine("{0}! {1}!!", name, skillName);
        }

    }
    class Bulbasaur : Poketmon
    {
        public Bulbasaur()
        {
            name = "이상해씨";
            skillName = "씨앗뿌리기";
        }

        public override void Skill()
        {
            Console.WriteLine("{0}! {1}!!", name, skillName);
        }

    }

    class Piplup : Poketmon
    {
        public Piplup()
        {
            name = "팽도리";
            skillName = "쪼기";
        }

        public override void Skill()
        {
            Console.WriteLine("{0}! {1}!!", name, skillName);
        }

    }

    class Chimchar : Poketmon
    {
        public Chimchar()
        {
            name = "불꽃숭이";
            skillName = "바위부수기";
        }

        public override void Skill()
        {
            Console.WriteLine("{0}! {1}!!", name, skillName);
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Trainer trainer = new Trainer();
            Pikachu pikachu = new Pikachu();
            trainer.Print();
            trainer.Peak(0);
            pikachu.Skill();


        }

    }


}
