using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Array1 : MonoBehaviour
{
    [SerializeField] private int[] myArray; //обьявили массив
    [SerializeField] private int[] myArray1 = new int[3]; //обьявили массив и задали размер
    [SerializeField] private int[] myArray2 = new int[3] {1, 2, 3};                                          //индексы   0  1  2  3  4  5  6 
    [SerializeField] private int[] myArray3 = new int[] { 1, 2, 3, 4, 5, 6, 7};


    [SerializeField] private string[] myFilms = new string[] { "Тор", "Ной", "Тор", "Гарри Поттер", "Тихое место", "Тор" };


    void Start()
    {
        //PrintArray();
        //myFilms[0] = "Пираты карибского моря";
        //PrintArray();


        //foreach (string item in myFilms)
        //{
        //    if(item != "Тор")
        //    {
        //        print(item);
        //    }
        //}
        foreach (string item in myFilms)
        {
            if (item == "T")
            {
                break;
            }
            else
            {
                print(item);
            }
            print("-------------------");
        }
    }

    void PrintArray1()
    {
        foreach (string item in myFilms)
        {
            string j = "";

            if(item == myFilms[item.Length])
            {
                j = j + item + "!";
            }
            else
            {
                j = j +item + ".";
            }
        }
    }

    void PrintArray2()
    {
        foreach (string item in myFilms)
        {
            string j = "";

            if (Array.IndexOf(myFilms, item) == item.Length-1)
            {
                j = j + item + "!";
            }
            else
            {
                j = j + item + ".";
            }
        }
    }





    void PrintArray()
        {

        string j = "";
        for (int i = 0; i < myFilms.Length; i++)
        {
            if(i == myFilms.Length - 1)
            {
                j = j + myFilms[i]+ "!";
            }
            else
            {
                j = j + myFilms[i] + ".";
            }
        }

        print(j);
    }

}
