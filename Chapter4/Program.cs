namespace ConsoleApp1
{
    class Program
    {
        enum ClassType
        {
            None = 0,
            Knight = 1,
            Archer = 2,
            Mage = 3
        }
        
        static ClassType ChooseClass()
        {
            ClassType choice = ClassType.None;
            Console.WriteLine("직업을 선택하세요!");
            Console.WriteLine("1. 기사");
            Console.WriteLine("2. 궁수");
            Console.WriteLine("3. 법사");

            string a = Console.ReadLine();

            switch (a)
            {
                case "1":
                    choice = ClassType.Knight;
                    // 각 케이스에 대해 break하지 않으면 에러발생
                    break;
                case "2":
                    choice = ClassType.Archer;
                    break;
                case "3":
                    choice = ClassType.Mage;
                    break;
            }

            return choice;

        }

        static void Main(string[] args)
        {
            ClassType choice = ClassType.None;
            while(true)
            {
                choice = ChooseClass();
                if (choice != ClassType.None)
                {
                    break;
                }
            }
        }
    }
}
