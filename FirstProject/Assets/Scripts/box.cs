using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    
    [SerializeField] private GameObject box2;
    [SerializeField] private float speed;
    [SerializeField] private Transform spawnPostion;



    void Start()
    {
        
    }

    




    void Update()
    {
        box2.transform.Translate(new Vector3(1f, 0f, 0f) * speed*Time.deltaTime);





        //if(transform.position.y <= -3)
        //{
        //    print("Земля");
        //}
        if (transform.position.y <= -10)
        {
            box2.transform.position = Vector3.zero; // transform.position = new Vector3.(0,0,0);
        }
        if (transform.position.x >= 10)
        {
            transform.position = spawnPostion.position;
        }
    }
}
