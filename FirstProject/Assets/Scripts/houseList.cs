using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class houseList : MonoBehaviour
{
    [SerializeField] private List<string> myHero = new List<string> { "���������", "������", "�������", "�����", "������" };
    [SerializeField] private List<string> seasons = new List<string> { "������", "�������", "����", "������", "���", "����", "����", "������", "��������", "�������", "������", "�������" };
    [SerializeField] private List<string> myAnimal = new List<string> { "�����", "�����", "����", "����", "�������" };
    void Start()
    {
        int k = 0;
        int i = 0;

        foreach (string hero in myHero)
        {
            print(hero);
        }

        myHero.Sort();

        foreach (string hero in myHero)
        {
            print(hero);
        }

        foreach (string month in seasons)
        {
            print(month);
        }


        foreach (string month in seasons)
            while (i <= seasons.Count -1)
        {
            
              i ++;
              k++;

            }

           print(k + " �������");

        print(seasons[6] + " ����� ����� ��������");

        seasons[6] = "�����������";
        print(seasons[6] + " ����� ����� ��������");
        foreach (string month in seasons)
        {
            print(month);
        }

        myAnimal.Add("��������");
        myAnimal.Remove("�������");

    }

   
    













    void Update()
    {
        
    }
}
