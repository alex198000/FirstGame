using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Array1 : MonoBehaviour
{
    [SerializeField] private int[] myArray; //�������� ������
    [SerializeField] private int[] myArray1 = new int[3]; //�������� ������ � ������ ������
    [SerializeField] private int[] myArray2 = new int[3] {1, 2, 3};                                          //�������   0  1  2  3  4  5  6 
    [SerializeField] private int[] myArray3 = new int[] { 1, 2, 3, 4, 5, 6, 7};


    [SerializeField] private string[] myFilms = new string[] { "���", "���", "���", "����� ������", "����� �����", "���" };


    void Start()
    {
        //PrintArray();
        //myFilms[0] = "������ ���������� ����";
        //PrintArray();


        //foreach (string item in myFilms)
        //{
        //    if(item != "���")
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
