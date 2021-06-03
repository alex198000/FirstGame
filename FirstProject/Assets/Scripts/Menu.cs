using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    public GameObject pLost;
    
    public Texture2D clossed;

    private void Start()
    {
        if (pLost.GetComponent<AudioSource>().mute == true)
            PlayerPrefs.SetInt("SoundOff", 1);
        else
                PlayerPrefs.SetInt("SoundOff", 0);
    }

    void OnGUI()
    {
        



        GUIStyle Latyle = new GUIStyle();
        

        if (GUI.Button(new Rect(Screen.width / 70, 15, 200, 55), "1"))
        {
            SceneManager.LoadScene(1);
            
        }

        if (GUI.Button(new Rect(Screen.width / 70, 80, 200, 55), "2"))
        {
            if (PlayerPrefs.GetInt("LevelSave") >= 3)
            {
                SceneManager.LoadScene(3);

            }
        }

        if (GUI.Button(new Rect(Screen.width / 70, 145, 200, 55), "3"))
        {
            if (PlayerPrefs.GetInt("LevelSave") >= 5)
            {
                SceneManager.LoadScene(5);
              
            }
        }

       


        if (PlayerPrefs.GetInt("LevelSave") < 3)
        {
            GUI.DrawTexture(new Rect(Screen.width / 70 + 205, 80, 55, 55), clossed);
        }
        if (PlayerPrefs.GetInt("LevelSave") < 5)
        {
            GUI.DrawTexture(new Rect(Screen.width / 70 + 205, 145, 55, 55), clossed);
        }
        



        

        if (GUI.Button(new Rect(Screen.width - 250, 175, 200, 55), "Sound"))
        {
            AudioListener.pause = !AudioListener.pause;
           
        }

        if (AudioListener.pause)
        {
            GUI.DrawTexture(new Rect(Screen.width -310, 175, 55, 55), clossed);
        }

        if (GUI.Button(new Rect(Screen.width - 250, 250, 200, 55), "Music"))
        {
            pLost.GetComponent<AudioSource>().mute = !pLost.GetComponent<AudioSource>().mute;
            PlayerPrefs.GetInt("SoundOff", 1);
        }
        if (pLost.GetComponent<AudioSource>().mute == true)
        {
            GUI.DrawTexture(new Rect(Screen.width - 310, 250, 55, 55), clossed);
        }
    }
    
}
