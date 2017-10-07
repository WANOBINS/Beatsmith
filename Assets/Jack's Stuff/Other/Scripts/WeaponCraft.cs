using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCraft : MonoBehaviour {

    public GameManager gm;
    public float frames;
    public float tFrames;
    bool firstThird = true;
    bool secondThird = false;
    bool finalThird = false;

    // Use this for initialization
    void Start ()
    {
        gm = FindObjectOfType<GameManager>();
        tFrames = gm.TotalFrames;
	}
	
	// Update is called once per frame
	void Update ()
    {
        frames = gm.CurrentFrame;
        if (firstThird)
        {
            if (frames / tFrames >= 0.33 && frames / tFrames < 0.66)
            {
                firstThird = false;
                secondThird = true;
            }
        }
        if (secondThird)
        {
            if (frames / tFrames >= 0.66 )
            {
                secondThird = false;
                finalThird = true;

            }
        }
    }
}
