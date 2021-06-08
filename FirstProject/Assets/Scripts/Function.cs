using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function : MonoBehaviour
{
    [SerializeField] private int age = 40;
    [SerializeField] private int money = 50;
    [SerializeField] private bool isDejawu = true;
    [SerializeField] private bool isFreePlaces = true;
    private void Start()
    {
        print("������� " + age + "���");
        print("������ " + money + "���");
        print("����� ���� ");
        print("����� �� �������  ");
        WwalkMovies(40, 50, true, true);
    }
    


    private int WwalkMovies(int age, int money, bool isFreePlaces, bool isDejawu)
    {

        if (age >= 18 && money >= 29 && isFreePlaces == true && isDejawu == true)
        {
            print("���� �� ������9 ");
            return 1;
        }
        else if (age < 18)
        {
            print("�� �� ������ �������� ����� � ��������� " + (18 - age));
            return 1;
        }
        else if (money < 29)
        {
            print("�� �� ������ �������� �����, � ��� ������������ ����� " + (29 - money));
            return 1;
        }
        else if (isFreePlaces == false)
        {
            print("�� �� ������ �������� �����, ��� ��������� ���� ");
            return 1;
        }
        else if (isDejawu == false)
        {
            print("�� ��� ������ ���� ����� ");
            return 1;
        }
        else
            return 0;

    }




}
