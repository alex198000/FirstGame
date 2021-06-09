using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Каышьеыум : MonoBehaviour
{
    // Start is called before the first frame update
    
        [Header("Рассказ обо мне")]

        [SerializeField] private string name = "Aleksandr";
        [SerializeField] private float rost = 187f;
        [SerializeField] private float vozr = 40f;
        [SerializeField] private bool zver = true;

	[Header("Рассказ о питомце")]

    [SerializeField] private string animal = "собака";
    [SerializeField] private string  klichka = "Пират";
    [SerializeField] private int vozrPirat = 12;

    [Header("скидка")]

    [SerializeField] private float cena = 100;
    [SerializeField] private float skidka = 50;
    [SerializeField] private float akcia = 0f;



    void Start()
    {
        print("Здравствуйте, меня зовут " + name + ", мой рост " + rost + "сантиметров, мой возраст " + vozr + " лет.");
        if(zver == true)
            print("У меня есть домашний питомец " + animal + ", по кличке " + klichka + ", его возраст " + vozrPirat + " лет.");
        
        
        akcia = cena - (cena / 100 * skidka);

        print("Внимание, АКЦИЯ!!!! Цена до распродажи " + cena + ", акционная цена " + akcia + ", Скидка =  " + skidka + " %!!!");
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
