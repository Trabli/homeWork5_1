using System;

namespace homeWork5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int oldLadys_inRow;
            int time_ForOnePerson_inMinutes = 10;
            int hour_ToWait;
            int min_ToWait;
            
            Console.WriteLine("Вы входите в поликлинику и видите очередь из старушек.");
            Console.Write("Сколько старушек перед вами?: ");
            oldLadys_inRow = Convert.ToInt32(Console.ReadLine());

            hour_ToWait = (oldLadys_inRow * time_ForOnePerson_inMinutes) / 60;
            min_ToWait = (oldLadys_inRow * time_ForOnePerson_inMinutes) % 60;

            Console.WriteLine("Так как на обслуживание одного человека уходит " + time_ForOnePerson_inMinutes + " минут, Вам предстоит прождать в очереди, примерно, " + hour_ToWait + " часов, " + min_ToWait + " минут.");
       }
    }
}
 
