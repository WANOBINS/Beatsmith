using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Type {

    public int id_Type = 1;
    public float Durability = 0.0f;
    // Durability goes down when you miss notes, if it reaches 0 then GAME OVER
    // Durability goes up when you hit notes





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
