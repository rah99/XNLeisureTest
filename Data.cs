using System;
using System.Numerics;

namespace XNLeisureTest
{
    public class Data
    {
        private readonly ObjectModel objectModel = new();

        public void ShowResults()
        {
            objectModel.FindLetter = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Eanean sodales justo et Enim ornare, a congue lacus commodo.";
            objectModel.FindNumber = BigInteger.Parse("17272838119191929838299111");
            objectModel.AdditionNumber = 7 + 5;

            var eInSentence = Helper.GetTypes(objectModel.FindLetter, null, "e");
            var oneInNumber = Helper.GetTypes(objectModel.FindNumber, objectModel.AdditionNumber, "1");

            Console.WriteLine($"The letter 'e' occurs { ((int?)eInSentence <= 1 ? "once" : eInSentence + " times") } in: \n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(objectModel.FindLetter);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\nThe number '1' occurs { ((int?)oneInNumber <= 1 ? "once" : oneInNumber + " times") } in: \n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(objectModel.FindNumber.ToString() + objectModel.AdditionNumber.ToString());
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }
    }
}
