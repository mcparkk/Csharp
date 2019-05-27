using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BroodWar
{
    class main
    {
        public static void Main(string[] args)
        {
            Zealot zeal1 = new Zealot();
            Zergling zerg1 = new Zergling();
            Vulture vult = new Vulture();
            Console.Write("질럿 사운드이펙트: ");
            System.Threading.Thread.Sleep(800);
            zeal1.Sound();
            System.Threading.Thread.Sleep(800);
            Console.Write("저글링 사운드이펙트: ");
            System.Threading.Thread.Sleep(800);
            zerg1.Sound();
            System.Threading.Thread.Sleep(800);
            Console.Write("벌쳐 사운드이펙트: ");
            System.Threading.Thread.Sleep(800);
            vult.Sound();
            System.Threading.Thread.Sleep(800);
            Console.WriteLine($"HP 상황\t질럿: {zeal1.getShield()}/{zeal1.getHp()}  저글링: {zerg1.getHp()}  벌쳐: {vult.getHp()}");
            System.Threading.Thread.Sleep(800);
            Console.WriteLine("질럿이 저글링 공격, 저글링이 벌쳐 공격, 벌쳐가 질럿 공격");
            System.Threading.Thread.Sleep(800);
            zeal1.Attack(zerg1);
            zerg1.Attack(vult);
            vult.Attack(zeal1);
            Console.WriteLine($"HP 상황\t질럿: {zeal1.getHp()}  저글링: {zerg1.getHp()}  벌쳐: {vult.getHp()}");
            System.Threading.Thread.Sleep(800);
            


        }
    }
}
