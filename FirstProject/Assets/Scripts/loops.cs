using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loops : MonoBehaviour
{

    //for
    // for (�������������; �������; ��������)
    //����������


    //while(�������)
    //����������


    // do {
    //���������;
   //while (�������) ;



void Start()
    {


        int j = 20;    // ������� �����
        int s = 1;      // �������

        do
        {
            print(Mathf.Pow(j, s));
            s++;         // ����������� ������� �� 1
        }
        while (s <= 10);  // ��� ����������� ���� ������� ������ ��� ����� 10





















        //int k = 7;       // ������ ������� ���� � update , ������ ���� � ����� ����� ��������

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

        //print(j + " ���");













        //int j = 0;
        //int i = -20;    //���������� �������� ����� ��������

        //while (i < 20)
        //{
        //    print(i);
        //    i += 2;
        //    j++;

        //}

        //print(j + " ���");











        // int j = 0;
        // for(int i = 2021; i >= 200; i --) // i=i+10
        // {
        //     print(i + " ���");
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
