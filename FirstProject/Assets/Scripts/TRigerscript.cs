using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TRigerscript : MonoBehaviour
{
    //private List<GameObject> rombs;
    SpriteRenderer spRed;
    SpriteRenderer spRomb;

    [SerializeField] private List<GameObject> rombs = new List<GameObject>();
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Diamont")
        {


            //1
            spRomb = col.gameObject.GetComponent<SpriteRenderer>();
            spRomb.color = Color.red;


            //2
            spRed = GetComponent<SpriteRenderer>();
            spRomb.color = spRed.color;
            
            
            
            //3
            rombs.Add(col.gameObject);


        }
     



    }
}
