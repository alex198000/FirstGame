using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLists : MonoBehaviour
{
<<<<<<< HEAD
    [SerializeField] private List<string> cars; //�������� ������
    [SerializeField] private List<string> myCars = new List<string> {"�����", "�����", "������", "�����"};
=======
    [SerializeField] private List<string> cars;    // �������� ������
    [SerializeField] private List<string> myCars = new List<string> { "�����", "�����", "������", "������", "������" };    // �������� ������


>>>>>>> 80fd4e07984527e4deffa2cd625fb46be6dee72c

    void Start()
    {

        print(myCars[2]);

        foreach (string car in myCars)
        {
            print(car);
        }

<<<<<<< HEAD
        myCars.Add("������");
=======
        myCars.Add("�������");
>>>>>>> 80fd4e07984527e4deffa2cd625fb46be6dee72c
        myCars.Remove("������");

        print("����� " + myCars.Count);


<<<<<<< HEAD
    }

    // Update is called once per frame
    void Update()
    {
        
=======
       
>>>>>>> 80fd4e07984527e4deffa2cd625fb46be6dee72c
    }
}
