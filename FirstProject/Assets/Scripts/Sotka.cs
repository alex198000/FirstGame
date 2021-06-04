using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sotka : MonoBehaviour
{
    [SerializeField] private int length = 15;
    [SerializeField] private int width = 15;
    [SerializeField] private int reference = 20;

    void Start()
    {
        Purchase(20, 25, 200);
    }

    // Update is called once per frame
    private void Purchase(int length, int width, int reference)
    {
        if ((length * width / 100) >= reference)
        {
            print("Покупаем");
        }


        else
        {
            print("не покупаем");
        }
    }

}


