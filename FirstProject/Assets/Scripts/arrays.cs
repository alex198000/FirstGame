using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrays : MonoBehaviour
{
    [SerializeField] private string [] myFilms = new string[] {"Тор", "Ной", "Гарри поттер", "Тор", "Тихое место" }; // Обьявили массив рентабельности




void Start()
    {


        //PrintArray();
        //myFilms[0] = "Пираты карибского моря";
        //PrintArray();



        //foreach (string item in myFilms)
        //    {
        //if (item!="Тор")
        //{
        //     print(item);
        //}



        int k = 0;
        foreach (string item in myFilms)
        {
            if (k != myFilms.Length - 1)
            {
            
                print(item);
            }
            else
            {

            
            print("!");
            }
        }



    }

   
   
 


   




//void PrintArray()
//    {
//        string j = "";
       
        
        
        
//        for (int i = 0; i < myFilms.Length; i++)
//        { 
//            if(i != myFilms.Length - 1)
//            {
//                j = j + myFilms[i] + " , ";
//            }
//            else
//            {
//                j = j + myFilms[i] + " ! ";
//            }
//        }
        
//        print(j);
//    }
    
}
