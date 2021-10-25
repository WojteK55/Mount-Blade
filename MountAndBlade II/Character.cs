using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MountAndBlade_II
{
    class Character
    {

        private int health;
        private int damage;


        public void Menu()
        {
            Console.WriteLine("***Добро пожаловать в Mount&Blade**");
            Console.WriteLine("Сегодня вы сразитесь лицом к лицу с настоящим гладиатором");
            Console.WriteLine("**********************************************************");
 Console.WriteLine("Победа в сражении – это самая незначительная победа. Победа без сражения – вот высочайшее мастерство.");



        }

       




        public virtual int HP()
        {
            return health;
        }

        public void Health_1()
        {
            Random rnd = new Random();
            health = rnd.Next(90, 100);
            Console.WriteLine("Твое здоровьей равно " + health);
        }

        public void Health_2()
        {
            Random rnd = new Random();
            health = rnd.Next(90, 100);
            Console.WriteLine("Здоровье твоего противника равно " + health);
        }

        public int Damage()
        {
            return damage;
        }




        public void Attack(Archer Archer)
        {


            Random rnd = new Random();
            damage = rnd.Next(0, 35);
            health = Archer.health - damage;
          
            Console.WriteLine("Твой урон составляет " + damage);

            Console.WriteLine("Здоровье противника после твоего удара равно " + health);
            
            if (health<=0)
            {
                health = 0;
            }


        }
        public void Attack_Back(Character Hero)
        {

            Random rnd = new Random();
            damage = rnd.Next(0, 35);
            health = Hero.health - damage;

            Console.WriteLine("Урон противника составляет " + damage);
            Console.WriteLine("Твоё здоровье после удара противника равно " + health);
            
            if (health<=0)
            {
                health = 0;
            }

        }

    }





}