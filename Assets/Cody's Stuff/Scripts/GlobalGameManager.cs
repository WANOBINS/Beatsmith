using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalGameManager : MonoBehaviour {

    

    public GameManager GM;
    public float score;
    public int combo;
    public int max_combo;
    public bool OnSongEnd;
    public Weapon weapon;
  
   


    // Use this for initialization
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    void Start () {
        max_combo = 0; 
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Application.loadedLevel.Equals(3))
        {
            {
                GM = FindObjectOfType<GameManager>();
            }
            combo = GM.combo;

            if (combo > max_combo)
            {
                max_combo = combo;
            }

            score = GM.score;
        }

        if (Application.loadedLevel.Equals(0))
        {
            max_combo = 0;
        }
    }
}
