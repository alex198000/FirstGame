using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{







    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Diamont")
        {
            Destroy(col.gameObject);
        }
        if (col.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }



    }

}
