using System;

namespace homeWork5_1
{
    class Program
    {
        static void Main(string[] args)
        {
           int oldWomenCount;
            int timeFor1oldWoman;
            int waitingTime;
            int hourWaiting;
            int minutesWaiting;
            
            Console.WriteLine("Вы заходите в больницу и видите в очереди некоторое количество старушек");
            Console.Write("Потратив некоторе время Вы всё-же подсчитали их количество. Их оказалось: ");

            oldWomenCount = Convert.ToInt32(Console.ReadLine());
            timeFor1oldWoman = 10;

            waitingTime = oldWomenCount * timeFor1oldWoman;
            hourWaiting = waitingTime / 60;
            minutesWaiting = waitingTime % 60;

            Console.WriteLine("Так как Вы увидели, что в среднем на обследование 1 старушки уходит " + timeFor1oldWoman + " минут,");
            Console.Write("Вы поняли, что ждать вам прийдеться " + hourWaiting + " часов " + minutesWaiting + " минут");
       }
    }
}
 
