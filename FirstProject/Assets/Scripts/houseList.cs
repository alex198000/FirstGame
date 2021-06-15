using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class houseList : MonoBehaviour
{
    [SerializeField] private List<string> myHero = new List<string> { "Россомаха", "Дедпул", "Аквамен", "Хамер", "Бэтмен" };
    [SerializeField] private List<string> seasons = new List<string> { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
    [SerializeField] private List<string> myAnimal = new List<string> { "Рокси", "Дерик", "Аква", "Халк", "Бульбик" };
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

           print(k + " Месяцев");

        print(seasons[6] + " месяц моего Рождения");

        seasons[6] = "Июллииййййй";
        print(seasons[6] + " месяц моего Рождения");
        foreach (string month in seasons)
        {
            print(month);
        }

        myAnimal.Add("Джинджер");
        myAnimal.Remove("Бульбик");

    }

   
    













    void Update()
    {
        
    }
}
