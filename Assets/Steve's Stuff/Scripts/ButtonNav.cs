using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonNav : MonoBehaviour {

    public Button MainMenu;
    public Button SellWeapon;

	void Start () {

        MainMenu.onClick.AddListener(MenuPress);
	}
	

	void Update () {
		
	}

    void MenuPress()
    {
        SceneManager.LoadScene(0);
    }
}
