using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250325_이윤형
{
    class Program
    {
        class Player
        {
            //변수(명사) : 정보
            private int level = 1;
            private int attackPoint = 10;

            //함수(동사) : 행동
            public void Attack(Monster monster)
            {
                Console.WriteLine("플레이어가 몬스터를 공격했습니다.");
                monster.TakeHit(attackPoint);
                Console.WriteLine("플레이어가 공격을 마칩니다.");
            }
        }

        class Monster
        {
            private int hp = 100;
            string name;

            public void TakeHit(int attackPoint)
            {
                Console.WriteLine("몬스터가 피격을 받습니다.");
                hp -= attackPoint;
                Console.WriteLine("몬스터의 현재 체력은 {0}입니다.", hp);
                if (hp <= 0)
                {
                    Die();
                }
            }

            private void Die()
            {
                Console.WriteLine("몬스터가 쓰러졌습니다.");
            }
        }

        static void Main(string[] args)
        {
            Player player = new Player();
            Monster monster = new Monster();

            player.Attack(monster);
        }
    }
}
