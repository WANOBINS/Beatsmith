using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour {

    public Button Play;
  

    /*enum Difficulty
    {
        EASY,
        MOD,
        HARD,
        ENDLESS
    }*/

    // Use this for initialization
    void Start()
    {


        Play.onClick.AddListener(playClick);

    }


    void playClick()
    {
        Debug.Log("Easy click!");
        SceneManager.LoadScene(1);

    }
   
}
