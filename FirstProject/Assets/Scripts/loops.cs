using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loops : MonoBehaviour
{

    //for
    // for (инициализатор; условие; итератор)
    //инструкции


    //while(условие)
    //инструкции


    // do {
    //операторы;
    //while (условие) ;

    int s = 1;
    int i = 1;
    void Start()
    {










        do
        {
            print(s + " Июня");
            s++;
        }
        while (s <= 30);



        while (i <= 30)
        {
            print(i + " Июня");
            i++;
        }


        for (int s = 1; s <= 30; s++)
        {
            print(s + " Июня");
        }



    }













        //int k = 7;       // нельзя ставить цикл в update , будеит цикл в цикле юнити зависнет

        //int j = 0;


        //do
        //{
        //  print(k + "*" + j + " = " + (k*j));
        //    j++;
        //}
        //while (j <= 10);











        //int k = 10;

        //do
        //{
        //    print("Hello");
        //    k--;
        //}
        //while (k > 0);











        //int j = 0;
        //int i = 1000000;    

        //while (i >= 0)
        //{
        //    print(i);
        //   i -= 10000;
        //   j++;

        //}

        //print(j + " Раз");













        //int j = 0;
        //int i = -20;    //бсконечная загрузка юнити зависнет

        //while (i < 20)
        //{
        //    print(i);
        //    i += 2;
        //    j++;

        //}

        //print(j + " Раз");











        // int j = 0;
        // for(int i = 2021; i >= 200; i --) // i=i+10
        // {
        //     print(i + " год");
        //    //j++; // j = j + 1   j += 1
        // }
        //// print(j);
        //// print("Ful");
    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}
