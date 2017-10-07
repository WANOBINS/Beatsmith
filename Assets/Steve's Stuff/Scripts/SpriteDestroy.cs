using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteDestroy : MonoBehaviour {


	void Start () {
        StartCoroutine(Destroy());
	}

    IEnumerator Destroy()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        Destroy(gameObject);
    }

}
