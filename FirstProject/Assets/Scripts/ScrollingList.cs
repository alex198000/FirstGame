using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ScrollingList : MonoBehaviour
{
    public Texture2D clossed;

    // ��������� ��������������� ���� � X � Y ����
    Vector2 scrollPosition = Vector2.zero;

    // ���������� ��� �������� �������
    Touch myTouch;

    // �������, ���������� ����(������� ����� ������������)
    string content;

    // ����������� ���������
    public float factorDamping;

    // ���� ��� �����������, ������� �� ���� ����� �� ������
    bool flag;

    // ���������� ��� ����������� ����������� ��������� (���� ��� �����)
    float firstYPos;
    float secondYPos;

    void Start()
    {
        // �������� ����� 1000 �������� (����� ���� ��� �������)
        for (int i = 0; i < 500; i++)
        content += "\n something content something content something content  " + i;
    }

    void OnGUI()
    {
        // ��������� �� ������ ScrollView
        scrollPosition = GUI.BeginScrollView(new Rect(0, 0, 470, 725), scrollPosition, new Rect(0, 0, 450, 1700), GUIStyle.none, GUIStyle.none);

        // ��������� ������ � ���������
        GUI.Label(new Rect(0, 0, 480, 725), content);

       // GUIStyle Latyle = new GUIStyle();


       // if (GUI.Button(new Rect(Screen.width / 70, 15, 200, 55), "1"))
       // {
       //     SceneManager.LoadScene(1);

       // }

       // if (GUI.Button(new Rect(Screen.width / 70, 80, 200, 55), "2"))
       // {
       //     if (PlayerPrefs.GetInt("LevelSave") >= 3)
       //     {
       //         SceneManager.LoadScene(3);

       //     }
       // }

       // if (GUI.Button(new Rect(Screen.width / 70, 145, 200, 55), "3"))
       // {
       //     if (PlayerPrefs.GetInt("LevelSave") >= 5)
       //     {
       //         SceneManager.LoadScene(5);

       //     }
       // }




       // if (PlayerPrefs.GetInt("LevelSave") < 3)
       // {
       //     GUI.DrawTexture(new Rect(Screen.width / 70 + 205, 80, 55, 55), clossed);
       // }
       // if (PlayerPrefs.GetInt("LevelSave") < 5)
       // {
       //     GUI.DrawTexture(new Rect(Screen.width / 70 + 205, 145, 55, 55), clossed);
       // }

       // //GUIStyle Latyle = new GUIStyle();


       // if (GUI.Button(new Rect(Screen.width / 70, 205, 200, 55), "1"))
       // {
       //     SceneManager.LoadScene(1);

       // }

       // if (GUI.Button(new Rect(Screen.width / 70, 265, 200, 55), "2"))
       // {
       //     if (PlayerPrefs.GetInt("LevelSave") >= 3)
       //     {
       //         SceneManager.LoadScene(3);

       //     }
       // }

       // if (GUI.Button(new Rect(Screen.width / 70, 355, 200, 55), "3"))
       // {
       //     if (PlayerPrefs.GetInt("LevelSave") >= 5)
       //     {
       //         SceneManager.LoadScene(5);

       //     }
       // }




       // if (PlayerPrefs.GetInt("LevelSave") < 3)
       // {
       //     GUI.DrawTexture(new Rect(Screen.width / 70 + 205, 265, 55, 55), clossed);
       // }
       // if (PlayerPrefs.GetInt("LevelSave") < 5)
       // {
       //     GUI.DrawTexture(new Rect(Screen.width / 70 + 205, 355, 55, 55), clossed);
       // }

       // //GUIStyle Latyle = new GUIStyle();


       // if (GUI.Button(new Rect(Screen.width / 70, 425, 200, 55), "1"))
       // {
       //     SceneManager.LoadScene(1);

       // }

       // if (GUI.Button(new Rect(Screen.width / 70, 490, 200, 55), "2"))
       // {
       //     if (PlayerPrefs.GetInt("LevelSave") >= 3)
       //     {
       //         SceneManager.LoadScene(3);

       //     }
       // }

       // if (GUI.Button(new Rect(Screen.width / 70, 570, 200, 55), "3"))
       // {
       //     if (PlayerPrefs.GetInt("LevelSave") >= 5)
       //     {
       //         SceneManager.LoadScene(5);

       //     }
       // }




       // if (PlayerPrefs.GetInt("LevelSave") < 3)
       // {
       //     GUI.DrawTexture(new Rect(Screen.width / 70 + 205, 490, 55, 55), clossed);
       // }
       // if (PlayerPrefs.GetInt("LevelSave") < 5)
       // {
       //     GUI.DrawTexture(new Rect(Screen.width / 70 + 205, 570, 55, 55), clossed);
       // }

       // //GUIStyle Latyle = new GUIStyle();


       // if (GUI.Button(new Rect(Screen.width / 70, 680, 200, 55), "1"))
       // {
       //     SceneManager.LoadScene(1);

       // }

       // if (GUI.Button(new Rect(Screen.width / 70, 750, 200, 55), "2"))
       // {
       //     if (PlayerPrefs.GetInt("LevelSave") >= 3)
       //     {
       //         SceneManager.LoadScene(3);

       //     }
       // }

       // if (GUI.Button(new Rect(Screen.width / 70, 820, 200, 55), "3"))
       // {
       //     if (PlayerPrefs.GetInt("LevelSave") >= 5)
       //     {
       //         SceneManager.LoadScene(5);

       //     }
       // }




       // if (PlayerPrefs.GetInt("LevelSave") < 3)
       // {
       //     GUI.DrawTexture(new Rect(Screen.width / 70 + 205, 750, 55, 55), clossed);
       // }
       // if (PlayerPrefs.GetInt("LevelSave") < 5)
       // {
       //     GUI.DrawTexture(new Rect(Screen.width / 70 + 205, 820, 55, 55), clossed);
       // }


       //// GUIStyle Latyle = new GUIStyle();


       // if (GUI.Button(new Rect(Screen.width / 70, 900, 200, 55), "1"))
       // {
       //     SceneManager.LoadScene(1);

       // }

       // if (GUI.Button(new Rect(Screen.width / 70, 970, 200, 55), "2"))
       // {
       //     if (PlayerPrefs.GetInt("LevelSave") >= 3)
       //     {
       //         SceneManager.LoadScene(3);

       //     }
       // }

       // if (GUI.Button(new Rect(Screen.width / 70, 1060, 200, 55), "3"))
       // {
       //     if (PlayerPrefs.GetInt("LevelSave") >= 5)
       //     {
       //         SceneManager.LoadScene(5);

       //     }
       // }




       // if (PlayerPrefs.GetInt("LevelSave") < 3)
       // {
       //     GUI.DrawTexture(new Rect(Screen.width / 70 + 205, 970, 55, 55), clossed);
       // }
       // if (PlayerPrefs.GetInt("LevelSave") < 5)
       // {
       //     GUI.DrawTexture(new Rect(Screen.width / 70 + 205, 1060, 55, 55), clossed);
       // }

       //// GUIStyle Latyle = new GUIStyle();


       // if (GUI.Button(new Rect(Screen.width / 70, 1130, 200, 55), "1"))
       // {
       //     SceneManager.LoadScene(1);

       // }

       // if (GUI.Button(new Rect(Screen.width / 70, 1200, 200, 55), "2"))
       // {
       //     if (PlayerPrefs.GetInt("LevelSave") >= 3)
       //     {
       //         SceneManager.LoadScene(3);

       //     }
       // }

       // if (GUI.Button(new Rect(Screen.width / 70, 1280, 200, 55), "3"))
       // {
       //     if (PlayerPrefs.GetInt("LevelSave") >= 5)
       //     {
       //         SceneManager.LoadScene(5);

       //     }
       // }




       // if (PlayerPrefs.GetInt("LevelSave") < 3)
       // {
       //     GUI.DrawTexture(new Rect(Screen.width / 70 + 205, 1200, 55, 55), clossed);
       // }
       // if (PlayerPrefs.GetInt("LevelSave") < 5)
       // {
       //     GUI.DrawTexture(new Rect(Screen.width / 70 + 205, 1280, 55, 55), clossed);
       // }


       // if (GUI.Button(new Rect(Screen.width / 70, 1370, 200, 55), "1"))
       // {
       //     SceneManager.LoadScene(1);

       // }

       // if (GUI.Button(new Rect(Screen.width / 70, 1450, 200, 55), "2"))
       // {
       //     if (PlayerPrefs.GetInt("LevelSave") >= 3)
       //     {
       //         SceneManager.LoadScene(3);

       //     }
       // }

       // if (GUI.Button(new Rect(Screen.width / 70, 1600, 200, 55), "3"))
       // {
       //     if (PlayerPrefs.GetInt("LevelSave") >= 5)
       //     {
       //         SceneManager.LoadScene(5);

       //     }
       // }

       // if (PlayerPrefs.GetInt("LevelSave") < 3)
       // {
       //     GUI.DrawTexture(new Rect(Screen.width / 70 + 205, 1450, 55, 55), clossed);
       // }
       // if (PlayerPrefs.GetInt("LevelSave") < 5)
       // {
       //     GUI.DrawTexture(new Rect(Screen.width / 70 + 205, 1600, 55, 55), clossed);
       // }



        GUI.EndScrollView();
    }

    void FixedUpdate()
    {
        // ���� ���� ������� �� �����
        if (Input.touchCount > 0)
        {
            // ����������� ������� ���������� myTouch
            myTouch = Input.GetTouch(0);

            // ���� ���� ������� ������� �� ������, ��� ������� ������ ��� ���������
            if ((myTouch.phase == TouchPhase.Moved) || (myTouch.phase == TouchPhase.Began))
            {
                // ������ ����
                flag = false;

                // ����������� �������� ������ ���������� ��� ����������� ����������� ���������
                firstYPos = scrollPosition.y;

                // ����������, ��������� ���������� �� _factorDamping (��� �� ������, ��� ������� ���������)
                scrollPosition.y += (myTouch.deltaPosition.y * factorDamping);
            }
            // ���� ���� ������� ����� �� ������
            else if (myTouch.phase == TouchPhase.Ended)
            {
                // ����������� �������� ������ ���������� ��� ����������� ����������� ���������
                secondYPos = scrollPosition.y;

                // ������ ����
                flag = true;
            }
        }

        // ���� ��� ������� �� ����� (�������, ��� ������� ������ ��������� �������, ���������)
        else if (Input.touchCount == 0)
        {
            // �������� ����� (����� ��� ����, ����� ������� �� ��� �����������)
            if (flag)
            {
                // ���������� ��������� ����������� ���������
                factorDamping -= 1 * Time.deltaTime;

                // ���������� ����������� ����������
                if (firstYPos < secondYPos)
                    // ��������� �����
                    scrollPosition.y += factorDamping;
                else
                    // ��������� ����
                    scrollPosition.y -= factorDamping;

                // ���� ����� �����, ���������� ��� ���������
                if (factorDamping <= 0)
                {
                    // ������ ����
                    flag = false;

                    // ���������� ������������ ��������� ��� ����������� ��������
                    factorDamping = 1.5f;
                }
            }
        }
    }
}
