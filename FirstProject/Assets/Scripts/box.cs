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





<<<<<<< HEAD
        //if(transform.position.y <= -3)
        //{
        //    print("�����");
        //}
=======
        
>>>>>>> 68cc00ae11964049aa523491af09033745773a97
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
