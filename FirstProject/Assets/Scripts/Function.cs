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
        print("Возраст " + age + "лет");
        print("Деньги " + money + "грн");
        print("места есть ");
        print("Фильм не смотрел  ");
        WwalkMovies(40, 50, true, true);
    }
    


    private int WwalkMovies(int age, int money, bool isFreePlaces, bool isDejawu)
    {

        if (age >= 18 && money >= 29 && isFreePlaces == true && isDejawu == true)
        {
            print("Идем на форсаж9 ");
            return 1;
        }
        else if (age < 18)
        {
            print("Вы не можете посетить фильм в ближайшие " + (18 - age));
            return 1;
        }
        else if (money < 29)
        {
            print("Вы не можете посетить фильм, у вас недостаточно денег " + (29 - money));
            return 1;
        }
        else if (isFreePlaces == false)
        {
            print("Вы не можете посетить фильм, нет свободных мест ");
            return 1;
        }
        else if (isDejawu == false)
        {
            print("Вы уже видели этот фильм ");
            return 1;
        }
        else
            return 0;

    }




}
