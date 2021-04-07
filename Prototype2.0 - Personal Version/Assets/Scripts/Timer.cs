using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Timer : MonoBehaviour
{
    public class recyclingDay
    {
        public DateTime date;
        public int items = 0;
    }

    // Start is called before the first frame update
    void Awake()
    {
        recyclingDay zeroD = new recyclingDay();
        recyclingDay oneD = new recyclingDay();
        recyclingDay twoD = new recyclingDay();
        recyclingDay threeD = new recyclingDay();
        recyclingDay fourD = new recyclingDay();
        recyclingDay fiveD = new recyclingDay();
        recyclingDay sixD = new recyclingDay();

        TimeSpan dayLength = new TimeSpan(1, 0, 0, 0, 0);
        TimeSpan dayLength2 = new TimeSpan(2, 0, 0, 0, 0);
        TimeSpan dayLength3 = new TimeSpan(3, 0, 0, 0, 0);
        TimeSpan dayLength4 = new TimeSpan(4, 0, 0, 0, 0);
        TimeSpan dayLength5 = new TimeSpan(5, 0, 0, 0, 0);
        TimeSpan dayLength6 = new TimeSpan(6, 0, 0, 0, 0);

        DateTime dayTime = System.DateTime.Now;
        DateTime dayOnly = dayTime.Date;

        zeroD.date = new DateTime(2021, 4, 1);

        TimeSpan difference = dayOnly.Subtract(zeroD.date);

        if (difference.Days == 0)
        {

        }
        else if (difference.Days == 1)
        {
            sixD = fiveD;
            fiveD = fourD;
            fourD = threeD;
            threeD = twoD;
            twoD = oneD;
            oneD = zeroD;

            zeroD.date = dayOnly;
            zeroD.items = 0;
        }
        else if (difference.Days == 2)
        {
            sixD = fourD;
            fiveD = threeD;
            fourD = twoD;
            threeD = oneD;
            twoD = zeroD;

            oneD.date = dayOnly.Subtract(dayLength);
            oneD.items = 0;

            zeroD.date = dayOnly;
            zeroD.items = 0;
        }
        else if (difference.Days == 3)
        {
            sixD = threeD;
            fiveD = twoD;
            fourD = oneD;
            threeD = zeroD;

            twoD.date = dayOnly.Subtract(dayLength2);
            twoD.items = 0;

            oneD.date = dayOnly.Subtract(dayLength);
            oneD.items = 0;

            Debug.Log(twoD.date);
            Debug.Log(oneD.date);

            zeroD.date = dayOnly;
            zeroD.items = 0;
        }
        else if (difference.Days == 4)
        {
            sixD = twoD;
            fiveD = oneD;
            fourD = zeroD;

            threeD.date = dayOnly.Subtract(dayLength3);
            threeD.items = 0;

            twoD.date = dayOnly.Subtract(dayLength2);
            twoD.items = 0;

            oneD.date = dayOnly.Subtract(dayLength);
            oneD.items = 0;

            zeroD.date = dayOnly;
            zeroD.items = 0;
        }
        else if (difference.Days == 5)
        {
            sixD = oneD;
            fiveD = zeroD;

            fourD.date = dayOnly.Subtract(dayLength4);
            fourD.items = 0;

            threeD.date = dayOnly.Subtract(dayLength3);
            threeD.items = 0;

            twoD.date = dayOnly.Subtract(dayLength2);
            twoD.items = 0;

            oneD.date = dayOnly.Subtract(dayLength);
            oneD.items = 0;

            zeroD.date = dayOnly;
            zeroD.items = 0;
        }
        else if (difference.Days == 6)
        {
            sixD = zeroD;

            fiveD.date = dayOnly.Subtract(dayLength5);
            fiveD.items = 0;

            fourD.date = dayOnly.Subtract(dayLength4);
            fourD.items = 0;

            threeD.date = dayOnly.Subtract(dayLength3);
            threeD.items = 0;

            twoD.date = dayOnly.Subtract(dayLength2);
            twoD.items = 0;

            oneD.date = dayOnly.Subtract(dayLength);
            oneD.items = 0;

            zeroD.date = dayOnly;
            zeroD.items = 0;
        }
        else
        {
            sixD.date = dayOnly.Subtract(dayLength6);
            sixD.items = 0;

            fiveD.date = dayOnly.Subtract(dayLength5);
            fiveD.items = 0;

            fourD.date = dayOnly.Subtract(dayLength4);
            fourD.items = 0;

            threeD.date = dayOnly.Subtract(dayLength3);
            threeD.items = 0;

            twoD.date = dayOnly.Subtract(dayLength2);
            twoD.items = 0;

            oneD.date = dayOnly.Subtract(dayLength);
            oneD.items = 0;

            zeroD.date = dayOnly;
            zeroD.items = 0;
        }
    }
}
