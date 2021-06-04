using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FirstScript : MonoBehaviour
{

    [SerializeField] GameObject pLost;


    [Header("Параметры поездки")]
    [SerializeField] private float dist = 16f;
    [SerializeField] private float speed = 60f;
    private float time =0f;

    [Header("Периметр треугольника")]
    [SerializeField] private float a = 10f;
    [SerializeField] private float b = 200f;
    [SerializeField] private float c = 300f;
    private float perimetr = 0f;

    [Header("Сторона ")]
    [SerializeField] private float d = 50f;
    private float  kub= 0f;
    private float okta = 0f;
    private float sideALength = 2f;
    private float sideBLength = 3f;
    void Start()
    {
        time = (dist / speed) * 60;
        print("Время поездки " + time );

        perimetr = a + b + c;
        print("Периметр " + perimetr);


        kub = (Mathf.Pow(d, 3f));
        print("Обьем куба " + kub);


        okta = (kub * Mathf.Sqrt(2)) / 3;
        print("Окта " + okta);
        //Debug.Log("Старт прогрымммы");
        //Debug.LogError("Ошибка");
        //print("print");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
