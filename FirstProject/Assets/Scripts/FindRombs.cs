using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindRombs : MonoBehaviour
{

    GameObject[] rombs;
    Rigidbody2D rombRigi;
    GameObject sprRend;
    GameObject sprTrig;
 

    void Start()
    {
        rombs = GameObject.FindGameObjectsWithTag("Diamont");
        sprRend = GameObject.FindGameObjectWithTag("Finish");
        sprTrig = GameObject.FindGameObjectWithTag("trigger");
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Diamont")
        {
            
            foreach (GameObject romb in rombs)
                {
                rombRigi = romb.GetComponent<Rigidbody2D>();
                   rombRigi.gravityScale = -0.5f;
                }
         
        }

    }



    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Diamont")
        {
            sprTrig.GetComponent<SpriteRenderer>().material.color = new Color32((byte)Random.Range(0, 255), (byte)Random.Range(0, 255), (byte)Random.Range(0, 255), 255);
            sprRend.GetComponent<SpriteRenderer>().material.color = new Color32((byte)Random.Range(0, 255), (byte)Random.Range(0, 255), (byte)Random.Range(0, 255), 255);
        }
       
    }
}