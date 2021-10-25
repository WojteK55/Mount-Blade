using System;

namespace MountAndBlade_II
{
    class Program
    {



        static void Main(string[] args)
        {


            Character Hero = new Character();
            Archer Archer = new Archer();

            Hero.Menu();

            Console.ReadKey();
            
            Hero.Health_1();
            Archer.Health_2();
            Console.ReadKey();

            for (int i = 0; i < 100; i++)
            {
               

                Hero.Attack_Back(Hero);


                Archer.Attack(Archer);
                Console.ReadKey();

                

                if (Hero.HP() <= 0)
                {
                    Console.WriteLine("К сожалению, Вы скоропостижнулись:(");
                    Console.WriteLine("Важно не то, проигрываем ли мы в игре, важно, как мы проигрываем и как мы благодаря этому изменимся, что нового вынесем для себя, как сможем применить это в других играх.");
                    Console.WriteLine("Странным образом поражение оборачивается победой.");
                 
                    break;

                }
                if (Archer.HP() <= 0)
                {
                    
                    Console.WriteLine("Поздравляю, Ваш противник скоропостижнулся:)");
                    Console.WriteLine("После опьянения победой возникает всегда чувство великой потери: наш враг, наш враг мертв! Даже о потере друга мы жалеем не так глубоко, как о потере врага.");
                    break;
                }


            }

            



        }
    }
}