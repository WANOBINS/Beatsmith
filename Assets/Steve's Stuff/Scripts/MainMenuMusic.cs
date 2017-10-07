using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuMusic : MonoBehaviour {

    public RhythmTool rhythmtool;
    public RhythmEventProvider events;
    public AudioClip Theme;
    public Weapon wspawn;
    public ParticleSystem Flames;
    public ParticleSystem Flames1;
    public ParticleSystem Flames2;
    public ParticleSystem Flames3;
    public ParticleSystem Flames4;
    public ParticleSystem Flames5;
    public ParticleSystem Flames6;
    public ParticleSystem[] flames;
    

    void Start () {
        rhythmtool = GetComponent<RhythmTool>();
        events = GetComponent<RhythmEventProvider>();
        wspawn = FindObjectOfType<Weapon>();
        

        rhythmtool.NewSong(Theme);
        rhythmtool.SongLoaded += OnSongLoaded;

        events.onSubBeat.AddListener(OnSubBeat);
	}

    void OnSongLoaded()
    {
        rhythmtool.Play();
    }

    void OnSubBeat(Beat beat, int count)
    {
        int random = Random.Range(0, 7);
        if (count == 3)
        {
             flames[random].startLifetime = 5;
            // flames[random].emission.rateOverTime = 20;
            //ParticleSystem ps = flames[random];
            //ps.startLifetime = 5;
            //ps.emissionRate = new ParticleSystem.MinMaxCurve(20.0f, 20.0f);
        }
        
        if (count == 0)
        {
            wspawn.MainMenu();
            flames[random].startLifetime = 3.75f;
        }
    }
}
