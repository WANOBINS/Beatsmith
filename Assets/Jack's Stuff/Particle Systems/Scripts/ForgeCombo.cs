using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForgeCombo : MonoBehaviour {

    public int combo;
    public int beat;
    public GameManager gm;
    public ParticleSystem ForgeFlames;
    public ParticleSystem ForgeFlames2;
    public ParticleSystem ForgeSpark;
    public ParticleSystem ForgeSpark2;
    public Light pLight1;
    public Light pLight2;

    // Use this for initialization
    void Start () {
        gm = FindObjectOfType<GameManager>();

    }
	
	// Update is called once per frame
	void Update () {
        combo = gm.combo;
        beat = gm.cbeat;
        var em = ForgeSpark.emission;
        var em2 = ForgeSpark2.emission;

        if (combo < 5 )
        {
            pLight1.intensity = 1.5f;
            pLight2.intensity = pLight1.intensity;

            if (ForgeFlames.isPlaying)
            {
                ForgeFlames.Stop();
            }

            if (!ForgeSpark.isPlaying)
            {
                ForgeSpark.Play();
            }

            var rate = em.rateOverTime;
            rate.constantMin = 3.0f;
            rate.constantMax = 3.0f;
            em.rateOverTime = rate;

            var rate2 = em2.rateOverTime;
            rate2.constantMin = 3.0f;
            rate2.constantMax = 3.0f;
            em2.rateOverTime = rate2;
        }
        else if ( combo >= 5 && combo < 10 )
        {
            pLight1.intensity = 2.5f;
            pLight2.intensity = pLight1.intensity;

            if (ForgeFlames.isPlaying)
            {
                ForgeSpark.Stop();
            }

            if (! ForgeSpark.isPlaying)
            {
                ForgeSpark.Play();
            }

            var rate = em.rateOverTime;
            rate.constantMin = 10.0f;
            rate.constantMax = 10.0f;
            em.rateOverTime = rate;

            var rate2 = em2.rateOverTime;
            rate2.constantMin = 10.0f;
            rate2.constantMax = 10.0f;
            em2.rateOverTime = rate2;
        }
        else if (combo >= 10 && combo < 15)
        {
            pLight1.intensity = 5.0f;
            pLight2.intensity = pLight1.intensity;

            if (ForgeFlames.isPlaying)
            {
                ForgeSpark.Stop();
            }

            if (!ForgeSpark.isPlaying)
            {
                ForgeSpark.Play();
            }

            var rate = em.rateOverTime;
            rate.constantMin = 20.0f;
            rate.constantMax = 20.0f;
            em.rateOverTime = rate;

            var rate2 = em2.rateOverTime;
            rate2.constantMin = 20.0f;
            rate2.constantMax = 20.0f;
            em2.rateOverTime = rate2;
        }
        else if (combo >= 15 && combo < 20)
        {
            pLight1.intensity = 8.0f;
            pLight2.intensity = pLight1.intensity;

            if (ForgeFlames.isPlaying)
            {
                ForgeSpark.Stop();
            }

            if (!ForgeSpark.isPlaying)
            {
                ForgeSpark.Play();
            }

            var rate = em.rateOverTime;
            rate.constantMin = 30.0f;
            rate.constantMax = 30.0f;
            em.rateOverTime = rate;

            var rate2 = em2.rateOverTime;
            rate2.constantMin = 30.0f;
            rate2.constantMax = 30.0f;
            em2.rateOverTime = rate2;
        }
        else if (combo >= 20)
        {
            pLight1.intensity = 8.0f;
            pLight2.intensity = pLight1.intensity;

            if (ForgeSpark.isPlaying)
            {
                ForgeSpark.Stop();
            }
            if (! ForgeFlames.isPlaying)
            {
                ForgeFlames.Play();
            }
             
        }

        if (beat == 0)
        {
            pLight1.intensity += 1;
            pLight2.intensity = pLight1.intensity;
        }
        else if (beat == 3)
        {
            pLight1.intensity -= 1;
            pLight2.intensity = pLight1.intensity;
        }

    }
}
