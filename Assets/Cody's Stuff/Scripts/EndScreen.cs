using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour {
    public Text Rename;
    public Text T_MaxCombo;
    public Text T_Score;
    public Weapon FinishedWeapon;
    public float Score;
    public int MaxCombo;
    public Button MainMenu;
   
    public int MySaveSlot = -1;
    public GameObject WeaponSpawn;

    public GlobalGameManager SGM;


    // Use this for initialization
    void Start() {
        SGM = FindObjectOfType<GlobalGameManager>();
        
        Score = SGM.score;
        MaxCombo = SGM.max_combo;
       
        T_MaxCombo.text = "Max Combo: " + MaxCombo.ToString();
        T_Score.text = "Score: " + Score.ToString();

        Instantiate(FinishedWeapon, gameObject.transform);

        MainMenu.onClick.AddListener(MainMenuPressed);
        

    }

    public void MainMenuPressed()
    {
        Debug.Log("Menu Button Pressed");
       

        if (Rename.text != null)
        {
            FinishedWeapon.Name = Rename.text;
        }
        else if(Rename.text == null)
        {
            FinishedWeapon.Name = "Weapon";
        }


        

        SceneManager.LoadScene(0);

    }

   

    


    // Update is called once per frame
    void Update ()
    {
       
    }
}
