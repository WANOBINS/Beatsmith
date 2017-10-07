using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLostObjects : MonoBehaviour {

    public GameManager GM;

    void Start()
    {
        GM = FindObjectOfType<GameManager>();
    }
    void OnTriggerEnter(Collider other)
    {
        GM.combo--;

        if (GM.combo > 0)
        {
            GM.combo = -1;
        }

        GM.score = GM.score - 50;

        Destroy(other.gameObject);
    }
}
