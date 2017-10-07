using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SongSelect : MonoBehaviour {

    public AudioClip Song1;
    public AudioClip Song2;
    public AudioClip Song3;
    public AudioClip Song4;
    public AudioClip Selectedsong;
    public Button Souls;
    public Button Skies;
    public Button Diggy;
    public Button Dragon;


    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
	// Use this for initialization
	void Start ()
    {
        Souls.onClick.AddListener(SoulsButton);
        Skies.onClick.AddListener(SkiesButton);
        Diggy.onClick.AddListener(DiggyButton);
        Dragon.onClick.AddListener(DragonButton);
	}
	
	// Update is called once per frame
	void Update ()
    {
	    	
	}

    void SoulsButton()
    {
        Selectedsong = Song1;
        Application.LoadLevel(3);
    }

    void SkiesButton()
    {
        Selectedsong = Song2;
        Application.LoadLevel(3);
    }

    void DiggyButton()
    {
        Selectedsong = Song3;
        Application.LoadLevel(3);
    }

    void DragonButton()
    {
        Selectedsong = Song4;
        Application.LoadLevel(3);
    }
}
