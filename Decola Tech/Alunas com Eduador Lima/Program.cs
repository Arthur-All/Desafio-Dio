using System;



    int [] [] VetorBidimensal = new int [] [] {
        new int [] {1,2},
        new int [] {1,2,3},
        new int [] {1,2,3,4}
    };

    foreach(int [] array in VetorBidimensal)
    {
        foreach(int e in array)
        {
            Console.WriteLine(e + ' ');
        }
    }


