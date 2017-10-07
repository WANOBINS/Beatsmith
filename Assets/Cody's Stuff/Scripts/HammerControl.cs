using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerControl : MonoBehaviour {

    public Transform Hit1;
    public Transform Hit2;
    public Transform Hit3;
    public Transform Idle;
    public GameObject HSLeftSpawn;
    public GameObject HSMidSpawn;
    public GameObject HSRightSpawn;
    public ParticleSystem HammerSpark;


    // Use this for initialization

    void HammerHit(Transform target)
    {
        transform.position = target.transform.position;
        Quaternion originalRot = transform.rotation;
        transform.rotation = originalRot * Quaternion.AngleAxis(90, Vector3.right);

    }

    void HammerReset()
    {

        gameObject.transform.position = Idle.transform.position;
        transform.rotation = Idle.transform.rotation;
    }

    void Start ()
    {
        HSLeftSpawn = GameObject.FindGameObjectWithTag("LeftSpawn");
        HSMidSpawn = GameObject.FindGameObjectWithTag("MidSpawn");
        HSRightSpawn = GameObject.FindGameObjectWithTag("RightSpawn");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            HammerReset();
            HammerHit(Hit1);
            Instantiate(HammerSpark, HSLeftSpawn.transform.position, HammerSpark.transform.rotation);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            HammerReset();
            HammerHit(Hit2);
            Instantiate(HammerSpark, HSMidSpawn.transform.position, HammerSpark.transform.rotation);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            HammerReset();
            HammerHit(Hit3);
            Instantiate(HammerSpark, HSRightSpawn.transform.position, HammerSpark.transform.rotation);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            HammerReset();
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            HammerReset();
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            HammerReset();
        }

    }
    

}
