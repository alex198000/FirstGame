using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrays : MonoBehaviour
{
    [SerializeField] private int[] myArray; // Обьявили массив

    [SerializeField] private int[] myArray1 = new int[3];  // обьявили массив и задали размер

    [SerializeField] private int[] myArray2 = new int[3] { 1, 2, 3 };
    
                                                      //  0 1  2  3  4  5  6  индексы
    [SerializeField] private int[] myArray3 = new int[] { 1, 2, 3, 4, 5, 6, 7};



    void Start()
    {
        print(myArray[0]);
        myArray[0] = 1000;
        print(myArray[00]);











        //print(myArray[0]);
        //print(myArray[1]);
        //print(myArray[3]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
