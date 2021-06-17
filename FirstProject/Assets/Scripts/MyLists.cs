using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLists : MonoBehaviour
{
<<<<<<< HEAD
    [SerializeField] private List<string> cars; //обьявили массив
    [SerializeField] private List<string> myCars = new List<string> {"Порше", "Ламба", "Жигуль", "Хамер"};
=======
    [SerializeField] private List<string> cars;    // обьявили список
    [SerializeField] private List<string> myCars = new List<string> { "Порше", "Ламба", "Жигуль", "Хаммер", "Тойота" };    // обьявили список


>>>>>>> 80fd4e07984527e4deffa2cd625fb46be6dee72c

    void Start()
    {

        print(myCars[2]);

        foreach (string car in myCars)
        {
            print(car);
        }

<<<<<<< HEAD
        myCars.Add("Ферари");
=======
        myCars.Add("Феррари");
>>>>>>> 80fd4e07984527e4deffa2cd625fb46be6dee72c
        myCars.Remove("Жигуль");

        print("Всего " + myCars.Count);


<<<<<<< HEAD
    }

    // Update is called once per frame
    void Update()
    {
        
=======
       
>>>>>>> 80fd4e07984527e4deffa2cd625fb46be6dee72c
    }
}
