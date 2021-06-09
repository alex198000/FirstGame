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



void Start()
    {


        int j = 20;    // любимое число
        int s = 1;      // степень

        do
        {
            print(Mathf.Pow(j, s));
            s++;         // увеличиваем степень на 1
        }
        while (s <= 10);  // цик выполн€етс€ пока степень меньше или равна 10





















        //int k = 7;       // нельз€ ставить цикл в update , будеит цикл в цикле юнити зависнет

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

        //print(j + " –аз");













        //int j = 0;
        //int i = -20;    //бсконечна€ загрузка юнити зависнет

        //while (i < 20)
        //{
        //    print(i);
        //    i += 2;
        //    j++;

        //}

        //print(j + " –аз");











        // int j = 0;
        // for(int i = 2021; i >= 200; i --) // i=i+10
        // {
        //     print(i + " год");
        //    //j++; // j = j + 1   j += 1
        // }
        //// print(j);
        //// print("Ful");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
