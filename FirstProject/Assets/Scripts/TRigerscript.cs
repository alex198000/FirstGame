using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TRigerscript : MonoBehaviour
{
    //private List<GameObject> rombs;
    SpriteRenderer spRed;
    SpriteRenderer spRomb;
    Rigidbody2D rombRigi;
    [SerializeField] private List<GameObject> rombs = new List<GameObject>();
    private void OnTriggerStay2D(Collider2D col)
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

            rombRigi = col.GetComponent<Rigidbody2D>();
            rombRigi.gravityScale = 1.5f;
        }
     



    }
}
