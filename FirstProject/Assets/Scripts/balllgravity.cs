using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balllgravity : MonoBehaviour
{
    [SerializeField] private List<GameObject> balls;

    [SerializeField] private Vector3 starPoz = new Vector3(0f, 5f, 0f);

    private List<Transform> rigi = new List<Transform>();
    void Start()
    {
        //balls[0].GetComponent<Rigidbody2D>(gravityScale(-1));


        foreach (GameObject ball in balls)
        {
            ball.transform.position = starPoz;
            starPoz = new Vector3(starPoz.x, starPoz.y++, starPoz.z);
            // balls[0].Rigidbody2d.gravityScale(-1);


            for (int i = 0; i < balls.Count; i++)
            {
                //rigi.Add(balls[i].GetComponent<Transform>(scale));
                
                //rigi[i].scale = new scale(Random.Range(1, 3));
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
