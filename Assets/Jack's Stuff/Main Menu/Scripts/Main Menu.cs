using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public Text Title;
    public Button Play;
    

    /*enum Difficulty
    {
        EASY,
        MOD,
        HARD,
        ENDLESS
    }*/

    // Use this for initialization
    void Start ()
    {
        Title.text = "Beatsmith";
        

        Play.onClick.AddListener(playClick);
       
    }


    void playClick()
    {
        Debug.Log("Easy click!");
        Application.LoadLevel(1);
        
    }
    
}
