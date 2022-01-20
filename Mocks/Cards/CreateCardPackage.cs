using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.Mocks
{
    class CreateCardPackage
    {
        public List<int> Cards { get; set; }
        //private int _groupAmount;
        //private List<string> Numbers;

        public CreateCardPackage()
        {
            //List<int> list1 = new List<int> { 1, 8, 6, 4, 9, 2, 5, 7, 10, 3 };
            //List<int> list2 = new List<int> { 4, 7, 2, 1, 9, 10, 5, 8, 6, 3 };
            //List<int> list3 = new List<int> { 4, 7, 9, 10, 2, 3, 5, 8, 6, 1 };
            //List<int> list4 = new List<int> { 9, 10, 7, 8, 5, 6, 4, 2, 3, 1 };
            //Cards = new List<int>(list1);
            //list2.ForEach(i => Cards.Add(i));
            //list3.ForEach(i => Cards.Add(i));
            //list4.ForEach(i => Cards.Add(i));

            //Cards.ForEach(i => Console.Write(i + "-"));

            List<int> Cards = new List<int> { 1, 8, 6, 4, 9, 2, 5, 7, 10, 3, 4, 7, 2, 1, 9, 10, 5, 8, 6, 3, 4, 7, 9, 10, 2, 3, 5, 8, 6, 1, 9, 10, 7, 8, 5, 6, 4, 2, 3, 1 };
            //Cards.ForEach(i => Console.Write(i));
            foreach (int i in Cards)
            {
                Console.WriteLine(i);
            }

            //_groupAmount = 4;
        }
    }
}
