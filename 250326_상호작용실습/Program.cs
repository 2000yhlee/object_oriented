using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _250326_상호작용실습
{
    class Program
    {
        static void Main(string[] args)
        {
            Interaction[] interactions = new Interaction[]
            {
                new Merchant("상인"),
                new NPC("마을 주민"),
                new Box(),
                new Door()
            };
            while (true)
            {
                Console.WriteLine("1 : 상인 앞으로 이동합니다.");
                Console.WriteLine("2 : 동네주민 앞으로 이동합니다.");
                Console.WriteLine("3 : 상자 앞으로 이동합니다.");
                Console.WriteLine("4 : 건물의 문 앞으로 이동합니다.");

                int choice;
                string input = Console.ReadLine();

                if (!int.TryParse(input, out choice) || choice < 1 || choice >4)
                {
                    Console.WriteLine("잘못 입력하셨습니다.");
                    continue;
                }

                Console.WriteLine("G키를 눌러 상호작용하세요.");
                string key = Console.ReadLine();
                if (key == "G" || key == "g")
                {
                    interactions[choice - 1].Interact();
                    break;
                }
                else
                {
                    Console.WriteLine("잘못된 키 입력. 다시 시도하세요");
                    
                }
                    
                
            }
            

        }
    }
    //상호작용
    abstract class Interaction
    {
        public abstract void Interact();
    }
    
    //NPC 클래스
    class NPC : Interaction
    {
        public string Name;
        
        public NPC(string name)
        {
            Name =  name;
        }

        public override void Interact()
        {
            Console.WriteLine($"{Name} : 안녕하세요! 좋은 아침이에요.");
        }
    }
    
    //상인
    class Merchant : Interaction
    {
        public string Name;
        public Merchant(string name)
        {
            Name = name;
        }


        public override void Interact()
        {
            Console.WriteLine($"{Name} :  상점을 엽니다.");
        }
    }
    //상자
    class Box : Interaction
    {
        public override void Interact()
        {
            Console.WriteLine("상자를 열었습니다! 골드를 획득했습니다.");
        }
    }

    class Door : Interaction
    {
        public override void Interact()
        {
            Console.WriteLine("문을 열고 건물안으로 들어갑니다.");
        }
    }
}
