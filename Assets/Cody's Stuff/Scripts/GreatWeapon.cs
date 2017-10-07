using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreatWeapon : Type {
    public int id_Type = 2;
    public float Durability = 0.0f;


    // Use this for initialization
    void Start()
    {
        gameObject.transform.position = gameObject.transform.position + OffSet;
        //transform.rotation = transform.parent.rotation;

    }

    // Update is called once per frame
    void Update()
    {

    }
    
}
