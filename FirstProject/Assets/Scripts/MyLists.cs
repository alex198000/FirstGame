using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLists : MonoBehaviour
{
    [SerializeField] private List<string> cars; //обьявили массив
    [SerializeField] private List<string> myCars = new List<string> {"Порше", "Ламба", "Жигуль", "Хамер"};

    void Start()
    {

        print(myCars[2]);

        foreach (string car in myCars)
        {
            print(car);
        }

        myCars.Add("Ферари");
        myCars.Remove("Жигуль");

        print("Всего " + myCars.Count);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
