using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    
    [SerializeField] private GameObject rocket1;
    [SerializeField] private GameObject rocket2;
    [SerializeField] private GameObject rocket3;
    [SerializeField] private float speed;
    [SerializeField] private float messege = 6.3f;
    [SerializeField] private float speedlimit = 8f;
    [SerializeField] private float messege1 = 0f;




    void Start()
    {
        
    }

    




    void Update()
    {
        rocket1.transform.Translate(new Vector3(0f, 1f, 0f) * speed * Time.deltaTime);
        rocket2.transform.Translate(new Vector3(0f, 1f, 0f) * speed * Time.deltaTime);
        rocket3.transform.Translate(new Vector3(0f, 1f, 0f) * speed * Time.deltaTime);





        if (rocket1.transform.position.y >= messege)
        {
            print("Ракеты улетели");
        }
        if (rocket2.transform.position.y >= 8)
        {
            speed = 0;
        }
        if (rocket3.transform.position.y <= messege1)
        {
            print("Ракеты прилетели");
        }
    }
}
