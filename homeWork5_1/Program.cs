using System;

namespace homeWork5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfPeople_inRow;
            int time_ForOnePerson_inMinutes = 10;
            int hour_ToWait;
            int min_ToWait;
            
            Console.WriteLine("Вы входите в поликлинику и видите очередь.");
            Console.Write("Сколько человек перед вами?: ");
            quantityOfPeople_inRow = Convert.ToInt32(Console.ReadLine());

            hour_ToWait = (quantityOfPeople_inRow * 10) / 60;
            min_ToWait = (quantityOfPeople_inRow * 10) % 60;

            Console.WriteLine("Так как на обслуживание одного человека уходит " + time_ForOnePerson_inMinutes + " минут, Вам предстоит прождать в очереди, примерно, " + hour_ToWait + " часов, " + min_ToWait + " минут.");
       }
    }
}
 
