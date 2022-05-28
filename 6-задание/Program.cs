using System;

namespace _6_задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько золота у вас?  ");
            int theAMountOfGoldThePlayerHas = Convert.ToInt32(Console.ReadLine());
            int theCostOfACrystalInGold = 17;
            Console.Write("Стоимость кристалов ровна = " + theCostOfACrystalInGold + ". Какое количество кристалов вы хотите купить?  ");
            int crystalsThatWantToBuy = Convert.ToInt32(Console.ReadLine());
            theAMountOfGoldThePlayerHas = theCostOfACrystalInGold * crystalsThatWantToBuy;
            Console.WriteLine("У вас теперь " + crystalsThatWantToBuy + " кристалов. Остаток золота в кошельке: " + theAMountOfGoldThePlayerHas + ".");
        }
    }
}
