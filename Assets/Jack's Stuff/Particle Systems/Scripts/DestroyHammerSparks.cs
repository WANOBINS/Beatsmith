using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DestroyHammerSparks : MonoBehaviour {

    public ParticleSystem HammerSpark;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(HammerSpark.isStopped)
        {
            Destroy(this.gameObject);
        }
	}
}
