using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> balls;
    [SerializeField] private Vector3 starPoz = new Vector3(0f, 5f, 0f);
    [SerializeField] private SpriteRenderer sp0;
    private List<SpriteRenderer> sps = new List<SpriteRenderer>();
    private SpriteRenderer sp1;

    void Start()
    {

        for (int i = 0; i < balls.Count; i++)
        {
            sps.Add(balls[i].GetComponent<SpriteRenderer>());
            //sps[i].color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);
            sps[i].color = new Color32((byte)Random.Range(0, 255), (byte)Random.Range(0, 255), (byte)Random.Range(0, 255), 255);
        }







        //sp0.color = Color.black;
        //sp1 = balls[1].GetComponent<SpriteRenderer>();
        //sp1.color = Color.blue;
        //foreach(SpriteRenderer sp in sps)
        //{
        //    foreach (GameObject ball in balls)
        //    {
        //        sp = ball.GetComponent<SpriteRenderer>();
        //    }

        //}
        //    foreach(GameObject ball in balls)
        //{
        //    sps.Add(ball.GetComponent<SpriteRenderer>());
        //}
        //sps = new List<SpriteRenderer>(balls.Capacity);
        ////sps. Capacity = new Cap
        //print(sps.Capacity);
        //print(sps.Count);
        //for ( int i = 0; i < balls.Capacity; i++)
        //{
        //    print(1);
        //    sps[i] = balls[i].GetComponent<SpriteRenderer>();
        //    sps[i].color = Color.clear;
        //}



        foreach (GameObject ball in balls)
        {
            ball.transform.position = starPoz;
            starPoz = new Vector3(starPoz.x, starPoz.y++, starPoz.z);


            //starPoz.y++;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
