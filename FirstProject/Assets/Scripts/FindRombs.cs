using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindRombs : MonoBehaviour
{

    private List<GameObject> rombs; // = new List<GameObject>()
    private GameObject yellowBox;

    private void Awake()
    {
        yellowBox = GameObject.Find("Box");
        rombs = new List<GameObject>(GameObject.FindGameObjectsWithTag("Diamont"));
    }



    void Start()
    {
       foreach(GameObject romb in rombs)
        {
            romb.transform.position = Vector3.zero;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
