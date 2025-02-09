﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CardGame.Mocks
{
    class CreateCardPackage
    {
        public static List<int> Cards { get; set; }

        public CreateCardPackage()
        {
            List<int> list1 = new List<int> { 1, 8, 6, 4, 9, 2, 5, 7, 10, 3, 13 };
            List<int> list2 = new List<int> { 4, 7, 2, 11, 1, 9, 10, 5, 8, 6, 3 };
            List<int> list3 = new List<int> { 4, 7, 9, 10, 2, 3, 5, 8, 6, 1 };
            List<int> list4 = new List<int> { 9, 10, 7, 8, 5, 6, 4, 12, 2, 3, 1 };
            Cards = new List<int>();

            Cards = list1.Concat(list2).Concat(list3).Concat(list4).ToList();
        }
    }
}
