using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FirstScript : MonoBehaviour
{

    [SerializeField] GameObject pLost;


    [Header("��������� �������")]
    [SerializeField] private float dist = 16f;
    [SerializeField] private float speed = 60f;
    private float time =0f;

    [Header("�������� ������������")]
    [SerializeField] private float a = 10f;
    [SerializeField] private float b = 200f;
    [SerializeField] private float c = 300f;
    private float perimetr = 0f;

    [Header("������� ")]
    [SerializeField] private float d = 50f;
    private float  kub= 0f;
    private float okta = 0f;
    private float sideALength = 2f;
    private float sideBLength = 3f;
    void Start()
    {
        time = (dist / speed) * 60;
        print("����� ������� " + time );

        perimetr = a + b + c;
        print("�������� " + perimetr);


        kub = (Mathf.Pow(d, 3f));
        print("����� ���� " + kub);


        okta = (kub * Mathf.Sqrt(2)) / 3;
        print("���� " + okta);
        //Debug.Log("����� ����������");
        //Debug.LogError("������");
        //print("print");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
