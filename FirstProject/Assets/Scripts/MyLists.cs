using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLists : MonoBehaviour
{

    [SerializeField] private List<string> cars; //�������� ������
    [SerializeField] private List<string> myCars = new List<string> {"�����", "�����", "������", "�����"};



//<<<<<<< HEAD
//=======


//>>>>>>> 025880c19b686193fa68fb34943724878263cbd3

    void Start()
    {

        print(myCars[2]);

        foreach (string car in myCars)
        {
            print(car);
        }


        myCars.Add("�������");

        myCars.Remove("������");

        print("����� " + myCars.Count);


//<<<<<<< HEAD
//=======

    }

    // Update is called once per frame
    void Update()
    {
   
//>>>>>>> 025880c19b686193fa68fb34943724878263cbd3
    }
}
