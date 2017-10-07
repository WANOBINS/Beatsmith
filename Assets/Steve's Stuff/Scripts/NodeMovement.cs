using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeMovement : MonoBehaviour {

    public Rigidbody rb;
    public float speed;
    public GameManager GM;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();
        GM = FindObjectOfType<GameManager>();
        speed = GM.rhythmtool.bpm / 10;

        rb.velocity = new Vector2(0, -speed/2);
    }

}
