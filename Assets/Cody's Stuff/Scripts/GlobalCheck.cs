using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCheck : MonoBehaviour {

    public GameObject GMM;

    // Use this for initialization

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
    void Start () {
        GameObject[] check = GameObject.FindGameObjectsWithTag("GGM");
        if (check.Length == 0)
        {
            Instantiate(GMM, gameObject.transform);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
