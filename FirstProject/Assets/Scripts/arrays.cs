using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrays : MonoBehaviour
{
    [SerializeField] private float [] profitability; // Обьявили массив рентабельности


//        profitability[0] = sotka1;
//        profitability[1] = sotka2;
//        profitability[2] = sotka3;

//        float[] profitability = {sotka1, sotka2, sotka3};

//    Array.Sort(profitability);
             
//foreach(int 3 in profitability)
//{
//    Console.Write($"{3} \t");
//}


void Start()
    {

        

        Optima(BestKvadr(10f, 20f), BestKvadr(20f, 2f), BestKvadr(2f, 30f));


        
    }

    private float BestKvadr(float sotka, float price)
    {
        float metrKvadr = price / sotka;
        print("1 кв метр выходит по цене " + metrKvadr);
        return metrKvadr;

    }

    private void Optima(float sotka1, float sotka2, float sotka3)
    {
        print(sotka1);
        print(sotka2);
        print(sotka3);
      


        if ((sotka1 < sotka2) && (sotka1 < sotka3))
        {
            print("Самая выгодная сотка №1 " + sotka1);
        }
        else if ((sotka2 < sotka1) && (sotka2 < sotka3))
        {
            print("Самая выгодная сотка №2 " + sotka2);
        }
        else if ((sotka3 < sotka1) && (sotka3 < sotka2))
        {
            print("Самая выгодная сотка №3 " + sotka3);
        }
    }



   













//print(myArray[0]);
//print(myArray[1]);
//print(myArray[3]);


// Update is called once per frame
void Update()
    {
        
    }
}
