namespace ConsoleApp1
{
    internal class Program
    {
        class Knight
        {
            public int hp;
            public int attack;

            // 복사 
            public Knight Clone()
            {
                Knight knight = new Knight();
                knight.hp = hp;
                knight.attack = attack;
                return knight;
            }



            public void Move()
            {
                Console.WriteLine("Knight Move");
            }
            public void Attack()
            {
                Console.WriteLine("Knight Attack");
            }
        }

        struct Mage
        {
            public int hp;
            public int attack;
        }

        static void KillKight(Knight knight)
        {
            knight.hp = 0;
        }

        static void KillMage(Mage mage)
        {
            mage.hp = 0;
        }

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 10;
            KillKight(knight);
            Console.WriteLine(knight.hp);

            Mage mage = new Mage();
            mage.hp = 100;
            mage.attack = 10;
            KillMage(mage);
            Console.WriteLine(mage.hp);

            Knight knight2 = knight.Clone();
        }
    }
}
